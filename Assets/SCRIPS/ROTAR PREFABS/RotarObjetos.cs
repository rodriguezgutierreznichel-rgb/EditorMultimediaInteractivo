using UnityEngine;

public class RotarObjetos : MonoBehaviour
{
    bool modoRotar = false;
    GameObject objetoSeleccionado = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!modoRotar) return;

        // Clic izquierdo: seleccionar objeto para rotar
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject obj = hit.collider.gameObject;

                if (obj.CompareTag("Escenario"))
                {
                    // No hace nada si clicas el escenario
                    return;
                }

                objetoSeleccionado = obj;
                Debug.Log("Objeto seleccionado para rotar: " + objetoSeleccionado.name);
            }
        }

        // Rotar objeto seleccionado con rueda del ratón
        if (objetoSeleccionado != null)
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            if (scroll != 0f)
            {
                objetoSeleccionado.transform.Rotate(0, scroll * 200f, 0);
            }
        }

        // Clic derecho cancela modo rotar
        if (Input.GetMouseButtonDown(1))
        {
            objetoSeleccionado = null;
            modoRotar = false;
            Debug.Log("Modo rotar cancelado con clic derecho");
        }

    }
    public void ActivarModoRotar()
    {
        modoRotar = true;
        Debug.Log("Modo rotar activado");
    }
}
