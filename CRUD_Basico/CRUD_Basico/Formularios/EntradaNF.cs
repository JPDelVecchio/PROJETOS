using CRUD_basico.Modelos;
using CRUD_Basico.Dados;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Basico.Formularios
{
    public partial class EntradaNF : Form
    {

        List<Item> lsItens = new List<Item>();
        public EntradaNF()
        {
            InitializeComponent();
            lblData.Text = "Data Movimento: " +  DateTime.Now.ToShortDateString();

            dgvItemNF.AutoGenerateColumns = false;

        }

        private void EntradaNF_Load(object sender, EventArgs e)
        {
            var listaProdutos = new List<Produto>();
            using (var contexto = new MovimentacaoContext())
            {
               List<Produto> lsProduto = contexto.Produtos.ToList();
            
                foreach (var item in lsProduto)
                {
                   cbItem.Items.Add(item.Nome);
                }

                List<ClienteFornecedor> cf = contexto.ClientesFornecedores.ToList();

                foreach (var clienteFornecedor in cf)
                {
                    cbCliente.Items.Add(clienteFornecedor.Nome);
                    cbFornecedor.Items.Add(clienteFornecedor.Nome);
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var item = new Item(); 
            item.Quantidade = Convert.ToDouble(txtQtd.Text.ToString());
            item.Valor = Convert.ToDouble(txtValor.Text.ToString());
            item.ItemNf = cbItem.Text.ToString();
            item.Total = item.Quantidade * item.Valor;
            lsItens.Add(item);


            dgvItemNF.DataSource = null;
            dgvItemNF.DataSource = lsItens ;
            dgvItemNF.Refresh();

            txtTotal.Text = CalcularTotal();
        }
        private string CalcularTotal()
        {
            double total = 0.00;
            foreach (var item in lsItens)
            {
                total = total + (item.Valor * item.Quantidade);
            }

            return total.ToString();
        }
    }
}
