using CRUD_Basico.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Basico
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clienteFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cadcliFor = new CadCliFor();
            cadcliFor.ShowDialog();
            cadcliFor.Close();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cadProduto = new CadProduto();
            cadProduto.ShowDialog();
            cadProduto.Close(); 
        }

        private void entradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form entrada = new EntradaNF();
            entrada.ShowDialog();
            entrada.Close();
        }
    }
}
