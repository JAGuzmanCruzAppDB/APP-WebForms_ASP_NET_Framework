using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _06_WebForm_eventos_de_controles : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}
        //Eventos de controles: los controles ASP tienen sus propios eventos

        //Eventos de PostBack: Estos eventos envian el WebForm al servidor para ser procesado -click
        //Eventos Cached: Estos eventos se guardan y se procesan cuando sucede un postBack, se puede convertir en postback por medio de la pripiedad AutoPostBack
        //Eventos de Validación: Son usados con los controles de validacion, ocurren en el cliente antes de que el webForm se envie al servidor
        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            lblMensajePB.Text = "Ya ocurrio el evento PostBack";
            Response.Write("Ya ocurrio el evento PostBack</BR>");
        }
        // Este evento sucede cuando hay un cambio en el texto del textBox
        // Despues de probar modificar AutoPostBack
        // Poner enabled en true para ver el ejemplo
        protected void txtChanged_TextChanged(object sender, EventArgs e)
        {
            lblMensajeCached.Text = "Ya ocurrio el evento cached";
            Response.Write("Ya ocurrio el evento cached</BR>");
        }
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