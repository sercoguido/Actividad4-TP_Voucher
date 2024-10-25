<%@ Page Title="Datos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="TpVoucher.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div class="d-flex flex-column justify-content-center align-items-center min-vh-100">

            <asp:Label runat="server" Text="Premio Seleccionado :" CssClass="h3 text-primary mb-4"></asp:Label>

            <div class="card text-center" style="width: 18rem;">
                <img src="<%= art != null ? art.VerPrimeraImagen() : "Imagen no disponible" %>" class="card-img-top" height="400" width="300" alt="...">
                <div class="card-body">
                    <!-- Nombre -->
                    <h5 class="card-title"><%= art != null ? art.Nombre : "Nombre no disponible" %></h5>
                    <!-- Descripcino -->
                    <p class="card-text"><%= art != null ? art.Descripcion : "Descripcion no disponible" %></p>
                </div>
            </div>

            <div class="card p-3 mt-4" style="width: 18rem;">
                <div class="form-group mb-3">
                    <label for="TextBox1" class="form-label">DNI</label>
                    <asp:TextBox ID="datos_dni" runat="server" CssClass="form-control" />
                    <asp:Label ID="LblInformacion" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="form-group">
                    <asp:Button ID="Btn_ValidaDni" OnClick="Btn_ValidaDni_Click" runat="server" Text="Validar DNI" CssClass="btn btn-primary col-12" />
                </div>
            </div>


              <div class="card p-4 mt-4" style="width: 24rem;">
                <h4 class="text-center mb-4">Complete su Información</h4>
                <div class="form-group mb-3">
                    <label for="TextBoxNombre" class="form-label">Nombre</label>
                    <asp:TextBox ID="TextBoxNombre" runat="server" CssClass="form-control" />
                </div>
                <div class="form-group mb-3">
                    <label for="TextBoxApellido" class="form-label">Apellido</label>
                    <asp:TextBox ID="TextBoxApellido" runat="server" CssClass="form-control" />
                </div>
                <div class="form-group mb-3">
                    <label for="TextBoxEmail" class="form-label">Email</label>
                    <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="form-control" TextMode="Email" />
                </div>
                <div class="form-group mb-3">
                    <label for="TextBoxDireccion" class="form-label">Dirección</label>
                    <asp:TextBox ID="TextBoxDireccion" runat="server" CssClass="form-control" />
                </div>
                <div class="form-group mb-3">
                    <label for="TextBoxCiudad" class="form-label">Ciudad</label>
                    <asp:TextBox ID="TextBoxCiudad" runat="server" CssClass="form-control" />
                </div>
                <div class="form-group mb-3">
                    <label for="TextBoxCP" class="form-label">Código Postal</label>
                    <asp:TextBox ID="TextBoxCP" runat="server" CssClass="form-control" />
                </div>
                <div class="form-group text-center">
                    <asp:Button ID="Btn_Submit" runat="server" Text="Enviar Información" CssClass="btn btn-primary col-12" />
                </div>
            </div>
        </div>
    </main>
</asp:Content>
