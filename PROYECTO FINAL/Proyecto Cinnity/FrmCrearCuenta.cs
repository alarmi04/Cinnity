using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Cinnity
{
    public partial class FrmCrearCuenta : Form
    {
        public FrmCrearCuenta()
        {
            InitializeComponent();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frmprincipal = new FrmPaginaPrincipal();
            this.Hide();
            frmprincipal.Show();
        }
    }
}
