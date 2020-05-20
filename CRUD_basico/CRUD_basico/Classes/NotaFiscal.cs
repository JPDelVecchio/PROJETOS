using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_basico.Modelos
{
    class NotaFiscal
    {
        public Fornecedor Fornecedor { get; set; }
        public IList<Item> itens { get; set; }

    }
}
