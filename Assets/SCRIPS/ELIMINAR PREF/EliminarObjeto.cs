using UnityEngine;

public class EliminarObjeto : MonoBehaviour
{
    bool modoEliminar = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!modoEliminar) return;

        // Clic izquierdo: intentar eliminar objeto
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

                Destroy(obj);
                Debug.Log("Objeto eliminado: " + obj.name);
                modoEliminar = false; // desactiva modo tras eliminar 1 objeto
            }
        }

        // Clic derecho cancela el modo eliminar
        if (Input.GetMouseButtonDown(1))
        {
            modoEliminar = false;
            Debug.Log("Modo eliminar cancelado con clic derecho");
        }
    }
    public void ActivarModoEliminar()
    {
        modoEliminar = true;
        Debug.Log("Modo eliminar activado");
    }



}


