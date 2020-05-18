using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWStestes
{
    class Program
    {
        static void Main(string[] args)
        {
            var cons = new Consulta();
            
            String retorno = cons.ConsultarUsuario();

            Console.WriteLine(retorno);

            Console.WriteLine("outra consulta de produtos \\n");

            cons.Produtos();
        }
    }
}
