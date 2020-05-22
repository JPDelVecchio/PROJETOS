using CRUD_Basico.Dados;
using CRUD_Basico.Formularios;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CRUD_Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            Form principal = new CadCliFor(); //Principal();

            principal.ShowDialog();

            principal.Close();


            using (var contexto = new MovimentacaoContext())
            {
                foreach (var clifor in contexto.ClientesFornecedores)
                {
                    System.Console.WriteLine(clifor.Nome);
                }
                Console.ReadLine();
            }
        }
         
    }
}
