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

            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();

                    errorInicioSesion.Clear();

                    if (txtUsuario.Text == "")
                    {
                        ok = false;
                        errorInicioSesion.SetError(txtUsuario, "Introduce Usuario");
                    }

                    if (txtContra.Text == "")
                    {
                        ok = false;
                        errorInicioSesion.SetError(txtContra, "Introduce Contraseña");
                    }

                }
                return ok;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                return ok;

            }

            finally
            {
                ConexionBD.CerrarConexion();
            }

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
                            ConexionBD.CerrarConexion();
                            FrmPaginaPrincipal frm1 = new FrmPaginaPrincipal();
                            this.Hide();
                            frm1.StartPosition = FormStartPosition.CenterScreen;
                            frm1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
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

        private void lblContraOlvidada_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                FrmCambiarContra frm1 = new FrmCambiarContra(txtUsuario.Text);
                this.Hide();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Indica tu correo electrónico para cambiar la contraseña.");
            }
        }

    }
}
