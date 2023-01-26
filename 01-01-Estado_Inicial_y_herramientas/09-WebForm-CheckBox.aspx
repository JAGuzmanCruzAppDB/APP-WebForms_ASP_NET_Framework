<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="09-WebForm-CheckBox.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._09_WebForm_CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Cantidad a pagar"></asp:Label>
            <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox>
        </div>
        <div>
        <asp:CheckBox ID="chekExtraQueso" runat="server" Text="Extra queso" AutoPostBack="True" OnCheckedChanged="chekExtraQueso_CheckedChanged"/>
        </div>
        <div>
        <asp:CheckBox ID="chekPapas" runat="server" Text="Papas" />
        </div>
        <div>
        <asp:CheckBox ID="chekBebida" runat="server" Text="Bebidas"/>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Total : "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" Text="0"></asp:Label>
        </div>
        <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
    
    
    </form>
</body>
</html>
