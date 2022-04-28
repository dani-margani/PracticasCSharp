<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaProductos.aspx.cs" Inherits="Practica_ASPNET_2.AltaProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingresa Nombre del Producto:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Ingresa el Precio del Producto:<br />
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Alta de Producto" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
