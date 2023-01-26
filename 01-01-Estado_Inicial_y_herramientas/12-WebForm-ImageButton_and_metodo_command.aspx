<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="12-WebForm-ImageButton_and_metodo_command.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._12_WebForm_ImageButton_and_metodo_command" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="Imagebtm" runat="server" Height="107px" ImageUrl="~/images/cube_icon.png" OnClick="Imagebtm_Click" Width="101px" />
        </div>
        <div>

            <asp:Label ID="Label1" runat="server" Text="A: "></asp:Label>

            <asp:TextBox ID="txta" runat="server"></asp:TextBox>

        </div>
        <div>

            <asp:Label ID="Label2" runat="server" Text="B: "></asp:Label>

            <asp:TextBox ID="txtb" runat="server"></asp:TextBox>

        </div>
        <div>

            <asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>

        </div>
        <div>

            <asp:Button ID="btnSuma" runat="server" Text="Suma" CommandName="suma" OnCommand="operaciones" />

        </div>
        <div>
            <asp:Button ID="btnResta" runat="server" Text="Resta" CommandName="resta" OnCommand="operaciones" />
        </div>
        <div>
            <asp:Button ID="btnMUlti" runat="server" Text="Multiplicacion" CommandName="multiplicacion" OnCommand="operaciones" />
        </div>
        <div>
            <asp:Button ID="btnDivision" runat="server" Text="Division" CommandName="division" OnCommand="operaciones" />
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Ahora un mismo handler con parametros"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnSaludo" runat="server" Text="Saludo" CommandArgument="Hola" CommandName="esp" OnCommand="mensaje" />
            <asp:Button ID="btnDespedida" runat="server" Text="Despedida" CommandArgument="Adios" CommandName="esp" OnCommand="mensaje" />
        </div>
        <div>
            <asp:Button ID="btnGreetings" runat="server" Text="Greetings" CommandArgument="Hello" CommandName="ing" OnCommand="mensaje" />
            <asp:Button ID="btnFarewell" runat="server" Text="Farewell" CommandArgument="Goodbye" CommandName="ing" OnCommand="mensaje" />
        </div>
    </form>
</body>
</html>
