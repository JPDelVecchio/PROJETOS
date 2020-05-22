using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_basico.Modelos
{
    class Produto
    {
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public String Unidade { get; set; }
        
        public String IncluirProduto()
        {

            return "";
        }
        public String ExcluirProduto()
        {

            return "";
        }

        public List<Produto> AlterarProduto()
        {
            var lista = new List<Produto>();

            return lista;
        }


    }
}
