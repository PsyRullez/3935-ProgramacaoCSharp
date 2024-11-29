namespace Prog15DiogoDias
{
    partial class RfmCirculo
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
            btnVoltar = new Button();
            lblRArea = new Label();
            btnCalcular = new Button();
            txtRaio = new TextBox();
            lblRaio = new Label();
            lblRPerimetro = new Label();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(515, 357);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblRArea
            // 
            lblRArea.AutoSize = true;
            lblRArea.Location = new Point(140, 217);
            lblRArea.Name = "lblRArea";
            lblRArea.Size = new Size(60, 25);
            lblRArea.TabIndex = 14;
            lblRArea.Text = "Área=";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(116, 357);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtRaio
            // 
            txtRaio.Location = new Point(97, 25);
            txtRaio.Name = "txtRaio";
            txtRaio.Size = new Size(150, 31);
            txtRaio.TabIndex = 10;
            // 
            // lblRaio
            // 
            lblRaio.AutoSize = true;
            lblRaio.Location = new Point(43, 25);
            lblRaio.Name = "lblRaio";
            lblRaio.Size = new Size(47, 25);
            lblRaio.TabIndex = 8;
            lblRaio.Text = "Raio";
            // 
            // lblRPerimetro
            // 
            lblRPerimetro.AutoSize = true;
            lblRPerimetro.Location = new Point(421, 217);
            lblRPerimetro.Name = "lblRPerimetro";
            lblRPerimetro.Size = new Size(100, 25);
            lblRPerimetro.TabIndex = 13;
            lblRPerimetro.Text = "Perímetro=";
            // 
            // RfmCirculo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(lblRArea);
            Controls.Add(lblRPerimetro);
            Controls.Add(btnCalcular);
            Controls.Add(txtRaio);
            Controls.Add(lblRaio);
            Name = "RfmCirculo";
            Text = "RfmCirculo";
            Load += RfmCirculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label lblRArea;
        private Button btnCalcular;
        private TextBox txtRaio;
        private Label lblRaio;
        private Label lblRPerimetro;
    }
}