using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Security;
using System.Net;
using System.Threading;
using Proyecto_Cinnity.RecursosLocalizables;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace Proyecto_Cinnity
{
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            lblInformacion.Text = StringRecursos.informacion;
            lblInformacion2.Text = StringRecursos.descripcionayuda;
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;


        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil frm1 = new FrmMiPerfil();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frm1 = new FrmPaginaPrincipal();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }

        private void ptbInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/appcinnity/");

        }

        private void ptbFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100092501948457");

        }

        private void ptbTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitter.com/CinnityApp");

        }

        private void ptbCorreo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:cinnityapp@gmail.com");

        }

        private void ptbLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cinnitytest.000webhostapp.com/index.php");

        }

        
    }
}
