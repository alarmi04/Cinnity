using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Cinnity
{
    class Entradas
    {
        private string titulo;
         private double precio;
         private DateTime fechaCompra;
         private string horaEmision;
         private DateTime fechaEmision;

         public double Precio { get { return precio; } }
         public DateTime FechaCompra { get { return fechaCompra; } }
         public string HoraEmision { get { return horaEmision; } }
         public DateTime FechaEmision { get { return fechaEmision; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }

         public Entradas(string titulo, double pre, DateTime fecha, string horaE, DateTime fechaE)
         {

            this.titulo = titulo;
             precio = pre;
             fechaCompra = fecha;
             horaEmision = horaE;
             fechaEmision = fechaE;
         }

        public Entradas(double pre, DateTime fecha, string horaE, DateTime fechaE)
        {            
            precio = pre;
            fechaCompra = fecha;
            horaEmision = horaE;
            fechaEmision = fechaE;
        }

        public Entradas() { }

        /// <summary>
        /// Método para generar la entrada en la base de datos.
        /// </summary>
        /// <param name="lista">Lista de las entradas a introducir en la base de datos.</param>
        public static void GenerarEntrada(List<Entradas> lista)
        {
            int idUsu = Usuario.RecogerID();

            foreach (Entradas ent in lista)
            {
                int retorno;
                int idPeli = Pelicula.RecogerID(ent.titulo);

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = ConexionBD.Conexion;
                    cmd.CommandText = "INSERT INTO  Entradas (precio, fecha_emision, hora_emision, fecha_compra, peliID, idUsuario) " +
                        "VALUES (@precio, @fechaEmi, @horaEmi, @fechaCompra,@idPeli,@idUsu);";

                    cmd.Parameters.AddWithValue("@precio", ent.precio);
                    cmd.Parameters.AddWithValue("@fechaEmi", ent.fechaEmision);
                    cmd.Parameters.AddWithValue("@horaEmi", ent.horaEmision);
                    cmd.Parameters.AddWithValue("@fechaCompra", ent.FechaCompra);
                    cmd.Parameters.AddWithValue("@idPeli", idPeli);
                    cmd.Parameters.AddWithValue("@idUsu", idUsu);

                    retorno = cmd.ExecuteNonQuery();
                }
            }

        }


        /// <summary>
        /// Método para devolver una entrada.
        /// </summary>
        /// <param name="titulo">Titulo de la pelicula a la que pertenece la entrada.</param>
        /// <returns>Devuelve 0 o 1</returns>
        public static int DevolverEntrada(string titulo)

        {
            int retorno;
            string consulta = string.Format("DELETE FROM Entradas WHERE peliID IN (SELECT idPelicula FROM Pelicula WHERE nombrePeli=@titulo);");
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("titulo", titulo);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        /// <summary>
        /// Método para comprobar si hay una entrada de una película. 
        /// </summary>
        /// <param name="titulo">Título de la película</param>
        /// <returns>Devuelve si existe la entrada o no.</returns>
        public static bool ComprobarEntrada(string titulo)
        {
            string consulta = string.Format("SELECT * FROM Entradas WHERE peliID IN (SELECT idPelicula FROM Pelicula WHERE nombrePeli=@titulo);");
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("titulo", titulo);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }


        /// <summary>
        /// Método que busca la entrada por el título de la película.
        /// </summary>
        /// <param name="titulo">Título de la película</param>
        /// <returns>Devuelve una lista de entradas.</returns>
        public static List<Entradas> BuscarEntrada(string titulo)
        {
            int idUser = Usuario.RecogerID();
            List<Entradas> lista = new List<Entradas>();
            string consulta = String.Format("SELECT e.*, p.nombrePeli AS titulo FROM Entradas e INNER JOIN Pelicula p ON e.peliID = p.idPelicula WHERE e.idUsuario=@idUser AND e.fecha_emision > DATE(NOW()) AND p.nombrePeli=@titulo;");
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("idUser", idUser);
            comando.Parameters.AddWithValue("titulo", titulo);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)   
            {
                while (reader.Read())
                {
                    Entradas entrada = new Entradas(reader.GetString("titulo"), reader.GetDouble("precio"), reader.GetDateTime("fecha_compra"), reader.GetString("hora_emision"),
                        reader.GetDateTime("fecha_emision"));
                    lista.Add(entrada);
                }
            }
            return lista;
        }

        /// <summary>
        /// Método para ver las entradas activas que tiene un usuario.
        /// </summary>
        /// <returns>Devuelve la lista de entradas activas.</returns>
        public static List<Entradas> EntradasActivas()
         {
             int idUser = Usuario.RecogerID();
             List<Entradas> listaActivas = new List<Entradas>();
            
             if (idUser != -1)
             {
                 string consulta = "SELECT p.nombrePeli AS titulo, e.* FROM Entradas e INNER JOIN Pelicula p ON e.peliID = p.idPelicula WHERE e.idUsuario = '" + idUser + "' AND e.fecha_emision >= DATE(NOW());";
                 MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                 MySqlDataReader reader = comando.ExecuteReader();

                 if (reader.HasRows)
                 {

                     while (reader.Read())
                     {
                         Entradas ent = new Entradas(reader.GetString("titulo"),reader.GetDouble("precio"), reader.GetDateTime("fecha_compra"), reader.GetString("hora_emision"), reader.GetDateTime("fecha_emision"));
                         listaActivas.Add(ent);
                     }
                 }
                 reader.Close();
             }

             return listaActivas;
         }


        /// <summary>
        /// Método para visualizar la lista de entradas adquiridas por el usuario.
        /// </summary>
        /// <param name="idUser">Id del usuario.</param>
        /// <returns>Devuelve la lista de entradas adquiridas.</returns>
        public static List<Entradas> EntradasAdquiridas(int idUser)
        {
            List<Entradas> listaAdquiridas = new List<Entradas>();

            if (idUser != -1)
            {
                string consulta = "SELECT p.nombrePeli AS titulo, e.* FROM Entradas e INNER JOIN Pelicula p ON e.peliID = p.idPelicula WHERE e.idUsuario = '" + idUser + "';";
                MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Entradas ent = new Entradas(reader.GetString("titulo"), reader.GetDouble("precio"), reader.GetDateTime("fecha_compra"), reader.GetString("hora_emision"), reader.GetDateTime("fecha_emision"));
                        listaAdquiridas.Add(ent);
                    }
                }
                reader.Close();
            }

            return listaAdquiridas;
        }
    }
}
