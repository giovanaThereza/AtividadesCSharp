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
    public partial class FrmEmprestimo : Form
    {
        public string conexaoString;
        private SqlConnection ConexaoDB;
        DataGridViewRow linhaSeleionada;


        public FrmEmprestimo()
        {
            InitializeComponent();

            conexaoString = "Data Source=MAR0625655W10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            ConexaoDB = new SqlConnection(conexaoString);
        }

       


        private void FrmEmprestimo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
