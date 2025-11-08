using UnityEngine;

public class EstadoPared : IEstadoObjetos
{
    public void Entrar(ObjectMachine cerebro2)
    {
        cerebro2.panelParedes.SetActive(true);
        
    }

    public void Ejecutar(ObjectMachine cerebro2)
    {
        
    }

    public void Salir(ObjectMachine cerebro2)
    {
       cerebro2.panelParedes.SetActive(false);
       
    }
}
