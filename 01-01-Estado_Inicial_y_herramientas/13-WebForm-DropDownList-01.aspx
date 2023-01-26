<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="13-WebForm-DropDownList-01.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._13_WebForm_DropDownList_01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 55px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblFrutas" runat="server" Text="Frutas: "></asp:Label>
        </div>
        <div>
            <asp:DropDownList ID="DropDownListFrutas" runat="server">
                <asp:ListItem Value="1">Manzana</asp:ListItem>
                <asp:ListItem Value="2">Pera</asp:ListItem>
                <asp:ListItem Value="3">Durazno</asp:ListItem>
                <asp:ListItem Value="15">Guayaba</asp:ListItem>
        </asp:DropDownList>
            <asp:Button ID="btnPruebas" runat="server" Text="Prueba" OnClick="btnPruebas_Click" />
            <asp:Label ID="lblSeleccionado" runat="server" Text="   Label  "></asp:Label>
            <asp:Label ID="lblIndice" runat="server" Text="   Label  "></asp:Label>
            <asp:Label ID="lblValor" runat="server" Text="    Label  "></asp:Label>
        </div>
    </form>
</body>
</html>
