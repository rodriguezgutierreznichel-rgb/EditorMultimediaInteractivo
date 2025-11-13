using UnityEngine;
using TMPro;
public class AnimacionObjeto : MonoBehaviour
{
    public GameObject botonParedes, botonTechos, botonDecoraciones, botonOtros, botonSalir;
    public TextMeshProUGUI textoCrear;

    [SerializeField]
    LeanTweenType tipoDeCurvaDelBoton;

    [SerializeField]
    public float velocidadDeAnimacion = 0f;

    private Vector3 escalaInicialBotonParedes;
    private Vector3 escalaInicialBotonTechos;
    private Vector3 escalaInicialBotonDecoraciones;
    private Vector3 escalaInicialBotonOtros;
    private Vector3 escalaInicialBotonSalir;
    private Vector3 escalaIncialTextoCrear;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        escalaInicialBotonParedes = botonParedes.transform.localScale;
        escalaInicialBotonTechos = botonTechos.transform.localScale;
        escalaInicialBotonDecoraciones = botonDecoraciones.transform.localScale;
        escalaInicialBotonOtros = botonOtros.transform.localScale;
        escalaInicialBotonSalir = botonSalir.transform.localScale;
        escalaIncialTextoCrear = textoCrear.rectTransform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimacionObjetos()
    {
        botonParedes.transform.localScale = escalaInicialBotonParedes;
        botonTechos.transform.localScale = escalaInicialBotonTechos;
        botonDecoraciones.transform.localScale = escalaInicialBotonDecoraciones;
        botonOtros.transform.localScale = escalaInicialBotonOtros;
        botonSalir.transform.localScale = escalaInicialBotonSalir;
        textoCrear.rectTransform.localScale = escalaIncialTextoCrear;

        LeanTween.scale(botonParedes, new Vector3(2f, 2f, 2f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonTechos, new Vector3(2f, 2f, 2f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonDecoraciones, new Vector3(2f, 2f, 2f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonOtros, new Vector3(2f, 2f, 2f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonSalir, new Vector3(0.9039427f, 0.831875f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(textoCrear.rectTransform, new Vector3(3f, 3f, 3f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        
    }

}
