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
                ptbImagen.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void LimpiarControles()
        {
            txtTitulo.Clear();
            txtGenero.Clear();
            txtDirector.Clear();
            txtReparto.Clear();
            nudDuracion.Value = 0;
            dtpFechaEstreno.Value = DateTime.Now;
            txtSinopsis.Clear();
            ptbImagen.Image = null;
            txtId.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            string nombre = txtTitulo.Text;
            string genero = txtGenero.Text;
            string director = txtDirector.Text;
            string reparto = txtReparto.Text;
            int duracionMinutos = (int)nudDuracion.Value;
            string sinopsis = txtSinopsis.Text;
            DateTime fechaEstreno = dtpFechaEstreno.Value;
            Image caratula = ptbImagen.Image;
            Pelicula pel = new Pelicula(nombre, genero, director, reparto, duracionMinutos, sinopsis, fechaEstreno, caratula);


            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();

                if (String.IsNullOrEmpty(txtId.Text))
                {
                    if (pel.YaEsta(ConexionBD.Conexion, pel.Nombre))
                    {
                        MessageBox.Show("Esta película ya existe en la base de datos.");
                    }
                    else
                    {
                        resultado = pel.AgregarPelicula(pel);

                    }
                }
                else
                {
                    resultado = pel.ActualizaPelicula(ConexionBD.Conexion, pel);
                }
                if (resultado > 0)
                {
                    LimpiarControles();
                }
                CargarDataGrid();
                ConexionBD.CerrarConexion();
            }







        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil frm1 = new FrmMiPerfil();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPeliculas.SelectedRows.Count == 1) // Si hay una fila seleccionada en el datagridview
                {
                    string titulo = dgvPeliculas.CurrentRow.Cells[0].Value.ToString();  // Obtenemos el id de la fila seleccionada
                    // Extraigo de la BD la información (no del datagrid!) 
                    // por si estuviese actualizada en la BD por otro usuario y no estuviese refrescada en mi datagridview
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();
                        Pelicula pel = Pelicula.ObtenerPelicula(ConexionBD.Conexion, titulo);
                        CargaCajasTexto(pel);

 
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                    }
                    // Cerramos la conexion
                    ConexionBD.CerrarConexion();
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

        private void CargaCajasTexto(Pelicula pel)
        {
            txtTitulo.Text = pel.Nombre.ToString();
            txtGenero.Text = pel.Genero;
            txtDirector.Text = pel.Director;
            txtReparto.Text = pel.Reparto;
            nudDuracion.Value = pel.DuracionMinutos;
            dtpFechaEstreno.Value = pel.FechaEstreno;
            txtSinopsis.Text = pel.Sinopsis;
            ptbImagen.Image = pel.Caratula;
            txtId.Text = pel.IdPelicula.ToString();
        }
 
    }
}
