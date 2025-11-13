using UnityEngine;

public class MovimientoDeLaCamara : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    public float velociadDelJugador = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeZ = Input.GetAxis("Horizontal") * Time.deltaTime * velociadDelJugador;
        movimientoEjeX = Input.GetAxis("Vertical") * Time.deltaTime * velociadDelJugador;

        transform.Translate(movimientoEjeZ, movimientoEjeY, movimientoEjeX);

    }
}

