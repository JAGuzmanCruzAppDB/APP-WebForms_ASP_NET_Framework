<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="02-WebForm-ViewState02.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._02_WebForm_ViewState02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtConteo" runat="server"></asp:TextBox>
            <asp:Button ID="btnIncremento" runat="server" OnClick="btnIncremento_Click" Text="Incremento" />
        
        </div>
    </form>
</body>
</html>
