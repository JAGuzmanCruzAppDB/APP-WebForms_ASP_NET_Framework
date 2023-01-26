using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _01_WebForm_ViewState : System.Web.UI.Page
    {
        // ViewState nos permite preservar los datos entre requests 
        // El ViewState viaja con la peticion y la respuesta, de esa manera se conserva el dato
        // Tenemos que colocar el nombre de la variable para el viewState
        // Si no se ha usado previamente tiene el valor de null
        // cuando lo leamos es importante hacer el typecast correspondiente

        private int conteo = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtConteo.Text = "4";
            }
        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            // Si ya se ha usado el ViewState con la variable click
            if (ViewState["click"] != null)
            {
                // Leemos el valor, hacemos typecast, lo incrementamos y lo colocamos en la 
                // Variable para poder trabajar con ese dato en nuestro codigo
                conteo = (int)ViewState["click"] + 1;
            }

            // Actualizacion del textBox
            txtConteo.Text = conteo.ToString();

            // Asignamos el valor al ViewState en la variable click
            ViewState["click"] = conteo;
        }
    }
}