<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="10-WebForm-HyperLink_and_LinkButton.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._10_WebForm_HyperLink_and_LinkButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:HyperLink ID="HlkUno" runat="server" NavigateUrl="https://www.google.com/">Ir a google</asp:HyperLink>
        </div>
        
        <div>
            <asp:Label ID="Label2" runat="server" Text="Link a un formulario de la misma aplicacion"></asp:Label>
            <br />
            <asp:HyperLink ID="HlkDos" runat="server" NavigateUrl="~/11-WebForm-HyperLink_and_LinkButton_segunda_pagina.aspx">HyperLink</asp:HyperLink>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Aperturar en otra pestaña"></asp:Label>
            <br />
            <asp:HyperLink ID="HlkTres" runat="server" NavigateUrl="~/11-WebForm-HyperLink_and_LinkButton_segunda_pagina.aspx" Target="_blank">link a otra pestaña</asp:HyperLink>
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Link con imagen"></asp:Label>
            <br />
            <asp:HyperLink ID="HLUno" runat="server" ImageUrl="~/images/social_icon.png" NavigateUrl="~/11-WebForm-HyperLink_and_LinkButton_segunda_pagina.aspx">HyperLink</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HLDos" runat="server" ImageUrl="~/images/cube_icon (1).png" NavigateUrl="~/11-WebForm-HyperLink_and_LinkButton_segunda_pagina.aspx">HyperLink</asp:HyperLink>

        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Link Button"></asp:Label>
        <br />
        <asp:LinkButton ID="linkbtn" runat="server" PostBackUrl="~/11-WebForm-HyperLink_and_LinkButton_segunda_pagina.aspx">ir a webForm 2</asp:LinkButton>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="link button con evento del lado del cliente"></asp:Label>
            <br />
        <asp:LinkButton ID="LkbScript" runat="server" OnClientClick="return Funcion():" PostBackUrl="~/11-WebForm-HyperLink_and_LinkButton_segunda_pagina.aspx">tiene un script</asp:LinkButton>
        
       <script type="text/javascript">
            function Funcion() {
                alert("Soy una funcion de javaScript");

                return true;
            }
        </script>


        </div>
    </form>
</body>
</html>
