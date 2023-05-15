using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cinnity.Clases
{
    static class Carrito
    {
<<<<<<< HEAD
        private Usuario usuAsociado;
        private List<Entradas> listaEntradas;
        
        public Carrito(Usuario usu)
        {
            usuAsociado = usu;
            listaEntradas= new List<Entradas>();

        }
=======
        static List<Entradas> listaEntradas;
>>>>>>> 5d1339d58beb975a2f34734bb6831ab61536de75

        static void AnyadirEntrada(Entradas entrada)
        {
            listaEntradas.Add(entrada);
        }

<<<<<<< HEAD
        //Eliminar entrada
        public void EliminarEntrada(Entradas entrada)
        {
            foreach (Entradas ent in listaEntradas)
            {

                //if ()
                {
=======
>>>>>>> 5d1339d58beb975a2f34734bb6831ab61536de75

        static void EliminarEntrada(Entradas entrada)
        {
            for (int i = 0; i < listaEntradas.Count; i++)
            {
                if (listaEntradas[i].FechaCompra == entrada.FechaCompra && listaEntradas[i].FechaEmision == entrada.FechaEmision && listaEntradas[i].HoraEmision == entrada.HoraEmision && listaEntradas[i].Precio == entrada.Precio)
                {
                    listaEntradas.RemoveAt(i);
                }
<<<<<<< HEAD

=======
>>>>>>> 5d1339d58beb975a2f34734bb6831ab61536de75
            }
        }
    }
}
