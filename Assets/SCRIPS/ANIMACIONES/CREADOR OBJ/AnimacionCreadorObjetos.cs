using UnityEngine;

public class AnimacionCreadorObjetos : MonoBehaviour
{
    public GameObject botonPared1, botonPared2, botonPared3, botonPared4, botonPared5;
    public GameObject botonTecho1, botonTecho2, botonTecho3, botonTecho4, botonTecho5;
    public GameObject botonDecoracion1, botonDecoracion2, botonDecoracion3, botonDecoracion4, botonDecoracion5;
    public GameObject botonOtros1, botonOtros2, botonOtros3, botonOtros4, botonOtros5;

    [SerializeField]
    LeanTweenType tipoDeCurvaDelBoton;

    [SerializeField]
    public float velocidadDeAnimacion = 0f;

    private Vector3 escalaInicialBotonParedes1;
    private Vector3 escalaInicialBotonParedes2;
    private Vector3 escalaInicialBotonParedes3;
    private Vector3 escalaInicialBotonParedes4;
    private Vector3 escalaInicialBotonParedes5;

    private Vector3 escalaInicialBotonTechos1;
    private Vector3 escalaInicialBotonTechos2;
    private Vector3 escalaInicialBotonTechos3;
    private Vector3 escalaInicialBotonTechos4;
    private Vector3 escalaInicialBotonTechos5;

    private Vector3 escalaInicialBotonDecoraciones1;
    private Vector3 escalaInicialBotonDecoraciones2;
    private Vector3 escalaInicialBotonDecoraciones3;
    private Vector3 escalaInicialBotonDecoraciones4;
    private Vector3 escalaInicialBotonDecoraciones5;

    private Vector3 escalaInicialBotonOtros1;
    private Vector3 escalaInicialBotonOtros2;
    private Vector3 escalaInicialBotonOtros3;
    private Vector3 escalaInicialBotonOtros4;
    private Vector3 escalaInicialBotonOtros5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        escalaInicialBotonParedes1 = botonPared1.transform.localScale;
        escalaInicialBotonParedes2 = botonPared2.transform.localScale;
        escalaInicialBotonParedes3 = botonPared3.transform.localScale;
        escalaInicialBotonParedes4 = botonPared4.transform.localScale;
        escalaInicialBotonParedes5 = botonPared5.transform.localScale;

        escalaInicialBotonTechos1 = botonTecho1.transform.localScale;
        escalaInicialBotonTechos2 = botonTecho2.transform.localScale;
        escalaInicialBotonTechos3 = botonTecho3.transform.localScale;
        escalaInicialBotonTechos4 = botonTecho4.transform.localScale;
        escalaInicialBotonTechos5 = botonTecho5.transform.localScale;

        escalaInicialBotonDecoraciones1 = botonDecoracion1.transform.localScale;
        escalaInicialBotonDecoraciones2 = botonDecoracion2.transform.localScale;
        escalaInicialBotonDecoraciones3 = botonDecoracion3.transform.localScale;
        escalaInicialBotonDecoraciones4 = botonDecoracion4.transform.localScale;
        escalaInicialBotonDecoraciones5 = botonDecoracion5.transform.localScale;

        escalaInicialBotonOtros1 = botonOtros1.transform.localScale;
        escalaInicialBotonOtros2 = botonOtros2.transform.localScale;
        escalaInicialBotonOtros3 = botonOtros3.transform.localScale;
        escalaInicialBotonOtros4 = botonOtros4.transform.localScale;
        escalaInicialBotonOtros5 = botonOtros5.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimacionParedes()
    {
        botonPared1.transform.localScale = escalaInicialBotonParedes1;
        botonPared2.transform.localScale = escalaInicialBotonParedes2;
        botonPared3.transform.localScale = escalaInicialBotonParedes3;
        botonPared4.transform.localScale = escalaInicialBotonParedes4;
        botonPared5.transform.localScale = escalaInicialBotonParedes5;

        LeanTween.scale(botonPared1, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonPared2, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonPared3, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonPared4, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonPared5, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
    }
    public void AnimacionTechos()
    {
        botonTecho1.transform.localScale = escalaInicialBotonTechos1;
        botonTecho2.transform.localScale = escalaInicialBotonTechos2;
        botonTecho3.transform.localScale = escalaInicialBotonTechos3;
        botonTecho4.transform.localScale = escalaInicialBotonTechos4;
        botonTecho5.transform.localScale = escalaInicialBotonTechos5;

        LeanTween.scale(botonTecho1, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonTecho2, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonTecho3, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonTecho4, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonTecho5, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);

    }

    public void AnimacionDecoraciones()
    {
        botonDecoracion1.transform.localScale = escalaInicialBotonDecoraciones1;
        botonDecoracion2.transform.localScale = escalaInicialBotonDecoraciones2;
        botonDecoracion3.transform.localScale = escalaInicialBotonDecoraciones3;
        botonDecoracion4.transform.localScale = escalaInicialBotonDecoraciones4;
        botonDecoracion5.transform.localScale = escalaInicialBotonDecoraciones5;

        LeanTween.scale(botonDecoracion1, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonDecoracion2, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonDecoracion3, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonDecoracion4, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonDecoracion5, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
    }
    public void AnimacionOtros()
    {
        botonOtros1.transform.localScale = escalaInicialBotonOtros1;
        botonOtros2.transform.localScale = escalaInicialBotonOtros2;
        botonOtros3.transform.localScale = escalaInicialBotonOtros3;
        botonOtros4.transform.localScale = escalaInicialBotonOtros4;
        botonOtros5.transform.localScale = escalaInicialBotonOtros5;

        LeanTween.scale(botonOtros1, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonOtros2, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonOtros3, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonOtros4, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonOtros5, new Vector3(0.2f, 0.2f, 0.3333333f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
    }
}
