<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="08-WebForm-RadioButton.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._08_WebForm_RadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="rbPizza" runat="server" GroupName="alimentos" Text="Pizza" AutoPostBack="True" OnCheckedChanged="rbPizza_CheckedChanged" />
            <asp:RadioButton ID="rbFruta" runat="server" GroupName="alimentos" Text="Fruta" />
            <asp:RadioButton ID="rbVerduras" runat="server" GroupName="alimentos" Text="Verduras" />
        </div>
        <div>
            <asp:Button ID="btnProcesa" runat="server" Text="Procesa" OnClick="btnProcesa_Click" />
        </div>
    </form>
</body>
</html>
