using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _08_WebForm_RadioButton : System.Web.UI.Page
    {
        // Propiedades 
        // Checked, Text, TextAlign, AutoPostBack, GroupName

        // Eventos
        //CheckedChanged
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProcesa_Click(object sender, EventArgs e)
        {
            if (rbPizza.Checked == true)
                Response.Write("Te recomendamos la hawaiana <br>");
            if (rbFruta.Checked == true)
                Response.Write("Te recomendamos la manzana <br>");
            if (rbVerduras.Checked == true)
                Response.Write("Te recomendamos espinacas <br>");

        }

        protected void rbPizza_CheckedChanged(object sender, EventArgs e)
        {
            // CheckedChanged es un evento que se ejecuta cuando el postBack es activado 
            // si se quiere llevar a cabo una tarea enseguida que es seleccionado activa autoPostBack en el radioButon
            Response.Write("La pizza tiene muchas calorias");
        }
    }
}