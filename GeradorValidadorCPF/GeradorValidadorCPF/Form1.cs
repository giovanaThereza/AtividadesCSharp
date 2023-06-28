using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorValidadorCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnValidarCPF_Click(object sender, EventArgs e)
        {
            string numero = TxtCPF.Text.Trim();
            int i;
            int soma = 0, soma2 = 0, resto1 = 0, resto2 = 0;
            int[] vt = new int[11];
            int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] peso2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            if (!numero.All(char.IsDigit))
            {
                MessageBox.Show("Contém letras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numero.Length != 11)
            {
                MessageBox.Show("Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            vt = numero.Select(d => Convert.ToInt32(d.ToString())).ToArray();

            for (i = 0; i < 9; i++) 
            {
                soma += vt[i] * peso1[i];
                resto1 = (soma * 10) % 11;

                if (resto1 == 10 || resto1 == 11)
                {
                    resto1 = 0;
                }
            }

            for (i = 0; i < 10; i++) 
            {
                soma2 += vt[i] * peso2[i];
                resto2 = (soma2 * 10) % 11;

                if (resto2 == 10 || resto2 == 11)
                {
                    resto2 = 0;
                }
            }

            string CPFcru = string.Join("", vt);
            string CPFrenovado = $"{CPFcru.Substring(0, 3)}.{CPFcru.Substring(3, 3)}.{CPFcru.Substring(6, 3)}-{CPFcru.Substring(9, 2)}";

            if (TxtCPF.Text == "")
            {
                MessageBox.Show("Por favor preencha o campo com o seu CPF", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;               
            }

           

            if (resto1 == vt[9] || resto2 == vt[10]) // Validação
            {
                MessageBox.Show($"Seu CPF está aprovado: {CPFrenovado}", "Aceito", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Seu CPF está inválido: {CPFrenovado}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
