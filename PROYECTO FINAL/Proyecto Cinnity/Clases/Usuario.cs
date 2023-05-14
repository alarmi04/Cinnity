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
    class Usuario
    {
        private string nombre;
        private string apellidos;
        private string correo;
        private string contrasenya;
        private string pais;
        private DateTime fechaNaci;
        private List<Entradas> entradas;

        public List<Entradas> Entradas { get { return entradas; } set { entradas }; }

        public Usuario(string nom, string ape, string corr, string clave, string pa, DateTime fecha)
        {
            nombre = nom;
            apellidos = ape;
            correo = corr;
            contrasenya = clave;
            pais = pa;
            fechaNaci = fecha;
        }

        public void IniciarSesion(string usuario, string contraseña)
        {
            List<Usuario> lista = new List<Usuario>();
            string consulta = "SELECT * FROM Usuario WHERE"
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
            }

        public int RegistrarUsuario(Usuario usu)
        {
            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "INSERT INTO Usuario (nombre, apellidos, correoElectronico, contrasenya, pais, fechaNaci) " +
                    "VALUES (@nombre, @apellidos, @correo, @clave,@pais,@fecha);";

                cmd.Parameters.AddWithValue("@nombre", usu.nombre);
                cmd.Parameters.AddWithValue("@apellidos", usu.apellidos);
                cmd.Parameters.AddWithValue("@correo", usu.correo);
                cmd.Parameters.AddWithValue("@clave", usu.contrasenya);
                cmd.Parameters.AddWithValue("@pais", usu.pais);
                cmd.Parameters.AddWithValue("@fecha", usu.fechaNaci);

                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }

        public bool ClaveValidada(string clave1, string clave2)
        {
            return clave1 == clave2;
        }

        public bool CorreoValidado(string correo1, string correo2)
        {
            return correo1 == correo2;
        }

        public int CambiarContraseña(Usuario usu, string contraNueva)
        {
            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "UPDATE Usuario SET contrasenya={@contraNueva} WHERE contrasenya={@contraVieja};";

                cmd.Parameters.AddWithValue("@contraNueva", contraNueva);
                cmd.Parameters.AddWithValue("@contraVieja", usu.contrasenya);

                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }

        //Buscar usuario


        //Comprar entrada (agregar una entrada en la lista del usuario tambien a la base de datos)


        //ConsumirEntrada (Eliminar una entrada en la lista y base de datos de entradas la entrada asignada al usuario por ID)


        











      

    }
}
