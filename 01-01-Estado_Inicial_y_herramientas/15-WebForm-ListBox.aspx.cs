using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _16_WebForm_RadioButtonList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // seleccion sencilla

            //verificamos que se tenga seleccionado un elemento
            //if(lbFrutas.SelectedItem != null)
            //{
            //    int indice = lbFrutas.SelectedIndex;
            //    string elemento = lbFrutas.SelectedItem.Text;
            //    string valor = lbFrutas.SelectedItem.Value;

            //    Response.Write("Seleccionaste " + elemento + " que tiene el valor " + valor + " en el indice " + indice);
            //    // pre visualizacion 
            //    //Seleccionaste Cerveza que tiene el valor 2 en el indice 1
            //}

            //seleccion multiple
            //Recorremos la lista de elementos
            foreach (ListItem fruta in lbFrutas.Items)
            {
                // verificamos si el elemento esta seleccionado
                if (fruta.Selected)
                {
                    int indice = lbFrutas.Items.IndexOf(fruta);
                    string elemento = fruta.Text;
                    string valor = fruta.Value;

                    Response.Write("Seleccionaste " + elemento + " que tiene el valor " + valor + " en el indice" + indice);
                    Response.Write("<br>");
                }
            }
        }
    }
}