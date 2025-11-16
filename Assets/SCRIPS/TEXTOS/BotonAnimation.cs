using Unity.VisualScripting;
using UnityEngine;

public class BotonAnimation : MonoBehaviour
{
    public GameObject mensajito, botonMensaje1, botonMensaje2, botonMensaje3;

    public AudioClip sonidoNotificacion;
    public AudioClip sonidoClick;
    private AudioSource audioSource;

    [SerializeField]
    LeanTweenType curvaInicial;

    [SerializeField]
    LeanTweenType curvaFinal;

    [SerializeField]
    float velocidadDeAnimacion = 0f;

    [SerializeField]
    Vector3 newPosition = new Vector3 (0f,0f, 0f);

    [SerializeField]
    Vector3 oldPosition = new Vector3 (0f,0f,0f);

    public float timer1 = 0f;
    public float timer2 = 0f;
    public float timer3 = 0f;

    bool juegoActivo1 = false;
    bool juegoActivo2 = false;
    bool juegoActivo3 = false;

    private Vector3 positionOriginalBotonMensaje1;
    private Vector3 positionOriginalBotonMensaje2;
    private Vector3 positionOriginalBotonMensaje3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        botonMensaje1.SetActive(false);
        botonMensaje2.SetActive(false);
        botonMensaje3.SetActive(false);
        mensajito.SetActive(false);

        positionOriginalBotonMensaje1 = botonMensaje1.transform.localPosition;
        positionOriginalBotonMensaje2 = botonMensaje2.transform.localPosition;
        positionOriginalBotonMensaje3 = botonMensaje3.transform.localPosition;

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (juegoActivo1)
        {
            timer1 += Time.deltaTime;

           

            if (timer1 > 5f)
            {

                LeanTween.move(botonMensaje1, oldPosition, velocidadDeAnimacion).setEase(curvaFinal);

                juegoActivo1 = false;
            }
        }
        if (juegoActivo2)
        {
            timer2 = timer2 + Time.deltaTime;

            if (timer2 > 5)
            {
                LeanTween.move(botonMensaje2, oldPosition, velocidadDeAnimacion).setEase(curvaFinal);

                juegoActivo2 = false;
            }
        }
        if (juegoActivo3)
        {
            timer3 = timer3 + Time.deltaTime;

            if (timer3 > 5)
            {
                LeanTween.move(botonMensaje3, oldPosition, velocidadDeAnimacion).setEase(curvaFinal);

                juegoActivo3 = false;

            }
        }
    }

    public void PrimeraNotificacion()
    {
        



        botonMensaje1.transform.localPosition = positionOriginalBotonMensaje1;
        timer1 = 0f;
        juegoActivo1 = true;

        botonMensaje1.SetActive(true);
        mensajito.SetActive(true);
        botonMensaje2.SetActive(false);
        botonMensaje3.SetActive(false);

        LeanTween.move(botonMensaje1, newPosition, velocidadDeAnimacion).setEase(curvaFinal);
        audioSource.PlayOneShot(sonidoNotificacion);
        

    }
    public void SegundaNotificacion()
    {
        botonMensaje2.transform.localPosition = positionOriginalBotonMensaje2;
        timer1 = 0f;
        juegoActivo2 = true;

        botonMensaje2.SetActive(true);
        mensajito.SetActive(true);
        botonMensaje1.SetActive(false);
        botonMensaje3.SetActive(false);

        LeanTween.move(botonMensaje2, newPosition, velocidadDeAnimacion).setEase(curvaFinal);
        audioSource.PlayOneShot(sonidoNotificacion);
    }
    
    public void TerceraNotificacion()
    {
        botonMensaje3.transform.localPosition = positionOriginalBotonMensaje3;
        timer3 = 0f;
        juegoActivo3 = true;

        botonMensaje3.SetActive(true);
        mensajito.SetActive(true);
        botonMensaje1.SetActive(false);
        botonMensaje2.SetActive(false);

        LeanTween.move(botonMensaje3, newPosition, velocidadDeAnimacion).setEase(curvaFinal);
        audioSource.PlayOneShot(sonidoNotificacion);
    }
    public void EscucharMusica()
    {
        audioSource.PlayOneShot(sonidoClick);
    }
}
