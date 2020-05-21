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
        public String Visor { get; set; }
        private static Double Valor1 { get; set; }
        public Double Valor2 { get; set; }
        public String Operacao { get; set; }
        public String Digito { get; set; }


        public double Somar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }
        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
        public void DeletarUltimoNumero()
        {

        }
        public static string ApagarTudo()
        {
            Form1.Pilha.Clear();
            return "";

        }
        public static string AtualizarVisor()
        {
            String visor = "";
            var fila = new Stack<String>();
            foreach (var item in Form1.Pilha)
            {
                fila.Push(item); 
            }
            foreach (var item in fila)
            {
                visor += item; ;
            }

            return visor;
        }
        public static void Verificaigito(String btn)
        {
            if (btn.ToString() != "+")
            {
                Form1.Pilha.Push(btn.ToString());
            }
            else
            {
                Valor1 = Convert.ToDouble(AtualizarVisor());
                Form1.Pilha.Push(btn.ToString());
            }

            //MessageBox.Show(Valor1.ToString());
        } 
    }
}
