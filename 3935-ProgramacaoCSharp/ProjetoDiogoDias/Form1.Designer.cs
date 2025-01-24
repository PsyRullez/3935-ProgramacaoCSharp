namespace ProjetoDiogoDias
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smenuDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuItemList = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuBrands = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.txtboxDataSource = new System.Windows.Forms.TextBox();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.LblDBstatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuDatabase,
            this.smenuItemList,
            this.smenuBrands,
            this.smenuSearch,
            this.smenuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smenuDatabase
            // 
            this.smenuDatabase.Name = "smenuDatabase";
            this.smenuDatabase.Size = new System.Drawing.Size(146, 30);
            this.smenuDatabase.Text = "Base de Dados";
            // 
            // smenuItemList
            // 
            this.smenuItemList.Name = "smenuItemList";
            this.smenuItemList.Size = new System.Drawing.Size(179, 30);
            this.smenuItemList.Text = "Lista de Telemoveis";
            // 
            // smenuBrands
            // 
            this.smenuBrands.Name = "smenuBrands";
            this.smenuBrands.Size = new System.Drawing.Size(84, 30);
            this.smenuBrands.Text = "Marcas";
            // 
            // smenuSearch
            // 
            this.smenuSearch.Name = "smenuSearch";
            this.smenuSearch.Size = new System.Drawing.Size(96, 30);
            this.smenuSearch.Text = "Pesquisa";
            // 
            // smenuExit
            // 
            this.smenuExit.Name = "smenuExit";
            this.smenuExit.Size = new System.Drawing.Size(57, 30);
            this.smenuExit.Text = "Sair";
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Location = new System.Drawing.Point(50, 175);
            this.lblDataSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(95, 20);
            this.lblDataSource.TabIndex = 1;
            this.lblDataSource.Text = "DataSource";
            // 
            // txtboxDataSource
            // 
            this.txtboxDataSource.Location = new System.Drawing.Point(154, 165);
            this.txtboxDataSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxDataSource.Name = "txtboxDataSource";
            this.txtboxDataSource.Size = new System.Drawing.Size(148, 26);
            this.txtboxDataSource.TabIndex = 2;
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Location = new System.Drawing.Point(154, 255);
            this.txtBoxPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(148, 26);
            this.txtBoxPort.TabIndex = 4;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(50, 266);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(47, 20);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Porta";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(436, 171);
            this.txtBoxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(148, 26);
            this.txtBoxUser.TabIndex = 6;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(352, 175);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(75, 20);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Utilizador";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(436, 262);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(148, 26);
            this.txtBoxPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(352, 266);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(630, 212);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 35);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // LblDBstatus
            // 
            this.LblDBstatus.AutoSize = true;
            this.LblDBstatus.Location = new System.Drawing.Point(658, 268);
            this.LblDBstatus.Name = "LblDBstatus";
            this.LblDBstatus.Size = new System.Drawing.Size(64, 20);
            this.LblDBstatus.TabIndex = 10;
            this.LblDBstatus.Text = "Estado:";
            this.LblDBstatus.Click += new System.EventHandler(this.LblDBstatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.LblDBstatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtBoxPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtboxDataSource);
            this.Controls.Add(this.lblDataSource);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smenuDatabase;
        private System.Windows.Forms.ToolStripMenuItem smenuItemList;
        private System.Windows.Forms.ToolStripMenuItem smenuBrands;
        private System.Windows.Forms.ToolStripMenuItem smenuSearch;
        private System.Windows.Forms.ToolStripMenuItem smenuExit;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.TextBox txtboxDataSource;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label LblDBstatus;
    }
}

