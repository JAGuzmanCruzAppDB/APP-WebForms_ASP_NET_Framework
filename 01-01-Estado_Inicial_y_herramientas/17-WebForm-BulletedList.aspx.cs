using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _17_WebForm_BulletedList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BulletedL3_Click(object sender, BulletedListEventArgs e)
        {
            // Obtenemos el elemento al que se le dio click
            ListItem elemento = BulletedL3.Items[e.Index];

            string texto = elemento.Text;
            string valor = elemento.Value;
            int indice = e.Index;

            Response.Write("Texto: " + texto + ", valor: " + valor + ", indice: " + indice);
        }
    }
}