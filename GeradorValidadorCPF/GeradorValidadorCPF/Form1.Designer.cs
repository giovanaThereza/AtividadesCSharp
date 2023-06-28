namespace GeradorValidadorCPF
{
    partial class Form1
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
            this.LblDigiteCPF = new System.Windows.Forms.Label();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.BtnValidarCPF = new System.Windows.Forms.Button();
            this.LblGeradorCPF = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGerarCPF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDigiteCPF
            // 
            this.LblDigiteCPF.AutoSize = true;
            this.LblDigiteCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDigiteCPF.ForeColor = System.Drawing.Color.Blue;
            this.LblDigiteCPF.Location = new System.Drawing.Point(186, 34);
            this.LblDigiteCPF.Name = "LblDigiteCPF";
            this.LblDigiteCPF.Size = new System.Drawing.Size(180, 31);
            this.LblDigiteCPF.TabIndex = 0;
            this.LblDigiteCPF.Text = "Digite o CPF";
            // 
            // TxtCPF
            // 
            this.TxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCPF.Location = new System.Drawing.Point(89, 77);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(364, 44);
            this.TxtCPF.TabIndex = 1;
            // 
            // BtnValidarCPF
            // 
            this.BtnValidarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidarCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnValidarCPF.Location = new System.Drawing.Point(173, 139);
            this.BtnValidarCPF.Name = "BtnValidarCPF";
            this.BtnValidarCPF.Size = new System.Drawing.Size(209, 51);
            this.BtnValidarCPF.TabIndex = 2;
            this.BtnValidarCPF.Text = "Validar CPF";
            this.BtnValidarCPF.UseVisualStyleBackColor = true;
            this.BtnValidarCPF.Click += new System.EventHandler(this.BtnValidarCPF_Click);
            // 
            // LblGeradorCPF
            // 
            this.LblGeradorCPF.AutoSize = true;
            this.LblGeradorCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGeradorCPF.ForeColor = System.Drawing.Color.Blue;
            this.LblGeradorCPF.Location = new System.Drawing.Point(167, 254);
            this.LblGeradorCPF.Name = "LblGeradorCPF";
            this.LblGeradorCPF.Size = new System.Drawing.Size(226, 31);
            this.LblGeradorCPF.TabIndex = 3;
            this.LblGeradorCPF.Text = "Gerador de CPF";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(90, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 44);
            this.textBox1.TabIndex = 4;
            // 
            // btnGerarCPF
            // 
            this.btnGerarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarCPF.Location = new System.Drawing.Point(173, 365);
            this.btnGerarCPF.Name = "btnGerarCPF";
            this.btnGerarCPF.Size = new System.Drawing.Size(209, 51);
            this.btnGerarCPF.TabIndex = 5;
            this.btnGerarCPF.Text = "Gerar CPF";
            this.btnGerarCPF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 481);
            this.Controls.Add(this.btnGerarCPF);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblGeradorCPF);
            this.Controls.Add(this.BtnValidarCPF);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.LblDigiteCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDigiteCPF;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.Button BtnValidarCPF;
        private System.Windows.Forms.Label LblGeradorCPF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGerarCPF;
    }
}

