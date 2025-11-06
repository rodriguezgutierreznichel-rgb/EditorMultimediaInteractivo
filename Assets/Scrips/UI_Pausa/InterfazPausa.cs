using Unity.VisualScripting;
using UnityEngine;

public class InterfazPausa : MonoBehaviour
{
    [SerializeField] GameObject botonPausar;
    [SerializeField] GameObject pausado;
    [SerializeField] GameObject interfazDeAdvertencia;
    [SerializeField] GameObject interfazPausa;
    [SerializeField] GameObject interfazDeInicio;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interfazPausa.SetActive(false);
        interfazDeAdvertencia.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PausarJuego()
    {
        botonPausar.gameObject.SetActive(false);
        interfazPausa.SetActive(true);
    }
    public void ReanudarJuego()
    {
        interfazPausa.SetActive(false);
        botonPausar.gameObject.SetActive(true);
    }
    public void AdvertenciaDeGuardarPartida()
    {
        interfazDeAdvertencia.SetActive(true);
        interfazPausa.SetActive(false);
    }
    public void SalirDelJuego()
    {
        botonPausar.gameObject.SetActive(false);
        pausado.SetActive(false);
        interfazDeInicio.SetActive(true);
    }
    public void CancelarSalida()
    {
        interfazDeAdvertencia.SetActive(false);
        interfazPausa.SetActive(true);
    }
    
}
