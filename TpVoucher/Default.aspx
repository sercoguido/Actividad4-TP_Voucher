<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TpVoucher._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>



        <asp:TextBox ID="Tb1" runat="server"></asp:TextBox>
        <asp:Button ID="Btn1" runat="server" OnClick="Btn1_Click" Text="Button" />
        <asp:Label ID="Lbl1" runat="server" Text="Label"></asp:Label>




        <asp:GridView ID="Dgv1" runat="server"></asp:GridView>

    </main>

</asp:Content>
