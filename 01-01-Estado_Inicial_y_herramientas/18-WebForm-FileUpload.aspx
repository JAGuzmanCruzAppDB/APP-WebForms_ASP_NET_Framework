<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="18-WebForm-FileUpload.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._18_WebForm_FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnSubir" runat="server" OnClick="btnSubir_Click" Text="Subir" />
        </div>
    </form>
</body>
</html>
