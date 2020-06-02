using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_WindowsForms
{
    class Calculador
    {
        public String Visor { get; set; }

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
 
        public static String Calcular()
        {
            string visor = AtualizarVisor();
            visor = (visor.Replace("X", "*").Replace(",","."));
            var resultado = ProcessarCommando(visor);
            return resultado.ToString();
        } 
        private static double ProcessarCommando(string command)
        {
            /*
             * REfenencia de codigo do Macoratti Link:  http://www.macoratti.net/12/10/c_avem.htm
             * 
             */

            //Cria um provedor de Código C#
            CSharpCodeProvider mCodeProvider = new CSharpCodeProvider();
            // Cria os parmaetros para a compilação origem
            CompilerParameters cp = new CompilerParameters();
            cp.GenerateExecutable = false;         //Não precisa criar um arquivo EXE
            cp.GenerateInMemory = true;            //Cria um na memória
            cp.OutputAssembly = "TempModule"; // Isso não é necessário, no entanto, se usado repetidamente, faz com que o CLR 
                                              //não precisa carregar uma novo assembly cada vez que a função é executada.
                                              // A string abaixo é basicamente a casca do programa C #, que não faz nada, mas contém um método Avaliar() 
                                              // para nossos propósitos. 
                                              //Atenção: Isso deixa a aplicação app aberto a ataques de injeção,
                                              //Estou fazendo apenas para demonstração .
            string TempModuleSource = "namespace ns{" +
                                      "using System;" +
                                      "class class1{" +
                                      "public static double Evaluate(){return " + command + ";}}} ";  //Calcula a expressão

            CompilerResults cr = mCodeProvider.CompileAssemblyFromSource(cp, TempModuleSource);
            if (cr.Errors.Count > 0)
            {
                //Se um erro de compilação é gerado, iremoslançar uma exceção
                //A sintaxe estava errado - novamente, isso é deixado ao implementador para verificar sintaxe antes
                //Chamando a função. O código de chamada pode prender isso em um laço try, e notificar o usuário
                //O comando não foi compreendido, por exemplo.
                throw new ArgumentException("A expressão não pode ser avaliada, utiliza uma expressão C# válida...");
            }
            else
            {
                MethodInfo Methinfo = cr.CompiledAssembly.GetType("ns.class1").GetMethod("Evaluate");
                return (double)Methinfo.Invoke(null, null);
            }
        } 
        internal static void AdicionaDigito(string btn)
        {
            Form1.Pilha.Push(btn);
        }
    }
}
