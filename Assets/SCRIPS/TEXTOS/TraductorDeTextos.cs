using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class TraductorDeTextos : MonoBehaviour
{
    public TextMeshProUGUI tituloDelJuego, nombreDelCreador, botonEmpezar;

    

    public TextMeshProUGUI botonMover, botonRotar, botonCrear, botonEliminar;

    public TextMeshProUGUI mensaje1, mensaje2, mensaje3;

    public TextMeshProUGUI botonSalirObj, textoCrear, botonParedes, botonTechos, botonDecoraciones, botonOtros;

    public TextMeshProUGUI techo1, techo2, techo3, techo4, techo5;
    public TextMeshProUGUI pared1, pared2, pared3, pared4, pared5;

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

        mensaje1.text = LocalizationSettings.StringDatabase.GetLocalizedString("MENSAJITOS", "-PULSA EL BOTON \"CREAR\" PARA EMPEZAR A CONSTRUIR TU HOGAR.");
        mensaje2.text = LocalizationSettings.StringDatabase.GetLocalizedString("MENSAJITOS", "-PULSA LOS BOTONES \"MOVER\" Y \"ROTAR\" PARA MODIFICAR LA CASA A TU GUSTO");
        mensaje3.text = LocalizationSettings.StringDatabase.GetLocalizedString("MENSAJITOS", "-PULSA EL BOTON \"ELIMINAR\" PARA DESTRUIR LOS OBJETOS QUE NO TE GUSTEN.");

        botonSalirObj.text = LocalizationSettings.StringDatabase.GetLocalizedString("UI_OBJETOS", "-Salir");
        textoCrear.text = LocalizationSettings.StringDatabase.GetLocalizedString("UI_OBJETOS", "-CREAR");
        botonParedes.text = LocalizationSettings.StringDatabase.GetLocalizedString("UI_OBJETOS", "-Paredes");
        botonTechos.text = LocalizationSettings.StringDatabase.GetLocalizedString("UI_OBJETOS", "-Techo");
        botonDecoraciones.text = LocalizationSettings.StringDatabase.GetLocalizedString("UI_OBJETOS", "-Decoracion");
        botonOtros.text = LocalizationSettings.StringDatabase.GetLocalizedString("UI_OBJETOS", "-Otros");

        techo1.text = LocalizationSettings.StringDatabase.GetLocalizedString("MenuDeObjetosTechos", "-Techo 1");
        techo2.text = LocalizationSettings.StringDatabase.GetLocalizedString("MenuDeObjetosTechos", "-Techo 2");
        techo3.text = LocalizationSettings.StringDatabase.GetLocalizedString("MenuDeObjetosTechos", "-Techo 3");
        techo4.text = LocalizationSettings.StringDatabase.GetLocalizedString("MenuDeObjetosTechos", "-Techo 4");
        techo5.text = LocalizationSettings.StringDatabase.GetLocalizedString("MenuDeObjetosTechos", "-Techo 5");

        pared1.text = LocalizationSettings.StringDatabase.GetLocalizedString("MenuDeObjetosTechos", "-Pared 1");




    }

}
