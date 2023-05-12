using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cinnity.Clases
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
                        string database = "database=Cinnity;";
                        string usuario = "uid=root;";
                        string password = "pwd=;";
                        string convert = "Convert Zero DateTime=True;";
                        instancia.ConnectionString = server + database + usuario + password + convert;
                    }
                    return instancia;
                }
            }
        }

        internal Entradas Entradas
        {
            get => default;
            set
            {
            }
        }

        internal Pelicula Pelicula
        {
            get => default;
            set
            {
            }
        }

        internal Usuario Usuario
        {
            get => default;
            set
            {
            }
        }

        public static void AbrirConexion()
        {
            if (instancia != null)
                instancia.Open();
        }
        public static void CerrarConexion()
        {
            if (instancia != null)
                instancia.Close();
        }

    }
}

