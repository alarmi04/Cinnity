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

        string nombrePeli;
        public FrmPaginaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPaginaPrincipal_Load(object sender, EventArgs e)
        {
            CargarPeliculas();
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
            FrmCarrito frm1 = new FrmCarrito();
            this.Hide();
            frm1.Show();
        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil frm1 = new FrmMiPerfil();
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

        private void CargarPeliculas()
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                List<Pelicula> peliculas = Pelicula.CargarPeliculas();

                if (peliculas != null && peliculas.Count > 0)
                {
                    int x = 10, y = 10;
                    int peliculaCount = 0;
                    int maxPeliculasPorFila = 5;
                    pnlPeliculas.Width = 600;
                    pnlPeliculas.Height = 400;
                    pnlPeliculas.Text = "";
                    this.Controls.Add(pnlPeliculas);
                    foreach (Pelicula pelicula in peliculas)
                    {
                        PictureBox imagen = new PictureBox();
                        imagen.Click += new EventHandler(pictureBox_Click);
                        imagen.Tag = pelicula.Nombre;
                        imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        imagen.BorderStyle = BorderStyle.FixedSingle;
                        imagen.Image = pelicula.Caratula;
                        imagen.Width = 100;
                        imagen.Height = 150;
                        imagen.Location = new Point(x, y);
                        pnlPeliculas.Controls.Add(imagen);
                        peliculaCount++;

                        if (peliculaCount % maxPeliculasPorFila == 0)
                        {
                            x = 10;
                            y = imagen.Bottom + 10;
                        }
                        else
                        {
                            x = imagen.Right + 10;
                        }
                    }
                    ConexionBD.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No existe conexión a la Base de datos");
                }
            }
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genero = cmbFiltrar.SelectedItem.ToString();
            string consulta = "";
            if (genero == "Todas")
            {
                consulta = "SELECT * FROM Pelicula;";
            }
            else
            {
                consulta = "SELECT * FROM Pelicula WHERE genero='" + genero + "';";

            }

            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();

                // Obtener la lista de películas del género seleccionado
                List<Pelicula> peliculas = Pelicula.FiltrarPelicula(genero, consulta);

                if (peliculas != null && peliculas.Count > 0)
                {
                    int x = 10, y = 10;
                    int peliculaCount = 0;
                    int maxPeliculasPorFila = 5;
                    pnlPeliculas.Width = 600;
                    pnlPeliculas.Height = 400;
                    pnlPeliculas.Text = "";
                    pnlPeliculas.Controls.Clear(); // Limpiar PictureBoxes anteriores
                    pnlPeliculas.AutoScroll = true; // Habilitar el scroll del GroupBox
                    this.Controls.Add(pnlPeliculas);

                    foreach (Pelicula pelicula in peliculas)
                    {
                        PictureBox imagen = new PictureBox();
                        imagen.Click += new EventHandler(pictureBox_Click);

                        imagen.Tag = pelicula.Nombre;
                        imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        imagen.BorderStyle = BorderStyle.FixedSingle;
                        imagen.Image = pelicula.Caratula;
                        imagen.Width = 100;
                        imagen.Height = 150;
                        imagen.Location = new Point(x, y);
                        pnlPeliculas.Controls.Add(imagen);
                        peliculaCount++;

                        if (peliculaCount % maxPeliculasPorFila == 0)
                        {
                            x = 10;
                            y = imagen.Bottom + 10;
                        }
                        else
                        {
                            x = imagen.Right + 10;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay películas del género seleccionado.");
                }

                ConexionBD.CerrarConexion();
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();

                // Obtener la lista de películas del género seleccionado
                List<Pelicula> peliculas = Pelicula.BuscarPelicula(txtBuscar.Text);

                if (peliculas != null && peliculas.Count > 0)
                {
                    int x = 10, y = 10;
                    int peliculaCount = 0;
                    int maxPeliculasPorFila = 5;
                    pnlPeliculas.Width = 600;
                    pnlPeliculas.Height = 400;
                    pnlPeliculas.Text = "";
                    pnlPeliculas.Controls.Clear(); // Limpiar PictureBoxes anteriores
                    pnlPeliculas.AutoScroll = true; // Habilitar el scroll del GroupBox
                    this.Controls.Add(pnlPeliculas);

                    foreach (Pelicula pelicula in peliculas)
                    {
                        PictureBox imagen = new PictureBox();
                        imagen.Click += new EventHandler(pictureBox_Click);
                        imagen.Tag = pelicula.Nombre;

                        imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        imagen.BorderStyle = BorderStyle.FixedSingle;
                        imagen.Image = pelicula.Caratula;
                        imagen.Width = 100;
                        imagen.Height = 150;
                        imagen.Location = new Point(x, y);
                        pnlPeliculas.Controls.Add(imagen);
                        peliculaCount++;

                        if (peliculaCount % maxPeliculasPorFila == 0)
                        {
                            x = 10;
                            y = imagen.Bottom + 10;
                        }
                        else
                        {
                            x = imagen.Right + 10;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay películas con el nombre seleccionado.");
                }

                ConexionBD.CerrarConexion();

            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
            this.Hide();
            frm1.Show();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string nombrePelicula = pictureBox.Tag.ToString();

            FrmInformacionPelicula frm1 = new FrmInformacionPelicula(nombrePelicula);
            frm1.Show();
        }










    }
}

