using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _05_WebForm_Variables_de_sesión : System.Web.UI.Page
    {
        //ViewState  VS variables de sesion
        // ViewState nos permite preservar los datos entre requests en el mismo form
        // El ViewState viaja con la peticion y la respuesta, de esa manera se conserva el dato
        // Tenemos que colocar el nombre de la variable para el ViewState
        // Si no se ha usado previamente tiene valor de null
        // Cuando lo leamos es importante hacer el typecast correspondiente

        //las variables de sesion nos permiten pasar informacion de un formularo a otro
        private int conteo = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtConteo.Text = "0";
            }
            if (Session["click"] != null)
            {
                txtConteo.Text = ((int)Session["click"]).ToString();
            }

        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            //si ya se ha usado la variable click
            if (Session["click"] != null)
            {
                //leemos el valor, hacemos typecast, lo incrementamos y lo colocamos en la 
                //variable para poder trabajar con ese dato en nuestro codigo
                conteo = (int)Session["click"] + 1;
            }
            //Actualiza el textBox
            txtConteo.Text = conteo.ToString();

            //Asignamos el valñor en la variable click
            Session["click"] = conteo;
        }
    }
}