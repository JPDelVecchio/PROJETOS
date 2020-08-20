using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_basico.Modelos
{
    class Item
    {
        public int Idmovimento { get; set; }
        public string ItemNf { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
        public String Unidade { get; set; }
        public Double Total { get; set; }

        //public Item()
        //{
        //    Total = Quantidade * Valor;
        //}

        public void IncluirItem()
        {

        }
        public void EncluirItem()
        {

        }
        public void AlterarItem()
        {

        }
    }
}
