using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicios;
using Dominio;

namespace TpVoucher
{
    public partial class About : Page
    {
        public List <Articulo> ListaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string VoucherValidado;
            VoucherValidado = Session["Voucher"] != null ? Session["Voucher"].ToString(): "";


            ArticuloCBD ArticuloCBD = new ArticuloCBD();
            ListaArticulo = ArticuloCBD.Listar();


        }

        protected void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Extraer el código del premio del ID del botón
            string codigoPremio = clickedButton.ID.Replace("codigo_", "");

            // Almaceno el código del premio en la session
            Session["CodigoPremio"] = codigoPremio;

            Response.Redirect("Datos.aspx");
        }
    }
}