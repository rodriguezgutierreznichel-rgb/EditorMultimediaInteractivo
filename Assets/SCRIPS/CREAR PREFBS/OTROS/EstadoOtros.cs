using UnityEngine;

public class EstadoOtros : IEstadoObjetos
{
    public void Entrar(ObjectMachine cerebro2)
    {
        cerebro2.panelOtros.SetActive(true);
       
    }

    public void Ejecutar(ObjectMachine cerebro2)
    {

    }

    public void Salir(ObjectMachine cerebro2)
    {
        cerebro2.panelOtros.SetActive(false);
        
    }
}
