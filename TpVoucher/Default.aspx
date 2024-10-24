<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TpVoucher._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">

        </section>



        

        
<div class="row">

    <div class="border rounded bg-light p-3">
        <div class="col-12 text-center mb-3">
            <h1 id="aspnetTitle">Canje Voucher</h1>
        </div>
        <div class="col-12 text-center mb-3">
            <asp:TextBox ID="TbVoucher" runat="server"></asp:TextBox>
        </div>
        <div class="col-12 text-center mb-3">
            <asp:Button ID="BtnValidar" runat="server" OnClick="BtnValidar_Click" Text="Validar" CssClass="btn btn-primary" />
        </div>
        <div class="col-12 text-center mb-3">
            <asp:Label ID="Lbl1" runat="server" CssClass = "text-danger" Text=" "></asp:Label>
        </div>
    </div>
</div>




        <asp:GridView ID="Dgv1" runat="server"></asp:GridView>

    </main>

</asp:Content>
