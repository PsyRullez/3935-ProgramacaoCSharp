namespace Prog15DiogoDias
{
    partial class Prog15DiogoDias
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
            lblTittle = new Label();
            lblSubTittle = new Label();
            label1 = new Label();
            combox = new ComboBox();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Location = new Point(393, 21);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(174, 25);
            lblTittle.TabIndex = 0;
            lblTittle.Text = "Formas Geometricas";
            // 
            // lblSubTittle
            // 
            lblSubTittle.AutoSize = true;
            lblSubTittle.Location = new Point(398, 65);
            lblSubTittle.Name = "lblSubTittle";
            lblSubTittle.Size = new Size(169, 25);
            lblSubTittle.TabIndex = 1;
            lblSubTittle.Text = "(Áreas e Perímetros)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 126);
            label1.Name = "label1";
            label1.Size = new Size(251, 25);
            label1.TabIndex = 2;
            label1.Text = "Selecione a Forma Geométrica";
            // 
            // combox
            // 
            combox.Font = new Font("Segoe UI", 14F);
            combox.FormattingEnabled = true;
            combox.Location = new Point(366, 186);
            combox.Name = "combox";
            combox.Size = new Size(300, 46);
            combox.TabIndex = 3;
            combox.Text = "Selecione uma opção";
            combox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(955, 558);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(112, 34);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Prog15DiogoDias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 604);
            Controls.Add(btnSair);
            Controls.Add(combox);
            Controls.Add(label1);
            Controls.Add(lblSubTittle);
            Controls.Add(lblTittle);
            Name = "Prog15DiogoDias";
            Text = "Prog15DiogoDias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTittle;
        private Label lblSubTittle;
        private Label label1;
        private ComboBox combox;
        private Button btnSair;
    }
}
