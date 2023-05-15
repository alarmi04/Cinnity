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

        private int id;
        private double precio;
        private DateTime fechaCompra;
        private string horaEmision;
        private DateTime fechaEmision;
        private int cantidad; // Vale por "x" entradas.

        public int ID { get { return id; } }
        public double Precio { get { return precio; } }
        public DateTime FechaCompra { get { return fechaCompra; } }
        public string HoraEmision { get { return horaEmision; } }
        public DateTime FechaEmision { get { return fechaEmision; } }
        public int Cantidad { get { return id; } set { cantidad = value; } }

        public Entradas(int id, double pre, DateTime fecha, string horaE, DateTime fechaE, int cant)
        {
            this.id = id;
            precio = pre;
            fechaCompra = fecha;
            horaEmision = horaE;
            fechaEmision = fechaE;
            cantidad = cant;
        }

        //BuscarEntrada ()
        public static Entradas BuscarEntrada(string consulta)
        {
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                Entradas entrada = new Entradas(reader.GetInt32(0), reader.GetDouble(1), Convert.ToDateTime(reader.GetDateTime(2)),
                        reader.GetString(3), Convert.ToDateTime(reader.GetDateTime(4)), reader.GetInt16(5)
                        );
                return entrada;
            }

            return null;
        }


    }
}
