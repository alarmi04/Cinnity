using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Cinnity.RecursosLocalizables;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace Proyecto_Cinnity
{
    public static class idioma
    {
        private static CultureInfo culturactual = CultureInfo.CurrentCulture;

        public static CultureInfo CulturaActual { get { return culturactual; } set { culturactual = value; } }
    }
}
