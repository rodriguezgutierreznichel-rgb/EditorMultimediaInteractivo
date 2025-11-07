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


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LeanTween.scale(tituloDelJuego.rectTransform, new Vector3(3f,3f,1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelTituloDelJuego);
        LeanTween.scale(nombreDelCreador.rectTransform, new Vector3(1.5f, 1.5f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelNombreDelCreador);
        LeanTween.scale(botonEmpezar, new Vector3(2f, 2f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
