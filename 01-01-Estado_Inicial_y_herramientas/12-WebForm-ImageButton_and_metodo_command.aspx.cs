using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _12_WebForm_ImageButton_and_metodo_command : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Imagebtm_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("Boton de imagen");
        }
        protected void operaciones(object sender, CommandEventArgs e)
        {
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);
            double r = 0;
            if (e.CommandName == "suma")
                r = a + b;
            if (e.CommandName == "resta")
                r = a - b;
            if (e.CommandName == "multiplicacion")
                r = a * b;
            if (e.CommandName == "division")
                r = a / b;

            lblResultado.Text = r.ToString();
        }
        protected void mensaje(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "esp")
            {
                Response.Write("En español es: " + e.CommandArgument);
            }
            if (e.CommandName == "ing")
            {
                Response.Write("En ingles es: " + e.CommandArgument);
            }
        }
    }
}