using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _07_WebForm_TextBox : System.Web.UI.Page
    {
        // las tres formas en las que el textBox se despliega usualmente
        // SingleLine, Multiline, Password

        // Propiedades mas importantes
        // ReadOnly - Solo se lee, no se puede escribir en el
        // MaxLength - cantidad maxima de caracteres que recibe el textBox
        // Columns - Ancho del control en caracteres
        // Tooltip - Da informacion sobre el control
        protected void Page_Load(object sender, EventArgs e)
        {
            txtReadOnly.Text = "Hola a todos";
            txtMultiline.Focus();
        }
    }
}