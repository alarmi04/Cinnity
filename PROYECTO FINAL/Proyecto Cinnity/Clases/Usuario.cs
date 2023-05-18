using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using Mysqlx.Connection;

namespace Proyecto_Cinnity
{
    
    static class Usuario
    {
        public static string nombre;
        public static string apellidos;
        public static string correo;
        public static string contrasenya;
        public static string pais;
        public static Image imagenSeleccionada = Properties.Resources.perfil;
        public static DateTime fechaNaci;

        public static bool InicioSesionCorrecto(string correo, string contraseña)

        {

            bool correcto = false;

            string consulta = "SELECT * FROM Usuario WHERE correoElectronico LIKE '" + correo + "' && contrasenya LIKE '" + contraseña + "';";

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                correcto = true;
                while (reader.Read())
                {
                    Usuario.nombre = reader.GetString("nombre");
                    Usuario.apellidos = reader.GetString("apellidos");
                    Usuario.correo = reader.GetString("correoElectronico");
                    Usuario.contrasenya = reader.GetString("contrasenya");
                    Usuario.pais = reader.GetString("pais");
                    Usuario.fechaNaci = reader.GetDateTime("fechaNaci");
                }
            }

            return correcto;

        }


        public static int RegistrarUsuario(string nombre, string apellidos, string correo, string contrasenya, string pais, DateTime fechaNaci)
        {
            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "INSERT INTO Usuario (nombre, apellidos, correoElectronico, contrasenya, pais, fechaNaci) " +
                    "VALUES (@nombre, @apellidos, @correo, @clave,@pais,@fecha);";

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellidos", apellidos);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@clave", contrasenya);
                cmd.Parameters.AddWithValue("@pais", pais);
                cmd.Parameters.AddWithValue("@fecha", fechaNaci);

                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }

        public static int RecogerID()
        {
            string consulta = "SELECT id from Usuario WHERE nombre='" + nombre + "' AND correoElectronico = '" + correo + "';";
            int id = -1;
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            reader.Close();
            return id;

        }

        public static bool ClaveValidada(string clave1, string clave2)
        {
            return clave1 == clave2;
        }

        public static bool CorreoValidado(string correo1, string correo2)
        {
            return correo1 == correo2;
        }

        public static int CambiarContraseña(string contraNueva, string contraVieja, string correo)
        {
            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "UPDATE Usuario SET contrasenya=@contraNueva WHERE correoElectronico=@correo AND contrasenya=@contraVieja;";

                cmd.Parameters.AddWithValue("@contraNueva", contraNueva);
                cmd.Parameters.AddWithValue("@contraVieja", contraVieja);
                cmd.Parameters.AddWithValue("@correo", correo);

                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }

        public static int CambiarDatos(string nuevoNombre, string nuevoCorreo, string nuevosApellidos)
        {
            int retorno;

            string nombreV = Usuario.nombre;
            string correoV = Usuario.correo;
            string apellidoV = Usuario.apellidos;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "UPDATE Usuario SET nombre=@nuevoNom, correoElectronico=@nuevoCorr, apellidos=@nuevosApe WHERE nombre=@viejoNom AND correoElectronico=@viejoCorr AND apellidos=@viejosApe;";

                cmd.Parameters.AddWithValue("@nuevoNom", nuevoNombre);
                cmd.Parameters.AddWithValue("@nuevoCorr", nuevoCorreo);
                cmd.Parameters.AddWithValue("@nuevosApe", nuevosApellidos);
                cmd.Parameters.AddWithValue("@viejoNom", nombreV);
                cmd.Parameters.AddWithValue("@viejoCorr", correoV);
                cmd.Parameters.AddWithValue("@viejosApe", apellidoV);


                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }


    }

}

