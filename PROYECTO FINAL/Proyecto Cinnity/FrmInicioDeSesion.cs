using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using Proyecto_Cinnity.RecursosLocalizables;

namespace Proyecto_Cinnity
{
    public partial class FrmInicioDeSesion : Form
    {
        public FrmInicioDeSesion()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region VALIDACIONES

        private bool DatosValidos()
        {
            bool ok = true;

            errorInicioSesion.Clear();

            if (txtUsuario.Text == "")
            {
                ok = false;
                errorInicioSesion.SetError(txtUsuario, "Enter your e-mail");
            }

            if (txtContra.Text == "")
            {
                ok = false;
                errorInicioSesion.SetError(txtContra, "Enter your password");
            }
            return ok;

        }




        #endregion

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {
                try
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();

                        if (Usuario.InicioSesionCorrecto(txtUsuario.Text, txtContra.Text))
                        {
                            Carrito.VaciarCarrito();
                            ConexionBD.CerrarConexion();
                            FrmPaginaPrincipal frm1 = new FrmPaginaPrincipal();
                            this.Hide();
                            frm1.StartPosition = FormStartPosition.CenterScreen;
                            frm1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong e-mail or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }


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


        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta frmcuenta = new FrmCrearCuenta();
            this.Hide();
            frmcuenta.StartPosition = FormStartPosition.CenterScreen;
            frmcuenta.Show();
        }


        private void FrmInicioDeSesion_Load(object sender, EventArgs e)
        {

        }

        private void chbMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (txtContra.PasswordChar == '*')
            {
                txtContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
            }
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idioma.CulturaActual = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblUsuario.Text = StringRecursos.emailMayus;
            lblContra.Text = StringRecursos.contrasenya;
            chbMostrarContra.Text = StringRecursos.mostrarContra;
            btnIniciarSesion.Text = StringRecursos.iniciarSesión;
            btnCrearCuenta.Text = StringRecursos.crearcuenta;
            toolStripLabel1.Text = StringRecursos.idioma;
            this.Text = StringRecursos.tituloventanaMiPerfil;
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
        }

        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idioma.CulturaActual = new CultureInfo("en-GB");
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
            AplicarIdioma();
        }
    }
}
