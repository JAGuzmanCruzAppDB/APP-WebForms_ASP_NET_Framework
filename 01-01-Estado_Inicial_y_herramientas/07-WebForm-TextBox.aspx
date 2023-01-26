<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="07-WebForm-TextBox.aspx.cs" Inherits="_01_01_Estado_Inicial_y_herramientas._07_WebForm_TextBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label7" runat="server" Text="SingleLine"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="txtSingleline" runat="server" ToolTip="TextBox de una linea"></asp:TextBox>
            <asp:Label ID="lblSingleline" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="ReadOnly"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="txtReadOnly" runat="server" ReadOnly="True"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label3" runat="server" Text="MaxLength 5"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="MaxLength" runat="server" MaxLength="5"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label4" runat="server" Text="Columns 5"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="txtColumns" runat="server" Columns="5"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label5" runat="server" Text="Multiline rows 5"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="txtMultiline" runat="server" Height="68px" TextMode="MultiLine"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    </form>
</body>
</html>
