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

        }

        protected void BtnValidar_Click(object sender, EventArgs e)
        {
            VoucherCBD VoucherCBD = new VoucherCBD();

            string VoucherNuevo = TbVoucher.Text;

            int ResultadoValidacion = VoucherCBD.ExisteVoucher(VoucherNuevo);

            switch (ResultadoValidacion)
            {
                case 2:
                    // El código del voucher existe y FechaCanje es NULL
                    Lbl1.Text = "VALIDO";

                    //ENVÍO EL CODIGO DE VOUCHER POR SESSION
                    Session.Add("Voucher", VoucherNuevo);
                    Response.Redirect("Premios.aspx", false);
                    break;

                case 1:
                    // El código del voucher existe pero FechaCanje no es NULL
                    Lbl1.Text = "El Voucher ya ha sido canjeado.";
                    break;

                case 0:
                default:
                    // El código del voucher no existe
                    Lbl1.Text = "El Voucher es inexistente.";
                    break;
            }
        }
    }
}