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
using System.Security.Cryptography.X509Certificates;

namespace Proyecto_Cinnity
{
    public partial class FrmCrearCuenta : Form
    {

        private bool isFirstClickContra = true;
        private bool isFirstClickConfirmarContra = true;
        private bool isFirstClickConfirmarCorreo = true;
        private bool isFirstClickCorreo = true;
        private bool isFirstClickNombre = true;
        private bool isFirstClickApellidos = true;
        public FrmCrearCuenta()
        {
            InitializeComponent();
        }

        private bool DatosValidos()
        {
            bool ok = true;

            errorCrearCuenta.Clear();

            if (txtNombre.Text == "" || txtNombre.Text == "Nombre")
            {
                ok = false;
                errorCrearCuenta.SetError(txtNombre, "Introduce Nombre");
            }

            if (txtContra.Text == "" || txtContra.Text == "Contraseña")
            {
                ok = false;
                errorCrearCuenta.SetError(txtContra, "Introduce Contraseña");
            }


            if (txtApellidos.Text == "" || txtApellidos.Text == "Apellidos")
            {
                ok = false;
                errorCrearCuenta.SetError(txtApellidos, "Introduce Apellidos");
            }

            if (cmbPais.Text == "" || cmbPais.Text == "País")
            {
                ok = false;
                errorCrearCuenta.SetError(cmbPais, "Introduce Pais");
            }
            if (txtCorreo.Text == "" || txtCorreo.Text == "Correo electrónico")
            {
                ok = false;
                errorCrearCuenta.SetError(txtCorreo, "Introduce Correo");
            }


            if (dtpFechaNacimiento.Value == DateTime.Today)
            {
                ok = false;
                errorCrearCuenta.SetError(dtpFechaNacimiento, "Introduce Fecha valida");
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
                errorCrearCuenta.SetError(txtConfirmarContra, "Introduce la misma contraseña");
            }

            return ok;

        }


        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();
                    if (DatosValidos())
                    {

                        if (Usuario.ClaveValidada(txtContra.Text, txtConfirmarContra.Text) && Usuario.CorreoValidado(txtCorreo.Text, txtConfirmarCorreo.Text))
                        {
                            Usuario.RegistrarUsuario(txtNombre.Text, txtApellidos.Text, txtConfirmarCorreo.Text, txtConfirmarContra.Text, cmbPais.Text, dtpFechaNacimiento.Value);
                            string correoDestino = txtConfirmarCorreo.Text; // Dirección de correo del usuario
                            EnviarCorreoRegistro(correoDestino);
                            ConexionBD.CerrarConexion();

                            FrmPaginaPrincipal frmprincipal = new FrmPaginaPrincipal();
                            this.Hide();
                            frmprincipal.StartPosition = FormStartPosition.CenterScreen;

                            frmprincipal.Show();

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

        private void EnviarCorreoRegistro(string correoDestino)
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("cinnityapp@gmail.com", "Cinnity", System.Text.Encoding.UTF8); // Correo de salida
            correo.To.Add(correoDestino); // Correo destino
            correo.Subject = "Gracias por tu registro"; // Asunto del correo
            string Body = "¡Gracias por registrarte en nuestra aplicación! [Nombre de Usuario]" +
                "<br><br>Es bueno que nos hayas elegido, porque somos tu mejor APP para adquirir entradas de cine."; // Mensaje del correo con HTML y demas
            correo.Body = Body;
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true; // True si el servidor de correo permite SSL
            smtp.Credentials = new NetworkCredential("cinnityapp@gmail.com", "caeiyxiguufehhke"); // Cuenta de correo de envío

            try
            {
                smtp.Send(correo);
                MessageBox.Show("Correo enviado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}");
            }
        }

        private void txtContra_Click(object sender, EventArgs e)
        {
            if (isFirstClickContra)
            {
                txtContra.PasswordChar = '*';
                txtContra.Text = "";
                isFirstClickContra = false;
            }
        }

        private void txtConfirmarContra_Click(object sender, EventArgs e)
        {
            if (isFirstClickConfirmarContra)
            {
                txtConfirmarContra.PasswordChar = '*';
                txtConfirmarContra.Text = "";
                isFirstClickConfirmarContra = false;
            }
        }

        private void txtConfirmarCorreo_Click(object sender, EventArgs e)
        {
            if (isFirstClickConfirmarCorreo)
            {
                txtConfirmarCorreo.Text = "";
                isFirstClickConfirmarCorreo = false;
            }
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            if (isFirstClickCorreo)
            {
                txtCorreo.Text = "";
                isFirstClickCorreo = false;
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (isFirstClickNombre)
            {
                txtNombre.Text = "";
                isFirstClickNombre = false;
            }
        }

        private void txtApellidos_Click(object sender, EventArgs e)
        {
            if (isFirstClickApellidos)
            {
                txtApellidos.Text = "";
                isFirstClickApellidos = false;
            }
        }

        private void chbMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConfirmarContra.PasswordChar == '*' || txtContra.PasswordChar == '*')
            {
                txtContra.PasswordChar = '\0';
                txtConfirmarContra.PasswordChar = '\0';
            }
            else
            {
                txtConfirmarContra.PasswordChar = '*';
                txtContra.PasswordChar = '*';
            }
        }

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}


