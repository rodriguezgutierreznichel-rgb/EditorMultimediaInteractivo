using TMPro;
using UnityEngine;

public class AnimacionPausa : MonoBehaviour
{
    public GameObject botonReanudar, botonSalir;
    public TextMeshProUGUI textoPausa;

    [SerializeField]
    LeanTweenType tipoDeCurvaDelBotonReanudar;

    [SerializeField]
    LeanTweenType tipoDeCurvaDelTextoPausa;

    [SerializeField]
    LeanTweenType tipoDeCurvaDelBotonSalir;

    [SerializeField]
    public float velocidadDeAnimacion = 0f;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimacionDeLaInterfazDePausa()
    {
        LeanTween.scale(textoPausa.rectTransform, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelTextoPausa);
        LeanTween.scale(botonSalir, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBotonSalir);
        LeanTween.scale(botonReanudar, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBotonReanudar);
    }
    public void VolverAlEstadoInicial()
    {
        LeanTween.scale(textoPausa.rectTransform, new Vector3(0.5f, 0.5f, 0.5f), velocidadDeAnimacion).setEase(tipoDeCurvaDelTextoPausa);
        LeanTween.scale(botonSalir, new Vector3(0.5f, 0.5f, 0.5f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBotonSalir);
        LeanTween.scale(botonReanudar, new Vector3(0.5f, 0.5f, 0.5f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBotonReanudar);
    }
}
