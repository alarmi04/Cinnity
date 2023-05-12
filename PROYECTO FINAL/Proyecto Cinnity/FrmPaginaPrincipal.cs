using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_Cinnity
{
    public partial class FrmPaginaPrincipal : Form
    {
        public FrmPaginaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPaginaPrincipal_Load(object sender, EventArgs e)
        {
            clbFiltrar.Visible= false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (clbFiltrar.Visible == true)
            {
                clbFiltrar.Visible = false;
            } else
            {
                clbFiltrar.Visible = true;
            }

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            FrmGestionDeEntradas gestionDeEntradas = new FrmGestionDeEntradas();
            this.Hide();
            gestionDeEntradas.Show();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito frm1= new FrmCarrito();
            this.Hide();
            frm1.Show();
        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil frm1= new FrmMiPerfil();
            this.Hide();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda frm1 = new FrmAyuda();
            this.Hide();
            frm1.Show();
        }
    }
}
