using UnityEngine;

public class InterfazInicio : MonoBehaviour
{
    GameObject interfazDeInicio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interfazDeInicio.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EmpezarJuego()
    {
        interfazDeInicio.SetActive(false);
    }
}
