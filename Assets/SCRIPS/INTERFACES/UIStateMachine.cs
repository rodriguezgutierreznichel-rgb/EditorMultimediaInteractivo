using UnityEngine;
using TMPro;
public class UIStateMachine : MonoBehaviour
{
    private IEstado estadoActual;

    public GameObject panelInicio, panelPausa, panelAdvertencia, panelAccion, panelObjetos;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CambiarEstado(new EstadoInicio());
    }

    // Update is called once per frame
    void Update()
    {
        if (estadoActual != null)
        {
            estadoActual.Ejecutar(this);
        }
    }
    public void CambiarEstado(IEstado nuevoEstado)
    {
        if (estadoActual != null)
        {
            estadoActual.Salir(this);
        }

        estadoActual = nuevoEstado;
        estadoActual.Entrar(this);
    }
    public void IniciarJuego()
    {
        CambiarEstado(new EstadoJuego());
    }
    public void PausarJuego()
    {
        CambiarEstado(new EstadoPausa());
        panelAccion.SetActive(false);
    }
    public void ReanudarJuego()
    {
        CambiarEstado(new EstadoJuego());
        panelAccion.SetActive(true);
    }
    public void CancelarSalida()
    {
        CambiarEstado(new EstadoPausa());
        
    }
   
    public void MostrarAdvertencia()
    {
        CambiarEstado(new EstadoAdvertencia());
    }
    public void SalirDelJuego()
    {
        CambiarEstado(new EstadoInicio());
        panelAccion.SetActive(false);
    }
    public void EntrarAlModoObjeto()
    {
        CambiarEstado(new EstadoObjetos());
    }
    public void OcultarMenuDeAccion()
    {
        panelAccion.SetActive(false);
    }

    public void SalirDelModoObjeto()
    {
        panelObjetos.SetActive(false);
        panelAccion.SetActive(true);
    }
}
