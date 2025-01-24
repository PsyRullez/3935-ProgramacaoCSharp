using MySqlConnector;

namespace Prog20DiogoDias
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            dbHostTxtbox.Text = "localhost";
            dbPortTxtbox.Text = "3306";
            dbUserTxtbox.Text = "root";
            dbNameTxtBox.Text = "login_db";
            dbPassTxtbox.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = $"Server={dbHostTxtbox.Text};Port={dbPortTxtbox.Text};Database={dbNameTxtBox.Text};Uid={dbUserTxtbox.Text};Pwd={dbPassTxtbox.Text};";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                conn.Close();
                MessageBox.Show("Connection successful!");
                this.Hide();
                RFMinsert rfm = new();
                rfm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        private void lbl_dbState_Click(object sender, EventArgs e)
        {

        }


        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
