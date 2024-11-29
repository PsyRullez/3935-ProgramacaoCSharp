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
    public partial class RfmRetangulo : Form
    {
        public RfmRetangulo()
        {
            InitializeComponent();
        }

        private void RfmRetangulo_Load(object sender, EventArgs e)
        {
            txtBase.Text = "";
            txtAltura.Text = "";
            lblRArea.Text = "Área=";
            lblRArea.Hide();
            lblRPerimetro.Text = "Perímetro=";
            lblRPerimetro.Hide();

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores da base e altura a partir dos campos de texto
                double baseRetangulo = double.Parse(txtBase.Text);
                double alturaRetangulo = double.Parse(txtAltura.Text);

                // Instanciar a classe Retangulo
                Retangulo retangulo = new Retangulo
                {
                    Largura = baseRetangulo,
                    Altura = alturaRetangulo
                };

                // Calcular área e perímetro
                double area = retangulo.CalculaArea();
                double perimetro = retangulo.CalculaPerimetro();

                // Exibir os resultados nos labels
                lblRArea.Text = $"Área = {area:F2}";
                lblRPerimetro.Text = $"Perímetro = {perimetro:F2}";

                // Tornar os labels visíveis
                lblRArea.Show();
                lblRPerimetro.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos para a base e altura.",
                                "Erro de Formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Prog15DiogoDias().Show();
        }

        private void TxtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblRArea_Click(object sender, EventArgs e)
        {

        }

        private void LblRPerimetro_Click(object sender, EventArgs e)
        {

        }
    }
}
