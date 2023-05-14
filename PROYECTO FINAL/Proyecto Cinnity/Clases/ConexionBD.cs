using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cinnity
{
    class ConexionBD
    {
        private static MySqlConnection instancia = null;
        private static readonly object padlock = new object();

        private ConexionBD() { }

        public static MySqlConnection Conexion
        {
            get
            {
                lock (padlock)
                {
                    if (instancia == null)
                    {
                        instancia = new MySqlConnection();
                        string server = "server=127.0.0.1;";
                        string port = "port=3306;";
                        string database = "database=Cinnity;";
                        string usuario = "uid=root;";
                        string password = "pwd=;";
                        string convert = "Convert Zero Datetime=True;";
                        instancia.ConnectionString = server + port + database + usuario + password + convert;
                    }
                    return instancia;
                }
            }
        }

        /// <summary>
        /// Función que permite abrir una conexión con la base de datos
        /// </summary>
        public static void AbrirConexion()
        {
            if (instancia != null) instancia.Open();
        }

        /// <summary>
        /// Función que cierra una conexión abierta de la base de datos
        /// </summary>
        public static void CerrarConexion()
        {
            if (instancia != null) instancia.Close();
        }
    }
}
