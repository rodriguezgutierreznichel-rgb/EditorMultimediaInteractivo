using UnityEngine;

public class MensajitoAnimation : MonoBehaviour
{
    public GameObject mensajito, imageCrear, imageAccion, imageEliminar;

    [SerializeField]
    LeanTweenType curvaInicial;

    [SerializeField]
    LeanTweenType curvaFinal;

    [SerializeField]
    Vector3 newPosition = new Vector3 (0f,0f,0f);

    [SerializeField]
    Vector3 newScale = new Vector3(0f, 0f, 0f);

    public float timerPrimer = 0f;
    bool juegoActivoPrimer = false;

    public float timerSegundo = 0f;
    bool juegoActivoSegundo = false;

    public float timerTercero = 0f;
    bool juegoActivoTercero = false;

    private Vector3 escalaOriginalCrear;
    private Vector3 escalaOriginalAccion;
    private Vector3 escalaOriginalEliminar;

    private Vector3 positionOriginalCrear;
    private Vector3 positionOriginalAccion;
    private Vector3 positionOriginalEliminar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mensajito.SetActive(false);
        imageCrear.SetActive(false);
        imageAccion.SetActive(false);
        imageEliminar.SetActive(false);

        escalaOriginalCrear = imageCrear.transform.localScale;
        escalaOriginalAccion = imageAccion.transform.localScale;
        escalaOriginalEliminar = imageEliminar.transform.localScale;

        positionOriginalCrear = imageCrear.transform.localPosition;
        positionOriginalAccion = imageAccion.transform.localPosition;
        positionOriginalEliminar = imageEliminar.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (juegoActivoPrimer)
        {
            timerPrimer += Time.deltaTime; 
           

           
            if (timerPrimer > 5f)
            {
                
                LeanTween.scale(imageCrear, newScale, 1f).setEase(curvaFinal);
                
                juegoActivoPrimer = false; 
            }
        }
        if (juegoActivoSegundo)
        {
            timerSegundo += Time.deltaTime;



            if (timerSegundo > 5f)
            {

                LeanTween.scale(imageAccion, newScale, 1f).setEase(curvaFinal);

                juegoActivoSegundo = false;
            }
        }
        if (juegoActivoTercero)
        {
            timerTercero += Time.deltaTime;



            if (timerTercero > 5f)
            {

                LeanTween.scale(imageEliminar, newScale, 1f).setEase(curvaFinal);

                juegoActivoTercero = false;
            }
        }
    }
    public void PrimerMensaje()
    {
        imageCrear.transform.localScale = escalaOriginalCrear;
        imageCrear.transform.localPosition = positionOriginalCrear;
        timerPrimer = 0f;
        juegoActivoPrimer = true;

        mensajito.SetActive(true);
        imageCrear.SetActive(true);
        imageAccion.SetActive(false);
        imageEliminar.SetActive(false);
       
        LeanTween.moveY(imageCrear, newPosition.y, 1f).setEase(curvaInicial);
    }
    public void SengundoMensaje()
    {
        imageAccion.transform.localScale = escalaOriginalAccion;
        imageAccion.transform.localPosition = positionOriginalAccion;
        timerSegundo = 0f;
        juegoActivoSegundo = true;

        mensajito.SetActive(true);
        imageAccion.SetActive(true);
        imageCrear.SetActive(false);
        imageEliminar.SetActive(false);

        LeanTween.moveY(imageAccion, newPosition.y, 1f).setEase(curvaInicial);
    }
    public void TercerMensaje()
    {
        imageEliminar.transform.localScale = escalaOriginalEliminar;
        imageEliminar.transform.localPosition = positionOriginalEliminar;
        timerTercero = 0f;
        juegoActivoTercero = true;

        mensajito.SetActive(true);
        imageEliminar.SetActive(true);
        imageCrear.SetActive(false);
        imageAccion.SetActive(false);

        LeanTween.moveY(imageEliminar, newPosition.y, 1f).setEase(curvaInicial);
    }


}

