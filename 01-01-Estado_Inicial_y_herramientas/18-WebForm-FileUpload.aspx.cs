using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_01_Estado_Inicial_y_herramientas
{
    public partial class _18_WebForm_FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubir_Click(object sender, EventArgs e)
        {
            //primero verificamos que se ha seleccionado un archivo
            if (FileUpload1.HasFiles)
            {
                //Obtenemos la extension y el tamaño para delimitar si es necesario
                string ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                ext = ext.ToLower();

                // ojo el tamaño esta en bytes
                int tam = FileUpload1.PostedFile.ContentLength;

                Response.Write(ext + ", " + tam);

                // podemos llevar a cabo verificacion de extension y tamaño
                if (ext == ".png" && tam <= 1048576)
                {
                    FileUpload1.SaveAs(Server.MapPath("~/Subidos/" + FileUpload1.FileName));
                    Response.Write("Se subio el archivo");
                }
            }
            else
            {
                Response.Write("Seleccione un archivo a subir");
            }
        }
    }
}