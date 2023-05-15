using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cinnity.Clases
{
    class Carrito
    {
        private Usuario usuAsociado;
        private List<Entradas> listaEntradas;
        
        public Carrito(Usuario usu)
        {
            usuAsociado = usu;
<<<<<<< HEAD
            List<Entradas> lista = new List<Entradas>();
=======
            listaEntradas= new List<Entradas>();
>>>>>>> 7c0184c2bc2894d6804263fcb157e4370bb185ff
        }

        //Agregar Entrada
        public void AnyadirEntrada(Entradas entrada)
        {
            listaEntradas.Add(entrada);
        }

        //Eliminar entrada
        public void EliminarEntrada(Entradas entrada)
        {
            foreach (Entradas ent in listaEntradas)
            {
<<<<<<< HEAD
                
=======
                //if ()
                {

                }
>>>>>>> 7c0184c2bc2894d6804263fcb157e4370bb185ff
            }
        }
    }
}
