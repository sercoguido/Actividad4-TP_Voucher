<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="TpVoucher.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>

        <asp:Label ID="LblCodigo" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="LblPremio" runat="server" Text="Label"></asp:Label>

    </main>
</asp:Content>
