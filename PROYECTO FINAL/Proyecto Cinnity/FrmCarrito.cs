using Proyecto_Cinnity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Proyecto_Cinnity.RecursosLocalizables;
using System.Globalization;

namespace Proyecto_Cinnity
{
    public partial class FrmCarrito : Form
    {

        public FrmCarrito()
        {
            InitializeComponent();
        }

        private void FrmCarrito_Load_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
            AplicarIdioma();
            ActualizarDataGrid();
            lblPrecioTotal2.Text = Carrito.PrecioTotal().ToString();
            lblTotalEntradas2.Text = Carrito.TotalEntradas().ToString();

        }


        private void AplicarIdioma()
        {
            lblTotalEntradas.Text = StringRecursos.totalEntradas;
            lblPrecioTotal.Text = StringRecursos.totalPrecio;
            btnVolver.Text = StringRecursos.volver;
            btnVaciar.Text = StringRecursos.vaciar;
            btnPagar.Text = StringRecursos.pagar;
            this.Text = StringRecursos.tituloventanaCarrito;
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
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


        

        private void dgvEntradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Are you sure you want to delete this ticket?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
            if (Carrito.listaCarrito.Count == 0)
            {
                MessageBox.Show("There are no tickets in your shopping cart.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            } else
            {
                Carrito.listaCarrito.Clear();
                lblPrecioTotal2.Text = Carrito.PrecioTotal().ToString();
                lblTotalEntradas2.Text = Carrito.TotalEntradas().ToString();

                dgvEntradas.DataSource = null;
                ActualizarDataGrid();
            }

        }

        private void btnPagar_Click_1(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                try
                {
                    if (Carrito.listaCarrito.Count == 0)
                    {
                        MessageBox.Show("There are no tickets in your shopping cart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else
                    {
                        ConexionBD.AbrirConexion();
                        Entradas.GenerarEntrada(Carrito.listaCarrito);
                        ConexionBD.CerrarConexion();
                        Carrito.listaCarrito.Clear();

                        dgvEntradas.DataSource = null;
                        ActualizarDataGrid();
                        lblPrecioTotal2.Text = Carrito.PrecioTotal().ToString();
                        lblTotalEntradas2.Text = Carrito.TotalEntradas().ToString();
                        MessageBox.Show("Purchased correctly.","Information",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    }


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
