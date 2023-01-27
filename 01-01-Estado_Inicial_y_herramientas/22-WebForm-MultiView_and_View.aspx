<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="22-WebForm-MultiView_and_View.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._22_WebForm_MultiView_and_View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="VDatos" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="a"></asp:Label>
                            <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="b"></asp:Label>
                            <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnSiguiente" runat="server" Text="->" OnClick="btnSiguiente_Click" />
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="VOperaciones" runat="server">
                <asp:RadioButton ID="rbSuma" runat="server" Text="Suma" GroupName="operaciones"/>
                <asp:RadioButton ID="rbResta" runat="server" Text="Resta" GroupName="operaciones"/>
                <asp:RadioButton ID="rbMulti" runat="server" Text="Multi" GroupName="operaciones"/>
                <asp:RadioButton ID="rbDiv" runat="server" Text="Div" GroupName="operaciones"/>
                <br />
                <asp:Button ID="btnAnterior" runat="server" OnClick="btnAnterior_Click" Text="<--" />
                <asp:Button ID="btnSiguiente01" runat="server" OnClick="btnSiguiente01_Click" Text="->" />
            </asp:View>
            <asp:View ID="VResultado" runat="server">
                <asp:Label ID="Label3" runat="server" Text="Resultado"></asp:Label>
                <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
            </asp:View>
        </asp:MultiView>
        <div>
        </div>
    </form>
</body>
</html>
