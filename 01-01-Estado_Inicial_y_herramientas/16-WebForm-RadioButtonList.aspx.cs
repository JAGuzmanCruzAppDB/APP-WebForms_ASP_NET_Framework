using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _16_WebForm_RadioButtonList1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // verifica que este algo seleccionado
            if (rblFrutas.SelectedItem != null)
            {
                //obtencion de datos
                string texto = rblFrutas.SelectedItem.Text;
                string valor = rblFrutas.SelectedItem.Value;
                int indice = rblFrutas.SelectedIndex;

                // mostramos
                Response.Write(texto + ", " + valor + ", " + indice + "<br>");
            }
        }

        protected void btnSeleccionarLimpiar_Click(object sender, EventArgs e)
        {
            if (rblColores.SelectedItem != null)
            {
                string texto = rblColores.SelectedItem.Text;
                string valor = rblColores.SelectedItem.Value;
                int indice = rblColores.SelectedIndex;

                Response.Write(texto + ", " + valor + ", " + indice + "<br>");

                //Limpiamos la seleccion
                rblColores.SelectedIndex = -1;
            }
        }
    }
}