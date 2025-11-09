using UnityEngine;

public class RotarObjetos : MonoBehaviour
{
    bool modoRotar = false; // Indica si el modo esta activado o no.

    GameObject objetoSeleccionado = null; // Es el objeto que vamos a rotar, inicialmente es nulo.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!modoRotar) return;  // Si el modo rotar no está activado, salimos inmediatamente, se necesita para evitar bugs con
                                 // otros botones que se activen con el mismo boton (el del raton).

        if (Input.GetMouseButtonDown(0)) // Cuando hago click izquierdo del raton.
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Creamos un rayo desde la cámara hacia la posición del mouse.

            RaycastHit hit;  // Variable que guardará información sobre el objeto que toque el rayo.

            if (Physics.Raycast(ray, out hit)) // Lanzamos el rayo y verificamos si golpea algún objeto con collider.
            {
                GameObject obj = hit.collider.gameObject; // Obtenemos el GameObject que fue golpeado por el rayo.

                if (obj.CompareTag("Escenario")) // Si el objeto tiene el tag "Escenario", no hacemos nada.
                {
                    return; // Salimos del Update.
                }

                objetoSeleccionado = obj;  // Guardamos el objeto seleccionado

                Debug.Log("Objeto seleccionado para rotar: " + objetoSeleccionado.name); //Texto de que objeto hemos seleccionado.
            }
        }

        if (objetoSeleccionado != null) //Si el objeto NO es nulo pasa esto...
        {
            float rotar = Input.GetAxis("Rueda del raton"); // Detecta la rueda del raton.

            if (rotar != 0f) //Si rotar NO ES 0, es decir, si muevo la rueda del raton, pasa esto...
            {
                objetoSeleccionado.transform.Rotate(0, rotar * 50f, 0); // El objeto golpeazo con el rayo se rotara cuando muevas
                                                                         // la rueda del raton.
            }
        }

        if (Input.GetMouseButtonDown(1)) //Cuando hago click derecho del raton.
        {
            objetoSeleccionado = null; // El objeto vuelve a ser nulo.

            modoRotar = false; // Se desactiva el modo rotar.

            Debug.Log("Modo rotar desactivado"); // Se añade otro texto diciendo que se salio del modo.
        }

    }
    public void ActivarModoRotar() // Funcion para el boton.
    {
        modoRotar = true; // Activamos el modo.

        Debug.Log("Modo rotar activado"); // Se añade otro texto diciendo que se entro al modo.
    }
}
