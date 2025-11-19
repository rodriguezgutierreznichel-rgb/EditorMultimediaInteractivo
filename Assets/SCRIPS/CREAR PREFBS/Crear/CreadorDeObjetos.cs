using UnityEngine;

public class CreadorDeObjetos : MonoBehaviour
{
    GameObject currentGameObject = null; // Guarda el objeto que estamos moviendo/colocando actualmente.
    GameObject prefabSeleccionado;       // Prefab que elegimos para crear.
    float rotacionY = 0f;                // Ángulo de rotación en el eje Y.
    [SerializeField]
    GameObject efecto;                   // Prefab del efecto visual al colocar el objeto.

    public AudioClip sonidoExplosion;   // Sonido al colocar el objeto.
    public AudioClip sonidoClick;       // Sonido al seleccionar un prefab.
    private AudioSource audioSource;    // Componente para reproducir sonidos.

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // Agrega un AudioSource al objeto.
        audioSource.playOnAwake = false;                      // Evita que se reproduzca al iniciar.
    }

    void Update()
    {
        MoverObjeto();   // Mueve el objeto mientras el mouse se mueve.
        ColocarObjeto(); // Coloca el objeto si se hace click izquierdo.
        RotarObjeto();   // Permite rotar el objeto con la rueda del ratón.
        BorrarObjeto();  // Permite borrar el objeto con Backspace.
    }

    public void SeleccionarPrefab(GameObject prefab)
    {
        prefabSeleccionado = prefab;               // Guardamos el prefab seleccionado.

        // Crear un nuevo objeto listo para moverlo
        currentGameObject = Instantiate(prefabSeleccionado);

        if (currentGameObject.GetComponent<Collider>() == null)
        {
            currentGameObject.AddComponent<BoxCollider>(); // Si no tiene collider, le agregamos uno.
            audioSource.PlayOneShot(sonidoClick);          // Reproducimos el sonido de click.
        }
    }

    void MoverObjeto()
    {
        if (currentGameObject == null) return; // Si no hay objeto, no hacemos nada.

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Creamos un rayo desde la cámara hacia el mouse.
        RaycastHit hit;

        currentGameObject.SetActive(false); // Desactivamos temporalmente el objeto para evitar colisiones con el raycast.

        if (Physics.Raycast(ray, out hit, 100f)) // Lanzamos el rayo y verificamos si golpea algo.
        {
            currentGameObject.transform.position = hit.point + Vector3.up; // Movemos el objeto sobre el punto de impacto.
        }

        currentGameObject.SetActive(true); // Activamos el objeto nuevamente.
    }

    void ColocarObjeto()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f))
        {
            if (currentGameObject != null && Input.GetMouseButtonDown(0)) // Si hacemos click izquierdo y hay un objeto seleccionado
            {
                currentGameObject = null;                         // Soltamos el objeto, permitiendo crear otro más tarde.
                Instantiate(efecto, hit.point, Quaternion.identity); // Creamos el efecto visual en el lugar donde se colocó.
                audioSource.PlayOneShot(sonidoExplosion);         // Reproducimos el sonido de colocación.
            }
        }
    }

    void RotarObjeto()
    {
        if (currentGameObject == null) return; // Si no hay objeto, no hacemos nada.

        float rotar = Input.GetAxis("Rueda del raton"); // Detecta movimiento de la rueda del ratón.

        if (rotar != 0f)
        {
            rotacionY += rotar * 50f; // Ajusta la rotación en Y con sensibilidad.
            currentGameObject.transform.rotation = Quaternion.Euler(0, rotacionY, 0); // Aplica la rotación.
        }
    }

    void BorrarObjeto()
    {
        if (currentGameObject != null && Input.GetKeyDown(KeyCode.Backspace)) // Si presionamos Backspace y hay objeto seleccionado
        {
            Destroy(currentGameObject); // Destruye el objeto.
            currentGameObject = null;   // Limpia la variable para poder crear otro.
        }
    }
}


