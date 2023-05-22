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

namespace Proyecto_Cinnity
{
    public partial class FrmCambiarContra : Form
    {
        string correoAsignado;
        public FrmCambiarContra(string correoAsignado)
        {
            InitializeComponent();
            this.correoAsignado = correoAsignado;
        }

        private void FrmCambiarContra_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }
        private void AplicarIdioma()
        {
            lblContraActual.Text = StringRecursos.contraActual;
            lblNuevaContra.Text = StringRecursos.nuevaContra;
            lblConfirmaContra.Text = StringRecursos.confirmaContra;
            btnAceptar.Text = StringRecursos.aceptarcambiar;
            chbMostrarContra.Text = StringRecursos.mostrarContra;
            this.Text = StringRecursos.tituloventanaCambioContra;
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    if (DatosValidos())
                    {
                        if (Usuario.ClaveValidada(txtNuevaContra.Text, txtConfirmaContra.Text))
                        {
                            Usuario.CambiarContraseña(txtConfirmaContra.Text, txtContraActual.Text, correoAsignado);
                            FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
                            ConexionBD.CerrarConexion();
                            this.Hide();
                            frm1.Show();
                        } else
                        {
                            MessageBox.Show("Wrong password.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
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

        private bool DatosValidos()
        {
            bool ok = true;

            errorCambiarContra.Clear();

            if (txtContraActual.Text == "")
            {
                ok = false;
                errorCambiarContra.SetError(txtContraActual, "Enter your current password");
            }

            if (txtNuevaContra.Text == "")
            {
                ok = false;
                errorCambiarContra.SetError(txtNuevaContra, "Enter your new password");
            }

            if (txtConfirmaContra.Text == "")
            {
                ok = false;
                errorCambiarContra.SetError(txtConfirmaContra, "Enter your new password");
            }

            if (!Usuario.ClaveValidada(txtNuevaContra.Text,txtConfirmaContra.Text))
            {
                ok = false;
                errorCambiarContra.SetError(txtConfirmaContra, "Passwords don't match");
            }
            return ok;

        }

        private void chbMostrarContra_Click(object sender, EventArgs e)
        {
            if (txtContraActual.PasswordChar == '*')
            {
                txtContraActual.PasswordChar = '\0';
                txtNuevaContra.PasswordChar = '\0';
                txtConfirmaContra.PasswordChar = '\0';

            }
            else
            {
                txtContraActual.PasswordChar = '*';
                txtNuevaContra.PasswordChar = '*';
                txtConfirmaContra.PasswordChar = '*';
            }
        }
    }
}
