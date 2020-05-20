using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_basico.Modelos
{
    class Fornecedor
    {
        public String Nome { get; set; }
        public String Cnpj { get; set; }
        public String Endereco { get; set; } 

        public Fornecedor()
        {

        }
        public String AdicionarFornecedor(Fornecedor fornecedor)
        {

            return $"";
        }

        public IList<Fornecedor> BaseFornecedor(Fornecedor fornecedor)
        {
            IList<Fornecedor> baseFor = new IList<Fornecedor>(); 

            retunr basefor;
        }
    }
}
