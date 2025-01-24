using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog20DiogoDias
{
    public partial class RFMinsert : Form
    {
        public RFMinsert()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
            //return to the login form
            FrmLogin login = new();
            login.ShowDialog();

        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
