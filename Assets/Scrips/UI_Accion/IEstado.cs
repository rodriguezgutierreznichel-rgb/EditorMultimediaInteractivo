using UnityEngine;

public interface IEstado 
{
    void Entrar(GameManager gameManager);
    void Ejecutar(GameManager gameManager);
    void Salir(GameManager gameManager);

}
