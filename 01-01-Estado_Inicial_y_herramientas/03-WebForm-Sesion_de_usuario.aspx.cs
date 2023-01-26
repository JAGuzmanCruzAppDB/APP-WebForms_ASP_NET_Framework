using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _03_WebForm_Sesion_de_usuario : System.Web.UI.Page
    {
        //-----En archivo Global se explica el uso del los handler y el inicio de una sesion de usuario al ejecutar la aplicacion y al termino de la sesion
        // La sesion de usuario es una instancia de un browser
        // pero las sesiones usan cookies, las cuales pueden ser compartidas por dos instancias del browser
        // se consideraria la misma sesion.
        // Si abrimos en otro browser veremos que tenemos dos sesiones y una aplicacion instanciada.

        // Si no queremos tener cokies para nuestra sesion, en web.config
        // <sessionState mode = "InProc" cookiesless="true"> </sessionState>
        // y nos manda visiblemente el sessionID

        // Este handler se ejecuta cuando se carga la pagina
        protected void Page_Load(object sender, EventArgs e)
        {
            // El servidor manda la respuesta al cliente
            Response.Write("Cantidad de aplicaciones instanciadas " + Application["Aplicaciones"] + "<br/>");
            Response.Write("Cantidad de sesiones de usuario " + Application["SesionesUsuario"]);
        }
    }
}