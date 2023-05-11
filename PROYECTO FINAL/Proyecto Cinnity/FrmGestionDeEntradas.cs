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
    public partial class FrmGestionDeEntradas : Form
    {
        public FrmGestionDeEntradas()
        {
            InitializeComponent();
        }

        private void FrmGestionDeEntradas_Load(object sender, EventArgs e)
        {

        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil frm1 = new FrmMiPerfil();
            frm1.Show();
        }
    }
}
