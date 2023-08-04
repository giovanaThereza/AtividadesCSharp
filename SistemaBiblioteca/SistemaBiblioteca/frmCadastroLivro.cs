using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmCadastroLivro : Form
    {
        public string conexaoString;
        private SqlConnection ConexaoDB;
        DataGridViewRow linhaSelecionada;

        public FrmCadastroLivro()
        {
            InitializeComponent();

            //String de conexão

            conexaoString = "Data Source=MAR0625655W10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            //Inicializando a conexão com o Banco de dados
            ConexaoDB = new SqlConnection(conexaoString);

        }

        public void CarregarDadosLivros(int id = 0)
        {
            try
            {
                ConexaoDB.Open();
                
                string sql;

                if (id == 0)
                {
                    sql = "SELECT * FROM livros";
                }
                else
                {
                    sql = "SELECT * FROM livros WHERE id=" + id;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sql, ConexaoDB);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataTable.Columns["numeros_paginas"].ColumnName = "N° Página";
                dataTable.Columns["preco"].ColumnName = "Preço";
                dataTable.Columns["ano_public"].ColumnName = "Ano_Public";
                dataTable.Columns["titulo"].ColumnName = "Título";
                dataTable.Columns["Autor"].ColumnName = "Autor";
                dataTable.Columns["isbn"].ColumnName = "ISBN";
                dataTable.Columns["id"].ColumnName = "ID";

                dgvLivro.DataSource = dataTable;

                ConexaoDB.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex);
            }
        }

        private void FrmCadastroLivro_Load(object sender, EventArgs e)
        {
            CarregarDadosLivros();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Livros (titulo, autor, numeros_paginas, preco, ano_public, isbn) " +
                         "VALUES (@titulo, @autor, @numeros_paginas, @preco, @ano_public, @isbn)";

            try
            {
                SqlCommand sqlCmd = new SqlCommand(sql, ConexaoDB);

                sqlCmd.Parameters.AddWithValue("@titulo", TxtTitulo.Text);
                sqlCmd.Parameters.AddWithValue("@autor", TxtAutor.Text);
                sqlCmd.Parameters.AddWithValue("@numeros_paginas", Convert.ToInt32(TxtNumeroPagina.Text));
                sqlCmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(TxtPreco.Text));
                sqlCmd.Parameters.AddWithValue("@ano_public", TxtAnoPublic.Text);
                sqlCmd.Parameters.AddWithValue("@isbn", TxtISBN.Text);

                ConexaoDB.Open();
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");

                ConexaoDB.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar os dados: " + ex);
            }
        }

        private void dgvLivro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                linhaSelecionada = dgvLivro.Rows[e.RowIndex];

                TxtISBN.Text = linhaSelecionada.Cells["ISBN"].Value.ToString();
                TxtTitulo.Text = linhaSelecionada.Cells["Título"].Value.ToString();
                TxtAutor.Text = linhaSelecionada.Cells["Autor"].Value.ToString();
                TxtNumeroPagina.Text = linhaSelecionada.Cells["N° Página"].Value.ToString();
                TxtPreco.Text = linhaSelecionada.Cells["Preço"].Value.ToString();
                TxtAnoPublic.Text = linhaSelecionada.Cells["Ano_Public"].Value.ToString();

                btnAdicionar.Enabled = false;
                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (linhaSelecionada != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja exlcuir o livro", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    try
                    {
                        int id = Convert.ToInt32(linhaSelecionada.Cells["id"].Value.ToString());

                        string sql = "DELETE FROM Livros " +
                                     "WHERE id=@id";

                        ConexaoDB.Open();

                        SqlCommand sqlCmd = new SqlCommand(sql, ConexaoDB);

                        sqlCmd.Parameters.AddWithValue("@id", id);
                        sqlCmd.ExecuteNonQuery();

                        MessageBox.Show("Livro excluido com Sucesso!!!");

                        ConexaoDB.Close();

                        CarregarDadosLivros();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao Excluir os Dados: " + ex);
                    }

                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(linhaSelecionada.Cells["id"].Value.ToString());

                string sql = "UPDATE Livros SET " +
                    "titulo=@titulo, " +
                    "autor=@autor, " +
                    "numeros_paginas=@numeros_paginas, " +
                    "preco=@preco, " +
                    "ano_public=@ano_public, " +
                    "isbn=@isbn" +
                    "WHERE id=@id";

                ConexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, ConexaoDB);

                sqlCmd.Parameters.AddWithValue("@id", id);
                sqlCmd.Parameters.AddWithValue("@titulo", TxtTitulo.Text);
                sqlCmd.Parameters.AddWithValue("@autor", TxtAutor.Text);
                sqlCmd.Parameters.AddWithValue("@numeros_paginas", TxtNumeroPagina.Text);
                sqlCmd.Parameters.AddWithValue("@preco", TxtPreco.Text);
                sqlCmd.Parameters.AddWithValue("@ano_public", TxtAnoPublic.Text);
                sqlCmd.Parameters.AddWithValue("@isbn", TxtISBN.Text);

                MessageBox.Show("Atualização Realizada com Sucesso!!!");

                ConexaoDB.Close();

                CarregarDadosLivros();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Atualizar os Dados: " + ex);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(tXtPesquisar.Text, out id))
            {
                CarregarDadosLivros(id);
            }
            else
            {
                MessageBox.Show("Código do aluno inválido");
            }
        }

        private void tXtPesquisar_KeyUp(object sender, EventArgs e)
        {
            CarregarDadosLivros();
        }
    }
    
}
