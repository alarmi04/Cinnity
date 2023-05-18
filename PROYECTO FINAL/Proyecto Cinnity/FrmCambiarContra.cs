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
    public partial class FrmCambiarContra : Form
    {
        string correoAsignado;
        public FrmCambiarContra(string correoAsignado)
        {
            InitializeComponent();
            this.correoAsignado = correoAsignado;
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
                            MessageBox.Show("La clave introducida no es correcta.");
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
                errorCambiarContra.SetError(txtContraActual, "Introduce tu constraseña actual.");
            }

            if (txtNuevaContra.Text == "")
            {
                ok = false;
                errorCambiarContra.SetError(txtNuevaContra, "Introduce nueva contraseña");
            }

            if (txtConfirmaContra.Text == "")
            {
                ok = false;
                errorCambiarContra.SetError(txtConfirmaContra, "Introduce nueva contraseña");
            }
            return ok;

        }

        private void FrmCambiarContra_Load(object sender, EventArgs e)
        {

        }
    }
}
