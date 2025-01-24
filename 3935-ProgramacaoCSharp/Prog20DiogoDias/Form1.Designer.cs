namespace Prog20DiogoDias
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginStrip = new MenuStrip();
            baseDeDadosToolStripMenuItem = new ToolStripMenuItem();
            listaDeTelemóveisToolStripMenuItem = new ToolStripMenuItem();
            inserirToolStripMenuItem = new ToolStripMenuItem();
            pesquisaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            lbl_dbHost = new Label();
            lbl_dbPort = new Label();
            lbl_User = new Label();
            lbl_Password = new Label();
            dbHostTxtbox = new TextBox();
            dbPortTxtbox = new TextBox();
            dbUserTxtbox = new TextBox();
            dbPassTxtbox = new TextBox();
            btnCxnx = new Button();
            lbl_dbState = new Label();
            loginStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            loginStrip.TabIndex = 0;
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
            inserirToolStripMenuItem.Click += inserirToolStripMenuItem_Click;
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
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(307, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbl_dbHost
            // 
            lbl_dbHost.AutoSize = true;
            lbl_dbHost.Location = new Point(33, 284);
            lbl_dbHost.Name = "lbl_dbHost";
            lbl_dbHost.Size = new Size(80, 25);
            lbl_dbHost.TabIndex = 2;
            lbl_dbHost.Text = "DB_Host";
            // 
            // lbl_dbPort
            // 
            lbl_dbPort.AutoSize = true;
            lbl_dbPort.Location = new Point(33, 352);
            lbl_dbPort.Name = "lbl_dbPort";
            lbl_dbPort.Size = new Size(74, 25);
            lbl_dbPort.TabIndex = 3;
            lbl_dbPort.Text = "DB_Port";
            lbl_dbPort.Click += label1_Click;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(447, 284);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(87, 25);
            lbl_User.TabIndex = 4;
            lbl_User.Text = "Utilizador";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(447, 352);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(87, 25);
            lbl_Password.TabIndex = 5;
            lbl_Password.Text = "Password";
            // 
            // dbHostTxtbox
            // 
            dbHostTxtbox.Location = new Point(119, 281);
            dbHostTxtbox.Name = "dbHostTxtbox";
            dbHostTxtbox.Size = new Size(243, 31);
            dbHostTxtbox.TabIndex = 6;
            dbHostTxtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // dbPortTxtbox
            // 
            dbPortTxtbox.Location = new Point(119, 346);
            dbPortTxtbox.Name = "dbPortTxtbox";
            dbPortTxtbox.Size = new Size(243, 31);
            dbPortTxtbox.TabIndex = 7;
            dbPortTxtbox.TextAlign = HorizontalAlignment.Center;
            dbPortTxtbox.TextChanged += textBox1_TextChanged;
            // 
            // dbUserTxtbox
            // 
            dbUserTxtbox.Location = new Point(540, 278);
            dbUserTxtbox.Name = "dbUserTxtbox";
            dbUserTxtbox.Size = new Size(243, 31);
            dbUserTxtbox.TabIndex = 8;
            dbUserTxtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // dbPassTxtbox
            // 
            dbPassTxtbox.Location = new Point(540, 346);
            dbPassTxtbox.Name = "dbPassTxtbox";
            dbPassTxtbox.Size = new Size(243, 31);
            dbPassTxtbox.TabIndex = 9;
            dbPassTxtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCxnx
            // 
            btnCxnx.Location = new Point(119, 479);
            btnCxnx.Name = "btnCxnx";
            btnCxnx.Size = new Size(112, 34);
            btnCxnx.TabIndex = 10;
            btnCxnx.Text = "Connect";
            btnCxnx.UseVisualStyleBackColor = true;
            btnCxnx.Click += button1_Click;
            // 
            // lbl_dbState
            // 
            lbl_dbState.AutoSize = true;
            lbl_dbState.Location = new Point(413, 484);
            lbl_dbState.Name = "lbl_dbState";
            lbl_dbState.Size = new Size(213, 25);
            lbl_dbState.TabIndex = 11;
            lbl_dbState.Text = "Ligação á Base de Dados:";
            lbl_dbState.TextAlign = ContentAlignment.MiddleCenter;
            lbl_dbState.Click += lbl_dbState_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(831, 689);
            ControlBox = false;
            Controls.Add(lbl_dbState);
            Controls.Add(btnCxnx);
            Controls.Add(dbPassTxtbox);
            Controls.Add(dbUserTxtbox);
            Controls.Add(dbPortTxtbox);
            Controls.Add(dbHostTxtbox);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_User);
            Controls.Add(lbl_dbPort);
            Controls.Add(lbl_dbHost);
            Controls.Add(pictureBox1);
            Controls.Add(loginStrip);
            MainMenuStrip = loginStrip;
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            loginStrip.ResumeLayout(false);
            loginStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label lbl_dbHost;
        private Label lbl_dbPort;
        private Label lbl_User;
        private Label lbl_Password;
        private TextBox dbHostTxtbox;
        private TextBox dbPortTxtbox;
        private TextBox dbUserTxtbox;
        private TextBox dbPassTxtbox;
        private Button btnCxnx;
        private Label lbl_dbState;
    }
}
