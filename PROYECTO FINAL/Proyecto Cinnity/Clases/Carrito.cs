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

        /// <summary>
        /// Método para añadir al carrito una lista de entradas.
        /// </summary>
        /// <param name="titulo">Título de la película.</param>
        /// <param name="pre">Precio según la sesión de la película.</param>
        /// <param name="fecha">Fecha escogida sobre película.</param>
        /// <param name="horaE">Hora de emisión sobre película.</param>
        /// <param name="fechaE">Fecha de emisión sobre película</param>
        public static void AñadirAlCarrito(string titulo, double pre, DateTime fecha, string horaE, DateTime fechaE)
        {
            Entradas ent = new Entradas(titulo, pre, fecha, horaE, fechaE);
            listaCarrito.Add(ent);
        }

        /// <summary>
        /// Método para vaciar las entradas del carrito.
        /// </summary>
        public static void VaciarCarrito()
        {
            listaCarrito.Clear();
        }

        /// <summary>
        /// Método para saber las entradas totales en el carrito.
        /// </summary>
        /// <returns>Devuelve el número de entradas en el carrito.</returns>
        public static int TotalEntradas()
        {
            int total = listaCarrito.Count;
            return total;
        }

        /// <summary>
        /// Método para saber el precio total de las entradas en el carrito.
        /// </summary>
        /// <returns>Devuelve el precio total de las entradas.</returns>
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
