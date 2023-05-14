using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cinnity.Clases
{
    static class Carrito
    {
        private Usuario usuAsociado;
        private List<Entradas> listaEntradas;
        
        public Carrito(Usuario usu)
        {
            usuAsociado = usu;
            List<Entradas> = new List<Entradas>();
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
                if ()
                {

                }
            }
        }
    }
}
