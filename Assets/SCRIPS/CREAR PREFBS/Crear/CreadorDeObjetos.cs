using UnityEngine;

public class CreadorDeObjetos : MonoBehaviour
{
    GameObject currentGameObject = null;
    GameObject prefabSeleccionado;
    float rotacionY = 0f;
    [SerializeField]
    GameObject efecto;

    public AudioClip sonidoExplosion;
   
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        MoverObjeto();
        ColocarObjeto();
        RotarObjeto();
        BorrarObjeto();
    }
    public void SeleccionarPrefab(GameObject prefab)
    {
        prefabSeleccionado = prefab;

        // Crear uno nuevo listo para mover
        currentGameObject = Instantiate(prefabSeleccionado);

        if (currentGameObject.GetComponent<Collider>() == null)
        {
            currentGameObject.AddComponent<BoxCollider>();
        }
    }

    void MoverObjeto()
    {
        if (currentGameObject == null) return;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        currentGameObject.SetActive(false);

        if (Physics.Raycast(ray, out hit, 100f))
        {
            currentGameObject.transform.position = hit.point + Vector3.up;
            
        }

        currentGameObject.SetActive(true);
    }

    void ColocarObjeto()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f))
        {

            if (currentGameObject != null && Input.GetMouseButtonDown(0))
            {
                // Suelta el objeto y permite crear otro m�s tarde
                currentGameObject = null;
                Instantiate(efecto, hit.point, Quaternion.identity);
                audioSource.PlayOneShot(sonidoExplosion);
            }
        }
    }
    void RotarObjeto()
    {
        if (currentGameObject == null) return;

        float rotar = Input.GetAxis("Rueda del raton");

        if (rotar != 0f)
        {
            rotacionY += rotar * 50f; // sensibilidad
            currentGameObject.transform.rotation = Quaternion.Euler(0, rotacionY, 0);
        }
    }
    void BorrarObjeto()
    {
        if (currentGameObject != null && Input.GetKeyDown(KeyCode.Backspace))
        {
            Destroy(currentGameObject);
            currentGameObject = null;
        }
    }
}

