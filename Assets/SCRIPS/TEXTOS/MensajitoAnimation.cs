using UnityEngine;

public class MensajitoAnimation : MonoBehaviour
{
    public GameObject botonNotificacion1, botonNotificacion2, botonNotificacion3;
    public GameObject mensajito, primerMensaje, segundoMensaje, tercerMensaje;

    [SerializeField]
    LeanTweenType curvaInicial;

    [SerializeField]
    LeanTweenType curvaFinal;

    [SerializeField]
    Vector3 newPosition = new Vector3 (0f,0f,0f);

    [SerializeField]
    Vector3 oldPosition = new Vector3(0f, 0f, 0f);

    [SerializeField]
    float velocidadDeAnimacion = 0f;

    [SerializeField]
    float velocidadFinal = 0f;

    public float timerPrimer = 0f;
    bool juegoActivoPrimer = false;

    public float timerSegundo = 0f;
    bool juegoActivoSegundo = false;

    public float timerTercero = 0f;
    bool juegoActivoTercero = false;

    private Vector3 positionOriginalPrimerMensaje;
    private Vector3 positionOriginalSegundoMensaje;
    private Vector3 positionOriginalTercerMensaje;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mensajito.SetActive(false);
        primerMensaje.SetActive(false);
        segundoMensaje.SetActive(false);
        tercerMensaje.SetActive(false);

        positionOriginalPrimerMensaje = primerMensaje.transform.localPosition;
        positionOriginalSegundoMensaje = segundoMensaje.transform.localPosition;
        positionOriginalTercerMensaje = tercerMensaje.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (juegoActivoPrimer)
        {
            timerPrimer = timerPrimer + Time.deltaTime;

            if (timerPrimer > 5)
            {
                LeanTween.move(primerMensaje, oldPosition, velocidadDeAnimacion).setEase(curvaFinal);
            }

        }
        if (juegoActivoSegundo)
        {
            timerSegundo = timerSegundo + Time.deltaTime;

            if (timerSegundo > 5)
            {
                LeanTween.move(segundoMensaje, oldPosition, velocidadDeAnimacion).setEase(curvaFinal);
            }
        }
    }
    public void PrimerMensaje()
    {
        timerPrimer = 0f;
        juegoActivoPrimer = true;

        primerMensaje.transform.localPosition = positionOriginalPrimerMensaje;

        mensajito.SetActive(true);
        primerMensaje.SetActive(true);

        segundoMensaje.SetActive(false);
        tercerMensaje .SetActive(false);

        LeanTween.scale(botonNotificacion1, new Vector3 (0f,0f,0f), velocidadFinal);
        
            Debug.Log("Cambio de posicion");
            LeanTween.move(primerMensaje, newPosition, velocidadDeAnimacion).setEase(curvaInicial);
        

    }
    public void SegundoMensaje()
    {
        timerSegundo = 0f;
        juegoActivoSegundo = true;

        segundoMensaje.transform.localPosition = positionOriginalSegundoMensaje;

        mensajito.SetActive(true);
        segundoMensaje.SetActive(true);

        primerMensaje.SetActive(false);
        tercerMensaje.SetActive(false);

        LeanTween.scale(botonNotificacion2, new Vector3(0f, 0f, 0f), velocidadFinal);

        Debug.Log("Cambio de posicion");
        LeanTween.move(segundoMensaje, newPosition, velocidadDeAnimacion).setEase(curvaInicial);

    }
}

