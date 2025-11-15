using UnityEngine;

public class ObjectMachine : MonoBehaviour
{
    private IEstadoObjetos estadoActual;

   public GameObject panelDeObjetos, panelObjetos;

    public GameObject panelDeTechos, panelParedes, panelDecoraciones, panelOtros;

    public AudioClip sonidoClick;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;

        CambiarEstado(new EstadoObjetoNinguno());
    }

    // Update is called once per frame
    void Update()
    {
        

        if (estadoActual != null)
            estadoActual.Ejecutar(this);
    }
    public void CambiarEstado(IEstadoObjetos nuevo)
    {
        if (estadoActual != null)
            estadoActual.Salir(this);

        estadoActual = nuevo;
        estadoActual.Entrar(this);
    }

    public void EntrarEnModoObjetosDeTechos()
    {
        CambiarEstado(new EstadoTechos());
        panelDeObjetos.SetActive(true);
        audioSource.PlayOneShot(sonidoClick);
    }
    public void AplicarObjetoTechos()
    {

    }
    public void EntrarEnModoObjetosDeParedes()
    {
        CambiarEstado(new EstadoPared());
        panelDeObjetos.SetActive(true);
        audioSource.PlayOneShot(sonidoClick);

    }
    public void EntrarEnModoObjetosDeDecoraciones()
    {
        CambiarEstado(new EstadoDecoracion());
        panelDeObjetos.SetActive(true);
        audioSource.PlayOneShot(sonidoClick);
    }
    public void EntrarEnModoObjetosDeOtros()
    {
        CambiarEstado(new EstadoOtros());
        panelDeObjetos.SetActive(true);
        audioSource.PlayOneShot(sonidoClick);
    }
    public void SalirDelMenuObjeto()
    {
        panelDeObjetos.SetActive(false);
        panelObjetos.SetActive(false);
        audioSource.PlayOneShot(sonidoClick);
    }
}
