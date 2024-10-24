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
            ArticuloCBD articuloCBD = new ArticuloCBD();
            Dgv1.DataSource = articuloCBD.Listar();
            Dgv1.DataBind();
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            string textoNuevo = Tb1.Text;
            Lbl1.Text = textoNuevo;
        }
    }
}