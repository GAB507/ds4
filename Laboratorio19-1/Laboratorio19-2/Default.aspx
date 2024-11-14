<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio19_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     
        <div> 
        <br />
        <br />

            <!-- Botón que invoca el método en el code-behind -->
            <asp:Button ID="btnLlamarApi1" runat="server" Text="Llamar API 1" OnClick="btnLlamarApi1_Click" />
            <asp:Button ID="btnLlamarApi2" runat="server" Text="Llamar API 2" OnClick="btnLlamarApi2_Click" />
        
        <br />
        <br />
            <h2>Resultado de la API:</h2>
            <asp:Label ID="lblResultado" runat="server" Text="Aquí se mostrará el resultado."></asp:Label>

            <br />
        </div>
 

</asp:Content>
