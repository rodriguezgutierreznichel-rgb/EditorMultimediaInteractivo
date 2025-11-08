using UnityEngine;

public class EstadoObjetos : IEstado
{
    public void Entrar(UIStateMachine cerebro)
    {
       cerebro.panelObjetos.SetActive(true);
    }

    public void Ejecutar(UIStateMachine cerebro)
    {
        
    }

    public void Salir(UIStateMachine cerebro)
    {
        cerebro.panelObjetos.SetActive(false);
    }
}
