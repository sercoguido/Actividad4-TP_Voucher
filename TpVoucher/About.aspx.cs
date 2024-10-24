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

            Label1.Text = VoucherValidado;

            ArticuloCBD ArticuloCBD = new ArticuloCBD();
            ListaArticulo = ArticuloCBD.Listar();


        }
    }
}