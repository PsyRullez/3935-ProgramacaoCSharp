using System;
using System.Windows.Forms;

namespace Prog15DiogoDias
{
    public partial class RfmCirculo : Form
    {
        public RfmCirculo()
        {
            InitializeComponent();
        }

        private void RfmCirculo_Load(object sender, EventArgs e)
        {
            // Inicializar os campos e esconder os labels de resultado
            txtRaio.Text = "";
            lblRArea.Text = "Área=";
            lblRArea.Hide();
            lblRPerimetro.Text = "Perímetro=";
            lblRPerimetro.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Voltar para o formulário principal
            this.Hide();
            new Prog15DiogoDias().Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter o valor do raio a partir do campo de texto
                if (double.TryParse(txtRaio.Text, out double raioCirculo))
                {
                    // Instanciar a classe Circulo
                    Circulo circulo = new Circulo
                    {
                        Raio = raioCirculo
                    };

                    // Calcular área e perímetro
                    double area = circulo.CalculaArea();
                    double perimetro = circulo.CalculaPerimetro();

                    // Exibir os resultados nos labels
                    lblRArea.Text = $"Área = {area:F2}";
                    lblRPerimetro.Text = $"Perímetro = {perimetro:F2}";

                    // Tornar os labels visíveis
                    lblRArea.Show();
                    lblRPerimetro.Show();
                }
                else
                {
                    // Exibir mensagem de erro se o valor não for numérico
                    MessageBox.Show("Por favor, insira um valor numérico válido para o raio.",
                        "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Capturar outros erros inesperados
                MessageBox.Show($"Ocorreu um erro: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}