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
            dataGridView1.DataSource = lista;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
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

            Pelicula pel = new Pelicula(nombre, genero, director, reparto, duracionMinutos, sinopsis, fechaEstreno, caratula);

            pel.AgregarPelicula(pel);
        }
    }
}
