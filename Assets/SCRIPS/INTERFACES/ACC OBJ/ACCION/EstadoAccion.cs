using UnityEngine;

public class EstadoAccion : IEstado
{
    public void Entrar(UIStateMachine cerebro)
    {
      cerebro.panelAccion.SetActive(false);
    }

    public void Ejecutar(UIStateMachine cerebro)
    {
       
    }

    public void Salir(UIStateMachine cerebro)
    {
       cerebro.panelAccion.SetActive(true);
    }
}
