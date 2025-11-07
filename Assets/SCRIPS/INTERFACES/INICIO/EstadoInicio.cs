using UnityEngine;

public class EstadoInicio : IEstado
{
    public void Entrar (UIStateMachine cerebro)
    {
        Debug.Log("Entré al estado de INICIO");
        cerebro.panelInicio.SetActive(true);

       
    }

    public void Ejecutar(UIStateMachine cerebro)
    {
        
    }

    public void Salir(UIStateMachine cerebro)
    {
        Debug.Log("Salí del estado de INICIO");
        cerebro.panelInicio.SetActive(false);
    }
}
