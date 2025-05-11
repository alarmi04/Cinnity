using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cinnity
{
    static class ConexionBD
    {
        private static MySqlConnection instancia = null;
        private static readonly object padlock = new object();


        public static MySqlConnection Conexion
        {
            get
            {
                lock (padlock)
                {
                    if (instancia == null)
                    {
                        instancia = new MySqlConnection();
                        /// Cuando teniamos avierto el módulo en AWS string server = "server=cinnityapp.caruzqlq1py9.us-east-1.rds.amazonaws.com;";
                        string server = "server=localhost;";
                        string port = "port=3306;";
                        string database = "database=cinnity;";
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
        /// Función que permite abrir una conexión con la base de datos.
        /// </summary>
        public static void AbrirConexion()
        {
            if (instancia != null) instancia.Open();
        }

        /// <summary>
        /// Función que cierra una conexión abierta de la base de datos.
        /// </summary>
        public static void CerrarConexion()
        {
            if (instancia != null) instancia.Close();
        }
    }
}
