using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _09_WebForm_CheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCosto.Text = "0";
        }
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            int cantidad = Convert.ToInt32(txtCosto.Text);

            if (chekExtraQueso.Checked == true)
            {
                cantidad += 15;
            }
            if (chekPapas.Checked == true)
            {
                cantidad += 20;
            }
            if (chekBebida.Checked == true)
            {
                cantidad += 18;
            }
            lblTotal.Text = "$" + cantidad.ToString();
        }

        protected void chekExtraQueso_CheckedChanged(object sender, EventArgs e)
        {
            //activar este hambler si se quiere llevar acabo una tarea tras oprimirlo
            // si actriva AutoPostBack la tarea se lleva acabo enseguida que es seleccionado
            Response.Write("Excelente elleccion el extra queso");
            Calcular();
        }
    }
}