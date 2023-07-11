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
            this.LblTítulo = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblNumeroPgns = new System.Windows.Forms.Label();
            this.LblPreco = new System.Windows.Forms.Label();
            this.LblAnoPublic = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtNumeroPgns = new System.Windows.Forms.TextBox();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.TxtAnoPublic = new System.Windows.Forms.TextBox();
            this.LbLISBN = new System.Windows.Forms.Label();
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTítulo
            // 
            this.LblTítulo.AutoSize = true;
            this.LblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTítulo.Location = new System.Drawing.Point(29, 36);
            this.LblTítulo.Name = "LblTítulo";
            this.LblTítulo.Size = new System.Drawing.Size(46, 16);
            this.LblTítulo.TabIndex = 1;
            this.LblTítulo.Text = "Título";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.Location = new System.Drawing.Point(342, 36);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(43, 16);
            this.LblAutor.TabIndex = 2;
            this.LblAutor.Text = "Autor";
            this.LblAutor.Click += new System.EventHandler(this.LblAutor_Click);
            // 
            // LblNumeroPgns
            // 
            this.LblNumeroPgns.AutoSize = true;
            this.LblNumeroPgns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroPgns.Location = new System.Drawing.Point(29, 80);
            this.LblNumeroPgns.Name = "LblNumeroPgns";
            this.LblNumeroPgns.Size = new System.Drawing.Size(144, 16);
            this.LblNumeroPgns.TabIndex = 3;
            this.LblNumeroPgns.Text = "Número de Páginas";
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreco.Location = new System.Drawing.Point(304, 80);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(48, 16);
            this.LblPreco.TabIndex = 4;
            this.LblPreco.Text = "Preço";
            // 
            // LblAnoPublic
            // 
            this.LblAnoPublic.AutoSize = true;
            this.LblAnoPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnoPublic.Location = new System.Drawing.Point(35, 130);
            this.LblAnoPublic.Name = "LblAnoPublic";
            this.LblAnoPublic.Size = new System.Drawing.Size(138, 16);
            this.LblAnoPublic.TabIndex = 5;
            this.LblAnoPublic.Text = "Ano de Publicação";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(81, 30);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(232, 26);
            this.TxtTitulo.TabIndex = 7;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutor.Location = new System.Drawing.Point(391, 30);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(232, 26);
            this.TxtAutor.TabIndex = 8;
            // 
            // TxtNumeroPgns
            // 
            this.TxtNumeroPgns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroPgns.Location = new System.Drawing.Point(188, 74);
            this.TxtNumeroPgns.Name = "TxtNumeroPgns";
            this.TxtNumeroPgns.Size = new System.Drawing.Size(87, 26);
            this.TxtNumeroPgns.TabIndex = 9;
            // 
            // TxtPreco
            // 
            this.TxtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPreco.Location = new System.Drawing.Point(358, 74);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(100, 26);
            this.TxtPreco.TabIndex = 10;
            // 
            // TxtAnoPublic
            // 
            this.TxtAnoPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnoPublic.Location = new System.Drawing.Point(188, 124);
            this.TxtAnoPublic.Name = "TxtAnoPublic";
            this.TxtAnoPublic.Size = new System.Drawing.Size(87, 26);
            this.TxtAnoPublic.TabIndex = 11;
            // 
            // LbLISBN
            // 
            this.LbLISBN.AutoSize = true;
            this.LbLISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLISBN.Location = new System.Drawing.Point(449, 217);
            this.LbLISBN.Name = "LbLISBN";
            this.LbLISBN.Size = new System.Drawing.Size(42, 16);
            this.LbLISBN.TabIndex = 12;
            this.LbLISBN.Text = "ISBN";
            // 
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtISBN.Location = new System.Drawing.Point(506, 211);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(90, 26);
            this.TxtISBN.TabIndex = 13;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(12, 209);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(104, 41);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(137, 209);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(104, 41);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(260, 209);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 41);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(602, 209);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 32);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 170);
            this.dataGridView1.TabIndex = 20;
            // 
            // FrmCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.TxtISBN);
            this.Controls.Add(this.LbLISBN);
            this.Controls.Add(this.TxtAnoPublic);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.TxtNumeroPgns);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.LblAnoPublic);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.LblNumeroPgns);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblTítulo);
            this.Name = "FrmCadastroLivro";
            this.Text = "Cadastro de Livro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTítulo;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblNumeroPgns;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.Label LblAnoPublic;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtNumeroPgns;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.TextBox TxtAnoPublic;
        private System.Windows.Forms.Label LbLISBN;
        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}