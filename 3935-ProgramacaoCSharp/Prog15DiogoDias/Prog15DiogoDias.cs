namespace Prog15DiogoDias
{
    public partial class Prog15DiogoDias : Form
    {
        public Prog15DiogoDias()
        {
            InitializeComponent();
            InicializarComboBox();
        }

        private void InicializarComboBox()
        {
            combox.Items.Clear();
            combox.Items.AddRange(new string[] {
                "Selecione uma op��o",
                "Ret�ngulo",
                "Quadrado",
                "C�rculo",
                "Tri�ngulo",
                "Sair"
            });
            combox.SelectedIndex = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirma��o",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox.SelectedIndex == 0)
            {
                combox.SelectedIndex = 0;
            }

            if (combox.SelectedIndex == 1)
            {
                this.Hide();
                new RfmRetangulo(). Show();
            }

            if (combox.SelectedIndex == 2)
            {
                this.Hide();
                new FrmQuadrado().Show();
            }

            if (combox.SelectedIndex == 3)
            {
                this.Hide();
                new RfmCirculo().Show();
            }

            if (combox.SelectedIndex == 4)
            {
                this.Hide();
                new RfmTriangulo().Show();
            }

            if (combox.SelectedIndex == 5)
            {
                Application.Exit();
            }

            /*if (combox.SelectedItem == null) return;

            Form formToShow = null;

            switch (combox.SelectedItem.ToString())
            {
                case "Ret�ngulo":
                    formToShow = new RfmRetangulo();
                    break;

                case "Quadrado":
                    formToShow = new FrmQuadrado();
                    break;

                case "C�rculo":
                    formToShow = new RfmCirculo();
                    break;

                case "Tri�ngulo":
                    formToShow = new RfmTriangulo();
                    break;

                case "Sair":
                    if (MessageBox.Show("Deseja realmente sair?", "Confirma��o",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        combox.SelectedIndex = 0;
                    }
                    return;*/
        }

            /*if (formToShow != null)
            {
                this.Hide(); // Oculta o formul�rio principal
                formToShow.FormClosed += (s, args) =>
                {
                    this.Show(); // Mostra o formul�rio principal quando o subformul�rio for fechado
                    combox.SelectedIndex = 0; // Volta para a primeira op��o
                };
                formToShow.Show();
            }
        } */

        /*protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Deseja realmente sair?", "Confirma��o",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }*/
    }
}