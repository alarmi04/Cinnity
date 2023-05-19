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
using System.Globalization;
using Proyecto_Cinnity.RecursosLocalizables;
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
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
            AplicarIdioma();

            CargarPeliculas();
            pnlMantenimiento.Visible= false;
        }

        private void AplicarIdioma()
        {
            btnMiPerfil.Text = StringRecursos.perfil;
            btnEntradas.Text = StringRecursos.entradas;
            btnAyuda.Text = StringRecursos.ayuda;
            btnCerrarSesion.Text = StringRecursos.cerrarsesion;
            btnMantenimiento.Text = StringRecursos.mantenimiento;
            lblContraAdmin.Text = StringRecursos.contrasenya;
            btnAcceder.Text = StringRecursos.acceder;
            txtBuscar.Text = StringRecursos.buscar;
            cmbFiltrar.Text = StringRecursos.filtrar;            

            cmbFiltrar.Items.Clear();
            cmbFiltrar.Items.Add(StringRecursos.acción);
            cmbFiltrar.Items.Add(StringRecursos.animación);
            cmbFiltrar.Items.Add(StringRecursos.terror);
            cmbFiltrar.Items.Add(StringRecursos.suspense);
            cmbFiltrar.Items.Add(StringRecursos.comedia);
            cmbFiltrar.Items.Add(StringRecursos.documental);
            cmbFiltrar.Items.Add(StringRecursos.aventura);
            cmbFiltrar.Items.Add(StringRecursos.drama);
            cmbFiltrar.Items.Add(StringRecursos.todas);
            this.Text = StringRecursos.tituloventanaMiPerfil;
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
        }



        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }
        private void btnEntradas_Click(object sender, EventArgs e)
        {
            FrmGestionDeEntradas gestionDeEntradas = new FrmGestionDeEntradas();
            this.Hide();
            gestionDeEntradas.StartPosition = FormStartPosition.CenterScreen;

            gestionDeEntradas.Show();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito frm1 = new FrmCarrito();
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


        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda frm1 = new FrmAyuda();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

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
                        imagen.Tag = pelicula.Nombre;
                        imagen.Click += new EventHandler(pictureBox_Click);

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
                
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ComprobarGenero()
        {
            string genero = "";



            switch (cmbFiltrar.SelectedIndex)
            {
                case 0:
                    genero = "Accion";
                    break;
                case 1:
                    genero = "Animacion";
                    break;
                case 2:
                    genero = "Terror";
                    break;
                case 3:
                    genero = "Suspense";
                    break;
                case 4:
                    genero = "Comedia";
                    break;
                case 5:
                    genero = "Documental";
                    break;
                case 6:
                    genero = "Aventura";
                    break;
                case 7:
                    genero = "Drama";
                    break;
                case 8:
                    genero = "Todas";
                    break;
            }

            return genero;
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genero = ComprobarGenero();
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
                        imagen.Tag = pelicula.Nombre;
                        imagen.Click += new EventHandler(pictureBox_Click);


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
                    MessageBox.Show("No hay películas del género seleccionado.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }

        private void ptbInsta_Click(object sender, EventArgs e)
        {
            //abrir un link en el navegador al clickar la imagen.
            System.Diagnostics.Process.Start("https://www.instagram.com/appcinnity/");
        }

        private void ptbFacebook_Click(object sender, EventArgs e)
        {
            //abrir un link en el navegador al clickar la imagen.
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100092501948457");
        }

        private void ptbTwitter_Click(object sender, EventArgs e)
        {
            //abrir un link en el navegador al clickar la imagen.
            System.Diagnostics.Process.Start("https://www.twitter.com/CinnityApp");
        }

        private void ptbEmail_Click(object sender, EventArgs e)
        {
            //al hacer click en la imagen que se abra el outlook para enviar un correo.
            System.Diagnostics.Process.Start("mailto:cinnityapp@gmail.com");
        }

        private void ptbLogo_Click(object sender, EventArgs e)
        {
            //al hacer click en la imagen que se abra el outlook para enviar un correo.
            System.Diagnostics.Process.Start("https://cinnitytest.000webhostapp.com/index.php");
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (pnlMantenimiento.Visible == true)
            {
                pnlMantenimiento.Visible = false;
            } else
            {
                pnlMantenimiento.Visible = true;

            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (ValidarContra())
            {
                FrmGestionAdmin frm1 = new FrmGestionAdmin();
                this.Hide();
                frm1.StartPosition = FormStartPosition.CenterScreen;

                frm1.Show();
            } else
            {
                MessageBox.Show("La contraseña no es correcta.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool ValidarContra()
        {
            bool correcto = false;
            string clave = "EQUIPOAMARILLO";
            if (txtContraAdmin.Text.ToUpper() == clave)
            {
                correcto = true;
            }
            return correcto;
        }
    }
}

