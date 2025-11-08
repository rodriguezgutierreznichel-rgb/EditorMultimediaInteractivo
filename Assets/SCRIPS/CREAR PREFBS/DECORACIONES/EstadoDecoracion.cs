using UnityEngine;

public class EstadoDecoracion : IEstadoObjetos
{
    public void Entrar(ObjectMachine cerebro2)
    {
        cerebro2.panelDecoraciones.SetActive(true);
    }

    public void Ejecutar(ObjectMachine cerebro2)
    {

    }

    public void Salir(ObjectMachine cerebro2)
    {
        cerebro2.panelDecoraciones.SetActive(false);
        
    }
}
