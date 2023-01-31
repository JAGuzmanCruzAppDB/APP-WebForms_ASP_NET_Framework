<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01-01-DropDownList_en_cascada.aspx.cs" Inherits="_03_00_HerramientasWeb_sqlServer._01_01_DropDownList_en_cascada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlEstado" runat="server" OnSelectedIndexChanged="ddlEstado_SelectedIndexChanged" AutoPostBack="true" Width="300"></asp:DropDownList>
        </div>
        <div>
            <asp:DropDownList ID="ddlMunicipio" runat="server" OnSelectedIndexChanged="ddlMunicipio_SelectedIndexChanged" AutoPostBack="true" Width="300"></asp:DropDownList>
        </div>
        <div>
            <asp:DropDownList ID="ddlColonia" runat="server" OnSelectedIndexChanged="ddlColonia_SelectedIndexChanged" AutoPostBack="true" Width="300"></asp:DropDownList>
        </div>
        <div>
        </div>
    </form>
</body>
</html>
