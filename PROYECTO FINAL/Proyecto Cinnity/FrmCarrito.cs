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
    public partial class FrmCarrito : Form
    {
        Entradas entradaRecibida;

        public FrmCarrito()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frm1= new FrmPaginaPrincipal();
            this.Hide();
            frm1.Show();
        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frm1 = new FrmPaginaPrincipal();
            this.Hide();
            frm1.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
            this.Hide();
            frm1.Show();
        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil frm1 = new FrmMiPerfil();
            this.Hide();
            frm1.Show();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (dgvEntradas.SelectedRows.Count > 0 && dgvEntradas.SelectedRows.Count < 2)
            {
                DataGridViewRow filaSeleccionada = dgvEntradas.SelectedRows[0];
                DataGridViewCell celdaValor = filaSeleccionada.Cells["Cantidad"];
                int valorActual = Convert.ToInt32(celdaValor.Value);
                valorActual++;
                celdaValor.Value = valorActual;


            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (dgvEntradas.SelectedRows.Count > 0 && dgvEntradas.SelectedRows.Count < 2)
            {
                DataGridViewRow filaSeleccionada = dgvEntradas.SelectedRows[0];
                DataGridViewCell celdaValor = filaSeleccionada.Cells["Cantidad"];
                int valorActual = Convert.ToInt32(celdaValor.Value);
                valorActual--;
                if (valorActual == 0)
                {
                    dgvEntradas.Rows.Remove(filaSeleccionada);
                }
                else
                {
                    celdaValor.Value = valorActual;
                }


            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // si se confirma la compra:
            //for (int i = 0; i < dgvEntradas.RowCount; i++)
            //{
            //    Lo que sea
            //    Usuario.EntradasCompradas.Add();  // El usuario deberia ser estatico.
            //}
            

            dgvEntradas.DataSource = null;
        }
    }
}
