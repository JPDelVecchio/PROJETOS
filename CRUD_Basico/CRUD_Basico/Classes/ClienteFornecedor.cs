using CRUD_Basico.Dados;
using CRUD_Basico.Formularios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_basico.Modelos
{ 
    public class ClienteFornecedor
    { 
        public int Id { get; set; }
 
        public String Nome { get; set; }
         
        public String Cnpj { get; set; }
         
        public String Endereco { get; set; } 

        public String Telefone { get; set; }

        public void IncluirCliFor(ClienteFornecedor cliFor)
        { 
            MessageBox.Show($"Cliente / Fornecedor: {Nome} - ''{Cnpj}''  Cadastrado com sucesso!!!");

            using (var contexto = new MovimentacaoContext())
            {
                contexto.Add(cliFor);
                contexto.SaveChanges();
            }
            CadCliFor.ActiveForm.Close();
        }
        public String ExcluirCliFor()
        {
            return "";
        }
        public String AlterarCliFor()
        {
            return "";
        }
        public List<ClienteFornecedor> ListarCliFor()
        {
            return new List<ClienteFornecedor>() ;
        }
    }
}
