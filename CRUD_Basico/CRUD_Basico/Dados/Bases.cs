using CRUD_basico.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_basico.Dados
{
     class Bases
    {
        public List<Fornecedor> Fornecedores { get; set; }
        public List<Produto> Produtos { get; set; }


        public Bases()
        {
            this.Fornecedores = new List<Fornecedor>();
            this.Produtos = new List<Produto>();
        }
        public String AdicionarFornecedor(Fornecedor fornecedor)
        { 
            if (fornecedor != null)
            {
                this.Fornecedores.Add(fornecedor);
                Console.WriteLine("Adicionado o fornecedor");
                return $"Fornecedor Adicionado com sucesso {fornecedor.Nome}";
            }
            else
            {
                return $"ERRO: Fornecedor {fornecedor.Nome}, não cadastrado";
            }
        }

        internal List<Fornecedor> ListarFornecedor()
        {
            return this.Fornecedores;
        }

        public String AdicionarProduto(Produto produto)
        {
            if ( produto != null)
            {
                this.Produtos.Add(produto);
                return $"Produto Adicionado {produto.Classe}";
            }
            else 
            { 
                return   "OLHA Deu Pau!!!!!!";
            }
        }

        internal List<Produto> ListarProdutos()
        {
            return this.Produtos;
        }
    }
}
