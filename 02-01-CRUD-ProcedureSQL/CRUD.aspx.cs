using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

namespace _02_01_CRUD_ProcedureSQL
{
    public partial class CRUD : System.Web.UI.Page
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

                --exec[SPSalumnos]
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
            public void actualizarAlumno()
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SPUlumnos";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = long.Parse(lblIdAlumno.Text);
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim();
                    cmd.Parameters.Add("@ap_paterno", SqlDbType.VarChar).Value = txtAp_Paterno.Text.Trim();
                    cmd.Parameters.Add("@ap_materno", SqlDbType.VarChar).Value = txtAp_materno.Text.Trim();
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text.Trim();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    /*
                     create procedure SPUlumnos
                        @id int,
                        @nombre varchar(60),
                        @ap_paterno varchar(60),
                        @ap_materno varchar(60),
                        @email varchar(60)
                        as 
                        begin
                            update alumno set nombre=@nombre, ap_paterno=@ap_paterno, ap_materno=@ap_materno, email=@email where id=@id
                        end

                     */
                }
            }
            public void BajaAlumno(string id)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SPBajaAlumno";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = Int64.Parse(id);
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    /* modificar la tabla existente de alumno agregando la columna banActivo
                     * 
                     alter table alumno add banActivo bit

                     select * from alumno

                     * Actualizar la columna de banActivo

                     update alumno set banActivo=1
                    *porocedimiento almacenado que se uso
                     create proc SPBajaAlumno
                     @id int
                     as begin
                        update alumno set banActivo=0
                     where id=@id
                     end
                    *sin dejar de lado que se tiene que modificar el procedimiento almacenado que llena la entidad donde visualizamos los registros 
                     proc despues de la modificacion
                    ALTER procedure [dbo].[SPSalumnos]
                    as 
                    begin
                    select  id 'Clave alumno'
                            ,nombre 'Nombre'
                            ,ap_paterno 'Apellido paterno'
                            ,ap_materno 'Apellido materno'
                            ,email 'Correo'
                    from alumno
                        where banActivo = 1
                    end
                     */
                }
            }
            public void BusquedaAlumno()
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SPSalumnosPorNombre";
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombreBus.Text.Trim();
                    cmd.Connection = conn;
                    conn.Open();
                    gvdAlumnos.DataSource = cmd.ExecuteReader();
                    gvdAlumnos.DataBind();
                }
                /*
                create procedure SPSalumnosPorNombre
                @nombre varchar(50)
                as 
                begin
                    select  id 'Clave alumno'
                            ,nombre 'Nombre'
                            ,ap_paterno 'Apellido paterno'
                            ,ap_materno 'Apellido materno'
                            ,email 'Correo'
                        from alumno
                        where banActivo=1
                        and nombre like '%'+@nombre+'%'
                end
                 */
            }
            public DataTable dtAlumno()
            {
                //generar PDF de la tabla 
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SPSalumnos";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Dispose();
                }
                return dt;
            }
            protected void btnGenerarPdf_Click(object sender, EventArgs e)
            {
                DataTable dt = new DataTable();
                Document document = new Document();
                PdfWriter write = PdfWriter.GetInstance(document, HttpContext.Current.Response.OutputStream);
                dt = dtAlumno();
                if (dt.Rows.Count > 0)
                {
                    document.Open();
                    Font fontTitle = FontFactory.GetFont(FontFactory.COURIER_BOLD, 25);
                    Font font9 = FontFactory.GetFont(FontFactory.TIMES, 9);


                    PdfPTable table = new PdfPTable(dt.Columns.Count);
                    document.Add(new Paragraph(20, "Reporte de Alumnos 2022", fontTitle));
                    document.Add(new Chunk("\n"));

                    float[] widths = new float[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                        widths[i] = 4f;

                    table.SetWidths(widths);
                    table.WidthPercentage = 90;

                    PdfPCell cell = new PdfPCell(new Phrase("columns"));
                    cell.Colspan = dt.Columns.Count;

                    foreach (DataColumn c in dt.Columns)
                    {
                        table.AddCell(new Phrase(c.ColumnName, font9));
                    }

                    foreach (DataRow r in dt.Rows)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            for (int h = 0; h < dt.Columns.Count; h++)
                            {
                                table.AddCell(new Phrase(r[h].ToString(), font9));
                            }
                        }
                    }
                    document.Add(table);
                }
                document.Close();

                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "attachment;filename=AlumnosActuales2022" + ".pdf");
                HttpContext.Current.Response.Write(document);
                Response.Flush();
                Response.End();
            }
            public Stream DataTableToExcel(DataTable dt)
            {
                XSSFWorkbook workbook = new XSSFWorkbook();
                MemoryStream ms = new MemoryStream();
                ISheet sheet = workbook.CreateSheet("Alumno20");
                XSSFRow headerRow = headerRow = (XSSFRow)sheet.CreateRow(0);
                try
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        headerRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);
                    }
                    int rowIndex = 1;
                    foreach (DataRow row in dt.Rows)
                    {
                        XSSFRow dataRow = (XSSFRow)sheet.CreateRow(rowIndex);
                        foreach (DataColumn column in dt.Columns)
                        {
                            dataRow.CreateCell(column.Ordinal).SetCellValue(row[column].ToString());
                        }
                        ++rowIndex;
                    }
                    for (int i = 0; i <= dt.Columns.Count; ++i)
                    {
                        sheet.AutoSizeColumn(i);
                    }
                    workbook.Write(ms);
                    ms.Flush();
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    ms.Close();
                    sheet = null;
                    headerRow = null;
                    workbook = null;
                }
                return ms;
            }

            protected void btnNuevo_Click(object sender, EventArgs e)
            {
                txtNombre.Text = string.Empty;
                txtAp_materno.Text = string.Empty;
                txtAp_Paterno.Text = string.Empty;
                txtEmail.Text = string.Empty;
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

            protected void btnBuscar_Click(object sender, EventArgs e)
            {
                BusquedaAlumno();
            }

            protected void btnActualizar_Click(object sender, EventArgs e)
            {
                pnlAltaAlumno.Visible = false;
                pnlDatoAlumno.Visible = true;
                actualizarAlumno();
                lblIdAlumno.Text = string.Empty;
                btnActualizar.Visible = false;
                btnGuardar.Visible = true;
                CargaDatosAlumno();
            }

            protected void lkbActualizar_Click(object sender, EventArgs e)
            {
                pnlAltaAlumno.Visible = true;
                btnGuardar.Visible = false;
                btnActualizar.Visible = true;
                GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
                gvdAlumnos.SelectedIndex = row.RowIndex;
                lblIdAlumno.Text = row.Cells[0].Text;
                txtNombre.Text = row.Cells[1].Text;
                txtAp_Paterno.Text = row.Cells[2].Text;
                txtAp_materno.Text = row.Cells[3].Text;
                txtEmail.Text = row.Cells[4].Text;
            }

            protected void btnGenerarExcel_Click(object sender, EventArgs e)
            {
                DataTable dt = new DataTable();
                dt = dtAlumno();
                Stream s = DataTableToExcel(dt);
                if (s != null)
                {
                    MemoryStream ms = s as MemoryStream;
                    Response.AddHeader("Content-Disposition", string.Format("attachment;filename=" + HttpUtility.UrlEncode("alumnos2022") + ".xlsx"));
                    Response.ContentType = "application/vnd.ms-excel";
                    Response.AddHeader("Content-Length", ms.ToArray().Length.ToString());
                    Response.BinaryWrite(ms.ToArray());
                    Response.Flush();
                    ms.Close();
                    ms.Dispose();
                }
            }

            protected void btnCorreo_Click(object sender, EventArgs e)
            {

            }
    }
}
