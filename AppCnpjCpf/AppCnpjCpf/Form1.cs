using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCnpjCpf
{
    public partial class TxtAppSelecionar : Form
    {
        public TxtAppSelecionar()
        {
            InitializeComponent();
        }

        private void BntValidar_Click(object sender, EventArgs e)
        {
            if (RDBntCPF.Checked)
            {
                //Parte do CPF
                string numero = TxtDigiteOpcao.Text.Trim();
                int i;
                int soma = 0, soma2 = 0, resto1 = 0, resto2 = 0;
                int[] vt = new int[11];
                int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] peso2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                if (numero.Length != 14)
                {
                    MessageBox.Show("CPF Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                numero = numero.Replace(".", "").Replace("-", "").Replace("/", "");
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

                char digito1 = numero[9];
                char digito2 = numero[10];
                char dig1 = Convert.ToChar(vt[9].ToString());
                char dig2 = Convert.ToChar(vt[10].ToString());

                if (dig1 == digito1 && dig2 == digito2) // Validação
                {
                    MessageBox.Show($"Seu CPF está aprovado: {CPFrenovado}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

                // Parte do CNPJ 
                if (RDBntCNPJ.Checked)
                {
                    string CNPJ = TxtDigiteOpcao.Text;
                    int ii;
                    int somas = 0, somas2 = 0;
                    int[] vtr = new int[14];
                    int[] multipd = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int[] multisd = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

               
                   CNPJ = CNPJ.Replace(".", "").Replace("-", "").Replace("/", "");   
                     
                    // Remover caracteres especiais

                    if (CNPJ.Length != 14)
                    {
                       MessageBox.Show("CNPJ Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                       return;
                    }
                       
                    
                    for(ii = 0 ; ii < 14; ii++){

                        vtr[ii] = int.Parse(CNPJ[ii].ToString());
                    }

                    for (ii = 0; ii < 12; ii++) //Primeiro Dígito
                    {
                        somas += vtr[ii] * multipd[ii];
                    }

                    int div = somas % 11;

                    if(div < 2)
                    {
                        vtr[12] = 0;
                    }
                    else
                    {
                        vtr[12] = 11 - div;
                    }
                    


                    for (ii = 0; ii < 13; ii++) //Segundo Dígito
                    {
                        somas2 += vtr[ii] * multisd[ii];

                    }

                    int div2 = somas2 % 11;
                    
                    if(div2 < 2)
                    {
                        vtr[13] = 0;
                    }
                    else
                    {
                        vtr[13] = 11 - div2;
                    }


                    char digito1 = CNPJ[12];
                    char digito2 = CNPJ[13];
                    char dig1 = Convert.ToChar(vtr[12].ToString());
                    char dig2 = Convert.ToChar(vtr[13].ToString());

                    string CNPJAntigo = string.Join("", vtr);
                    string CNPJRenovado = $"{CNPJAntigo.Substring(0, 2)}.{CNPJAntigo.Substring(2, 3)}.{CNPJAntigo.Substring(5, 3)}/{CNPJAntigo.Substring(8, 4)}-{CNPJAntigo.Substring(12, 2)}";

                    if (dig1 == digito1 && dig2 == digito2) //Validação
                    {
                        MessageBox.Show("Seu CNPJ está aprovado", "Aprovado", MessageBoxButtons.OK, MessageBoxIcon.Information);                     
                    }               
                }
               

        }

       private void TxtDigiteOpcao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '/' && e.KeyChar != '-')
            {
                
                e.Handled = true; // Impede a digitação de caracteres não numéricos
            }
        }

        private void BntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validarCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btngerar.Hide();
            BntValidar.Show();  
        }

        private void geradorCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BntValidar.Hide();
            Btngerar.Show();
        }

        private void Btngerar_Click(object sender, EventArgs e)
        {
            int[] cpf = new int[11];

            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                cpf[i] = random.Next (0, 9);
            }

            int Soma = 0;
            for (int i = 0; i < 9; i++)
            {
                Soma += cpf[i] * (10 - i);
            }
            int primeiroDigito = 11 - (Soma % 11);
            if (primeiroDigito > 9)
            {
                primeiroDigito = 0;
            }
            cpf[9] = primeiroDigito;


            for (int i = 0; i < 10; i++)
            {
                Soma += cpf[i] * (10 - i);
            }
            int segundoDigito = 11 - (Soma % 11);
            if (segundoDigito > 9)
            {
                segundoDigito = 0;
            }
            cpf[10] = segundoDigito;

            string Cpf = string.Join("", cpf);
            Cpf = Cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            TxtDigiteOpcao.Text = Cpf;
        }
    }
}
