using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReqMateriaisRmTotvs.Models
{
    public class CentroCusto 
    {

        public void Consultar( )
        {

            var consulta = new Consulta();
            var retorno = consulta.AutenticaAcessoAuth("Mestre", "totvs");
            Console.WriteLine(retorno);
        }
    }
}