using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_basico.Modelos
{
    class NotaFiscal
    {
        public int Id { get; set; }
        public int NumeroNota { get; set; }
        public ClienteFornecedor Fornecedor { get; set; }
        public IList<Item> itens { get; set; }

        public NotaFiscal()
        {
            this.itens = new List<Item>();
        }

        public void AdicionarItem(Produto produto,int quantidade, double valor)
        {
            Item it = new Item() {ItemNf = produto, Quantidade = quantidade, Valor = valor };
            this.itens.Add(it);
        }

        public void RemoverItem(Item item)
        {
            this.itens.Remove(item);
        }
    }
}
