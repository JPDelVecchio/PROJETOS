using CRUD_basico.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Basico.Formularios
{
    public partial class CadProduto : Form
    {
        public CadProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text.ToString();
            produto.Descricao = txtDescricao.Text.ToString();
            produto.Unidade = txtUnidade.Text.ToString();

            var res = produto.IncluirProduto(produto);

            MessageBox.Show(res.ToString());
        }
    }
}
