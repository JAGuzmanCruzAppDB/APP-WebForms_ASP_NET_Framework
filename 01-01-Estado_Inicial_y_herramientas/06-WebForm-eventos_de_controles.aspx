<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="06-WebForm-eventos_de_controles.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._06_WebForm_eventos_de_controles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="-------------------------------"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lbl" runat="server" Text="Evento postBack"></asp:Label>
            
        </div>
        <div>
            <asp:Button ID="btnPostBack" runat="server" Text="PostBack" OnClick="btnPostBack_Click" />
            <asp:Label ID="lblMensajePB" runat="server" Text="Antes del PostBack"></asp:Label>
        </div>

        <div>
            <asp:Label ID="lbluno" runat="server" Text="Evento cached"></asp:Label> 
        </div>
        <div>
            <asp:TextBox ID="txtChanged" runat="server" OnTextChanged="txtChanged_TextChanged"></asp:TextBox>
            <asp:Label ID="lblMensajeCached" runat="server" Text="No ha sucedido el evento cached"></asp:Label>
        </div>

        <div>
            <asp:Label ID="Label5" runat="server" Text="Enviando validacion"></asp:Label> 
        </div>
        <div>
            <asp:TextBox ID="txtValidacion" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFVtxtValidacion" runat="server" ControlToValidate="txtValidacion" Enabled="False" ErrorMessage="Mi mensaje de error"></asp:RequiredFieldValidator>
        </div>
    </form>
</body>
</html>
