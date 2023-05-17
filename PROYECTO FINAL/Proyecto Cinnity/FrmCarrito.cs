using Proyecto_Cinnity.Clases;
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

        private void ActualizarDataGrid()
        {
            dgvEntradas.DataSource = Carrito.listaCarrito;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frm1 = new FrmPaginaPrincipal();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frm1 = new FrmPaginaPrincipal();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;
            frm1.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil frm1 = new FrmMiPerfil();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }       

        

        private void btnPagar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCarrito_Load_1(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void dgvEntradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres eliminar este producto?", "Ayuda", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                if (e.RowIndex > -1)
                {
                    Carrito.listaCarrito.RemoveAt(e.RowIndex);

                    dgvEntradas.DataSource = null;
                    ActualizarDataGrid();
                }
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            Carrito.listaCarrito.Clear();

            dgvEntradas.DataSource = null;
            ActualizarDataGrid();
        }

        private void btnPagar_Click_1(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();
                    Entradas.GenerarEntrada(Carrito.listaCarrito);
                    ConexionBD.CerrarConexion();
                    Carrito.listaCarrito.Clear();

                    dgvEntradas.DataSource = null;
                    ActualizarDataGrid();
                    MessageBox.Show("Compra realizada.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ConexionBD.CerrarConexion();
                }
            }

        }
    }
}
