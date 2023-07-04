namespace Tela_de_Login
{
    partial class BuscaTec
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtDigiteLogin = new System.Windows.Forms.TextBox();
            this.LkLblEsquecida = new System.Windows.Forms.LinkLabel();
            this.BtnLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(191, 24);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(102, 31);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login: ";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(187, 162);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(106, 31);
            this.LblSenha.TabIndex = 1;
            this.LblSenha.Text = "Senha:";
            // 
            // btnLogar
            // 
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Location = new System.Drawing.Point(67, 288);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(127, 49);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "Entrar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(64, 206);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(364, 44);
            this.TxtSenha.TabIndex = 4;
            // 
            // TxtDigiteLogin
            // 
            this.TxtDigiteLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDigiteLogin.Location = new System.Drawing.Point(59, 71);
            this.TxtDigiteLogin.Name = "TxtDigiteLogin";
            this.TxtDigiteLogin.Size = new System.Drawing.Size(364, 44);
            this.TxtDigiteLogin.TabIndex = 5;
            // 
            // LkLblEsquecida
            // 
            this.LkLblEsquecida.AutoSize = true;
            this.LkLblEsquecida.LinkColor = System.Drawing.Color.DarkMagenta;
            this.LkLblEsquecida.Location = new System.Drawing.Point(3, 263);
            this.LkLblEsquecida.Name = "LkLblEsquecida";
            this.LkLblEsquecida.Size = new System.Drawing.Size(104, 13);
            this.LkLblEsquecida.TabIndex = 8;
            this.LkLblEsquecida.TabStop = true;
            this.LkLblEsquecida.Text = "Esqueceu a Senha?";
            // 
            // BtnLista
            // 
            this.BtnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLista.Location = new System.Drawing.Point(266, 288);
            this.BtnLista.Name = "BtnLista";
            this.BtnLista.Size = new System.Drawing.Size(122, 49);
            this.BtnLista.TabIndex = 9;
            this.BtnLista.Text = "Listar";
            this.BtnLista.UseVisualStyleBackColor = true;
            this.BtnLista.Click += new System.EventHandler(this.BtnLista_Click);
            // 
            // BuscaTec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(477, 469);
            this.Controls.Add(this.BtnLista);
            this.Controls.Add(this.LkLblEsquecida);
            this.Controls.Add(this.TxtDigiteLogin);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.lblLogin);
            this.Name = "BuscaTec";
            this.Text = "BuscaTec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtDigiteLogin;
        private System.Windows.Forms.LinkLabel LkLblEsquecida;
        private System.Windows.Forms.Button BtnLista;
    }
}

