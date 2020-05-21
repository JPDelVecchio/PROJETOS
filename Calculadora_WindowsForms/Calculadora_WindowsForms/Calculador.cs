using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_WindowsForms
{
    class Calculador
    {
        public static double Digito { get; set; } 
        public static double UltimoDigito { get; set; }

        public static void InsereDigito(double btn)
        {
            Digito += btn;
            UltimoDigito = btn;
        }

        internal static double RetornaDigitos()
        {
            var numero = Digito;
            Digito = 0;
            return numero; 
        }
        public static void ExcluirUltimoDigito()
        {

        }
    }
}
