using UnityEngine;

public class CreadorDeObjetos : MonoBehaviour
{
    GameObject currentGameObject = null;
    GameObject prefabSeleccionado;
    float rotacionY = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
        if (currentGameObject != null && Input.GetMouseButtonDown(0))
        {
            // Suelta el objeto y permite crear otro más tarde
            currentGameObject = null;
        }
    }
    void RotarObjeto()
    {
        if (currentGameObject == null) return;

        float rotar = Input.GetAxis("Rueda del raton");

        if (rotar != 0f)
        {
            rotacionY += rotar * 120f; // sensibilidad
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
