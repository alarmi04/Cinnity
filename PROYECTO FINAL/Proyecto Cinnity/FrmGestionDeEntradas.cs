using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Proyecto_Cinnity.RecursosLocalizables;
using System.Globalization;

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
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
            AplicarIdioma();

            CargaListaEntradasActivas();
        }

        private void AplicarIdioma()
        {
            lblEntradasActivas.Text = StringRecursos.entradasact;
            btnBuscarEntrada.Text = StringRecursos.buscarentr;
            btnVenderEntrada.Text = StringRecursos.venderentr;
            lblIdEntrada.Text = StringRecursos.tituloMayus;
            this.Text = StringRecursos.tituloventanaEntradas;
            lblInformacion.Text = StringRecursos.infoGestionEntradas;
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
        }

        private void CargaListaEntradasActivas()
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();                
                dgvEntradasActivas.DataSource = Entradas.EntradasActivas();
                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }



        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil frm1 = new FrmMiPerfil();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }

        private void btnBuscarEntrada_Click(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();

                if (Entradas.ComprobarEntrada(txtTitulo.Text))

                {
                    dgvEntradasActivas.DataSource = Entradas.BuscarEntrada(txtTitulo.Text);
                }

                else

                {
                    MessageBox.Show("Titulo de película introducido no existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ConexionBD.CerrarConexion();
            }

            else

            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }



        private void btnVenderEntrada_Click(object sender, EventArgs e)

        {
            int resultado = 0;
            try
            { 
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    if (Entradas.ComprobarEntrada(txtTitulo.Text))
                    {
                        resultado = Entradas.DevolverEntrada(txtTitulo.Text);
                    }
                    else
                    {
                        MessageBox.Show("Titulo de película introducido no existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }
                ConexionBD.CerrarConexion();
                CargaListaEntradasActivas();
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
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

        private void dgvEntradasActivas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
                {
                    DataGridViewRow selectedRow = dgvEntradasActivas.Rows[e.RowIndex];

                    string nombrePelicula = selectedRow.Cells["titulo"].Value.ToString(); 
                    txtTitulo.Text = nombrePelicula;

                    byte[] imagenBytes = Pelicula.CargarCaratula(nombrePelicula); 

                    if (imagenBytes != null)
                    {

                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            Image imagen = Image.FromStream(ms);

                            ptbImagenPeli.Image = imagen;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esta película no tiene caratula.","Alerta",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    ConexionBD.CerrarConexion();
                }
     
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargaListaEntradasActivas();
        }
    }
}
