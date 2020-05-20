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
        public string ConsultarUsuario()
        {
            var ret = new WSConsulta.wsConsultaSQLSoapClient();

            if (ret.AutenticaAcessoAuth("Mestre", "totvs") == "1")
            {
                return "Existe";
            }
            else
            {
                return "Falso";
            }
        }
        public void Produtos(string parametro)
        {
            var ret = new wsConsultaSQLSoapClient();
            var xml = new XmlDocument();
            xml.Load(new StringReader(ret.RealizarConsultaSQLAuth("TESTEJOAO", 1, "T", "Mestre", "totvs", ($"P={parametro.Trim()}"))));
            Console.WriteLine($"Parametro: {parametro}");
            XmlNode raiz = xml.FirstChild;

            if (raiz.HasChildNodes)
            {
                for (int i = 0; i < raiz.ChildNodes.Count; i++)
                { 
                    Console.WriteLine(raiz.ChildNodes[i].InnerText);
                }
            }


            /*
             Modelo de busca dos dados com o titulo 
            */
            //xml.LoadXml("<book ISBN='1-861001-57-5'>" +
            //            "<title>Pride And Prejudice</title>" +
            //            "<price>19.95</price>" +
            //            "</book>");

            //XmlNode raiz = xml.FirstChild;
            //Console.WriteLine("Display...");
            //Console.WriteLine(raiz["title"].OuterXml);


            Console.ReadKey();
        }
    } 
    }


