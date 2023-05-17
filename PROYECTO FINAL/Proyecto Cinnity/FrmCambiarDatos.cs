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
    public partial class FrmCambiarDatos : Form
    {
        public FrmCambiarDatos()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            if(ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();
                    Usuario.CambiarDatos(txtNombre.Text, txtCorreo.Text, txtApellidos.Text);
                    ConexionBD.CerrarConexion();

                    FrmInicioDeSesion fr1 = new FrmInicioDeSesion();
                    this.Close();
                    fr1.Show();
                    
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
