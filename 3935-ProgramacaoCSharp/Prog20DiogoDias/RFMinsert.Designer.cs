namespace Prog20DiogoDias
{
    partial class RFMinsert
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
            loginStrip = new MenuStrip();
            baseDeDadosToolStripMenuItem = new ToolStripMenuItem();
            listaDeTelemóveisToolStripMenuItem = new ToolStripMenuItem();
            inserirToolStripMenuItem = new ToolStripMenuItem();
            pesquisaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            lbl_marca = new Label();
            pictureBox1 = new PictureBox();
            lbl_modelo = new Label();
            lbl_ano = new Label();
            txtbox_modelo = new TextBox();
            txtbox_ano = new TextBox();
            lbl_desc = new Label();
            txtbox_desc = new TextBox();
            txtbox_preco = new TextBox();
            lbl_preco = new Label();
            lbl_imagem = new Label();
            picbox_tel = new PictureBox();
            comboBox1 = new ComboBox();
            txtbox_ram = new TextBox();
            lbl_ram = new Label();
            txtbox_mem = new TextBox();
            label1 = new Label();
            loginStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_tel).BeginInit();
            SuspendLayout();
            // 
            // loginStrip
            // 
            loginStrip.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginStrip.ImageScalingSize = new Size(24, 24);
            loginStrip.Items.AddRange(new ToolStripItem[] { baseDeDadosToolStripMenuItem, listaDeTelemóveisToolStripMenuItem, inserirToolStripMenuItem, pesquisaToolStripMenuItem, sairToolStripMenuItem });
            loginStrip.Location = new Point(0, 0);
            loginStrip.Name = "loginStrip";
            loginStrip.Size = new Size(831, 46);
            loginStrip.TabIndex = 1;
            loginStrip.Text = "Loja de Telemoveis";
            // 
            // baseDeDadosToolStripMenuItem
            // 
            baseDeDadosToolStripMenuItem.Name = "baseDeDadosToolStripMenuItem";
            baseDeDadosToolStripMenuItem.Size = new Size(215, 42);
            baseDeDadosToolStripMenuItem.Text = "Base de Dados";
            // 
            // listaDeTelemóveisToolStripMenuItem
            // 
            listaDeTelemóveisToolStripMenuItem.Name = "listaDeTelemóveisToolStripMenuItem";
            listaDeTelemóveisToolStripMenuItem.Size = new Size(271, 42);
            listaDeTelemóveisToolStripMenuItem.Text = "Lista de Telemóveis";
            // 
            // inserirToolStripMenuItem
            // 
            inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            inserirToolStripMenuItem.Size = new Size(110, 42);
            inserirToolStripMenuItem.Text = "Inserir";
            // 
            // pesquisaToolStripMenuItem
            // 
            pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            pesquisaToolStripMenuItem.Size = new Size(140, 42);
            pesquisaToolStripMenuItem.Text = "Pesquisa";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(79, 42);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Location = new Point(12, 303);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(60, 25);
            lbl_marca.TabIndex = 2;
            lbl_marca.Text = "Marca";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(237, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbl_modelo
            // 
            lbl_modelo.AutoSize = true;
            lbl_modelo.Location = new Point(266, 298);
            lbl_modelo.Name = "lbl_modelo";
            lbl_modelo.Size = new Size(74, 25);
            lbl_modelo.TabIndex = 4;
            lbl_modelo.Text = "Modelo";
            // 
            // lbl_ano
            // 
            lbl_ano.AutoSize = true;
            lbl_ano.Location = new Point(621, 295);
            lbl_ano.Name = "lbl_ano";
            lbl_ano.Size = new Size(45, 25);
            lbl_ano.TabIndex = 5;
            lbl_ano.Text = "Ano";
            // 
            // txtbox_modelo
            // 
            txtbox_modelo.Location = new Point(346, 292);
            txtbox_modelo.Name = "txtbox_modelo";
            txtbox_modelo.Size = new Size(269, 31);
            txtbox_modelo.TabIndex = 6;
            // 
            // txtbox_ano
            // 
            txtbox_ano.Location = new Point(672, 292);
            txtbox_ano.Name = "txtbox_ano";
            txtbox_ano.Size = new Size(133, 31);
            txtbox_ano.TabIndex = 7;
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Location = new Point(106, 377);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(88, 25);
            lbl_desc.TabIndex = 8;
            lbl_desc.Text = "Descrição";
            // 
            // txtbox_desc
            // 
            txtbox_desc.Location = new Point(12, 405);
            txtbox_desc.Multiline = true;
            txtbox_desc.Name = "txtbox_desc";
            txtbox_desc.Size = new Size(269, 96);
            txtbox_desc.TabIndex = 9;
            // 
            // txtbox_preco
            // 
            txtbox_preco.Location = new Point(672, 465);
            txtbox_preco.Name = "txtbox_preco";
            txtbox_preco.Size = new Size(133, 31);
            txtbox_preco.TabIndex = 11;
            // 
            // lbl_preco
            // 
            lbl_preco.AutoSize = true;
            lbl_preco.Location = new Point(610, 468);
            lbl_preco.Name = "lbl_preco";
            lbl_preco.Size = new Size(56, 25);
            lbl_preco.TabIndex = 10;
            lbl_preco.Text = "Preço";
            // 
            // lbl_imagem
            // 
            lbl_imagem.AutoSize = true;
            lbl_imagem.Location = new Point(298, 377);
            lbl_imagem.Name = "lbl_imagem";
            lbl_imagem.Size = new Size(78, 25);
            lbl_imagem.TabIndex = 12;
            lbl_imagem.Text = "Imagem";
            // 
            // picbox_tel
            // 
            picbox_tel.Location = new Point(380, 353);
            picbox_tel.Name = "picbox_tel";
            picbox_tel.Size = new Size(205, 140);
            picbox_tel.TabIndex = 13;
            picbox_tel.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 295);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 14;
            // 
            // txtbox_ram
            // 
            txtbox_ram.Location = new Point(672, 353);
            txtbox_ram.Name = "txtbox_ram";
            txtbox_ram.Size = new Size(133, 31);
            txtbox_ram.TabIndex = 16;
            // 
            // lbl_ram
            // 
            lbl_ram.AutoSize = true;
            lbl_ram.Location = new Point(615, 356);
            lbl_ram.Name = "lbl_ram";
            lbl_ram.Size = new Size(51, 25);
            lbl_ram.TabIndex = 15;
            lbl_ram.Text = "RAM";
            // 
            // txtbox_mem
            // 
            txtbox_mem.Location = new Point(672, 405);
            txtbox_mem.Name = "txtbox_mem";
            txtbox_mem.Size = new Size(133, 31);
            txtbox_mem.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(615, 408);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 17;
            label1.Text = "Mem";
            // 
            // RFMinsert
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(831, 689);
            Controls.Add(txtbox_mem);
            Controls.Add(label1);
            Controls.Add(txtbox_ram);
            Controls.Add(lbl_ram);
            Controls.Add(comboBox1);
            Controls.Add(picbox_tel);
            Controls.Add(lbl_imagem);
            Controls.Add(txtbox_preco);
            Controls.Add(lbl_preco);
            Controls.Add(txtbox_desc);
            Controls.Add(lbl_desc);
            Controls.Add(txtbox_ano);
            Controls.Add(txtbox_modelo);
            Controls.Add(lbl_ano);
            Controls.Add(lbl_modelo);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_marca);
            Controls.Add(loginStrip);
            Name = "RFMinsert";
            Text = "RFMinsert";
            Load += RFMinsert_Load;
            loginStrip.ResumeLayout(false);
            loginStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_tel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip loginStrip;
        private ToolStripMenuItem baseDeDadosToolStripMenuItem;
        private ToolStripMenuItem listaDeTelemóveisToolStripMenuItem;
        private ToolStripMenuItem inserirToolStripMenuItem;
        private ToolStripMenuItem pesquisaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label lbl_marca;
        private PictureBox pictureBox1;
        private Label lbl_modelo;
        private Label lbl_ano;
        private TextBox txtbox_modelo;
        private TextBox txtbox_ano;
        private Label lbl_desc;
        private TextBox txtbox_desc;
        private TextBox txtbox_preco;
        private Label lbl_preco;
        private Label lbl_imagem;
        private PictureBox picbox_tel;
        private ComboBox comboBox1;
        private TextBox txtbox_ram;
        private Label lbl_ram;
        private TextBox txtbox_mem;
        private Label label1;
    }
}