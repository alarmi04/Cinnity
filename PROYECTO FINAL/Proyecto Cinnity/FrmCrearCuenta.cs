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


        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();
                    if (Usuario.ClaveValidada(txtContra.Text, txtConfirmarContra.Text) && Usuario.CorreoValidado(txtCorreo.Text, txtConfirmarCorreo.Text))
                    {
                        Usuario.RegistrarUsuario(txtNombre.Text, txtApellidos.Text, txtConfirmarCorreo.Text, txtConfirmarContra.Text, cmbPais.Text, dtpFechaNacimiento.Value.ToString());
                        ConexionBD.CerrarConexion();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            FrmPaginaPrincipal frmprincipal = new FrmPaginaPrincipal();
            this.Hide();
            frmprincipal.Show();
        }


    }
}

