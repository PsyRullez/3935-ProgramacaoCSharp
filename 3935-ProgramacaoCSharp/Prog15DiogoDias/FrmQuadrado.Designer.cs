﻿namespace Prog15DiogoDias
{
    partial class FrmQuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuadrado));
            txtLadoA = new TextBox();
            lblLadoA = new Label();
            lblRArea = new Label();
            lblRPerimetro = new Label();
            btnVoltar = new Button();
            btnCalcular = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(90, 68);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(150, 31);
            txtLadoA.TabIndex = 6;
            // 
            // lblLadoA
            // 
            lblLadoA.AutoSize = true;
            lblLadoA.Location = new Point(14, 68);
            lblLadoA.Name = "lblLadoA";
            lblLadoA.Size = new Size(66, 25);
            lblLadoA.TabIndex = 4;
            lblLadoA.Text = "Lado-L";
            // 
            // lblRArea
            // 
            lblRArea.AutoSize = true;
            lblRArea.Location = new Point(90, 262);
            lblRArea.Name = "lblRArea";
            lblRArea.Size = new Size(60, 25);
            lblRArea.TabIndex = 9;
            lblRArea.Text = "Área=";
            // 
            // lblRPerimetro
            // 
            lblRPerimetro.AutoSize = true;
            lblRPerimetro.Location = new Point(395, 262);
            lblRPerimetro.Name = "lblRPerimetro";
            lblRPerimetro.Size = new Size(100, 25);
            lblRPerimetro.TabIndex = 8;
            lblRPerimetro.Text = "Perímetro=";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(545, 395);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(146, 395);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(529, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FrmQuadrado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnVoltar);
            Controls.Add(btnCalcular);
            Controls.Add(lblRArea);
            Controls.Add(lblRPerimetro);
            Controls.Add(txtLadoA);
            Controls.Add(lblLadoA);
            Name = "FrmQuadrado";
            Text = "FrmQuadrado";
            Load += FrmQuadrado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtLadoA;
        private Label lblLadoA;
        private Label lblRArea;
        private Label lblRPerimetro;
        private Button btnVoltar;
        private Button btnCalcular;
        private PictureBox pictureBox1;
    }
}