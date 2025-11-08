using UnityEngine;

public interface IEstado 
{
    void Entrar(UIStateMachine cerebro);
    void Ejecutar(UIStateMachine cerebro);
    void Salir(UIStateMachine cerebro);

}
