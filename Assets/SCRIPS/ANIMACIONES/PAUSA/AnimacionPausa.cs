using TMPro;
using UnityEngine;

public class AnimacionPausa : MonoBehaviour
{
    public GameObject botonPausa;

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
    public void AnimacionDeLaInterfazDePausa()
    {
        LeanTween.scale(botonPausa, new Vector3(2f, 2f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
    }
}
