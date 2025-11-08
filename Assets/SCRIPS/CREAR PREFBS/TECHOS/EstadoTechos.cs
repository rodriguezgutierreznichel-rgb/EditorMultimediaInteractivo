using UnityEngine;

public class EstadoTechos : IEstadoObjetos
{
    public void Entrar(ObjectMachine cerebro2)
    {
        cerebro2.panelDeTechos.SetActive(true);
        
    }

    public void Ejecutar(ObjectMachine cerebro2)
    {
        
    }

    public void Salir(ObjectMachine cerebro2)
    {
      cerebro2.panelDeTechos.SetActive(false);
      
    }
}
