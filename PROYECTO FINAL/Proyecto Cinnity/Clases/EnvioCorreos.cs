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
    static class EnvioCorreos
    {
        private const string CorreoEnvio = "cinnityapp@gmail.com";
        private const string ContraseñaEnvio = "akhwplovsjvdttsm";

        public static void EnviarCorreoRegistro(string correoDestino)
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress(CorreoEnvio, "Cinnity", System.Text.Encoding.UTF8); // Correo de salida
            correo.To.Add(correoDestino); // Correo destino
            correo.Subject = "Gracias por tu registro"; // Asunto del correo
            string Body = "¡Bienvenido a Cinnity! Tu lugar ideal para ver el cine de una manera diferente." +
                "<br><br>Es bueno que nos hayas elegido, porque somos tu mejor APP para adquirir entradas de cine."; // Mensaje del correo con HTML y demas
            correo.Body = Body;
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true; // True si el servidor de correo permite SSL
            smtp.Credentials = new NetworkCredential(CorreoEnvio, ContraseñaEnvio); // Cuenta de correo de envío

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

        public static void EnviarCorreoCompra(string correoDestino)
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress(CorreoEnvio, "Cinnity", System.Text.Encoding.UTF8); // Correo de salida
            correo.To.Add(correoDestino); // Correo destino
            correo.Subject = "Gracias por tu compra"; // Asunto del correo
            string Body = "¡Gracias por tu compra, recuerda que puedes consultar tus entradas en nuestra aplicación." +
                "<br><br>Que disfrutes de tu película."; // Mensaje del correo con HTML y demas
            correo.Body = Body;
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true; // True si el servidor de correo permite SSL
            smtp.Credentials = new NetworkCredential(CorreoEnvio, ContraseñaEnvio); // Cuenta de correo de envío

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

        public static void EnviarCorreoCambioContra(string correoDestino)
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress(CorreoEnvio, "Cinnity", System.Text.Encoding.UTF8); // Correo de salida
            correo.To.Add(correoDestino); // Correo destino
            correo.Subject = "Contraseña Actualizada"; // Asunto del correo
            string Body = "Tu contraseña ha sido cambiada correctamente, recuerda que si no has sido tú quien ha realizado estos cambios" +
                "ponte en contacto con nosotros si crees que la seguridad de tu cuenta ha sido vulnerada."; // Mensaje del correo con HTML y demas
            correo.Body = Body;
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true; // True si el servidor de correo permite SSL
            smtp.Credentials = new NetworkCredential(CorreoEnvio, ContraseñaEnvio); // Cuenta de correo de envío

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
    }
}
