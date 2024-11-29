using System;
using System.Windows.Forms;

namespace Prog15DiogoDias
{
    public partial class RfmTriangulo : Form
    {
        public RfmTriangulo()
        {
            InitializeComponent();
        }

        private void RfmTriangulo_Load(object sender, EventArgs e)
        {
            // Estado inicial de componentes
            txtLado1.Text = "";
            txtLado2.Text = "";
            txtLado3.Text = "";
            lblRArea.Text = "Área=";
            lblRArea.Hide();
            lblRPerimetro.Text = "Perímetro=";
            lblRPerimetro.Hide();
            lblTipo.Text = "Tipo de Triângulo:";
            lblTipo.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Voltar para o formulário principal
            this.Close();
            new Prog15DiogoDias().Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores dos lados a partir dos campos de texto
                double lado1 = double.Parse(txtLado1.Text);
                double lado2 = double.Parse(txtLado2.Text);
                double lado3 = double.Parse(txtLado3.Text);

                // Validar se os lados formam um triângulo
                if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
                {
                    // Instanciar a classe Triangulo
                    Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

                    // Calcular área e perímetro
                    double area = triangulo.CalculaArea();
                    double perimetro = triangulo.CalculaPerimetro();
                    string tipo = triangulo.RetornaTipo();

                    // Exibir os resultados nos labels
                    lblRArea.Text = $"Área = {area:F2}";
                    lblRPerimetro.Text = $"Perímetro = {perimetro:F2}";
                    lblTipo.Text = $"Tipo de Triângulo: {tipo}";

                    // Tornar os labels visíveis
                    lblRArea.Show();
                    lblRPerimetro.Show();
                    lblTipo.Show();
                }
                else
                {
                    MessageBox.Show("Os valores inseridos não formam um triângulo válido.",
                        "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insire valores numéricos válidos para os lados.",
                    "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Este método não é necessário, pois o tipo do triângulo já é exibido no botão Calcular
            MessageBox.Show("Clique no botão Calcular para ver o tipo do triângulo.",
                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}