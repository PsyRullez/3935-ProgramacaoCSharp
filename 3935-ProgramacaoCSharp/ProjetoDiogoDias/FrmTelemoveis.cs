using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPedro
{
    public partial class FrmTelemoveis : Form
    {

        MySqlConnection conexao;
        List<Marca> listamarcas;
        BindingList<Telemoveis> listatelemoveis;

        bool inserir = false;
        public FrmTelemoveis()
        {
            InitializeComponent();
        }

        private Marca RetornaMarca(int idtabmarca)
        {
            foreach (Marca marca in listamarcas)
            {

                if (marca.getidtabmarcas == idtabmarca)
                    return marca;
            }

            return null;
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void baseDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            this.Close();
            newForm1.ShowDialog();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            TxtTamanho.Text = "";
            TxtLancamento.Text = "";
            TxtModelo.Text = "";
            TxtPreco.Text = "";
            CboMarcas.SelectedIndex = -1;
            PbTelemoveis.Image = null;


        }

        private void PreencheCombo(object sender, EventArgs e)
        {
            listamarcas = new List<Marca>();
            string sql = "select * from tabmarcas";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Marca marca = new Marca(reader.GetInt32("idtabmarcas"), reader.GetString("Marca"));
                        listamarcas.Add(marca);
                    }
                }


            }
            CboMarcas.DisplayMember = "Detalhes";
            CboMarcas.DataSource = listamarcas;

        }

        private void Listatelemoveis()
        {
            string sql = "select * from tabtelemoveis";
            listatelemoveis = new BindingList<Telemoveis>();

            using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listatelemoveis.Add(new Telemoveis(reader.GetInt32("idtabtelemoveis"),
                                             RetornaMarca(reader.GetInt32("idtabmarca")),
                                             reader.GetString("modelo"),
                                             reader.GetInt16("tamanho"),
                                             reader.GetInt16("ano"),
                                             reader.GetFloat("preco"),
                                             reader.GetString("detalhes"),
                                            (byte[])reader["foto"]));
                    }
                }
            }

            Dgvtelemoveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgvtelemoveis.EditMode = DataGridViewEditMode.EditProgrammatically;
            Dgvtelemoveis.MultiSelect = false;
            Dgvtelemoveis.DataSource = listatelemoveis;
            Dgvtelemoveis.Columns[0].Visible = false;
            Dgvtelemoveis.Columns[7].Visible = false;
            Dgvtelemoveis.Columns[3].Width = 80;
            Dgvtelemoveis.Columns[4].Width = 80;
            Dgvtelemoveis.Columns[5].Width = 80;

        }

        private void PbTelemoveis_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagem = new OpenFileDialog();
            imagem.InitialDirectory = Directory.GetCurrentDirectory() + @"\imagens";
            imagem.Filter = "Imagens (*.jpg) | *.jpg | Imagens (*.png) | *.png";

            if (imagem.ShowDialog() == DialogResult.OK)
            {
                Bitmap foto = new Bitmap(imagem.OpenFile());
                PbTelemoveis.Image = foto;
                PbTelemoveis.ImageLocation = imagem.FileName;

            }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgvtelemoveis.SelectedRows.Count > 0)
                {
                    int nRow = Dgvtelemoveis.SelectedRows[0].Index;
                    Telemoveis telemoveis = (Telemoveis)Dgvtelemoveis.SelectedRows[0].DataBoundItem;
                    string sql = "delete from tabtelemoveis where idtabtelemoveis=@idtabtelemoveis";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idtabtelemoveis", telemoveis.Idtabtelemoveis);

                        int nRegistos = cmd.ExecuteNonQuery();
                        MessageBox.Show("Registo Eliminado: " + nRegistos, "Informação");

                        if (nRegistos == 1)
                        {

                            listatelemoveis.Remove(telemoveis);
                            Dgvtelemoveis.Refresh();

                            if (nRow > 0)
                            {
                                Dgvtelemoveis.Rows[nRow - 1].Selected = true;
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (inserir)
                {
                    string sql = "insert into tabtelemoveis values(0, @idtabmarca, @modelo, @tamanho, @ano, @preco, @detalhes, @foto)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idtabmarca", ((Marca)CboMarcas.SelectedItem).getidtabmarcas);
                        cmd.Parameters.AddWithValue("@modelo", TxtModelo.Text);
                        cmd.Parameters.AddWithValue("@tamanho", TxtTamanho.Text);
                        cmd.Parameters.AddWithValue("@ano", TxtLancamento.Text);
                        cmd.Parameters.AddWithValue("@preco", TxtPreco.Text);
                        cmd.Parameters.AddWithValue("@detalhes", TxtDetalhes.Text);
                        cmd.Parameters.AddWithValue("@foto", File.ReadAllBytes(PbTelemoveis.ImageLocation));

                        int nRegistos = cmd.ExecuteNonQuery();
                        MessageBox.Show("Registos inseridos: " + nRegistos, "Informação");

                        if (nRegistos > 0)
                        {
                            listatelemoveis.Add(new Telemoveis((int)cmd.LastInsertedId,
                                                                (Marca)CboMarcas.SelectedItem,
                                                                TxtModelo.Text,
                                                                int.Parse(TxtTamanho.Text),
                                                                int.Parse(TxtLancamento.Text),
                                                                int.Parse(TxtPreco.Text),
                                                                TxtDetalhes.Text,
                                                                File.ReadAllBytes(PbTelemoveis.ImageLocation)));
                            Dgvtelemoveis.Refresh();
                            Dgvtelemoveis.Rows[Dgvtelemoveis.Rows.Count - 1].Selected = true;
                        }

                    }
                }
                else
                {
                    if (Dgvtelemoveis.SelectedRows.Count > 0)
                    {
                        Telemoveis telemoveis = (Telemoveis)Dgvtelemoveis.SelectedRows[0].DataBoundItem;
                        string sql = "update tabtelemoveis set idtabmarca=@idTabMarca," +
                                     "Modelo=@modelo," +
                                     "Tamanho=@tamanho," +
                                     "Ano=@ano" +
                                     "Preo=@preco" +
                                     "Deatlhes=@detalhes" +
                                     "Imagem=@imagem" +
                                     " where idtabtelemoveis=@idtabtelemoveis";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                        {
                            cmd.Parameters.AddWithValue("@idtabtelemoveis", telemoveis.Idtabtelemoveis);
                            cmd.Parameters.AddWithValue("@idtabmarca", ((Marca)CboMarcas.SelectedItem).getidtabmarcas);
                            cmd.Parameters.AddWithValue("@modelo", TxtModelo.Text);
                            cmd.Parameters.AddWithValue("@tamanho", TxtTamanho.Text);
                            cmd.Parameters.AddWithValue("@ano", TxtLancamento.Text);
                            cmd.Parameters.AddWithValue("@preco", TxtPreco.Text);
                            cmd.Parameters.AddWithValue("@detalhes", TxtDetalhes.Text);   
                            cmd.Parameters.AddWithValue("@foto", (PbTelemoveis.ImageLocation != null) ? File.ReadAllBytes(PbTelemoveis.ImageLocation) : telemoveis.Imagem);

                            int nRegistos = cmd.ExecuteNonQuery();
                            MessageBox.Show("Registos Atualizados: " + nRegistos, "Informação");

                            if (nRegistos > 0)
                            {
                                telemoveis.MarcaTele = (Marca)CboMarcas.SelectedItem;
                                telemoveis.Modelo = TxtModelo.Text;
                                telemoveis.Tamanho = int.Parse(TxtTamanho.Text);
                                telemoveis.Ano = int.Parse(TxtLancamento.Text);
                                telemoveis.Preco = float.Parse(TxtPreco.Text);
                                telemoveis.Detalhes = TxtDetalhes.Text;
                                telemoveis.Imagem = (PbTelemoveis.ImageLocation != null) ? File.ReadAllBytes(PbTelemoveis.ImageLocation) : telemoveis.Imagem;
                                Dgvtelemoveis.Refresh();
                            }
                        }

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Erros"); }
        }
        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            Dgvtelemoveis.Focus();
            if (listatelemoveis.Count > 0)
            {
                Dgvtelemoveis.CurrentCell = Dgvtelemoveis.Rows[0].Cells[0];
                Dgvtelemoveis.Rows[0].Selected = true;
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            Dgvtelemoveis.Focus();
            if (Dgvtelemoveis.SelectedRows.Count > 0)
            {
                int indexRow = Dgvtelemoveis.Rows[0].Index;
               
                if (indexRow > 0)
                {
                    Dgvtelemoveis.CurrentCell = Dgvtelemoveis.Rows[indexRow - 1].Cells[0];
                    Dgvtelemoveis.Rows[indexRow - 1].Selected = true;
                }
            }
        }

        private void BtnSeguinte_Click(object sender, EventArgs e)
        {
            Dgvtelemoveis.Focus();
            if (Dgvtelemoveis.SelectedRows.Count > 0)
            {
                int indexRow = Dgvtelemoveis.Rows[0].Index;

                if (indexRow > 0)
                {
                    Dgvtelemoveis.CurrentCell = Dgvtelemoveis.Rows[indexRow + 1].Cells[0];
                    Dgvtelemoveis.Rows[indexRow + 1].Selected = true;
                }
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            Dgvtelemoveis.Focus();
            if (listatelemoveis.Count > 0)
            {
                Dgvtelemoveis.CurrentCell = Dgvtelemoveis.Rows[listatelemoveis.Count - 1].Cells[0];
                Dgvtelemoveis.Rows[0].Selected = true;
            }
        }

        private void Dgvtelemoveis_SelectionChanged(object sender, EventArgs e)
        {
            if(Dgvtelemoveis.SelectedRows.Count > 0)
            {
                Telemoveis telemoveis = (Telemoveis)Dgvtelemoveis.SelectedRows[0].DataBoundItem;

                CboMarcas.SelectedItem = telemoveis.MarcaTele;
                TxtModelo.Text = telemoveis.Modelo;
                TxtTamanho.Text = telemoveis.Tamanho.ToString();
                TxtLancamento.Text = telemoveis.Ano.ToString();
                TxtPreco.Text = telemoveis.Preco.ToString();
                TxtDetalhes.Text = telemoveis.Detalhes;

                if (telemoveis.Imagem != null)
                {
                    PbTelemoveis.Image = new Bitmap(new MemoryStream(telemoveis.Imagem));
                }

                else
                    PbTelemoveis.Image = null;
                inserir = false;
            }


        }
    }
}

