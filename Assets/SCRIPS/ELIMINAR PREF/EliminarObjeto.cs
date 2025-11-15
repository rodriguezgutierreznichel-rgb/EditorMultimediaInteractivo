using TMPro;
using UnityEngine;

public class EliminarObjeto : MonoBehaviour
{
    bool modoEliminar = false; //Indica si el modo esta activo o no, al inicio debe estar desactivado.

    public AudioClip sonidoClick;
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

        if (!modoEliminar) return;  // Si el modo eliminar no está activado, salimos inmediatamente, se necesita para evitar bugs con
                                    // otros botones que se activen con el mismo boton (el del raton).

        if (Input.GetMouseButtonDown(0)) // Cuando hago click izquierdo del raton.
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Creamos un rayo desde la cámara hacia la posición del mouse.

            RaycastHit hit; // Variable que guardará información sobre el objeto que toque el rayo.

            if (Physics.Raycast(ray, out hit)) // Lanzamos el rayo y verificamos si golpea algún objeto con collider.
            {
                GameObject obj = hit.collider.gameObject; // Obtenemos el GameObject que fue golpeado por el rayo.

                if (obj.CompareTag("Escenario")) // Si el objeto tiene el tag "Escenario", no hacemos nada.
                {
                    return; // Salimos del Update.
                }
                
                
                Destroy(obj); // Destruye el objeto.
                    
                Debug.Log("Objeto eliminado: " + obj.name); //Añade un texto a la console diciendo que objeto elimino.

                modoEliminar = false; // desactiva modo tras eliminar 1 objeto
            
            }
        }

        if (Input.GetMouseButtonDown(1)) //Cuando hago click derecho del raton.
        {
            modoEliminar = false; // Desactivamos el modo.

            Debug.Log("Modo eliminar desactivado."); // Se añade otro texto diciendo que se salio del modo.
        }
    }
    public void ActivarModoEliminar() // Funcion para el boton.
    {
        audioSource.PlayOneShot(sonidoClick);

        modoEliminar = true; // Activamos el modo.

        Debug.Log("Modo eliminar activado"); // Se añade otro texto diciendo que se entro al modo.
    }



}


