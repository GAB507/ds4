<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Problema_2.aspx.cs" Inherits="Laboratorio20.Problema_2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matriz N x N con Diagonal Inversa</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Generar Matriz con Diagonal Inversa</h2>
            <label for="txtDimension">Introduce el tamaño de la matriz (N):</label>
            <asp:TextBox ID="txtDimension" runat="server" />
            <asp:Button ID="btnGenerar" runat="server" Text="Generar Matriz" OnClick="btnGenerar_Click" />
            <br /><br />
            <asp:Label ID="lblMatriz" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>