using UnityEngine;

public class CrearObjetos1 : MonoBehaviour
{
    [SerializeField]
    GameObject[] paredes;

    int currentPrefab = 0;
    GameObject currentGameObject = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ColocarObjetoClick();
        MoverObjeto();
    }
    public void CrearObjetos()
    {
        if (currentGameObject == null && paredes.Length > 0)
        {
            // Instanciamos el primer prefab
            currentGameObject = Instantiate(paredes[0]);
        }
    }
    void MoverObjeto()
    {
        if (currentGameObject == null) return;

        // Creamos un rayo desde la cámara hasta el ratón
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Desactivamos el objeto para que no interfiera con el raycast
        currentGameObject.SetActive(false);

        // Si el rayo golpea algo en la escena
        if (Physics.Raycast(ray, out hit, 100f))
        {
            // Colocamos el objeto un poco sobre el punto de impacto
            currentGameObject.transform.position = hit.point + Vector3.up;
        }

        currentGameObject.SetActive(true);
    }
    void ColocarObjetoClick()
    {
        if (currentGameObject != null && Input.GetMouseButtonDown(0))
        {
            // Cuando hacemos click, el objeto se queda en su lugar
            currentGameObject = null;
        }
    }
}
