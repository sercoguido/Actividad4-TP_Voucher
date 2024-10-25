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
    }
}
