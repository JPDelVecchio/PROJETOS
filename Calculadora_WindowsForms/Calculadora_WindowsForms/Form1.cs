using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            var digito = Convert.ToDouble(btn4.Text.ToString());
            Calculador.InsereDigito(digito);
            txtVisor.Text += Convert.ToString(Calculador.RetornaDigitos());
        }

        private void btnDeletaUm_Click(object sender, EventArgs e)
        { 
            Calculador.UltimoDigito
        }

        private void btnSoma_Click(object sender, EventArgs e)
        { 

        }
    }
}
