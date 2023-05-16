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
         private double precio;
         private DateTime fechaCompra;
         private string horaEmision;
         private DateTime fechaEmision;

         public double Precio { get { return precio; } }
         public DateTime FechaCompra { get { return fechaCompra; } }
         public string HoraEmision { get { return horaEmision; } }
         public DateTime FechaEmision { get { return fechaEmision; } }

         public Entradas(int id, double pre, DateTime fecha, string horaE, DateTime fechaE)
         {

             precio = pre;
             fechaCompra = fecha;
             horaEmision = horaE;
             fechaEmision = fechaE;
         }

        public Entradas() { }

        public static int GenerarEntrada(double precio, DateTime fechaCompra, DateTime fechaEmi, string horaEmi, int idPeli, int idUsu)
        {
            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "INSERT INTO  entradas (precio, fecha_emision, hora_emision, fecha_compra, peliID, idUsuario) " +
                    "VALUES (@precio, @fechaEmi, @horaEmi, @fechaCompra,@idPeli,@idUsu);";

                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@fechaEmi", fechaEmi);
                cmd.Parameters.AddWithValue("@horaEmi", horaEmi);
                cmd.Parameters.AddWithValue("@fechaCompra", fechaCompra);
                cmd.Parameters.AddWithValue("@idPeli", idPeli);
                cmd.Parameters.AddWithValue("@idUsu", idUsu);

                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }
        public static Entradas BuscarEntrada(string consulta)
         {
             MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
             MySqlDataReader reader = comando.ExecuteReader();

             if (reader.HasRows)
             {
                 reader.Read();

                 Entradas entrada = new Entradas(reader.GetInt32(0), reader.GetDouble(1), Convert.ToDateTime(reader.GetDateTime(2)),
                       reader.GetString(3), Convert.ToDateTime(reader.GetDateTime(4))
                         );
                 return entrada;
             }

             return null;
         }

         public static List<Entradas> EntradasActivas()
         {
             int idUser = Usuario.RecogerID();
             List<Entradas> listaActivas = new List<Entradas>();

             if (idUser != -1)
             {
                 string consulta = "SELECT * from Entradas WHERE idUsuario = '" + idUser + "' AND fecha_emision > DATE(NOW());";
                 MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                 MySqlDataReader reader = comando.ExecuteReader();

                 if (reader.HasRows)
                 {

                     while (reader.Read())
                     {
                         Entradas ent = new Entradas(reader.GetDouble("precio"), reader.GetDateTime("fecha_compra"), reader.GetDateTime("hora_emision").ToString(), reader.GetDateTime("fecha_emision"));
                         listaActivas.Add(ent);
                     }
                 }
                 reader.Close();
             }

             return listaActivas;
         }
 
    }
}
