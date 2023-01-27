<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="20-WebForm-AdRotator.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._20_WebForm_AdRotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/anuncios.xml" />
        </div>
    </form>
</body>
</html>
