<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="17-WebForm-BulletedList.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._17_WebForm_BulletedList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="BulletedL1" runat="server" BulletStyle="Numbered">
                <asp:ListItem Value="1">Manzana</asp:ListItem>
                <asp:ListItem Value="2">Pera</asp:ListItem>
                <asp:ListItem Value="3">Ciruela</asp:ListItem>
                <asp:ListItem Value="4">Banana</asp:ListItem>
                <asp:ListItem Value="5">Mango</asp:ListItem>
            </asp:BulletedList>
        </div>
        <div>
            <asp:BulletedList ID="BulletedL2" runat="server" DisplayMode="HyperLink">
                <asp:ListItem Value="https://www.google.com.mx/">Google</asp:ListItem>
                <asp:ListItem Value="https://es.wikipedia.org/">Wikipedia</asp:ListItem>
            </asp:BulletedList>
        </div>
        <div>
            <asp:BulletedList ID="BulletedL3" runat="server" DisplayMode="LinkButton" OnClick="BulletedL3_Click">
                <asp:ListItem Value="1">Azul</asp:ListItem>
                <asp:ListItem Value="2">Rojo</asp:ListItem>
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
