using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPedro
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        List<Marca> listatabmarcas;
        BindingList<Telemoveis> listatabtelemoveis;

        bool inserir = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {

                string DataSource = TxtDataSource.Text;
                int porta = int.Parse(TxtPorta.Text);
                string utilizador = TxtUtilizador.Text;
                string password = TxtPassword.Text;

                string connectioninfo = "datasource=" + DataSource + ";port=" + porta + ";username=" + utilizador + ";password=" + password + ";database=telemoveis;SslMode=none";

                conexao = new MySqlConnection(connectioninfo);
                conexao.Open();

                MessageBox.Show("Conexão com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(FrmTelemoveis.ActiveForm, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listaTelemóveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelemoveis newForm = new FrmTelemoveis();
            newForm.ShowDialog();
            this.Hide();
        }
    }
    
}