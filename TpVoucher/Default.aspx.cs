using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicios;

namespace TpVoucher
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VoucherCBD VoucherCBD = new VoucherCBD();
            Dgv1.DataSource = VoucherCBD.Listar();
            Dgv1.DataBind();
        }

        protected void BtnValidar_Click(object sender, EventArgs e)
        {
            VoucherCBD VoucherCBD = new VoucherCBD();

            string VoucherNuevo = TbVoucher.Text;

            if (VoucherCBD.ExisteVoucher(VoucherNuevo))
            {
                Lbl1.Text = "SI RE";
            }
            else { Lbl1.Text = "no NO"; }
        }
    }
}