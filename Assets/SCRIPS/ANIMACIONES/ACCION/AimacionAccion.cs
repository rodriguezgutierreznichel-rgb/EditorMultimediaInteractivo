using UnityEngine;

public class AimacionAccion : MonoBehaviour
{
    public GameObject botonMover, botonRotar, botonPausar, botonCrear, botonEliminar;

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
    public void AnimacionAccion()
    {
        LeanTween.scale(botonMover, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonRotar, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonPausar, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonCrear, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonEliminar, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
    }

    public void VolverAlEstadoInicial()
    {
        LeanTween.scale(botonMover, new Vector3(0.5f, 0.5f, 0.5f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonRotar, new Vector3(0.5f, 0.5f, 0.5f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonPausar, new Vector3(0.5f, 0.5f, 0.5f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonCrear, new Vector3(0.5f, 0.5f, 0.5f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonEliminar, new Vector3(0.5f, 0.5f, 0.5f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
    }
}
