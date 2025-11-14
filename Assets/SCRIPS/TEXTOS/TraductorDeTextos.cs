using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class TraductorDeTextos : MonoBehaviour
{
    public TextMeshProUGUI tituloDelJuego, nombreDelCreador, botonEmpezar;

    

    public TextMeshProUGUI botonMover, botonRotar, botonCrear, botonEliminar;

   

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

       
        
       

        botonMover.text = LocalizationSettings.StringDatabase.GetLocalizedString("ACCION", "-Mover");
        botonRotar.text = LocalizationSettings.StringDatabase.GetLocalizedString("ACCION", "-Rotar");
       
        botonCrear.text = LocalizationSettings.StringDatabase.GetLocalizedString("ACCION", "-Crear");
        botonEliminar.text = LocalizationSettings.StringDatabase.GetLocalizedString("ACCION", "-Eliminar");

       
    }
}
