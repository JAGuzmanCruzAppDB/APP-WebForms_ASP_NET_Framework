using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _04_WebForm_Eventos_del_proyecto : System.Web.UI.Page
    {
        /*
            * Los eventos pueden ocurrir  en tres niveles
            * - Nivel de aplicación :
            *                      >Eventos de applicación
            *                      +se usan para inicializar datos que estarán disponibles para todas las sesiones actuales de la aplicacion.
            *                      >Eventos de sesión
            *                      +Se usan para inicializar datos que estarán disponibles para una sesión invdividual en particular.
            *                      -los Eventos de sesion Se guardan en global.asax
            *                          +Application_Start
            *                          +Application_End
            *                          +Application_Error
            * - Nivel de la página : 
            *                      >PreInit
            *                      +sucede antes de que el evento de inicializacion ocurra
            *                      +permite colocar muchas cosas como el Master page y el tema
            *                      +tambien se usa cuando se tienen controles dinámicos
            *                      >Init
            *                      +El PageInit sucede después de la inicialización de los controles de la forma muy util para colocarle propiedades a los eventos
            *                      >InitComplete
            *                      +Sucede despues de la inicializacion de las paginas
            *                      >PreLoad
            *                      +sucede antes del evento Load
            *                      >Load
            *                      +Sucede antes del evento Load de cada uno de los controles en la pagina
            *                      +Sucede antes del evento Load de cada uno de los controles en la pagina
            * - Nivel del control
            *                      >Evento de control
            *                      +Despues del evento Load y son los eventos de cada copntrol
            *                      >Load Complete
            *                      +Sucede después de los eventos de controles
            *                      >PreRender
            *                      +Antes de que se visualice la página
            *                      >PreRenderComplete
            *                      +Despues del evento PreRender
            *                      >UnLoad
            *                      +Primero sucede en los controles y luego en la página
            *                      +Se lleva a cada cuando la página se libera de la memoria 
            * **/
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("1) PreInit <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("2) Init <br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("3) InitComplete <br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("4) PreLoad <br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("5) Load <br/>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("6) LoadComplete <br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("7) PreRender <br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("8) PreRenderComplete <br/>");
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //comentado porque no tiene sentido el uso de response en este evento
            //Response.Write("9) Unload <br/>");
        }
    }
}