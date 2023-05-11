using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cinnity
{
    class Usuario
    {
        private string nombre;
        private string apellidos;
        private string correo;
        private string contrasenya;
        private string pais;
        private DateTime fechaNaci;

        public Usuario(string nom, string ape, string corr, string clave, string pa, DateTime fecha)
        {
            nombre = nom;
            apellidos = ape;
            correo = corr;
            contrasenya = clave;
            pais = pa;
            fechaNaci = fecha;
        }
    }
}
