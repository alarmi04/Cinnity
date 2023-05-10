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
    public partial class FrmInicioDeSesion : Form
    {
        public FrmInicioDeSesion()
        {
            InitializeComponent();
        }

        private void FrmInicioDeSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frm1 = new FrmPaginaPrincipal();
            frm1.ShowDialog();
        }
    }
}
