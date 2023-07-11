namespace SistemaBiblioteca
{
    partial class FrmCadastroAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblCPF = new System.Windows.Forms.Label();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.TxtDataNascimento = new System.Windows.Forms.TextBox();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.LblCelular = new System.Windows.Forms.Label();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnExibir = new System.Windows.Forms.Button();
            this.BtnAtualuzar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.LblCodCliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(39, 50);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(48, 16);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(113, 44);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(280, 26);
            this.TxtNome.TabIndex = 1;
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCPF.Location = new System.Drawing.Point(430, 50);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(36, 16);
            this.LblCPF.TabIndex = 2;
            this.LblCPF.Text = "CPF";
            // 
            // TxtCPF
            // 
            this.TxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCPF.Location = new System.Drawing.Point(486, 44);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(183, 26);
            this.TxtCPF.TabIndex = 3;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(41, 112);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(46, 16);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(113, 102);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(280, 26);
            this.TxtEmail.TabIndex = 5;
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataNascimento.Location = new System.Drawing.Point(430, 108);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(148, 16);
            this.LblDataNascimento.TabIndex = 6;
            this.LblDataNascimento.Text = "Data de Nascimento";
            this.LblDataNascimento.Click += new System.EventHandler(this.LblDataNascimento_Click);
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataNascimento.Location = new System.Drawing.Point(595, 102);
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.Size = new System.Drawing.Size(194, 26);
            this.TxtDataNascimento.TabIndex = 7;
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefone.Location = new System.Drawing.Point(26, 164);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(69, 16);
            this.LblTelefone.TabIndex = 8;
            this.LblTelefone.Text = "Telefone";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefone.Location = new System.Drawing.Point(113, 158);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(207, 26);
            this.TxtTelefone.TabIndex = 9;
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCelular.Location = new System.Drawing.Point(347, 164);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(56, 16);
            this.LblCelular.TabIndex = 10;
            this.LblCelular.Text = "Celular";
            // 
            // TxtCelular
            // 
            this.TxtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.Location = new System.Drawing.Point(421, 158);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(199, 26);
            this.TxtCelular.TabIndex = 11;
            this.TxtCelular.TextChanged += new System.EventHandler(this.TxtCelular_TextChanged);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.Location = new System.Drawing.Point(29, 244);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(93, 39);
            this.BtnAdicionar.TabIndex = 12;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            // 
            // BtnExibir
            // 
            this.BtnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExibir.Location = new System.Drawing.Point(252, 244);
            this.BtnExibir.Name = "BtnExibir";
            this.BtnExibir.Size = new System.Drawing.Size(93, 39);
            this.BtnExibir.TabIndex = 13;
            this.BtnExibir.Text = "Exibir";
            this.BtnExibir.UseVisualStyleBackColor = true;
            // 
            // BtnAtualuzar
            // 
            this.BtnAtualuzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualuzar.Location = new System.Drawing.Point(139, 244);
            this.BtnAtualuzar.Name = "BtnAtualuzar";
            this.BtnAtualuzar.Size = new System.Drawing.Size(93, 39);
            this.BtnAtualuzar.TabIndex = 14;
            this.BtnAtualuzar.Text = "Atualizar";
            this.BtnAtualuzar.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.Location = new System.Drawing.Point(789, 244);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(93, 39);
            this.BtnPesquisar.TabIndex = 15;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisa.Location = new System.Drawing.Point(558, 249);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(201, 26);
            this.TxtPesquisa.TabIndex = 16;
            // 
            // LblCodCliente
            // 
            this.LblCodCliente.AutoSize = true;
            this.LblCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodCliente.Location = new System.Drawing.Point(444, 255);
            this.LblCodCliente.Name = "LblCodCliente";
            this.LblCodCliente.Size = new System.Drawing.Size(87, 16);
            this.LblCodCliente.TabIndex = 17;
            this.LblCodCliente.Text = "Cod.Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 211);
            this.dataGridView1.TabIndex = 18;
            // 
            // FrmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblCodCliente);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnAtualuzar);
            this.Controls.Add(this.BtnExibir);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.LblCelular);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.TxtDataNascimento);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Name = "FrmCadastroAluno";
            this.Text = "Cadastro de Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.TextBox TxtDataNascimento;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnExibir;
        private System.Windows.Forms.Button BtnAtualuzar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label LblCodCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

