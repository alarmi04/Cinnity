using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Cinnity.RecursosLocalizables;
using System.Globalization;
using System.Threading;

namespace Proyecto_Cinnity
{
    public partial class FrmMiPerfil : Form
    {
        public FrmMiPerfil()
        {
            InitializeComponent();
            lblCorreo.Text = Usuario.correo;
            lblNombreUsuario.Text = Usuario.nombre;
        }

        private void FrmMiPerfil_Load(object sender, EventArgs e)
        {
            AplicarIdioma();

            int cant = CargarDataGrid();
            lblTotalEntradas.Text += cant.ToString();
        }

        private void AplicarIdioma()
        {
            lblEditarInformacion.Text = StringRecursos.editinfo;
            lblMetodosDePago.Text = StringRecursos.metpago;
            lblCambiarContra.Text = StringRecursos.cambContrasenya;
            lblTotalEntradas.Text = StringRecursos.totalEntradas;
            lblEntradasAdquiridas.Text = StringRecursos.entradasadquiridas;
            this.Text = StringRecursos.tituloventanaMiPerfil;
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
        }

        private int CargarDataGrid()
        {
            int cantEntradasAdquiridas = -1;
            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();
                    int id = Usuario.RecogerID();
                    List<Entradas> lista = Entradas.EntradasAdquiridas(id);
                    cantEntradasAdquiridas = lista.Count;
                    ConexionBD.CerrarConexion();
                    dgvEntradasActivas.DataSource = lista;                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ConexionBD.CerrarConexion();
                }
            } else
            {
                MessageBox.Show("No existe conexión a la base de datos.");
            }

            return cantEntradasAdquiridas;

        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frm1 = new FrmPaginaPrincipal();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;


            frm1.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.ShowDialog();
        }

        private void lblCambiarContra_Click(object sender, EventArgs e)
        {
            FrmCambiarContra frm1 = new FrmCambiarContra(lblCorreo.Text);
            frm1.StartPosition = FormStartPosition.CenterScreen;
            frm1.Show();
        }



        private void lblEditarInformacion_Click(object sender, EventArgs e)
        {
            FrmCambiarDatos fr = new FrmCambiarDatos();
            this.Hide();
            fr.Show();
        }
    }
}
