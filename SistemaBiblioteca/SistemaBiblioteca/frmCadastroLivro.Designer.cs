namespace SistemaBiblioteca
{
    partial class FrmCadastroLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.tXtPesquisar = new System.Windows.Forms.TextBox();
            this.LblCodlivro = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.LblPreço = new System.Windows.Forms.Label();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblNumeros_pgs = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TxtNumeroPagina = new System.Windows.Forms.TextBox();
            this.LblAnoPublic = new System.Windows.Forms.Label();
            this.lbliSbn = new System.Windows.Forms.Label();
            this.TxtAnoPublic = new System.Windows.Forms.MaskedTextBox();
            this.TxtISBN = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(639, 208);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 34);
            this.btnPesquisar.TabIndex = 40;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(228, 208);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 34);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(125, 208);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(97, 34);
            this.btnAtualizar.TabIndex = 38;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvLivro
            // 
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Location = new System.Drawing.Point(21, 261);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.Size = new System.Drawing.Size(714, 177);
            this.dgvLivro.TabIndex = 37;
            this.dgvLivro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivro_CellContentClick);
            // 
            // tXtPesquisar
            // 
            this.tXtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tXtPesquisar.Location = new System.Drawing.Point(535, 211);
            this.tXtPesquisar.Name = "tXtPesquisar";
            this.tXtPesquisar.Size = new System.Drawing.Size(89, 26);
            this.tXtPesquisar.TabIndex = 36;

            // 
            // LblCodlivro
            // 
            this.LblCodlivro.AutoSize = true;
            this.LblCodlivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodlivro.Location = new System.Drawing.Point(452, 217);
            this.LblCodlivro.Name = "LblCodlivro";
            this.LblCodlivro.Size = new System.Drawing.Size(77, 16);
            this.LblCodlivro.TabIndex = 35;
            this.LblCodlivro.Text = "Cod. Livro";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(22, 208);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(97, 34);
            this.btnAdicionar.TabIndex = 34;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // TxtPreco
            // 
            this.TxtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPreco.Location = new System.Drawing.Point(421, 55);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(119, 26);
            this.TxtPreco.TabIndex = 33;
            // 
            // LblPreço
            // 
            this.LblPreço.AutoSize = true;
            this.LblPreço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreço.Location = new System.Drawing.Point(367, 61);
            this.LblPreço.Name = "LblPreço";
            this.LblPreço.Size = new System.Drawing.Size(48, 16);
            this.LblPreço.TabIndex = 32;
            this.LblPreço.Text = "Preço";
            // 
            // TxtAutor
            // 
            this.TxtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutor.Location = new System.Drawing.Point(421, 15);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(176, 26);
            this.TxtAutor.TabIndex = 31;
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.Location = new System.Drawing.Point(372, 21);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(43, 16);
            this.LblAutor.TabIndex = 30;
            this.LblAutor.Text = "Autor";
            // 
            // LblNumeros_pgs
            // 
            this.LblNumeros_pgs.AutoSize = true;
            this.LblNumeros_pgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeros_pgs.Location = new System.Drawing.Point(41, 65);
            this.LblNumeros_pgs.Name = "LblNumeros_pgs";
            this.LblNumeros_pgs.Size = new System.Drawing.Size(136, 16);
            this.LblNumeros_pgs.TabIndex = 28;
            this.LblNumeros_pgs.Text = "Número de Página";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(106, 15);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(205, 26);
            this.TxtTitulo.TabIndex = 27;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(41, 21);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(46, 16);
            this.LblTitulo.TabIndex = 26;
            this.LblTitulo.Text = "Título";
            // 
            // TxtNumeroPagina
            // 
            this.TxtNumeroPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroPagina.Location = new System.Drawing.Point(197, 59);
            this.TxtNumeroPagina.Name = "TxtNumeroPagina";
            this.TxtNumeroPagina.Size = new System.Drawing.Size(89, 26);
            this.TxtNumeroPagina.TabIndex = 25;
            // 
            // LblAnoPublic
            // 
            this.LblAnoPublic.AutoSize = true;
            this.LblAnoPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnoPublic.Location = new System.Drawing.Point(41, 109);
            this.LblAnoPublic.Name = "LblAnoPublic";
            this.LblAnoPublic.Size = new System.Drawing.Size(138, 16);
            this.LblAnoPublic.TabIndex = 24;
            this.LblAnoPublic.Text = "Ano de Publicação";
            // 
            // lbliSbn
            // 
            this.lbliSbn.AutoSize = true;
            this.lbliSbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliSbn.Location = new System.Drawing.Point(367, 109);
            this.lbliSbn.Name = "lbliSbn";
            this.lbliSbn.Size = new System.Drawing.Size(42, 16);
            this.lbliSbn.TabIndex = 22;
            this.lbliSbn.Text = "ISBN";
            // 
            // TxtAnoPublic
            // 
            this.TxtAnoPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnoPublic.Location = new System.Drawing.Point(197, 105);
            this.TxtAnoPublic.Name = "TxtAnoPublic";
            this.TxtAnoPublic.Size = new System.Drawing.Size(121, 26);
            this.TxtAnoPublic.TabIndex = 41;
            this.TxtAnoPublic.ValidatingType = typeof(System.DateTime);
            // 
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtISBN.Location = new System.Drawing.Point(421, 103);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(205, 26);
            this.TxtISBN.TabIndex = 42;
            // 
            // FrmCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.TxtISBN);
            this.Controls.Add(this.TxtAnoPublic);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvLivro);
            this.Controls.Add(this.tXtPesquisar);
            this.Controls.Add(this.LblCodlivro);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.LblPreço);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblNumeros_pgs);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtNumeroPagina);
            this.Controls.Add(this.LblAnoPublic);
            this.Controls.Add(this.lbliSbn);
            this.Name = "FrmCadastroLivro";
            this.Text = "Cadastro de Livro";
            this.Load += new System.EventHandler(this.FrmCadastroLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.TextBox tXtPesquisar;
        private System.Windows.Forms.Label LblCodlivro;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.Label LblPreço;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblNumeros_pgs;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TextBox TxtNumeroPagina;
        private System.Windows.Forms.Label LblAnoPublic;
        private System.Windows.Forms.Label lbliSbn;
        private System.Windows.Forms.MaskedTextBox TxtAnoPublic;
        private System.Windows.Forms.MaskedTextBox TxtISBN;
    }
}