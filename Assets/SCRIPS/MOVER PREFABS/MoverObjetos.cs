using UnityEngine;

public class MoverObjetos : MonoBehaviour
{
    bool modoMover = false;
    GameObject objetoSeleccionado = null;

    public AudioClip sonidoClick;
    private AudioSource audioSource;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    void Update()
    {
        if (!modoMover) return;

        // Selección de objeto con clic izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject obj = hit.collider.gameObject;

                if (!obj.CompareTag("Escenario"))
                {
                    objetoSeleccionado = obj;
                    Debug.Log("Objeto seleccionado para mover: " + objetoSeleccionado.name);
                }
            }
        }

        // Mover objeto seleccionado sobre XZ con el ratón
        if (objetoSeleccionado != null)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Raycast hacia el plano del escenario para mover en XZ
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 nuevaPos = objetoSeleccionado.transform.position;
                nuevaPos.x = hit.point.x;
                nuevaPos.z = hit.point.z;
                objetoSeleccionado.transform.position = nuevaPos;
            }

            // Ajustar altura con rueda del ratón
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            if (scroll != 0f)
            {
                Vector3 pos = objetoSeleccionado.transform.position;
                pos.y += scroll * 2f; // velocidad de subida/bajada
                objetoSeleccionado.transform.position = pos;
            }
        }

        // Clic derecho cancela modo mover
        if (Input.GetMouseButtonDown(1))
        {
            objetoSeleccionado = null;
            modoMover = false;
            Debug.Log("Modo mover cancelado con clic derecho");
        }
    }

    // Función pública para botón
    public void ActivarModoMover()
    {
        audioSource.PlayOneShot(sonidoClick);

        modoMover = true;
        objetoSeleccionado = null;
        Debug.Log("Modo mover activado: selecciona un objeto, mueve con ratón y ajusta altura con rueda, clic derecho para cancelar");
    }
}
