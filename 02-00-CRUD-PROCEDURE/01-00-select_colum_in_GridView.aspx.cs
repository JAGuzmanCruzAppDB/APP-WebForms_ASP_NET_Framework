using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_00_CRUD_PROCEDURE
{
    public partial class _01_00_select_colum_in_GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaDatosAlumno();
            }
        }
        public void CargaDatosAlumno()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SPSalumnos";
                cmd.Connection = conn;
                conn.Open();
                gvdAlumnos.DataSource = cmd.ExecuteReader();
                gvdAlumnos.DataBind();
            }
            /*tabla que se uso y la base de datos esta en el archivo (web.config) en  connectionStrings
                 create table alumno(
	                id int identity(1,1),
	                nombre varchar(50),
	                ap_paterno varchar(50),
	                ap_materno varchar(50),
	                email varchar(50)
	                primary key(id) 
                 );
                 */
            /* procedimiento almacenado ocupado en la consulta anterior
             create procedure SPSalumnos
            as 
            begin
            select  id 'Clave alumno'
                    ,nombre 'Nombre'
                    ,ap_paterno 'Apellido paterno'
                    ,ap_materno 'Apellido materno'
                    ,email 'Correo'
                    from alumno
            end

            exec[SPSalumnos]
             */
        }
        public void GuardaAlumno()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SPIalumnos";
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim();
                cmd.Parameters.Add("@ap_paterno", SqlDbType.VarChar).Value = txtAp_Paterno.Text.Trim();
                cmd.Parameters.Add("@ap_materno", SqlDbType.VarChar).Value = txtAp_materno.Text.Trim();
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text.Trim();
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            /*procedimiento almacenado ocupado en la consulta anterior
                create proc SPIalumnos
	                @nombre varchar(50),
	                @ap_paterno varchar(50),
	                @ap_materno varchar(50),
	                @email varchar(50)
                as
                begin
	                insert into alumno(nombre,ap_paterno,ap_materno,email)
					            values(@nombre,@ap_paterno,@ap_materno,@email);
                end
                 */
        }
        public void EliminarAlumno(string id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SPDalumnos";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Int64.Parse(id);
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            /*procedimiento almacenado ocupado para eliminar registros
             create proc SPDalumnos
	                @id int
             as begin
	                delete from alumno where id=@id
             end
             */
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlDatoAlumno.Visible = false;
            pnlAltaAlumno.Visible = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            pnlAltaAlumno.Visible = false;
            pnlDatoAlumno.Visible = true;
            GuardaAlumno();
            CargaDatosAlumno();
        }

        protected void gvdAlumnos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)gvdAlumnos.Rows[e.RowIndex];
            EliminarAlumno(gvdAlumnos.DataKeys[e.RowIndex].Value.ToString());
            CargaDatosAlumno();
        }
    }
}