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
            Form principal = new Principal();  

            principal.ShowDialog();

            principal.Close();
        }
         
    }
}
