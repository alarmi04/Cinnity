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
        }

        private void FrmInicioDeSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBD.AbrirConexion();
                if (Usuario.InicioSesionCorrecto(txtUsuario.Text, txtContra.Text))
                {
                    FrmPaginaPrincipal frm1 = new FrmPaginaPrincipal();
                    this.Hide();
                    frm1.Show();
                    ConexionBD.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
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

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta frmcuenta = new FrmCrearCuenta();
            this.Hide();
            frmcuenta.Show();
        }

        private void lblContraOlvidada_Click(object sender, EventArgs e)
        {
            FrmCambiarContra frm1 = new FrmCambiarContra();
            this.Hide();
            frm1.Show();
        }

    }
}
