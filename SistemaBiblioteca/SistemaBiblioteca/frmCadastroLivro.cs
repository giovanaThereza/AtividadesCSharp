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
        private SqlConnection conexaoDB;

        public FrmCadastroLivro()
        {
            InitializeComponent();

            //String de conexão
            conexaoString = "Data Source=MAR0625655W10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            //Inicializando a conexão com o Banco de Dados
            conexaoDB = new SqlConnection(conexaoString); 
        }



        private void FrmCadastroLivro_Load(object sender, EventArgs e)
        {
            CarregarDadosLivros();
        }

        private void CarregarDadosLivros()
        {
            try
            {
                conexaoDB.Open();
                string sql = "SELECT * FROM Livros";

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                DgvLivros.DataSource = dataTable;

                conexaoDB.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Livros(Titulo, Autor, Numeros_Pagianas,Preço,Ano_Public,ISBN) Values (@Titulo, @Autor, @Numeros_Pagianas, @Preço, @Ano_Public, @ISBN)";

                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);
                sqlCmd.Parameters.AddWithValue("@Titulo", TxtTitulo.Text);
                sqlCmd.Parameters.AddWithValue("@Autor", TxtAutor.Text);
                sqlCmd.Parameters.AddWithValue("@Numeros_Paginas", TxtNumeroPgns.Text);
                sqlCmd.Parameters.AddWithValue("@Preço",TxtPreco.Text);
                sqlCmd.Parameters.AddWithValue("@ISBN", TxtISBN.Text);
               
                DateTime Ano_public;
                DateTime.TryParse(TxtAno_Public.Text, out Ano_public);
                
                sqlCmd.Parameters.AddWithValue("@Ano_Public", Ano_public);

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com Sucesso!!");

                conexaoDB.Close();

                CarregarDadosLivros();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao inserir os Dados: " + ex);
            }
        }   

    }
}
