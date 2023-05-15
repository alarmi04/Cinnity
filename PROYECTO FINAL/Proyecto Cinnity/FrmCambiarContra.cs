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
        public FrmCambiarContra()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBD.AbrirConexion();

                if (Usuario.ClaveValidada(txtNuevaContra.Text, txtConfirmaContra.Text))
                {
                    Usuario.CambiarContraseña(txtConfirmaContra.Text);
                    FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
                    this.Hide();
                    frm1.Show();
                    ConexionBD.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            } finally
            {
                ConexionBD.CerrarConexion();
            }
            
        }
    }
}
