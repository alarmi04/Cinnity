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
                        frmprincipal.StartPosition = FormStartPosition.CenterScreen;

                        frmprincipal.Show();

                        // Envío de correo
                        string correoDestino = txtConfirmarCorreo.Text; // Dirección de correo del usuario
                        EnviarCorreoRegistro(correoDestino);
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

<<<<<<< HEAD
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
            SmtpClient smtp = new SmtpClient("smpt.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true; // True si el servidor de correo permite SSL
            smtp.Credentials = new NetworkCredential("cinnityapp@gmail.com", "caeiyxiguufehhke"); // Cuenta de correo de envío


            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };

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

=======
        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {

        }
>>>>>>> 5a6b66dd5d840c6aa520331b3f5f7ed25c20b44c
    }
}

