<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="16-WebForm-RadioButtonList.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._16_WebForm_RadioButtonList1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="rblFrutas" runat="server" RepeatLayout="OrderedList">
                <asp:ListItem Text="Manzana" Value="1"></asp:ListItem>
                <asp:ListItem Text="Pera" Value="2"></asp:ListItem>
                <asp:ListItem Text="Durazno" Value="3"></asp:ListItem>
                <asp:ListItem Text="Platano" Value="4"></asp:ListItem>
                <asp:ListItem Text="Tamarindo" Value="5"></asp:ListItem>
                <asp:ListItem Text="Mango" Value="6"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Button ID="btnSeleccionar" runat="server" OnClick="btnSeleccionar_Click" Text="Seleccionar" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="-----------------"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButtonList ID="rblColores" runat="server">
                        <asp:ListItem Text="Rojo" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Naranja" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Amarillo" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Verde" Value="4"></asp:ListItem>
                        <asp:ListItem Text="Azul" Value="5"></asp:ListItem>
                        <asp:ListItem Text="Violeta" Value="6"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSeleccionarLimpiar" runat="server" OnClick="btnSeleccionarLimpiar_Click" Text="Seleccionar y limpiar" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
