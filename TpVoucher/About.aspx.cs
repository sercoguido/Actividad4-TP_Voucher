using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpVoucher
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string VoucherValidado;
            VoucherValidado = Session["Voucher"] != null ? Session["Voucher"].ToString(): "";

            Label1.Text = VoucherValidado;

        }
    }
}