using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cinnity.Clases
{
    static class Carrito
    {
        static List<Entradas> listaEntradas;

        static void AnyadirEntrada(Entradas entrada)
        {
            listaEntradas.Add(entrada);
        }


        static void EliminarEntrada(Entradas entrada)
        {
            for (int i = 0; i < listaEntradas.Count; i++)
            {
                if (listaEntradas[i].FechaCompra == entrada.FechaCompra && listaEntradas[i].FechaEmision == entrada.FechaEmision && listaEntradas[i].HoraEmision == entrada.HoraEmision && listaEntradas[i].Precio == entrada.Precio)
                {
                    listaEntradas.RemoveAt(i);
                }
            }
        }
    }
}
