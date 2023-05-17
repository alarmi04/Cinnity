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

                    if (Usuario.ClaveValidada(txtNuevaContra.Text, txtConfirmaContra.Text))
                    {
                        Usuario.CambiarContraseña(txtConfirmaContra.Text, txtContraActual.Text, correoAsignado);
                        FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
                        ConexionBD.CerrarConexion();
                        this.Hide();
                        frm1.Show();
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
}
