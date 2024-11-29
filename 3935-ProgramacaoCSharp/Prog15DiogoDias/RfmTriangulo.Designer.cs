namespace Prog15DiogoDias
{
    partial class RfmTriangulo
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
            lblRPerimetro = new Label();
            btnCalcular = new Button();
            txtLado2 = new TextBox();
            txtLado1 = new TextBox();
            lblLado2 = new Label();
            lblLado1 = new Label();
            txtLado3 = new TextBox();
            lblLado3 = new Label();
            lblTipo = new Label();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(586, 374);
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
            lblRArea.Location = new Point(187, 234);
            lblRArea.Name = "lblRArea";
            lblRArea.Size = new Size(60, 25);
            lblRArea.TabIndex = 14;
            lblRArea.Text = "Área=";
            // 
            // lblRPerimetro
            // 
            lblRPerimetro.AutoSize = true;
            lblRPerimetro.Location = new Point(492, 234);
            lblRPerimetro.Name = "lblRPerimetro";
            lblRPerimetro.Size = new Size(100, 25);
            lblRPerimetro.TabIndex = 13;
            lblRPerimetro.Text = "Perímetro=";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(187, 374);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(102, 101);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(150, 31);
            txtLado2.TabIndex = 11;
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(102, 21);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(150, 31);
            txtLado1.TabIndex = 10;
            // 
            // lblLado2
            // 
            lblLado2.AutoSize = true;
            lblLado2.Location = new Point(24, 101);
            lblLado2.Name = "lblLado2";
            lblLado2.Size = new Size(66, 25);
            lblLado2.TabIndex = 9;
            lblLado2.Text = "Lado 2";
            // 
            // lblLado1
            // 
            lblLado1.AutoSize = true;
            lblLado1.Location = new Point(35, 21);
            lblLado1.Name = "lblLado1";
            lblLado1.Size = new Size(61, 25);
            lblLado1.TabIndex = 8;
            lblLado1.Text = "Lado1";
            // 
            // txtLado3
            // 
            txtLado3.Location = new Point(102, 165);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(150, 31);
            txtLado3.TabIndex = 17;
            // 
            // lblLado3
            // 
            lblLado3.AutoSize = true;
            lblLado3.Location = new Point(24, 165);
            lblLado3.Name = "lblLado3";
            lblLado3.Size = new Size(66, 25);
            lblLado3.TabIndex = 16;
            lblLado3.Text = "Lado 3";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(472, 61);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(125, 25);
            lblTipo.TabIndex = 18;
            lblTipo.Text = "Triangulo tipo:";
            lblTipo.Click += label1_Click;
            // 
            // RfmTriangulo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTipo);
            Controls.Add(txtLado3);
            Controls.Add(lblLado3);
            Controls.Add(btnVoltar);
            Controls.Add(lblRArea);
            Controls.Add(lblRPerimetro);
            Controls.Add(btnCalcular);
            Controls.Add(txtLado2);
            Controls.Add(txtLado1);
            Controls.Add(lblLado2);
            Controls.Add(lblLado1);
            Name = "RfmTriangulo";
            Text = "RfmTriangulo";
            Load += RfmTriangulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label lblRArea;
        private Label lblRPerimetro;
        private Button btnCalcular;
        private TextBox txtLado2;
        private TextBox txtLado1;
        private Label lblLado2;
        private Label lblLado1;
        private TextBox txtLado3;
        private Label lblLado3;
        private Label lblTipo;
    }
}