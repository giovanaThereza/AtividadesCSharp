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
    public partial class FrmCadastroAluno : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;
        public FrmCadastroAluno()
        {
            InitializeComponent();
            
            //String de conexão
            conexaoString = "Data Source=MAR0625655W10-1;Initial Catalog=Biblioteca;Integrated Security=True";
            
            //Inicializando a conexão com o Banco de Dados
            conexaoDB = new SqlConnection(conexaoString);
        }



        private void FrmCadastroAluno_Load(object sender, EventArgs e)
        {
            CarregarDadosAlunos();
        }


        private void CarregarDadosAlunos()
        {
            try
            {
                conexaoDB.Open();
                string sql = " SELECT * FROM Alunos";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DgvAlunos.DataSource = dataTable;

                conexaoDB.Close();



            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex);
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Alunos (Nome, CPF, Email, Telefone, Celular, Data_Nascimento) Values (@Nome, @CPF, @Email, @Telefone, @Celular, @Data_Nascimento)";
               
                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                sqlCmd.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                sqlCmd.Parameters.AddWithValue("@Email", TxtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@Telefone",TxtTelefone.Text);
                sqlCmd.Parameters.AddWithValue("@Celular", TxtCelular.Text);
                
                DateTime dataNascimento;
                DateTime.TryParse(TxtDataNascimento.Text, out dataNascimento);
                
                sqlCmd.Parameters.AddWithValue("@Data_Nascimento",dataNascimento);

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com Sucesso!!");

                conexaoDB.Close();

                CarregarDadosAlunos();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao inserir os Dados: " + ex);
            }
        }
    }
}
