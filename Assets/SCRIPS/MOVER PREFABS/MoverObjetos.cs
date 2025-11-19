using UnityEngine;

public class MoverObjetos : MonoBehaviour
{
    bool modoMover = false;  //Indica si el "modo mover" está activado o no.

    GameObject objetoSeleccionado = null; //Guarda el objeto que vamos a mover, inicialmente no hay ninguno.

    public AudioClip sonidoClick; //Almacena el sonido que se reproducirá al activar el modo mover.

    private AudioSource audioSource; //Variable que nos permitirá controlar un componente de sonido.


    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); //Le agrega un "parlante" (AudioSource) al objeto para reproducir sonidos.

        audioSource.playOnAwake = false; //Evita que el sonido se reproduzca automáticamente al inicio del juego.
    }

    void Update()
    {
        if (!modoMover) return; //Si el modo mover no está activo, no hace nada. Evita que se mueva accidentalmente.

        if (Input.GetMouseButtonDown(0)) //Detecta click izquierdo del ratón.
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 🟢 Crea un rayo desde la cámara hacia el mouse.
            RaycastHit hit; //Guardará información del objeto golpeado por el rayo.

            if (Physics.Raycast(ray, out hit)) //Lanza el rayo y verifica si golpea un objeto con collider.
            {
                GameObject obj = hit.collider.gameObject; //Obtenemos el objeto golpeado.

                if (!obj.CompareTag("Escenario")) //Si el objeto NO es el escenario, podemos seleccionarlo.
                {
                    objetoSeleccionado = obj;  //Guardamos el objeto seleccionado.

                    Debug.Log("Objeto seleccionado para mover: " + objetoSeleccionado.name); //Muestra en consola qué objeto seleccionamos.
                }
            }
        }

        if (objetoSeleccionado != null) //Si hay un objeto seleccionado, podemos moverlo.
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //Creamos otro rayo desde la cámara.
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) //Lanza el rayo para encontrar la posición donde queremos moverlo.
            {
                Vector3 nuevaPos = objetoSeleccionado.transform.position; //Guardamos la posición actual del objeto.
                nuevaPos.x = hit.point.x; //Cambiamos solo la posición X.
                nuevaPos.z = hit.point.z; //Cambiamos solo la posición Z.
                objetoSeleccionado.transform.position = nuevaPos; //Aplicamos la nueva posición al objeto.
            }

            float scroll = Input.GetAxis("Mouse ScrollWheel"); //Detecta movimiento de la rueda del ratón.
            if (scroll != 0f)
            {
                Vector3 pos = objetoSeleccionado.transform.position; //Guardamos la posición actual.
                pos.y += scroll * 2f; //Subimos o bajamos el objeto según la rueda.
                objetoSeleccionado.transform.position = pos; //Aplicamos el cambio en Y.
            }
        }

        if (Input.GetMouseButtonDown(1)) //Click derecho cancela el modo mover.
        {
            objetoSeleccionado = null; //Dejamos de seleccionar el objeto.
            modoMover = false; //Desactivamos el modo mover.
            Debug.Log("Modo mover cancelado con clic derecho"); // 🟢 Mensaje en consola.
        }
    }

    public void ActivarModoMover()
    {
        audioSource.PlayOneShot(sonidoClick); //Reproduce el sonido de click una sola vez.

        modoMover = true; //Activamos el modo mover.
        objetoSeleccionado = null; // Reiniciamos la selección de objeto.
        Debug.Log("Modo mover activado: selecciona un objeto, mueve con ratón y ajusta altura con rueda, clic derecho para cancelar"); // 🟢 Explicación en consola.
    }
}

