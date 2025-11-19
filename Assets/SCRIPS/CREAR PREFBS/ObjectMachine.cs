using UnityEngine;

public class ObjectMachine : MonoBehaviour
{
    private IEstadoObjetos estadoActual; // Guarda el estado actual de la máquina de objetos (patrón Estado).

    public GameObject panelDeObjetos, panelObjetos; // Paneles del menú principal y de objetos.
    public GameObject panelDeTechos, panelParedes, panelDecoraciones, panelOtros; // Paneles específicos para cada categoría.

    public AudioClip sonidoClick; // Sonido que se reproduce al hacer click en los botones.
    private AudioSource audioSource; // Componente para reproducir sonidos.

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // Agrega AudioSource al objeto.
        audioSource.playOnAwake = false; // Evita que se reproduzca automáticamente al iniciar.

        CambiarEstado(new EstadoObjetoNinguno()); // Inicializa la máquina de objetos en estado "ninguno".
    }

    void Update()
    {
        // Ejecuta el comportamiento del estado actual cada frame.
        if (estadoActual != null)
            estadoActual.Ejecutar(this);
    }

    public void CambiarEstado(IEstadoObjetos nuevo)
    {
        // Si ya había un estado, ejecuta su salida
        if (estadoActual != null)
            estadoActual.Salir(this);

        estadoActual = nuevo; // Asigna el nuevo estado
        estadoActual.Entrar(this); // Ejecuta la entrada del nuevo estado
    }

    // Métodos para entrar en cada categoría de objetos
    public void EntrarEnModoObjetosDeTechos()
    {
        CambiarEstado(new EstadoTechos()); // Cambia al estado techos
        panelDeObjetos.SetActive(true); // Muestra el panel de objetos
        audioSource.PlayOneShot(sonidoClick); // Reproduce sonido de click
    }

    public void AplicarObjetoTechos()
    {
        // Aquí se implementaría la lógica para aplicar un objeto de techo
    }

    public void EntrarEnModoObjetosDeParedes()
    {
        CambiarEstado(new EstadoPared()); // Cambia al estado paredes
        panelDeObjetos.SetActive(true);
        audioSource.PlayOneShot(sonidoClick);
    }

    public void EntrarEnModoObjetosDeDecoraciones()
    {
        CambiarEstado(new EstadoDecoracion()); // Cambia al estado decoraciones
        panelDeObjetos.SetActive(true);
        audioSource.PlayOneShot(sonidoClick);
    }

    public void EntrarEnModoObjetosDeOtros()
    {
        CambiarEstado(new EstadoOtros()); // Cambia al estado otros
        panelDeObjetos.SetActive(true);
        audioSource.PlayOneShot(sonidoClick);
    }

    public void SalirDelMenuObjeto()
    {
        panelDeObjetos.SetActive(false); // Oculta el panel de objetos
        panelObjetos.SetActive(false);   // Oculta el panel principal de objetos
        audioSource.PlayOneShot(sonidoClick); // Reproduce sonido de click
    }
}

