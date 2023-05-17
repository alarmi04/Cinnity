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
using static System.Resources.ResXFileRef;

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

        private void btnAñadirEntrada_Click(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();
                    Carrito.AñadirAlCarrito(txtNombrePeli.Text, Convert.ToDouble(lblPrecioNum.Text), DateTime.Now, cmbSesion.Text, dttDiaEmision.Value);
                    ConexionBD.CerrarConexion();
                    this.Close();
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
            lblPrecioNum.Text = "8.00";

            if (dttDiaEmision.Value.Day % 2 == 0)
            {
                string[] sesiones1 = { "17:00", "18:00", "19:00", "21:00" };
                cmbSesion.Items.Clear();
                cmbSesion.Items.AddRange(sesiones1);
            }
            else
            {
                string[] sesiones2 = { "16:00", "17:30", "19:40", "22:00" };
                cmbSesion.Items.Clear();
                cmbSesion.Items.AddRange(sesiones2);
            }
        }

        private void dttDiaEmision_ValueChanged(object sender, EventArgs e)
        {
            if (dttDiaEmision.Value.Day % 2 == 0)
            {
                string[] sesiones1 = { "17:00", "18:00", "19:00", "21:00" };
                cmbSesion.Items.Clear();
                cmbSesion.Items.AddRange(sesiones1);
            }
            else
            {
                string[] sesiones2 = { "16:00", "17:30", "19:40", "22:00" };
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
                        lblPrecioNum.Text = "7";
                        break;
                    case 1:
                        lblPrecioNum.Text = "9";
                        break;
                    case 2:
                        lblPrecioNum.Text = "10";
                        break;
                    case 3:
                        lblPrecioNum.Text = "8";
                        break;
                    default:
                        lblPrecioNum.Text = "10";
                        break;
                }
            }
        
    }
}
