using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _Default : Page
    {
        //No se guarda el estado debido a la naturaleza de http
        //Cada vez que se oprime el boton se hace un request al servidor
        //Se regresa una instancia del webForm, que ejecuta de forma normal
        //en el segundo request no se cumple el if
        //y el boton siempre pasa de 0 a 1 el valor de conteo para cada instancia 
        //La solucion es 

        //variable para llevar la cuenta
        private int conteo = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificamos que no sea un postback del webForm
            if (!IsPostBack)//si es la primera ejecución del webForm se cumple,
                            //pero si hacemos una peticion al servidor ya seria otra instancia de webForm gracias al request
            {
                txtConteo.Text = "0";
            }
        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            conteo++;
            txtConteo.Text = conteo.ToString();
        }
    }
}