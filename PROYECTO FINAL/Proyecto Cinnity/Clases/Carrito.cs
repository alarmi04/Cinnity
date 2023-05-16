using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cinnity
{
    static class Carrito
    {
        public static List<Entradas> listaCarrito = new List<Entradas>();

        public static void AñadirAlCarrito(string titulo, double pre, DateTime fecha, string horaE, DateTime fechaE)
        {
            Entradas ent = new Entradas(titulo, pre, fecha, horaE, fechaE);
            listaCarrito.Add(ent);
        }

        public static void EliminarDelCarrito(int indice)
        {
            listaCarrito.RemoveAt(indice);
        }

        public static int TotalEntradas()
        {
            int total = listaCarrito.Count;
            return total;
        }

        public static double PrecioTotal()
        {
            double total = 0;

            foreach (Entradas ent in listaCarrito)
            {
                total += ent.Precio;
            }

            return total;
        }

    }
}
