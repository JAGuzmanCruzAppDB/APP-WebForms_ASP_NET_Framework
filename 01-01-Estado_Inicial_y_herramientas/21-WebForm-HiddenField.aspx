<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="21-WebForm-HiddenField.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._21_WebForm_HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfValor" runat="server" />
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Dato"></asp:Label>
                    <asp:TextBox ID="txtDato" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMostrar" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnLeer" runat="server" OnClick="btnLeer_Click" Text="Leer" />
                    <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
