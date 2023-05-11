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
    public partial class FrmMiPerfil : Form
    {
        public FrmMiPerfil()
        {
            InitializeComponent();
        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frm1= new FrmPaginaPrincipal();
            this.Hide();
            frm1.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
            this.Hide();
            frm1.ShowDialog();
        }
    }
}
