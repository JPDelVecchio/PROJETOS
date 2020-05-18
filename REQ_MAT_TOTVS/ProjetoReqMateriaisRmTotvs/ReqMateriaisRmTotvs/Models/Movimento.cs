using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReqMateriaisRmTotvs.Models
{
    public class Movimento
    {
        public String Usuario { get; set; } 
        public int Coligada { get; set; }
        public int Filial { get; set; }
        public String Data { get; set; }
        public Item Dtens { get; set; }
        public String CentroCusto { get; set; }
        public String HistoricoCurto { get; set; }

        public Movimento()
        {
            this.Data = DateTime.Now.ToString("d");
            this.Usuario = "jlima"; // (String) new Usuario().usuario;

        }
    }
}