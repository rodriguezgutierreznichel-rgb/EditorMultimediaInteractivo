using UnityEngine;
using TMPro;

public class UIStateMachine : MonoBehaviour
{
    private IEstado estadoActual; // Guarda el estado actual de la máquina de estados de la UI.

    public GameObject panelInicio, panelAccion, panelObjetos; // Referencias a los paneles de la UI.

    public AudioClip sonidoClick; // Sonido que se reproducirá al interactuar con botones.
    private AudioSource audioSource; // Componente que permite reproducir sonidos.

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // Agrega un AudioSource al objeto.
        audioSource.playOnAwake = false; // Evita que el sonido se reproduzca automáticamente al iniciar.

        CambiarEstado(new EstadoInicio()); // Inicializa la UI en el estado de inicio.
    }

    void Update()
    {
        // Ejecuta el comportamiento del estado actual cada frame
        if (estadoActual != null)
        {
            estadoActual.Ejecutar(this);
        }
    }

    public void CambiarEstado(IEstado nuevoEstado)
    {
        // Si hay un estado actual, llama a su método de salida
        if (estadoActual != null)
        {
            estadoActual.Salir(this);
        }

        estadoActual = nuevoEstado; // Asigna el nuevo estado
        estadoActual.Entrar(this);  // Llama al método de entrada del nuevo estado
    }

    public void IniciarJuego()
    {
        CambiarEstado(new EstadoJuego()); // Cambia al estado de juego
        audioSource.PlayOneShot(sonidoClick); // Reproduce el sonido de click
    }

    public void ReanudarJuego()
    {
        CambiarEstado(new EstadoJuego()); // Cambia al estado de juego
        panelAccion.SetActive(true);      // Muestra el panel de acción
    }

    public void EntrarAlModoObjeto()
    {
        CambiarEstado(new EstadoObjetos()); // Cambia al estado de objetos
        audioSource.PlayOneShot(sonidoClick); // Reproduce el sonido de click
    }

    public void OcultarMenuDeAccion()
    {
        panelAccion.SetActive(false); // Oculta el panel de acción
    }

    public void SalirDelModoObjeto()
    {
        panelObjetos.SetActive(false); // Oculta el panel de objetos
        panelAccion.SetActive(true);   // Muestra el panel de acción nuevamente
    }
}
