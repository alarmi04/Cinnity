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

namespace Proyecto_Cinnity
{
    public partial class FrmInformacionPelicula : Form
    {
        private Entradas entradaEnviadaCarrito = null;

        //public Entradas EntradaEnviadaCarrito { get { return entradaEnviadaCarrito; } }
        string nombre;
        public FrmInformacionPelicula(string nombre)
        {
            this.nombre = nombre;
            InitializeComponent();
        }

        private void btnAñadirEntrada_Click(object sender, EventArgs e)
        {
            // Se recoge la entrada con el id mas alto.
            //string consulta = "SELECT * FROM entrada WHERE entrada.id=(SELECT MAX(id) FROM entrada);";
            //Entradas entrada = new Entradas();

            // abrir conexion
            //ConexionBD.AbrirConexion();
            //ConexionBD.CerrarConexion();

            // Comprobar Si el ID de la entrada no existe y meter el resultado en una variable booleana

            // Comprobar el ID mas alto, coger el valor y sumarle 1 (almacenar este valor en una variable id)

            // cerrar conexion

            //entradaEnviadaCarrito = new Entradas(id(recogido de antes), precio, fechaCompra, horaEmision, fechaDeEmision);
        }

        private void dttDiaEmision_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmInformacionPelicula_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }


        public void CargarInformacion()
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                lblGenero.Text += Pelicula.BuscarInformacion("genero",nombre);
                lblDirector.Text += Pelicula.BuscarInformacion("director",nombre);
                lblDuracion.Text += Pelicula.BuscarInformacion("duracion",nombre);
                txtSinopsis.Text = Pelicula.BuscarInformacion("sinopsis",nombre);
                lblNombrePeli.Text += Pelicula.BuscarInformacion("nombre",nombre);
                lblFechaEstreno.Text += Pelicula.BuscarInformacion("fechaEstreno",nombre);
                lblReparto.Text += Pelicula.BuscarInformacion("reparto",nombre);
                ConexionBD.CerrarConexion();
            }

            
        }
    }
}
