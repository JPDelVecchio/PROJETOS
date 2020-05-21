using CRUD_basico.Dados;
using CRUD_basico.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Basico
{
    class Program
    {
        static void Main(string[] args)
        {

            var f1 = new Fornecedor() { Nome = "joão Lima", Cnpj = "4613145614", Endereco = "Ruas das Noivas, 131" };
            var f2 = new Fornecedor() { Nome = "José Lima", Cnpj = "33333333331", Endereco = "Ruas das Noivas, 131" };
            var f3 = new Fornecedor() { Nome = "Cida de Lima", Cnpj = "22224322222", Endereco = "Ruas das Noivas, 131" };

            var p1 = new Produto() { Descricao = "Barcardi", Classe = "Bebidas", Unidade = "Unidade" };
            var p2 = new Produto() { Descricao = "Cerveja Brahma 350 ml", Classe = "Bebidas", Unidade = "Unidade" };
            var p3 = new Produto() { Descricao = "Vinho Francês - Tinto seco Le Monte 600 ml", Classe = "Bebidas", Unidade = "Unidade" };
            var p4 = new Produto() { Descricao = "Corda de Matar", Classe = "Materiais", Unidade = "Metros" };
            var p5 = new Produto() { Descricao = "Fio 3/1", Classe = "Materiais", Unidade = "Metros" };
            var p6 = new Produto() { Descricao = "Areia ", Classe = "Materiais", Unidade = "Saco" };
            var p7 = new Produto() { Descricao = "Candida", Classe = "Uso e Consumo", Unidade = "Litros" };
            var p8 = new Produto() { Descricao = "Detergente", Classe = "Uso e Consumo", Unidade = "Litros" };
            var p9 = new Produto() { Descricao = "Desinfetante", Classe = "Uso e Consumo", Unidade = "Litros" }; 

            var bs = new Bases();
            bs.AdicionarFornecedor(f1);
            bs.AdicionarFornecedor(f2);
            bs.AdicionarFornecedor(f3);

            bs.AdicionarProduto(p1);
            bs.AdicionarProduto(p2);
            bs.AdicionarProduto(p3);
            bs.AdicionarProduto(p4);
            bs.AdicionarProduto(p5);
            bs.AdicionarProduto(p6);
            bs.AdicionarProduto(p7);
            bs.AdicionarProduto(p8);
            bs.AdicionarProduto(p9);

            foreach (var item in bs.ListarFornecedor())
            {
                Console.WriteLine($"Fornecedor: {item.Nome} - CNPJ: {item.Cnpj}");
            }
            foreach (var item in bs.ListarProdutos())
            {
                Console.WriteLine("Produto: " + item.Descricao);
            }

            Console.ReadKey();

            /*
             * Produtos e fornecedores carregados - Agora irei inserir uma nota fiscal
             * e lista ela 
             */

            var nf = new NotaFiscal();



            nf.AdicionarItem(p1, 10, 29.00);
            nf.AdicionarItem(p2, 4, 2.00);
            nf.AdicionarItem(p2, 17, 9.00);
            nf.AdicionarItem(p3, 5, 4.98);
            nf.AdicionarItem(p7, 8, 9.99);

            nf.Fornecedor = f3;

            Console.WriteLine($"\n \n \nCompra com Fornecedor: {nf.Fornecedor.Nome}");
            var total = 0.0;
            foreach (var item in nf.itens)
            {
                total += (item.Quantidade * item.Valor);
                Console.WriteLine($"{item.ItemNf.Descricao} - QTD: {item.Quantidade} - R$: {item.Valor} : {item.Valor * item.Quantidade} ");
            }

            Console.WriteLine("Subtotal: " + total);
            Console.ReadLine();

            /* REmover itens da nota fiscal */
             










        }
         
    }
}
