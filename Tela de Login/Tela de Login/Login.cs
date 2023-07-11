using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_de_Login
{
    public partial class BuscaTec : Form
    {
        List<string> listaLogin = new List<string>();
        List<string> listaSenha = new List<string>();
       
        public BuscaTec()
        {
            InitializeComponent();
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            listaLogin.Add(TxtDigiteLogin.Text);
            listaSenha.Add(TxtSenha.Text);

            MessageBox.Show("Login ou Senha Salvos", "Deu bom!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        { 

            string Login = TxtDigiteLogin.Text;
            string Senha = TxtSenha.Text;

            if (listaLogin.Contains(Login) && listaSenha.Contains(Senha))
            {
                MessageBox.Show("Login Efetuado", "Amém", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login ou senha inválido", "Deu ruim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
