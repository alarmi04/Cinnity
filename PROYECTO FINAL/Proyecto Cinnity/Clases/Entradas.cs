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
        private DateTime horaEmision;
        private DateTime fechaEmision;

        public Usuario Usuario { get; set; }

        public Entradas (double pre, DateTime fecha, Usuario usu, DateTime horaE, DateTime fechaE)
        {
            precio = pre;
            fechaCompra = fecha;
            usuarioAsociado = usu;
        }

        //BuscarEntrada ()



    }
}
