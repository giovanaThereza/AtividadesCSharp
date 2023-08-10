namespace BuscaTec_Cadastro
{
    partial class Tela_de_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_de_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCPFlogin = new System.Windows.Forms.Label();
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.txtCpfLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem - Vindo  :)";
            // 
            // lblCPFlogin
            // 
            this.lblCPFlogin.AutoSize = true;
            this.lblCPFlogin.BackColor = System.Drawing.SystemColors.Window;
            this.lblCPFlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFlogin.Location = new System.Drawing.Point(674, 130);
            this.lblCPFlogin.Name = "lblCPFlogin";
            this.lblCPFlogin.Size = new System.Drawing.Size(91, 33);
            this.lblCPFlogin.TabIndex = 1;
            this.lblCPFlogin.Text = "Login";
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.BackColor = System.Drawing.SystemColors.Window;
            this.lblSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaLogin.Location = new System.Drawing.Point(674, 288);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(151, 33);
            this.lblSenhaLogin.TabIndex = 2;
            this.lblSenhaLogin.Text = "Password";
            // 
            // txtCpfLogin
            // 
            this.txtCpfLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfLogin.Location = new System.Drawing.Point(680, 187);
            this.txtCpfLogin.Name = "txtCpfLogin";
            this.txtCpfLogin.Size = new System.Drawing.Size(344, 38);
            this.txtCpfLogin.TabIndex = 3;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaLogin.Location = new System.Drawing.Point(684, 342);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(344, 38);
            this.txtSenhaLogin.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(768, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Tela_de_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 778);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtCpfLogin);
            this.Controls.Add(this.lblSenhaLogin);
            this.Controls.Add(this.lblCPFlogin);
            this.Controls.Add(this.label1);
            this.Name = "Tela_de_Login";
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCPFlogin;
        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.TextBox txtCpfLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button button1;
    }
}