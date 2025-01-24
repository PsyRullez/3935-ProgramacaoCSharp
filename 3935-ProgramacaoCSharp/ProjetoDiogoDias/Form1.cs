using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Certifique-se de incluir esta linha

namespace ProjetoDiogoDias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = null;

            try
            {
                string connectionString = txtboxDataSource.Text; // Endereço do servidor
                string databaseName = txtBoxPort.Text; // Nome do banco de dados
                string username = txtBoxUser.Text; // Nome de usuário
                string password = txtBoxPassword.Text; // Senha

                // Corrigindo a string de conexão para MySQL
                string cnxnString = $"Server={connectionString};Database={databaseName};User ID={username};Password={password};";
                mySqlConnection = new MySqlConnection(cnxnString);
                mySqlConnection.Open();

                // Se a conexão for bem-sucedida
                LblDBstatus.Text = "Conectado";
                LblDBstatus.ForeColor = Color.Green; // Muda a cor do texto para verde
            }
            catch (MySqlException mySqlEx)
            {
                // Captura exceções específicas do MySQL
                MessageBox.Show($"Erro de MySQL: {mySqlEx.Message}");
                LblDBstatus.Text = "Desconectado"; // Atualiza o status para desconectado
                LblDBstatus.ForeColor = Color.Red; // Muda a cor do texto para vermelho
            }
            catch (Exception ex)
            {
                // Captura outras exceções
                MessageBox.Show($"Erro: {ex.Message}");
                LblDBstatus.Text = "Desconectado"; // Atualiza o status para desconectado
                LblDBstatus.ForeColor = Color.Red; // Muda a cor do texto para vermelho
            }
            finally
            {
                // Certifique-se de fechar a conexão se ela foi aberta
                if (mySqlConnection != null && mySqlConnection.State == System.Data.ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializa o status da conexão
            LblDBstatus.Text = "Desconectado";
            LblDBstatus.ForeColor = Color.Red; // Muda a cor do texto para vermelho
        }

        private void LblDBstatus_Click(object sender, EventArgs e)
        {
            // Você pode adicionar alguma lógica aqui se necessário
        }
    }
}