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
            lblCorreo.Text = Usuario.correo;
            lblNombreUsuario.Text = Usuario.nombre;
        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frm1 = new FrmPaginaPrincipal();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;


            frm1.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.ShowDialog();
        }

        private void lblCambiarContra_Click(object sender, EventArgs e)
        {
            FrmCambiarContra frm1 = new FrmCambiarContra(lblCorreo.Text);
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }

    }
}
