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

        public static Stack<String> Pilha = new Stack<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btn4.Text);
            txtVisor.Text =  Calculador.AtualizarVisor(); 
        }

        private void btnDeletaUm_Click(object sender, EventArgs e)
        {
            Form1.Pilha.Pop();
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btnSoma.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtVisor.Text = Calculador.ApagarTudo();
        }

        private void btn7_Click(object sender, EventArgs e)
        { 
            Calculador.Verificaigito(btn7.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btn8.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btn9.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void btn1_Click(object sender, EventArgs e)
        { 
            Calculador.Verificaigito(btn1.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btn2.Text);
            txtVisor.Text = Calculador.AtualizarVisor(); 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btn3.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btn5.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btn6.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btn0.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btnPonto.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btnIgual.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btnSubtrai.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btnMultiplica.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Calculador.Verificaigito(btnDivisao.Text);
            txtVisor.Text = Calculador.AtualizarVisor();
        }
    }
}
