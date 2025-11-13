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

    private Vector3 escalaInicialReanudar;
    private Vector3 escalaInicialSalir;
    private Vector3 escalaInicialTexto;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        escalaInicialReanudar = botonReanudar.transform.localScale;
        escalaInicialSalir = botonSalir.transform.localScale;
        escalaInicialTexto = textoPausa.rectTransform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimacionPausaUI()
    {
        botonReanudar.transform.localScale = escalaInicialReanudar;
        botonSalir.transform.localScale = escalaInicialSalir;
        textoPausa.rectTransform.localScale = escalaInicialTexto;

        LeanTween.scale(textoPausa.rectTransform, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelTextoPausa);
        LeanTween.scale(botonSalir, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBotonSalir);
        LeanTween.scale(botonReanudar, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBotonReanudar);
    }
    public void ReiniciarAnimacion()
    {
        // Antes de animar, ponemos todo en escala 0
        botonReanudar.transform.localScale = Vector3.zero;
        botonSalir.transform.localScale = Vector3.zero;
        textoPausa.rectTransform.localScale = Vector3.zero;

        // Ahora animamos a escala final 1
        AnimacionPausaUI();
       
    }
}
