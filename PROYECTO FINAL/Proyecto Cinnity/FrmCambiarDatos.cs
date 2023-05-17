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

        private void FrmCambiarDatos_Load(object sender, EventArgs e)
        {
            ptbApariencia.Image = Usuario.imagenSeleccionada;
        }

        private void cmbSeleccionarApariencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeleccionarApariencia.SelectedItem.ToString() == "Masculino")
            {
                Usuario.imagenSeleccionada = Properties.Resources.perfil;
            }else
            {
                Usuario.imagenSeleccionada = Properties.Resources.Femenino;
            }

            ptbApariencia.Image = Usuario.imagenSeleccionada;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
