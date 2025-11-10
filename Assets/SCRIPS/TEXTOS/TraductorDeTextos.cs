using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class TraductorDeTextos : MonoBehaviour
{
    public TextMeshProUGUI tituloDelJuego, nombreDelCreador, botonEmpezar;

    public TextMeshProUGUI botonDeReanudar, textoPausa, botonSalir;



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

        botonDeReanudar.text = LocalizationSettings.StringDatabase.GetLocalizedString("TEXTOS DE INTERFAZES", "-REANUDAR");
        botonSalir.text = LocalizationSettings.StringDatabase.GetLocalizedString("TEXTOS DE INTERFAZES", "-SALIR");
        textoPausa.text = LocalizationSettings.StringDatabase.GetLocalizedString("TEXTOS DE INTERFAZES", "-PAUSAR");
    }
}
