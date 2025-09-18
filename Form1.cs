using System;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        string connString = "server=localhost;username=root;" +
                                   "password=;database=agenda";
        public Form1()
        {
            InitializeComponent();
            lstContatos.View = View.Details;
            lstContatos.Columns.Add("ID", 50);
            lstContatos.Columns.Add("Nome", 150);
            lstContatos.Columns.Add("Telefone", 100);
            lstContatos.Columns.Add("Email", 150);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(connString);
                string sql = "INSERT INTO contatos (nome, telefone, email) " +
                             "VALUES ('" + txtNome.Text + "','" + txtTelefone.Text + "','" + txtEmail.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Contato salvo com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o contato!!! \n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "'" + txtLocalizar.Text + "'";

                conexao = new MySqlConnection(connString);
                string sql = "SELECT * FROM contatos WHERE nome LIKE " + query + " OR telefone LIKE " + query + " OR email LIKE " + query + "OR id LIKE " + query;

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                lstContatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader["id"].ToString(),
                        reader["nome"].ToString(),
                        reader["telefone"].ToString(),
                        reader["email"].ToString()
                    };
                    var listViewItem = new ListViewItem(row);

                    lstContatos.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar registro no banco!!! \n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }

        private void btnAtualuzar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(connString);

                string sql = "UPDATE contatos SET nome = '" + txtNome.Text + "', telefone = '" + txtTelefone.Text + "', email = '" + txtEmail.Text + "' WHERE id = " + txtID.Text;

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@id", txtID.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
                MessageBox.Show("Contato atualizado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o contato!!! \n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(connString);

                string sql = "DELETE FROM contatos WHERE id = @id";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", txtID.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
                MessageBox.Show("Contato apagado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar o contato!!! \n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}