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
    public partial class FrmGestionDeEntradas : Form
    {
        public FrmGestionDeEntradas()
        {
            InitializeComponent();
        }

        private void FrmGestionDeEntradas_Load(object sender, EventArgs e)
        {
            CargaListaEntradasActivas();
        }

        private void CargaListaEntradasActivas()
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();                
                List<Entradas> lista = Entradas.EntradasActivas();
                dgvEntradasActivas.DataSource = lista;
                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil frm1 = new FrmMiPerfil();
            frm1.Show();
        }

        private void btnBuscarEntrada_Click(object sender, EventArgs e)
        {

        }

        private void btnVenderEntrada_Click(object sender, EventArgs e)
        {

        }
    }
}
