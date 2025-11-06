using UnityEngine;
using TMPro;
public class InterfazInicio : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI tituloDelJuego;

    [SerializeField]
    TextMeshProUGUI nombreDelCreador;

    [SerializeField] GameObject botonJugar;

    public GameObject interfazDeInicio;

    public float tiempoDeAnimacion = 0;
    public LeanTweenType tipoDeCurvaDelTituloDelJuego;
    public LeanTweenType tipoDeCurvaDelNombreDelCreador;
    public LeanTweenType tipoDeCurvaDelBoton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interfazDeInicio.SetActive(true);
        AnimacionDelTituloDelJuego();
        AnimacionDelNombreDelCreador();
        AnimacionDelBotonDeEmpezarJuego();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EmpezarJuego()
    {
        interfazDeInicio.SetActive(false);

    }

    void AnimacionDelTituloDelJuego()
    {
        LeanTween.scale(tituloDelJuego.rectTransform, new Vector3(3f, 3f, 1f), tiempoDeAnimacion).setEase(tipoDeCurvaDelTituloDelJuego);
    }
    void AnimacionDelNombreDelCreador()
    {
        LeanTween.scale(nombreDelCreador.rectTransform, new Vector3(1.5f, 1.5f, 1f), tiempoDeAnimacion).setEase(tipoDeCurvaDelNombreDelCreador);
    }
    void AnimacionDelBotonDeEmpezarJuego()
    {
        LeanTween.scale(botonJugar, new Vector3(2f, 2f, 1f), tiempoDeAnimacion).setEase(tipoDeCurvaDelBoton);
    }
}
