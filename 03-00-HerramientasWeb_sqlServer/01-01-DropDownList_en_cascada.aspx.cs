using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _03_00_HerramientasWeb_sqlServer
{
    public partial class _01_01_DropDownList_en_cascada : System.Web.UI.Page
    {
        /*
        create database testdb01
        use testdb01

        drop table ciudad_estado

        create table ciudad_estado(
	            id int identity(1,1),
	            nombre varchar(50)
	            primary key(id)
        );
        create table delegacion_municipio(
	            id int identity(1,1),
	            id_ciudad_estado int,
	            nombre varchar(50)
	    primary key(id)
	    constraint fk_delegacion_municipio_ciudad_estado foreign key(id_ciudad_estado)references ciudad_estado(id) 
	    );

        create table colonia(
	            id int identity(1,1),
	            id_delegacion_municipio int,
	            nombre varchar(50)
	    primary key(id)
	    constraint fk_colonia_delegacion_municipio foreign key(id_delegacion_municipio) references delegacion_municipio(id)
        );
        create proc sps_estado
        as begin
	    select id, nombre from ciudad_estado
        end

        create proc sps_municipio
        @id_ciudad_estado int
        as begin
	            select id,nombre from delegacion_municipio
	    where id_ciudad_estado=@id_ciudad_estado 
        end

        create procedure sps_colonia
        @id_delegacion_municipio int
        as begin
	            select id,nombre from colonia
	    where id_delegacion_municipio=@id_delegacion_municipio
        end
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCiudadEstado();
            }
        }
        public void CargarCiudadEstado()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sps_estado";
                cmd.Connection = conn;
                conn.Open();
                ddlEstado.DataSource = cmd.ExecuteReader();
                ddlEstado.DataTextField = "nombre";
                ddlEstado.DataValueField = "id";
                ddlEstado.DataBind();
                ddlEstado.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            }
        }
        public void CargarMunicipio(long idCiudad)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sps_municipio";
                cmd.Parameters.Add("@id_ciudad_estado", SqlDbType.BigInt).Value = idCiudad;
                cmd.Connection = conn;
                conn.Open();
                ddlMunicipio.DataSource = cmd.ExecuteReader();
                ddlMunicipio.DataTextField = "nombre";
                ddlMunicipio.DataValueField = "id";
                ddlMunicipio.DataBind();
                ddlMunicipio.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            }
        }
        public void CargarColonia(long idMUnicipiod)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sps_colonia";
                cmd.Parameters.Add("@id_delegacion_municipio", SqlDbType.BigInt).Value = idMUnicipiod;
                cmd.Connection = conn;
                conn.Open();
                ddlMunicipio.DataSource = cmd.ExecuteReader();
                ddlMunicipio.DataTextField = "nombre";
                ddlMunicipio.DataValueField = "id";
                ddlMunicipio.DataBind();
                ddlMunicipio.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            }
        }
        protected void ddlEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlMunicipio.ClearSelection();
            ddlColonia.ClearSelection();
            CargarMunicipio(long.Parse(ddlEstado.SelectedValue));
        }

        protected void ddlMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlColonia.ClearSelection();
            CargarColonia(long.Parse(ddlMunicipio.SelectedValue));
        }
    }
}