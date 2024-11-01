<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio16_1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <div class="row">

      <div style="height: 200px; width: 500px;">

       <asp:Label  id="lblMensaje" foreColor="Red" Font-Size="35px" runat="server"> </asp:Label>

      </div>

     <div style="height:200px; width:500px;">

       <asp:Button id="btnMensaje" Text="Mostrar Mensaje" ToolTip="Dar click para mostrar mensaje" runat="server" OnClick ="btnMensaje_Click"/>

     </div>

  </div>

</asp:Content>
