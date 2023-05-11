using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cinnity
{
    class Entradas
    {
        private double precio;
        private DateTime fechaCompra;
        private Usuario usuarioAsociado;
        private Cartelera carteleraAsociada;

        public Entradas (double pre, DateTime fecha, Usuario usu, Cartelera carte)
        {
            precio = pre;
            fechaCompra = fecha;
            usuarioAsociado = usu;
            carteleraAsociada = carte;
        }
    }
}
