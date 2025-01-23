using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                string connectionString = txtboxDataSource.Text;
                int databaseName = int.Parse(txtBoxPort.Text);
                string username = txtBoxUser.Text;
                string password = txtBoxPassword.Text;

                string cnxnString = $"Data Source={connectionString};Initial Catalog={databaseName};User ID={username};Password={password} + dbcsharp";
                SqlConnection cnxn = new SqlConnection(cnxnString);
                SqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
