using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cinnity
{
    class Pelicula
    {
        private string nombre;
        private string genero;
        private string director;
        private string reparto;
        private int duracionMinutos;
        private string sinopsis;
        private DateTime fechaEstreno;
        private Image caratula;
        private Cartelera carteleraAsociada;


        public Pelicula(string nom, string gene, string direc, string repar, int dura, string sinop, DateTime estreno, Image carat, Cartelera cartel)
        {
            nombre = nom;
            genero = gene;
            director = direc;
            reparto = repar;
            duracionMinutos = dura;
            sinopsis = sinop;
            fechaEstreno = estreno;
            caratula = carat;
            carteleraAsociada = cartel;
        }
    }

}
