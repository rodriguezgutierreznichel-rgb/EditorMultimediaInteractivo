using TMPro;
using UnityEngine;

public class EliminarObjeto : MonoBehaviour
{
    bool modoEliminar = false; // Indica si el modo eliminar está activo o no, al inicio está desactivado.

    public AudioClip sonidoExplosion; // Sonido que se reproducirá al eliminar un objeto.
    public AudioClip sonidoClick;     // Sonido que se reproducirá al activar el modo eliminar.
    private AudioSource audioSource;  // Variable para controlar el componente de sonido.
    [SerializeField]
    GameObject efecto;               // Prefab del efecto visual que aparece al eliminar el objeto.

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // Agrega un AudioSource al objeto.
        audioSource.playOnAwake = false; // Evita que el sonido se reproduzca automáticamente al inicio.
    }

    void Update()
    {
        if (!modoEliminar) return;  // Si el modo eliminar no está activado, no hacemos nada.

        if (Input.GetMouseButtonDown(0)) // Detecta click izquierdo del ratón.
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Crea un rayo desde la cámara hacia el mouse.
            RaycastHit hit; // Guardará información sobre el objeto golpeado por el rayo.

            if (Physics.Raycast(ray, out hit)) // Lanza el rayo y verifica si golpea un objeto con collider.
            {
                GameObject obj = hit.collider.gameObject; // Obtenemos el GameObject golpeado.

                if (obj.CompareTag("Escenario")) // Si el objeto es el escenario, no hacemos nada.
                {
                    return; // Salimos del Update.
                }

                audioSource.PlayOneShot(sonidoExplosion); // Reproduce sonido de explosión.
                Instantiate(efecto, hit.point, Quaternion.identity); // Crea el efecto visual en la posición del impacto.
                Destroy(obj); // Destruye el objeto seleccionado.

                Debug.Log("Objeto eliminado: " + obj.name); // Muestra en consola qué objeto se eliminó.

                modoEliminar = false; // Desactiva el modo eliminar tras eliminar un objeto.
            }
        }

        if (Input.GetMouseButtonDown(1)) // Detecta click derecho del ratón.
        {
            modoEliminar = false; // Desactiva el modo eliminar.
            Debug.Log("Modo eliminar desactivado."); // Muestra mensaje en consola.
        }
    }

    public void ActivarModoEliminar() // Función para activar el modo desde un botón.
    {
        audioSource.PlayOneShot(sonidoClick); // Reproduce sonido al activar el modo.
        modoEliminar = true; // Activa el modo eliminar.
        Debug.Log("Modo eliminar activado"); // Muestra mensaje en consola.
    }
}



