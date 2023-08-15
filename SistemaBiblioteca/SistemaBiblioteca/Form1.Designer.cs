namespace SistemaBiblioteca
{
    partial class FrmEmprestimo
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
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblNomelivro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MtxtDataRetirada = new System.Windows.Forms.MaskedTextBox();
            this.MtxtDataDevolução = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DvgLivro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DvgLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.Location = new System.Drawing.Point(26, 97);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(163, 24);
            this.lblNomeAluno.TabIndex = 0;
            this.lblNomeAluno.Text = "Nome do Aluno ";
            // 
            // lblNomelivro
            // 
            this.lblNomelivro.AutoSize = true;
            this.lblNomelivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomelivro.Location = new System.Drawing.Point(26, 198);
            this.lblNomelivro.Name = "lblNomelivro";
            this.lblNomelivro.Size = new System.Drawing.Size(153, 24);
            this.lblNomelivro.TabIndex = 1;
            this.lblNomelivro.Text = "Nome do Livro ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 31);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(30, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(474, 31);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data de Devolução ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data de Retirada ";
            // 
            // MtxtDataRetirada
            // 
            this.MtxtDataRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtDataRetirada.Location = new System.Drawing.Point(253, 333);
            this.MtxtDataRetirada.Mask = "00/00/0000";
            this.MtxtDataRetirada.Name = "MtxtDataRetirada";
            this.MtxtDataRetirada.Size = new System.Drawing.Size(127, 31);
            this.MtxtDataRetirada.TabIndex = 8;
            this.MtxtDataRetirada.ValidatingType = typeof(System.DateTime);
            // 
            // MtxtDataDevolução
            // 
            this.MtxtDataDevolução.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtDataDevolução.Location = new System.Drawing.Point(474, 333);
            this.MtxtDataDevolução.Mask = "00/00/0000";
            this.MtxtDataDevolução.Name = "MtxtDataDevolução";
            this.MtxtDataDevolução.Size = new System.Drawing.Size(135, 31);
            this.MtxtDataDevolução.TabIndex = 9;
            this.MtxtDataDevolução.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "Empréstimo ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Emprestar ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DvgLivro
            // 
            this.DvgLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgLivro.Location = new System.Drawing.Point(12, 402);
            this.DvgLivro.Name = "DvgLivro";
            this.DvgLivro.Size = new System.Drawing.Size(626, 198);
            this.DvgLivro.TabIndex = 12;
            // 
            // FrmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 612);
            this.Controls.Add(this.DvgLivro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MtxtDataDevolução);
            this.Controls.Add(this.MtxtDataRetirada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNomelivro);
            this.Controls.Add(this.lblNomeAluno);
            this.Name = "FrmEmprestimo";
            this.Text = "Emprestimo de Livro ";
            this.Load += new System.EventHandler(this.FrmEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblNomelivro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MtxtDataRetirada;
        private System.Windows.Forms.MaskedTextBox MtxtDataDevolução;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DvgLivro;
    }
}