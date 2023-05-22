using MySql.Data.MySqlClient;
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
using static System.Resources.ResXFileRef;
using System.Globalization;

namespace Proyecto_Cinnity
{
    public partial class FrmInformacionPelicula : Form
    {
        private string nombre;

        public FrmInformacionPelicula(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }

        private void AplicarIdioma()
        {
            lblGenero.Text = StringRecursos.genero;
            lblDirector.Text = StringRecursos.director;
            lblReparto.Text = StringRecursos.reparto;
            lblDuracion.Text = StringRecursos.duracion;
            lblSinopsis.Text = StringRecursos.sinopsis;
            cmbSesion.Text = StringRecursos.seleccsesion;
            lblFechaEstreno.Text = StringRecursos.fechaestreno;
            lblPrecio.Text = StringRecursos.precio;
            lblSesionesDisponibles.Text = StringRecursos.sesiones;
            btnAñadirEntrada.Text = StringRecursos.añcarrito;
            this.Text = StringRecursos.TituloVentanaInfoPeli; 
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
        }

        private bool DatosValidos()
        {
            bool ok = true;

            errorInformacionPelicula.Clear();

            DateTime.TryParse(cmbSesion.Text, out DateTime sesion);
            if (cmbSesion.Text == "" || cmbSesion.Text == StringRecursos.seleccsesion)
            {
                ok = false;
                errorInformacionPelicula.SetError(cmbSesion, "Set a valid session");
            }
            if (dttDiaEmision.Value < DateTime.Today)
            {
                ok = false;
                errorInformacionPelicula.SetError(dttDiaEmision, "Set a valid day");
            }
            else
            {
                DateTime fechaEmision = new DateTime(dttDiaEmision.Value.Year, dttDiaEmision.Value.Month, dttDiaEmision.Value.Day,
                                              sesion.Hour, sesion.Minute, sesion.Second);

                if (fechaEmision < DateTime.Now)
                {
                    ok = false;
                    errorInformacionPelicula.SetError(cmbSesion, "The session time must be greater than or equal to the current time");
                }
            }


            return ok;
        }

        private void btnAñadirEntrada_Click(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();
                    if (DatosValidos())
                    {
                        Carrito.AñadirAlCarrito(txtNombrePeli.Text, Convert.ToDouble(lblPrecioNum.Text), DateTime.Now, cmbSesion.Text, dttDiaEmision.Value.Date);
                        ConexionBD.CerrarConexion();
                        this.Close();
                    }

                    
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

        private void FrmInformacionPelicula_Load(object sender, EventArgs e)
        {

            CargarInformacion();
            AplicarIdioma();
            lblPrecioNum.Text = "8.00";

            if (dttDiaEmision.Value.Day % 2 == 0)
            {
                string[] sesiones1 = { "17:00:00", "18:00:00", "19:00:00", "21:00:00" };
                cmbSesion.Items.Clear();
                cmbSesion.Items.AddRange(sesiones1);
            }
            else
            {
                string[] sesiones2 = { "16:00:00", "17:30:00", "19:40:00", "22:00:00" };
                cmbSesion.Items.Clear();
                cmbSesion.Items.AddRange(sesiones2);
            }
        }


        private void dttDiaEmision_ValueChanged(object sender, EventArgs e)
        {
            if (dttDiaEmision.Value.Day % 2 == 0)
            {
                string[] sesiones1 = { "17:00:00", "18:00:00", "19:00:00", "21:00:00" };
                cmbSesion.Items.Clear();
                cmbSesion.Items.AddRange(sesiones1);
            }
            else
            {
                string[] sesiones2 = { "16:00:00", "17:30:00", "19:40:00", "22:00:00" };
                cmbSesion.Items.Clear();
                cmbSesion.Items.AddRange(sesiones2);
            }
        }

        public void CargarInformacion()
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();

                lblGeneroInfo.Text = Pelicula.BuscarInformacion("genero", nombre);
                lblDirectorInfo.Text = Pelicula.BuscarInformacion("director", nombre);
                lblDuracionInfo.Text = Pelicula.BuscarInformacion("duracion", nombre);
                txtSinopsis.Text = Pelicula.BuscarInformacion("sinopsis", nombre);
                txtNombrePeli.Text = Pelicula.BuscarInformacion("nombre", nombre);
                lblFechaEstrenoInfo.Text = Pelicula.BuscarInformacion("fechaEstreno", nombre);
                txtReparto.Text = Pelicula.BuscarInformacion("reparto", nombre);

                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                ptbPeli.Image = (Image)converter.ConvertFrom(Pelicula.CargarCaratula(nombre));

                ConexionBD.CerrarConexion();
            }
        }

            private void cmbSesion_SelectedIndexChanged(object sender, EventArgs e)
            {
                switch (cmbSesion.SelectedIndex)
                {
                    case 0:
                        lblPrecioNum.Text = "7,00";
                        break;
                    case 1:
                        lblPrecioNum.Text = "9,00";
                        break;
                    case 2:
                        lblPrecioNum.Text = "10,00";
                        break;
                    case 3:
                        lblPrecioNum.Text = "8,00";
                        break;
                    default:
                        lblPrecioNum.Text = "10,00";
                        break;
                }
            }
        
    }
}
