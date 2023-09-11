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

namespace BuscaTec_Cadastro
{
    public partial class Tela_de_Login : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;

        public Tela_de_Login()
        {
            InitializeComponent();

            conexaoString = "Data Source = MAR0625655W10 - 1; Initial Catalog = DB_OFICIAL; Integrated Security = True";

            conexaoDB = new SqlConnection(conexaoString);
        }

        public void CarregarDadosLogin (int id = 0)
        {
            try
            {
                conexaoDB.Open();

                string sql;

                if (id == 0)
                {
                    sql = "SELECT * FROM User ";
                }
                else
                {
                    sql = "SLECT * FROM User WHERE ID_User=" + id;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataTable.Columns["Name"].ColumnName = "Nome";
                dataTable.Columns["Password"].ColumnName = "Senha";
                dataTable.Columns["CPF"].ColumnName = "CPF";
                dataTable.Columns["Email"].ColumnName = "E-mail";
                dataTable.Columns["CEP"].ColumnName = "CEP";
                dataTable.Columns["Fone"].ColumnName = "Telefone";
                dataTable.Columns[""].ColumnName = "";
            }
            catch{
            
            }
        }
    }
}
