using UnityEngine;
using TMPro;
public class AnimacionInicio : MonoBehaviour
{
    public GameObject botonEmpezar;


    [SerializeField]
    TextMeshProUGUI tituloDelJuego;

    [SerializeField]
    TextMeshProUGUI nombreDelCreador;

    [SerializeField]
    LeanTweenType tipoDeCurvaDelTituloDelJuego;

    [SerializeField]
    LeanTweenType tipoDeCurvaDelNombreDelCreador;

    [SerializeField]
    LeanTweenType tipoDeCurvaDelBoton;

    [SerializeField]
    public float velocidadDeAnimacion = 0f;

    private Vector3 escalaInicialTitulo;
    private Vector3 escalaInicialCreador;
    private Vector3 escalaInicialBoton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        escalaInicialTitulo = tituloDelJuego.rectTransform.localScale;
        escalaInicialCreador = nombreDelCreador.rectTransform.localScale;
        escalaInicialBoton = botonEmpezar.transform.localScale;

        AnimationInicio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimationInicio()
    {
        tituloDelJuego.rectTransform.localScale = escalaInicialTitulo;
        nombreDelCreador.rectTransform.localScale = escalaInicialCreador;
        botonEmpezar.transform.localScale = escalaInicialBoton;

        LeanTween.scale(tituloDelJuego.rectTransform, new Vector3(3f, 3f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelTituloDelJuego);
        LeanTween.scale(nombreDelCreador.rectTransform, new Vector3(1.5f, 1.5f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelNombreDelCreador);
        LeanTween.scale(botonEmpezar, new Vector3(2f, 2f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
    }

    public void ReiniciarAnimacion()
    {
        AnimationInicio();
    }
}

