using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicios;
using Dominio;
using Tp_Voucher.Clases;

namespace TpVoucher
{
    public partial class Contact : Page
    {
        protected Articulo art;  // Hacer el artículo accesible en el .aspx

        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifico si existe el parámetro en la URL
            if (Request.QueryString["art"] != null)
            {
                // Extraer el código del artículo
                string codigoArticulo = Request.QueryString["art"];

                // Buscar el artículo usando el método Buscar
                ArticuloCBD articuloCBD = new ArticuloCBD();
                art = articuloCBD.Buscar(codigoArticulo);

            }
            else
            {
                Response.Redirect("Premios.aspx", false);
            }
        }

        protected void Btn_ValidaDni_Click(object sender, EventArgs e)
        {
            int dniVerifica;
            bool esValido = int.TryParse(datos_dni.Text, out dniVerifica);

            if (esValido)
            {
                ClienteCBD clienteCBD = new ClienteCBD();
                bool existeDni = clienteCBD.ValidarExistenciaDni(dniVerifica);

                if (existeDni)
                {
                    // Si DNI está en la base de datos

                    PanelAlertaCompletar.Visible = false; // Oculto el mensaje de alerta si estaba visible ed otro intento anteriormente
                    PanelAlertaNoValido.Visible = false;
                    PanelAlertaValido.Visible = true;

                    Cliente cliente = new Cliente();

                    cliente = clienteCBD.BuscarPorDni(dniVerifica);

                    //Completo la información del formulario
                    datos_nombre.Text = cliente.Nombre;
                    datos_apellido.Text = cliente.Apellido;
                    datos_mail.Text = cliente.Email;
                    datos_direccion.Text = cliente.Direccion;
                    datos_ciudad.Text = cliente.Ciudad;
                    datos_cp.Text = cliente.CodigoPostal;
                }
                else
                {
                    // Si DNI no esta registardo
                    PanelAlertaNoValido.Visible = false;
                    PanelAlertaValido.Visible = false;
                    PanelAlertaCompletar.Visible = true; // Muestro mensaje de alerta
                    datos_nombre.Text = "";
                    datos_apellido.Text = "";
                    datos_mail.Text = "";
                    datos_direccion.Text = "";
                    datos_ciudad.Text = "";
                    datos_cp.Text = "";
                }
            }
            else
            {
                // Si hay algun error
                PanelAlertaCompletar.Visible = false;
                PanelAlertaValido.Visible = false;
                PanelAlertaNoValido.Visible = true; // Muestro mensaje de alerta
                datos_nombre.Text = "";
                datos_apellido.Text = "";
                datos_mail.Text = "";
                datos_direccion.Text = "";
                datos_ciudad.Text = "";
                datos_cp.Text = "";
            }
        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            ValidacionNombre();
            ValidacionApellido();
            ValidacionCiudad();
            ValidacionCodigoPostal();
            ValidacionDireccion();
            ValidacionEmail();

        }


        public void ValidacionNombre()
        {
            string nombre = datos_nombre.Text.Trim();
            ErrorNombre.Visible = false;
            LblErrorNombre.Text = "";

            if (nombre.Length < 3)
            {
                ErrorNombre.Visible = true;
                LblErrorNombre.Text = "El nombre debe tener más de 3 caracteres.";
            }
            else if (nombre.Any(char.IsDigit))
            {
                ErrorNombre.Visible = true;
                LblErrorNombre.Text = "El nombre no debe contener números.";
            }

            if (ErrorNombre.Visible)
            {
                return;
            }
        }

        public void ValidacionApellido()
        {
            string apellido = datos_apellido.Text.Trim();
            ErrorApellido.Visible = false;
            LblErrorApellido.Text = "";

            if (apellido.Length < 3)
            {
                ErrorApellido.Visible = true;
                LblErrorApellido.Text = "El apellido debe tener más de 3 caracteres.";
            }
            else if (apellido.Any(char.IsDigit))
            {
                ErrorApellido.Visible = true;
                LblErrorApellido.Text = "El apellido no debe contener números.";
            }

            if (ErrorApellido.Visible)
            {
                return;
            }
        }

        public void ValidacionEmail()
        {
            string email = datos_mail.Text.Trim();
            ErrorEmail.Visible = false;
            LblErrorEmail.Text = "";

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                ErrorEmail.Visible = true;
                LblErrorEmail.Text = "Mail Inválida";
            }

            if (ErrorEmail.Visible)
            {
                return;
            }
        }

        public void ValidacionDireccion()
        {
            string direccion = datos_direccion.Text.Trim();
            ErrorDireccion.Visible = false;
            LblErrorDireccion.Text = "";

            if (string.IsNullOrWhiteSpace(direccion) || direccion.Length < 3)
            {
                ErrorDireccion.Visible = true;
                LblErrorDireccion.Text = "Dirección Inválida";
            }

            if (ErrorDireccion.Visible)
            {
                return;
            }
        }

        public void ValidacionCiudad()
        {
            string ciudad = datos_ciudad.Text.Trim();
            ErrorCiudad.Visible = false;
            LblErrorCiudad.Text = "";

            if (string.IsNullOrWhiteSpace(ciudad) || ciudad.Length < 3)
            {
                ErrorCiudad.Visible = true;
                LblErrorCiudad.Text = "Ciudad Inválida";
            }

            if (ErrorCiudad.Visible)
            {
                return;
            }
        }

        public void ValidacionCodigoPostal()
        {
            string codigoPostal = datos_cp.Text.Trim();
            ErrorCP.Visible = false;
            LblErrorCP.Text = "";

            if (string.IsNullOrWhiteSpace(codigoPostal) || codigoPostal.Length < 4)
            {
                ErrorCP.Visible = true;
                LblErrorCP.Text = "Codigo Postal Inválido";
            }

            if (ErrorCP.Visible)
            {
                return;
            }
        }


    }
}
