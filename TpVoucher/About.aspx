<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="TpVoucher.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

<div class="row row-cols-1 row-cols-md-3 g-4">


    <%
        foreach (Articulo art in ListaArticulo)
        {
    %>

  <div class="col">
    <div class="card">
      <img src="..." class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title"> <%: art.Nombre %> </h5>
        <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
      </div>
    </div>
    <%
        }
    %>


  </div>
</div>

    </main>
</asp:Content>
