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
    public partial class FrmGestionAdmin : Form
    {
        public FrmGestionAdmin()
        {
            InitializeComponent();
        }

        public void CargarDataGrid()
        {
            List<Pelicula> lista = Pelicula.CargarPeliculas();
            dgvPeliculas.DataSource = lista;
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofdSeleccionar.Title = "Seleccionar imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtTitulo.Text;
            string genero = txtGenero.Text;
            string director = txtDirector.Text;
            string reparto = txtReparto.Text;
            int duracionMinutos = (int)nudDuracion.Value;
            string sinopsis = txtSinopsis.Text;
            DateTime fechaEstreno = dtpFechaEstreno.Value;
            Image caratula = pictureBox1.Image;

            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                Pelicula pel = new Pelicula(nombre, genero, director, reparto, duracionMinutos, sinopsis, fechaEstreno, caratula);

                pel.AgregarPelicula(pel);
                CargarDataGrid();
            }
            ConexionBD.CerrarConexion();


        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil frm1 = new FrmMiPerfil();
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

        private void FrmGestionAdmin_Load(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();
                    CargarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    ConexionBD.CerrarConexion();
                }
            }
        }
    }
}
