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
            marcasToolStripMenuItem = new ToolStripMenuItem();
            pesquisaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            loginStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginStrip
            // 
            loginStrip.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginStrip.ImageScalingSize = new Size(24, 24);
            loginStrip.Items.AddRange(new ToolStripItem[] { baseDeDadosToolStripMenuItem, listaDeTelemóveisToolStripMenuItem, marcasToolStripMenuItem, pesquisaToolStripMenuItem, sairToolStripMenuItem });
            loginStrip.Location = new Point(0, 0);
            loginStrip.Name = "loginStrip";
            loginStrip.Size = new Size(1256, 46);
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
            // marcasToolStripMenuItem
            // 
            marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            marcasToolStripMenuItem.Size = new Size(121, 42);
            marcasToolStripMenuItem.Text = "Marcas";
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(322, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(719, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1256, 481);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(loginStrip);
            MainMenuStrip = loginStrip;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "FrmLogin";
            WindowState = FormWindowState.Maximized;
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
        private ToolStripMenuItem marcasToolStripMenuItem;
        private ToolStripMenuItem pesquisaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
