using UnityEngine;

public class EliminarObjeto : MonoBehaviour
{
    public static bool deleteMode = false; // Indica si el modo eliminar está activado

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Detecta clic derecho
        if (Input.GetMouseButtonDown(1)) // 1 = clic derecho
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }

    // Este método se conecta al botón UI
    public void ToggleDeleteMode()
    {
        deleteMode = !deleteMode;
        Debug.Log("Modo eliminar: " + deleteMode);
    }
}


