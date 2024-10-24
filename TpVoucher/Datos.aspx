<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="TpVoucher.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <div class="row">
        <asp:Label ID="LblCodigo" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="LabelCodigo" runat="server" Text="Label"></asp:Label>


<div class="card" style="width: 18rem;">
    <img src="..." class="card-img-top" alt="...">
    <div class="card-body">
        <!-- nombre del artículo -->
        <h5 class="card-title"><%= art != null ? art.Nombre : "Nombre nosponible" %></h5>
        <!-- Descripcion del artículo -->
        <p class="card-text"><%= art != null ? art.Descripcion : "Descripción no disponible" %></p>
    </div>
</div>
        </div>

        <asp:Label ID="Label1" runat="server" Text="DNI"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />

    </main>
</asp:Content>
