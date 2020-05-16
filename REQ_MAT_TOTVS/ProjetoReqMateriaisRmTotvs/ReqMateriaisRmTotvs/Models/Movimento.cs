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
        public Usuario usuario { get; set; } 
        public String data { get; set; }
        public Item itens { get; set; }
        public String CentroCusto { get; set; }

        public Movimento()
        {
            data = DateTime.Now.ToString("d");
        }
    }
}