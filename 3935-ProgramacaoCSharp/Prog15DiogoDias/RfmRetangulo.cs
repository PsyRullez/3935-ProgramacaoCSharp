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
