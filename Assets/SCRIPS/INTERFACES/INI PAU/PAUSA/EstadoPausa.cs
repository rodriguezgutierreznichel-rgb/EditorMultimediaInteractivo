using TMPro;
using UnityEngine;

public class EstadoPausa : IEstado
{
  

    public void Entrar(UIStateMachine cerebro)
    {
       

        cerebro.panelPausa.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Ejecutar(UIStateMachine cerebro)
    {
       
    }

    public void Salir(UIStateMachine cerebro)
    {
        cerebro.panelPausa.SetActive(false);
        Time.timeScale = 1f;
    }
}

