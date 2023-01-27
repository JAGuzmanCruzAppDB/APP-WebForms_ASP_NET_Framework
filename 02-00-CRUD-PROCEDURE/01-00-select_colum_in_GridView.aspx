<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01-00-select_colum_in_GridView.aspx.cs" Inherits="_02_00_CRUD_PROCEDURE._01_00_select_colum_in_GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Panel ID="pnlDatoAlumno" runat="server">
            <asp:GridView ID="gvdAlumnos" runat="server" AutoGenerateColumns="false" DataKeyNames="clave alumno" OnRowDeleting="gvdAlumnos_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="Clave alumno" HeaderText="Clave alumno" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Apellido paterno" HeaderText="Apellido paterno" />
                    <asp:BoundField DataField="Apellido materno" HeaderText="Apellido materno" />
                    <asp:BoundField DataField="Correo" HeaderText="Correo" />
                    <asp:CommandField ShowDeleteButton="true" EditText="Eliminar" />
                    
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnNuevo" runat="server" OnClick="btnNuevo_Click" Text="Nuevo Alumno" />
        </asp:Panel>
        <asp:Panel ID="pnlAltaAlumno" runat="server" Visible="false">
            <div>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblAp_Paterno" runat="server" Text="Ap paterno"></asp:Label>
                <asp:TextBox ID="txtAp_Paterno" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblAp_materno" runat="server" Text="Ap_materno"></asp:Label>
                <asp:TextBox ID="txtAp_materno" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar alumno" />
            </div>
        </asp:Panel>
        </div>
    </form>
</body>
</html>
