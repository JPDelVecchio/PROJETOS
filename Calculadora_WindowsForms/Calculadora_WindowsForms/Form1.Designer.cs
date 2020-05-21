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
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnDeletaUm = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnSubtrai = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 139);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 49);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 194);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 49);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 249);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 49);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "CE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(74, 139);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 49);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(74, 194);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 49);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(74, 249);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 49);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(13, 304);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(116, 49);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button12_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(137, 139);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 49);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(137, 249);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 49);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(137, 194);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 49);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(198, 84);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(55, 49);
            this.btnDivisao.TabIndex = 17;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnDeletaUm
            // 
            this.btnDeletaUm.Location = new System.Drawing.Point(137, 84);
            this.btnDeletaUm.Name = "btnDeletaUm";
            this.btnDeletaUm.Size = new System.Drawing.Size(55, 49);
            this.btnDeletaUm.TabIndex = 18;
            this.btnDeletaUm.Text = "<-";
            this.btnDeletaUm.UseVisualStyleBackColor = true;
            this.btnDeletaUm.Click += new System.EventHandler(this.btnDeletaUm_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(196, 249);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(57, 49);
            this.btnSoma.TabIndex = 19;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(196, 304);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(57, 49);
            this.btnIgual.TabIndex = 20;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(137, 304);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(55, 49);
            this.btnPonto.TabIndex = 21;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.button22_Click);
            // 
            // btnSubtrai
            // 
            this.btnSubtrai.Location = new System.Drawing.Point(196, 194);
            this.btnSubtrai.Name = "btnSubtrai";
            this.btnSubtrai.Size = new System.Drawing.Size(57, 49);
            this.btnSubtrai.TabIndex = 22;
            this.btnSubtrai.Text = "-";
            this.btnSubtrai.UseVisualStyleBackColor = true;
            this.btnSubtrai.Click += new System.EventHandler(this.btnSubtrai_Click);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Location = new System.Drawing.Point(196, 139);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(57, 49);
            this.btnMultiplica.TabIndex = 23;
            this.btnMultiplica.Text = "X";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.SystemColors.Control;
            this.txtVisor.Enabled = false;
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(13, 12);
            this.txtVisor.Multiline = true;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(240, 63);
            this.txtVisor.TabIndex = 24;
            this.txtVisor.TextChanged += new System.EventHandler(this.txtVisor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 364);
            this.Controls.Add(this.txtVisor);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnSubtrai);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnDeletaUm);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Name = "Form1";
            this.Text = "Calculadora - João";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnDeletaUm;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnSubtrai;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.TextBox txtVisor;
    }
}

