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
                    LblInformacion.Text = "El DNI ya está registrado!";

                    clienteCBD.BuscarPorDni(dniVerifica);
                }
                else
                {
                    // Si DNI no esta registardo
                    LblInformacion.Text = "El DNI NO está registrado!, por favor complete los datos:";
                }
            }
            else
            {
                // Si hay algun error
                LblInformacion.Text = "Por favor ingrese un DNI válido.";
            }
        }
    }
}
