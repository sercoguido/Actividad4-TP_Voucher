using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicios;
using Dominio;

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
    }
}
