using UnityEngine;

public class AimacionAccion : MonoBehaviour
{
    public GameObject botonMover, botonRotar, botonCrear, botonEliminar;

    [SerializeField]
    LeanTweenType tipoDeCurvaDelBoton;

    [SerializeField]
    public float velocidadDeAnimacion = 0f;

    private Vector3 escalaOriginalMover;
    private Vector3 escalaOriginalRotar;
   
    private Vector3 escalaOriginalCrear;
    private Vector3 escalaOriginalEliminar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        escalaOriginalMover = botonMover.transform.localScale;
        escalaOriginalRotar = botonRotar.transform.localScale;
       
        escalaOriginalCrear = botonCrear.transform.localScale;
        escalaOriginalEliminar = botonEliminar.transform.localScale;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimacionAccion()
    {
        botonMover.transform.localScale = escalaOriginalMover;
        botonRotar.transform.localScale = escalaOriginalRotar;
        
        botonCrear.transform.localScale = escalaOriginalCrear;
        botonEliminar.transform.localScale = escalaOriginalEliminar;

        LeanTween.scale(botonMover, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonRotar, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        
        LeanTween.scale(botonCrear, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
        LeanTween.scale(botonEliminar, new Vector3(1f, 1f, 1f), velocidadDeAnimacion).setEase(tipoDeCurvaDelBoton);
    }

    public void ReiniciarAnimacion()
    {
        AnimacionAccion();
    }
}
