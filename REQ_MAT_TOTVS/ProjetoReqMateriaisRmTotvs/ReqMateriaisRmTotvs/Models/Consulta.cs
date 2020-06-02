using ReqMateriaisRmTotvs.WSConsultar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReqMateriaisRmTotvs.Models
{
    public class Consulta : wsConsultaSQLSoapClient
    {
        public new string AutenticaAcessoAuth(string Usuario, string Senha)
        {
            
            return base.Channel.AutenticaAcessoAuth(Usuario, Senha);
        }

        
    }
}