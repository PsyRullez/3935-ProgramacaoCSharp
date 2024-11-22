namespace Prog15DiogoDias
{
    partial class RfmRetangulo
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
            lblBase = new Label();
            lblAltura = new Label();
            txtBase = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lblRPerimetro = new Label();
            lblRArea = new Label();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(85, 53);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(48, 25);
            lblBase.TabIndex = 0;
            lblBase.Text = "Base";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(74, 133);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(59, 25);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(139, 53);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(150, 31);
            txtBase.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(139, 133);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(150, 31);
            txtAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(158, 385);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblRPerimetro
            // 
            lblRPerimetro.AutoSize = true;
            lblRPerimetro.Location = new Point(463, 245);
            lblRPerimetro.Name = "lblRPerimetro";
            lblRPerimetro.Size = new Size(100, 25);
            lblRPerimetro.TabIndex = 5;
            lblRPerimetro.Text = "Perímetro=";
            // 
            // lblRArea
            // 
            lblRArea.AutoSize = true;
            lblRArea.Location = new Point(158, 245);
            lblRArea.Name = "lblRArea";
            lblRArea.Size = new Size(60, 25);
            lblRArea.TabIndex = 6;
            lblRArea.Text = "Área=";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(557, 385);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // RfmRetangulo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(lblRArea);
            Controls.Add(lblRPerimetro);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Controls.Add(lblAltura);
            Controls.Add(lblBase);
            Name = "RfmRetangulo";
            Text = "RfmRetangulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBase;
        private Label lblAltura;
        private TextBox txtBase;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblRPerimetro;
        private Label lblRArea;
        private Button btnVoltar;
    }
}