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
    public partial class FrmCrearCuenta : Form
    {
        public FrmCrearCuenta()
        {
            InitializeComponent();
        }

        private bool DatosValidos()
        {
            bool ok = true;

            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();

                    errorCrearCuenta.Clear();

                    if (txtNombre.Text == "")
                    {
                        ok = false;
                        errorCrearCuenta.SetError(txtNombre, "Introduce Nombre");
                    }

                    if (txtContra.Text == "")
                    {
                        ok = false;
                        errorCrearCuenta.SetError(txtContra, "Introduce Contraseña");
                    }

                    if (cmbPais.Text == "")
                    {
                        ok = false;
                        errorCrearCuenta.SetError(cmbPais, "Introduce Pais");
                    }

                    if (dtpFechaNacimiento.Value == DateTime.Now)
                    {
                        ok = false;
                        errorCrearCuenta.SetError(dtpFechaNacimiento, "Introduce Fecha valida");
                    }

                    if (txtCorreo.Text == "")
                    {
                        ok = false;
                        errorCrearCuenta.SetError(txtCorreo, "Introduce Correo");
                    }

                    if (txtCorreo.Text != txtConfirmarCorreo.Text)
                    {
                        ok = false;
                        errorCrearCuenta.SetError(txtConfirmarCorreo, "Introduce el mismo correo");
                    }

                    if (txtContra.Text == "")
                    {
                        ok = false;
                        errorCrearCuenta.SetError(txtContra, "Introduce Contraseña");
                    }

                    if (txtContra.Text != txtConfirmarContra.Text)
                    {
                        ok = false;
                        errorCrearCuenta.SetError(txtContra, "Introduce la misma contraseña");
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


        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();
                    if (Usuario.ClaveValidada(txtContra.Text, txtConfirmarContra.Text) && Usuario.CorreoValidado(txtCorreo.Text, txtConfirmarCorreo.Text))
                    {
                        Usuario.RegistrarUsuario(txtNombre.Text, txtApellidos.Text, txtConfirmarCorreo.Text, txtConfirmarContra.Text, cmbPais.Text, dtpFechaNacimiento.Value);
                        ConexionBD.CerrarConexion();

                        FrmPaginaPrincipal frmprincipal = new FrmPaginaPrincipal();
                        this.Hide();
                        frmprincipal.Show();
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

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}

