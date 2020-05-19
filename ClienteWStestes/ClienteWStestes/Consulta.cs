using ClienteWStestes.WSConsulta;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClienteWStestes
{
    public class Consulta 
    {
        String Produto { get; set; }
        public string ConsultarUsuario() { 
        var ret = new  WSConsulta.wsConsultaSQLSoapClient();
  
            if (ret.AutenticaAcessoAuth("Mestre", "totvs") == "1"){
                return "Existe";
                    }
            else{
                return "Falso";
                }
            }
        public void Produtos()
        {
            var ret = new wsConsultaSQLSoapClient();
            var retorno  = ret.RealizarConsultaSQLAuth("TESTEJOAO",1,"T","Mestre","totvs", "1");
            Console.WriteLine(retorno);

            using(StringReader leitor = new StringReader(retorno))
            {
               var leitorXML = new XmlTextReader(leitor);
             
                    while(leitorXML.Read())
                    { 
                        Console.WriteLine( leitorXML.Value); 
                    }
                    
			
            }
            
            }


        }
    }

