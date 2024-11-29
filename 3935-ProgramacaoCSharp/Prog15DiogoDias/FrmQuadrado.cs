using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog15DiogoDias
{
    public partial class FrmQuadrado : Form
    {
        public FrmQuadrado()
        {
            InitializeComponent();
        }

        private void FrmQuadrado_Load(object sender, EventArgs e)
        {
            txtLadoA.Text = "";
            lblRArea.Text = "Área=";
            lblRArea.Hide();
            lblRPerimetro.Text = "Perímetro=";
            lblRPerimetro.Hide();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Prog15DiogoDias().Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obter os valores dos lados a partir dos campos de texto
            double ladoA = double.Parse(txtLadoA.Text);

            // Instanciar a classe Quadrado
            Quadrado quadrado = new Quadrado
            {
                Lado = ladoA
            };

            // Calcular área e perímetro
            double area = quadrado.CalculaArea();
            double perimetro = quadrado.CalculaPerimetro();

            // Exibir os resultados nos labels
            lblRArea.Text = $"Área = {area:F2}";
            lblRPerimetro.Text = $"Perímetro = {perimetro:F2}";

            // Tornar os labels visíveis
            lblRArea.Show();
            lblRPerimetro.Show();
        }
    }
}
