using UnityEngine;

public class EstadoObjetoNinguno : IEstadoObjetos
{
    public void Entrar(ObjectMachine cerebro2)
    {
        cerebro2.panelDeTechos.SetActive(false);
        cerebro2.panelParedes.SetActive(false);
        cerebro2.panelDecoraciones.SetActive(false);
        cerebro2.panelOtros.SetActive(false);
    }

    public void Ejecutar(ObjectMachine cerebro2)
    {
       
    }

    public void Salir(ObjectMachine cerebro2)
    {
        
    }
}
