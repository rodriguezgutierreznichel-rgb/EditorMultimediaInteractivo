using UnityEngine;

public class EstadoAdvertencia : IEstado
{
    public void Entrar(UIStateMachine cerebro)
    {
        cerebro.panelAdvertencia.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Ejecutar(UIStateMachine cerebro)
    {
        
    }

    public void Salir(UIStateMachine cerebro)
    {
        cerebro.panelAdvertencia.SetActive(false);
        Time.timeScale = 1f;
    }

}
