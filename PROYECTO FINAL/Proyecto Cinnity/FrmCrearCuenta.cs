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

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
            RellenarIdiomas();
            AplicarIdioma();
        }
        private void AplicarIdioma()
        {
            txtNombre.Text = StringRecursos.nombrecuenta;
            txtCorreo.Text = StringRecursos.correoelectronico;
            txtApellidos.Text = StringRecursos.apellidoscuenta;
            txtConfirmarCorreo.Text = StringRecursos.confcorreo;
            cmbPais.Text = StringRecursos.pais;
            txtContra.Text = StringRecursos.contrasenya;
            txtConfirmarContra.Text = StringRecursos.confcontrasenyacuenta;
            chbMostrarContra.Text = StringRecursos.mostrarContra;
            btnCrearCuenta.Text = StringRecursos.crearcuenta;
            this.Text = StringRecursos.TituloVentanaCrearCuenta;
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
        }

        private void RellenarIdiomas()
        {
            string[] paises = { "Afganistán", "Albania",

  "Alemania",

  "Andorra",

  "Angola",

  "Antigua y Barbuda",

  "Arabia Saudita",

  "Argelia",

  "Argentina",

  "Armenia",

  "Australia",

  "Austria",

  "Azerbaiyán",

  "Bahamas",

  "Bangladés",

  "Barbados",

  "Baréin",

  "Bélgica",

  "Belice",

  "Benín",

  "Bielorrusia",

  "Birmania",

  "Bolivia",

  "Bosnia y Herzegovina",

  "Botsuana",

  "Brasil",

  "Brunéi",

  "Bulgaria",

  "Burkina Faso",

  "Burundi",

  "Bután",

  "Cabo Verde",

  "Camboya",

  "Camerún",

  "Canadá",

  "Catar",

  "Chad",

  "Chile",

  "China",

  "Chipre",

  "Ciudad del Vaticano",

  "Colombia",

  "Comoras",

  "Corea del Norte",

  "Corea del Sur",

  "Costa de Marfil",

  "Costa Rica",

  "Croacia",

  "Cuba",

  "Dinamarca",

  "Dominica",

  "Ecuador",

  "Egipto",

  "El Salvador",

  "Emiratos Árabes Unidos",

  "Eritrea",

  "Eslovaquia",

  "Eslovenia",

  "España",

  "Estados Unidos",

  "Estonia",

  "Etiopía",

  "Filipinas",

  "Finlandia",

  "Fiyi",

  "Francia",

  "Gabón",

  "Gambia",

  "Georgia",

  "Ghana",

  "Granada",

  "Grecia",

  "Guatemala",

  "Guyana",

  "Guinea",

  "Guinea-Bisáu",

  "Guinea Ecuatorial",

  "Haití",

  "Honduras",

  "Hungría",

  "India",

  "Indonesia",

  "Irak",

  "Irán",

  "Irlanda",

  "Islandia",

  "Israel",

  "Italia",

  "Jamaica",

  "Japón",

  "Jordania",

  "Kazajistán",

  "Kenia",

  "Kirguistán",

  "Kiribati",

  "Kuwait",

  "Laos",

  "Lesoto",

  "Letonia",

  "Líbano",

  "Liberia",

  "Libia",

  "Liechtenstein",

  "Lituania",

  "Luxemburgo",

  "Madagascar",

  "Malasia",

  "Malaui",

  "Maldivas",

  "Malí",

  "Malta",

  "Marruecos",

  "Islas Marshall",

  "Mauricio",

  "Mauritania",

  "México",

  "Micronesia",

  "Moldavia",

  "Mónaco",

  "Mongolia",

  "Montenegro",

  "Mozambique",

  "Namibia",

  "Nauru",

  "Nepal",

  "Nicaragua",

  "Níger",

  "Nigeria",

  "Noruega",

  "Nueva Zelanda",

  "Omán",

  "Países Bajos",

  "Pakistán",

  "Palaos",

  "Panamá",

  "Papúa Nueva Guinea",

  "Paraguay",

  "Perú",

  "Polonia",

  "Portugal",

  "Reino Unido",

  "República Centroafricana",

  "República Checa",

  "República del Congo",

  "República Democrática del Congo",

  "República Dominicana",

  "República Sudafricana",

  "Ruanda",

  "Rumania",

  "Rusia",

  "Samoa",

  "San Cristóbal y Nieves",

  "San Marino",

  "San Vicente y las Granadinas",

  "Santa Lucía",

  "Santo Tomé y Príncipe",

  "Senegal",

  "Serbia",

  "Seychelles",

  "Sierra Leona",

  "Singapur",

  "Siria",

  "Somalia",

  "Sri Lanka",

  "Suazilandia",

  "Sudán",

  "Sudán del Sur",

  "Suecia",

  "Suiza",

  "Surinam",

  "Tailandia",

  "Tanzania",

  "Tayikistán",

  "Timor Oriental",

  "Togo",

  "Tonga",

  "Trinidad y Tobago",

  "Túnez",

  "Turkmenistán",

  "Turquía",

  "Tuvalu",

  "Ucrania",

  "Uganda",

  "Uruguay",

  "Uzbekistán",

  "Vanuatu",

  "Venezuela",

  "Vietnam",

  "Yemen",

  "Yibuti",

  "Zambia",

  "Zimbabue"

            };

            cmbPais.Items.Clear();

            cmbPais.Items.AddRange(paises);
        }

        private bool DatosValidos()
        {
            bool ok = true;

            errorCrearCuenta.Clear();

            if (txtNombre.Text == "" || txtNombre.Text == StringRecursos.nombrecuenta)
            {
                ok = false;
                errorCrearCuenta.SetError(txtNombre, "Enter your name");
            }

            if (txtContra.Text == "" || txtContra.Text == StringRecursos.contrasenya)
            {
                ok = false;
                errorCrearCuenta.SetError(txtContra, "Enter your password");
            }


            if (txtApellidos.Text == "" || txtApellidos.Text == StringRecursos.apellidoscuenta)
            {
                ok = false;
                errorCrearCuenta.SetError(txtApellidos, "Enter your last name");
            }

            if (cmbPais.Text == "" || cmbPais.Text == StringRecursos.pais)
            {
                ok = false;
                errorCrearCuenta.SetError(cmbPais, "Enter country");
            }
            if (txtCorreo.Text == "" || txtCorreo.Text == StringRecursos.correoelectronico)
            {
                ok = false;
                errorCrearCuenta.SetError(txtCorreo, "Enter your e-mail");
            }


            if (dtpFechaNacimiento.Value == DateTime.Today || dtpFechaNacimiento.Value > DateTime.Today)
            {
                ok = false;
                errorCrearCuenta.SetError(dtpFechaNacimiento, "Enter a valid date");
            }

            

            if (txtCorreo.Text != txtConfirmarCorreo.Text)
            {
                ok = false;
                errorCrearCuenta.SetError(txtConfirmarCorreo, "e-mails don't match");
            }

            if (txtContra.Text == "")
            {
                ok = false;
                errorCrearCuenta.SetError(txtContra, "Enter password");
            }

            if (txtContra.Text != txtConfirmarContra.Text)
            {
                ok = false;
                errorCrearCuenta.SetError(txtConfirmarContra, "Passwords don't match");
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
                                if (!Usuario.ValidarCuenta(txtCorreo.Text))
                                {
                                    Usuario.RegistrarUsuario(txtNombre.Text, txtApellidos.Text, txtConfirmarCorreo.Text, txtConfirmarContra.Text, cmbPais.Text, dtpFechaNacimiento.Value);
                                    string correoDestino = txtConfirmarCorreo.Text; // Dirección de correo del usuario
                                    EnvioCorreos.EnviarCorreoRegistro(correoDestino);
                                    ConexionBD.CerrarConexion();

                                    this.Close();
                                } else
                            {
                                MessageBox.Show("It is not possible to create an account with an email already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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

        
    }
}


