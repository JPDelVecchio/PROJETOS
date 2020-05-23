using CRUD_Basico.Dados;
using CRUD_Basico.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_basico.Modelos
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public String Unidade { get; set; }
        
        public String IncluirProduto(Produto produto)
        {
            using (var contexto = new MovimentacaoContext())
            {
                contexto.Produtos.Add(produto);
                contexto.SaveChanges();
            }
            CadProduto.ActiveForm.Close();
            return $"Produto {produto.Nome} Cadastrado com Sucesso!!!";
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
