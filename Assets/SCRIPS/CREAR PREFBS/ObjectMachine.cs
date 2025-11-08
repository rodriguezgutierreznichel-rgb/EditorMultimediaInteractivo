using UnityEngine;

public class ObjectMachine : MonoBehaviour
{
    private IEstadoObjetos estadoActual;

   public GameObject panelDeObjetos, panelObjetos;

    public GameObject panelDeTechos, panelParedes, panelDecoraciones, panelOtros;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
    }
    public void AplicarObjetoTechos()
    {

    }
    public void EntrarEnModoObjetosDeParedes()
    {
        CambiarEstado(new EstadoPared());
        panelDeObjetos.SetActive(true);

    }
    public void EntrarEnModoObjetosDeDecoraciones()
    {
        CambiarEstado(new EstadoDecoracion());
        panelDeObjetos.SetActive(true);
    }
    public void EntrarEnModoObjetosDeOtros()
    {
        CambiarEstado(new EstadoOtros());
        panelDeObjetos.SetActive(true);
    }
    public void SalirDelMenuObjeto()
    {
        panelDeObjetos.SetActive(false);
        panelObjetos.SetActive(false);
    }
}
