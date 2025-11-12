using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class TraductorDeTextos : MonoBehaviour
{
    public TextMeshProUGUI tituloDelJuego, nombreDelCreador, botonEmpezar;

    public TextMeshProUGUI botonDeReanudar, textoPausa, botonSalir;

    public TextMeshProUGUI botonMover, botonRotar, botonPausa, botonCrear, botonEliminar;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tituloDelJuego.text = LocalizationSettings.StringDatabase.GetLocalizedString("TEXTOS DE INTERFAZES", "-PROYECT GAME");
        botonEmpezar.text = LocalizationSettings.StringDatabase.GetLocalizedString("TEXTOS DE INTERFAZES", "-EMPEZAR");
        nombreDelCreador.text = LocalizationSettings.StringDatabase.GetLocalizedString("TEXTOS DE INTERFAZES", "-Creado por Nichel Hacomar Rodriguez Gutierrez");

        botonDeReanudar.text = LocalizationSettings.StringDatabase.GetLocalizedString("INTERFAZ DE PAUSA", "-REANUDAR");
        botonSalir.text = LocalizationSettings.StringDatabase.GetLocalizedString("INTERFAZ DE PAUSA", "-SALIR");
        textoPausa.text = LocalizationSettings.StringDatabase.GetLocalizedString("INTERFAZ DE PAUSA", "-PAUSAR");

        botonMover.text = LocalizationSettings.StringDatabase.GetLocalizedString("ACCION", "-Mover");
        botonRotar.text = LocalizationSettings.StringDatabase.GetLocalizedString("ACCION", "-Rotar");
        botonPausa.text = LocalizationSettings.StringDatabase.GetLocalizedString("ACCION", "-Pausar");
        botonCrear.text = LocalizationSettings.StringDatabase.GetLocalizedString("ACCION", "-Crear");
        botonEliminar.text = LocalizationSettings.StringDatabase.GetLocalizedString("ACCION", "-Eliminar");


    }
}
