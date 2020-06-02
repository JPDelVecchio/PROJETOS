using CRUD_basico.Modelos;
using CRUD_Basico.Dados;
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
    public partial class CadCliFor : Form
    {
        public CadCliFor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cliFor = new ClienteFornecedor();
            cliFor.Nome = txtNome.Text;
            cliFor.Telefone = txtFone.Text;
            cliFor.Cnpj = txtCNPJ.Text;
            cliFor.Endereco = txtEndereco.Text;

            cliFor.IncluirCliFor(cliFor);
        }
    }
}
