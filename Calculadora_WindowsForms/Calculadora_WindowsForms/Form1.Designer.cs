using System;

namespace Calculadora_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnDeletaUm = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.btnSubtrai = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "1/x";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 195);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 49);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 250);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 49);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 305);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 49);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "+/-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 85);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 49);
            this.button6.TabIndex = 5;
            this.button6.Text = "%";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(74, 85);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "CE";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(74, 140);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 49);
            this.button8.TabIndex = 7;
            this.button8.Text = "X²";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(74, 195);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 49);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(74, 250);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 49);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(74, 305);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 49);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(74, 360);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 49);
            this.button12.TabIndex = 11;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(135, 85);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 49);
            this.button13.TabIndex = 12;
            this.button13.Text = "C";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(135, 140);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 49);
            this.button14.TabIndex = 13;
            this.button14.Text = "²Vx";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(137, 195);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 49);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(137, 305);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 49);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(137, 250);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 49);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(196, 140);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(90, 49);
            this.btnDivisao.TabIndex = 17;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            // 
            // btnDeletaUm
            // 
            this.btnDeletaUm.Location = new System.Drawing.Point(196, 85);
            this.btnDeletaUm.Name = "btnDeletaUm";
            this.btnDeletaUm.Size = new System.Drawing.Size(90, 49);
            this.btnDeletaUm.TabIndex = 18;
            this.btnDeletaUm.Text = "<-";
            this.btnDeletaUm.UseVisualStyleBackColor = true;
            this.btnDeletaUm.Click += new System.EventHandler(this.btnDeletaUm_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(196, 305);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(90, 49);
            this.btnSoma.TabIndex = 19;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(196, 360);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(90, 49);
            this.btnIgual.TabIndex = 20;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(137, 360);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(55, 49);
            this.button22.TabIndex = 21;
            this.button22.Text = ",";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // btnSubtrai
            // 
            this.btnSubtrai.Location = new System.Drawing.Point(196, 250);
            this.btnSubtrai.Name = "btnSubtrai";
            this.btnSubtrai.Size = new System.Drawing.Size(90, 49);
            this.btnSubtrai.TabIndex = 22;
            this.btnSubtrai.Text = "-";
            this.btnSubtrai.UseVisualStyleBackColor = true;
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Location = new System.Drawing.Point(196, 195);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(90, 49);
            this.btnMultiplica.TabIndex = 23;
            this.btnMultiplica.Text = "X";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.SystemColors.Control;
            this.txtVisor.Location = new System.Drawing.Point(13, 12);
            this.txtVisor.Multiline = true;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(273, 63);
            this.txtVisor.TabIndex = 24;
            this.txtVisor.Text = Convert.ToString(Calculador.RetornaDigitos());
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 417);
            this.Controls.Add(this.txtVisor);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnSubtrai);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnDeletaUm);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calculadora - João";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnDeletaUm;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button btnSubtrai;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.TextBox txtVisor;
    }
}

