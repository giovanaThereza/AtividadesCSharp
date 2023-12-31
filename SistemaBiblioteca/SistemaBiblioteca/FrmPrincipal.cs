﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroAluno frmCadastroAluno = new FrmCadastroAluno();
            frmCadastroAluno.ShowDialog();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroLivro frmCadastroLivro = new FrmCadastroLivro(); 
            frmCadastroLivro.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void emprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmprestimo frmEmprestimo = new FrmEmprestimo();
            frmEmprestimo.ShowDialog();
        }
    }
}
