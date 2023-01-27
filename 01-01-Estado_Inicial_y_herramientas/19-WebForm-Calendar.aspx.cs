using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _19_WebForm_Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificamos si es la primera vez que se muestra
            if (!IsPostBack)
                Calendar1.Visible = false;
        }

        protected void btnCalendario_Click(object sender, EventArgs e)
        {
            //mostramos u ocultamos el calendario
            Calendar1.Visible = !Calendar1.Visible;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            // para una fecha
            // mostramos en el textbox la fecha, nota que hay diferentes estilos
            //txtFecha.Text = Calendar1.SelectedDate.ToString();
            //txtFecha.Text =  Calendar1.SelectedDate.ToShortDateString();

            // para multiples fechas
            foreach (DateTime d in Calendar1.SelectedDates)
            {
                Response.Write(d.ToShortDateString() + "</br>");
            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsToday)
                e.Cell.Text = "Hoy";
            // Hacemos que ciertos dias no sean seleccionables
            //e.Day.IsWeekend
            if (e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false;
            }
        }
    }
}