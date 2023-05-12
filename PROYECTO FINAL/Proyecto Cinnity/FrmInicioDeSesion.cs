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
            this.Hide();
            frm1.Show();

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta frmcuenta = new FrmCrearCuenta();
            this.Hide();
            frmcuenta.Show();
        }

        private void lblContraOlvidada_Click(object sender, EventArgs e)
        {
            FrmCambiarContra frm1 = new FrmCambiarContra();
            this.Hide();
            frm1.Show();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
