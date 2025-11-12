using UnityEngine;

public class AnimacionObjeto : MonoBehaviour
{
    public GameObject botonParedes, botonTechos, botonDecoraciones, botonOtros;

    [SerializeField]
    LeanTweenType tipoDeCurvaDelBoton;

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
    public void AnimacionObjetos()
    {
        LeanTween.scale(botonParedes, new Vector3(2f, 2f, 2f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonTechos, new Vector3(2f, 2f, 2f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonDecoraciones, new Vector3(2f, 2f, 2f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonOtros, new Vector3(2f, 2f, 2f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        
    }

    public void VolverAlEstadoInicial()
    {
        LeanTween.scale(botonParedes, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonTechos, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonDecoraciones, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonOtros, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        
    }

}
