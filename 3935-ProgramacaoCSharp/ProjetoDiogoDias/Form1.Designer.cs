namespace ProjetoPedro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baseDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaTelemóveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDataSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUtilizador = new System.Windows.Forms.TextBox();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPorta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeToolStripMenuItem,
            this.listaTelemóveisToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.pesquisaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baseDeToolStripMenuItem
            // 
            this.baseDeToolStripMenuItem.Name = "baseDeToolStripMenuItem";
            this.baseDeToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.baseDeToolStripMenuItem.Text = "Base de Dados";
            // 
            // listaTelemóveisToolStripMenuItem
            // 
            this.listaTelemóveisToolStripMenuItem.Name = "listaTelemóveisToolStripMenuItem";
            this.listaTelemóveisToolStripMenuItem.Size = new System.Drawing.Size(154, 29);
            this.listaTelemóveisToolStripMenuItem.Text = "Lista Telemóveis";
            this.listaTelemóveisToolStripMenuItem.Click += new System.EventHandler(this.listaTelemóveisToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 363);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conexão à Base de Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 440);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "DataSource";
            // 
            // TxtDataSource
            // 
            this.TxtDataSource.Location = new System.Drawing.Point(240, 440);
            this.TxtDataSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDataSource.Name = "TxtDataSource";
            this.TxtDataSource.Size = new System.Drawing.Size(148, 26);
            this.TxtDataSource.TabIndex = 4;
            this.TxtDataSource.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 440);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Utilizador";
            // 
            // TxtUtilizador
            // 
            this.TxtUtilizador.Location = new System.Drawing.Point(582, 440);
            this.TxtUtilizador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUtilizador.Name = "TxtUtilizador";
            this.TxtUtilizador.Size = new System.Drawing.Size(148, 26);
            this.TxtUtilizador.TabIndex = 6;
            this.TxtUtilizador.Text = "root";
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(975, 418);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(130, 71);
            this.BtnConectar.TabIndex = 7;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 518);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Porta";
            // 
            // TxtPorta
            // 
            this.TxtPorta.Location = new System.Drawing.Point(240, 508);
            this.TxtPorta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPorta.Name = "TxtPorta";
            this.TxtPorta.Size = new System.Drawing.Size(148, 26);
            this.TxtPorta.TabIndex = 9;
            this.TxtPorta.Text = "3306";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 512);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(582, 502);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(148, 26);
            this.TxtPassword.TabIndex = 11;
            this.TxtPassword.Text = "MySQL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(314, 585);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(464, 252);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 917);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPorta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.TxtUtilizador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDataSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baseDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaTelemóveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDataSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUtilizador;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPorta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

