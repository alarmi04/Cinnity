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

        public Usuario Usuario { get { return usuarioAsociado; } }
        public double Precio { get { return precio; } }
        public DateTime FechaCompra { get { return fechaCompra; } }
        public DateTime HoraEmision { get { return horaEmision; } }
        public DateTime FechaEmision { get { return fechaEmision; } }


        public Entradas (double pre, DateTime fecha, Usuario usu, DateTime horaE, DateTime fechaE)
        {
            precio = pre;
            fechaCompra = fecha;
            usuarioAsociado = usu;
        }

        //BuscarEntrada ()



    }
}
