using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;

namespace Proyecto_Cinnity
{
    static class Usuario
    {
        static string nombre;
        static string apellidos;
        static string correo;
        static string contrasenya;
        static string pais;
        static DateTime fechaNaci;
        static List<Entradas> entradas;


        public static bool InicioSesionCorrecto(string correo, string contraseña)

        {

            bool correcto = false;

            string consulta = "SELECT * FROM usuario WHERE correoElectronico LIKE '" + correo + "' && contrasenya LIKE '" + contraseña + "';";



            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            MySqlDataReader reader = comando.ExecuteReader();



            if (reader.HasRows)

            {

                correcto = true;

            }





            return correcto;

        }


        public static int RegistrarUsuario(string nombre, string apellidos, string correo, string contrasenya, string pais, string fechaNaci)
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


        public static bool ClaveValidada(string clave1, string clave2)
        {
            return clave1 == clave2;
        }

        public static bool CorreoValidado(string correo1, string correo2)
        {
            return correo1 == correo2;
        }

        public static int CambiarContraseña(string contraNueva)
        {
            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "UPDATE Usuario SET contrasenya={@contraNueva} WHERE contrasenya={@contraVieja};";

                cmd.Parameters.AddWithValue("@contraNueva", contraNueva);
                cmd.Parameters.AddWithValue("@contraVieja", Usuario.contrasenya);

                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }


        //Comprar entrada (agregar una entrada en la lista del usuario tambien a la base de datos)


        //ConsumirEntrada (Eliminar una entrada en la lista y base de datos de entradas la entrada asignada al usuario por ID)


        











      

    }
}
