using UnityEngine;
using TMPro;
public class UIStateMachine : MonoBehaviour
{
    private IEstado estadoActual;

    public GameObject panelInicio, panelAccion, panelObjetos;

    public AudioClip sonidoClick;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;

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
        audioSource.PlayOneShot(sonidoClick);
    }
    public void ReanudarJuego()
    {
        CambiarEstado(new EstadoJuego());
        panelAccion.SetActive(true);
    }
    public void EntrarAlModoObjeto()
    {
        CambiarEstado(new EstadoObjetos());
        audioSource.PlayOneShot(sonidoClick);
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
