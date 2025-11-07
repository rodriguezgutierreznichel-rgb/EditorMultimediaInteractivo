using UnityEngine;

public class EstadoJuego : IEstado
{
    public void Entrar(UIStateMachine cerebro)
    {
        Debug.Log("Entré al estado de JUEGO");
    }

    public void Ejecutar(UIStateMachine cerebro)
    {
       
    }

    public void Salir(UIStateMachine cerebro)
    {
        Debug.Log("Salí del estado de JUEGO");
    }
}
