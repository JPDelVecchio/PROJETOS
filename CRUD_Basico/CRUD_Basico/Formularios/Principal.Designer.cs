namespace CRUD_Basico
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 339);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(28, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(239, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsStripMenu
            // 
            this.toolsStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.entradaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.toolsStripMenu.Name = "toolsStripMenu";
            this.toolsStripMenu.Size = new System.Drawing.Size(107, 20);
            this.toolsStripMenu.Text = "Menu - Principal";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteFornecedorToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // clienteFornecedorToolStripMenuItem
            // 
            this.clienteFornecedorToolStripMenuItem.Name = "clienteFornecedorToolStripMenuItem";
            this.clienteFornecedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.clienteFornecedorToolStripMenuItem.Text = "Cliente / Fornecedor";
            this.clienteFornecedorToolStripMenuItem.Click += new System.EventHandler(this.clienteFornecedorToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem1});
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entradaToolStripMenuItem.Text = "Movimento";
            // 
            // entradaToolStripMenuItem1
            // 
            this.entradaToolStripMenuItem1.Name = "entradaToolStripMenuItem1";
            this.entradaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.entradaToolStripMenuItem1.Text = "Entrada";
            this.entradaToolStripMenuItem1.Click += new System.EventHandler(this.entradaToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 339);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Entrada e Saídas";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsStripMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}