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
        protected void Page_Load(object sender, EventArgs e)
        {

            string VoucherValidado;
            string CodigoPremio;

            VoucherValidado = Session["Voucher"] != null ? Session["Voucher"].ToString() : "";
            CodigoPremio = Session["CodigoPremio"] != null ? Session["CodigoPremio"].ToString() : "";

            LblCodigo.Text = VoucherValidado;
            LblPremio.Text = CodigoPremio;


        }
    }
}