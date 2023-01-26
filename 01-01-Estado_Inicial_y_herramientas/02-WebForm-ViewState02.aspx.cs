using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _02_WebForm_ViewState02 : System.Web.UI.Page
    {
        //Los controles ASP.NET usan internamente a ViewState para guardar su estado
        //Pero esto nos quita de la responsabilidad de guardar los datos correctamente en el VieState
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtConteo.Text = "0";
            }
        }

        protected void btnIncremento_Click(object sender, EventArgs e)
        {
            int conteo = Convert.ToInt32(txtConteo.Text) + 1;
            txtConteo.Text = conteo.ToString();
        }
    }
}