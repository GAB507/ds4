<%@ Page Title="Programacion C# , WEB FORMS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio20._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <div>
    <head>
        <title>Tabla de Multiplicar</title>
    </head>
    </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
      <div>
            <h2>Generar Tabla de Multiplicar</h2>
            <label for="txtNumero">Introduce un número:</label>
            <asp:TextBox ID="txtNumero" runat="server" />
            <asp:Button ID="btnGenerar" runat="server" Text="Generar Tabla" OnClick="btnGenerar_Click" />
            <br /><br />
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
        </div>
</asp:Content>
