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
    public partial class FrmCambiarDatos : Form
    {
        public FrmCambiarDatos()
        {
            InitializeComponent();
        }

        private void FrmCambiarDatos_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblCambioDatos.Text = StringRecursos.cambiodatos;
            lblNombre.Text = StringRecursos.nombrecuenta;
            lblApellidos.Text = StringRecursos.apellidoscuenta;
            lblCorreo.Text = StringRecursos.correoelectronico;
            this.Text = StringRecursos.TituloVentanaCambioDatos;
            btnAceptar.Text = StringRecursos.btnModificar;
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
        }

        private bool DatosValidos()
        {
            bool ok = true;

            errorCambiarDatos.Clear();

            if (txtNombre.Text == "")
            {
                ok = false;
                errorCambiarDatos.SetError(txtNombre, "Introduce tu nuevo nombre.");
            }

            if (txtApellidos.Text == "")
            {
                ok = false;
                errorCambiarDatos.SetError(txtApellidos, "Introduce tus nuevos apellidos.");
            }

            if (txtCorreo.Text == "")
            {
                ok = false;
                errorCambiarDatos.SetError(txtCorreo, "Introduce tu nuevo correo.");
            }
            return ok;

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            if(ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();
                    if (DatosValidos())
                    {
                        Usuario.CambiarDatos(txtNombre.Text, txtCorreo.Text, txtApellidos.Text);
                        ConexionBD.CerrarConexion();

                        FrmInicioDeSesion fr1 = new FrmInicioDeSesion();
                        this.Close();
                        fr1.StartPosition = FormStartPosition.CenterScreen;

                        fr1.Show();
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

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frmPP = new FrmPaginaPrincipal();
            this.Close();
            frmPP.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmInicioDeSesion frmIni = new FrmInicioDeSesion();
            this.Close();
            frmIni.Show();
        }

        
    }
}
