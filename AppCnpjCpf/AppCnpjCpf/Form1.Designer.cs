namespace AppCnpjCpf
{
    partial class TxtAppSelecionar
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
            this.BntValidar = new System.Windows.Forms.Button();
            this.BntCancel = new System.Windows.Forms.Button();
            this.TxtDigiteOpcao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RDBntCPF = new System.Windows.Forms.RadioButton();
            this.RDBntCNPJ = new System.Windows.Forms.RadioButton();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Btngerar = new System.Windows.Forms.Button();
            this.geradorCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BntValidar
            // 
            this.BntValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntValidar.Location = new System.Drawing.Point(54, 193);
            this.BntValidar.Name = "BntValidar";
            this.BntValidar.Size = new System.Drawing.Size(147, 53);
            this.BntValidar.TabIndex = 0;
            this.BntValidar.Text = "Ok";
            this.BntValidar.UseVisualStyleBackColor = true;
            this.BntValidar.Click += new System.EventHandler(this.BntValidar_Click);
            // 
            // BntCancel
            // 
            this.BntCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntCancel.Location = new System.Drawing.Point(319, 193);
            this.BntCancel.Name = "BntCancel";
            this.BntCancel.Size = new System.Drawing.Size(147, 53);
            this.BntCancel.TabIndex = 1;
            this.BntCancel.Text = "Cancel";
            this.BntCancel.UseVisualStyleBackColor = true;
            this.BntCancel.Click += new System.EventHandler(this.BntCancel_Click);
            // 
            // TxtDigiteOpcao
            // 
            this.TxtDigiteOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDigiteOpcao.Location = new System.Drawing.Point(198, 98);
            this.TxtDigiteOpcao.Name = "TxtDigiteOpcao";
            this.TxtDigiteOpcao.Size = new System.Drawing.Size(368, 49);
            this.TxtDigiteOpcao.TabIndex = 4;
            this.TxtDigiteOpcao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDigiteOpcao_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entrada:";
            // 
            // RDBntCPF
            // 
            this.RDBntCPF.AutoSize = true;
            this.RDBntCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBntCPF.Location = new System.Drawing.Point(111, 39);
            this.RDBntCPF.Name = "RDBntCPF";
            this.RDBntCPF.Size = new System.Drawing.Size(90, 35);
            this.RDBntCPF.TabIndex = 6;
            this.RDBntCPF.Text = "CPF";
            this.RDBntCPF.UseVisualStyleBackColor = true;
            // 
            // RDBntCNPJ
            // 
            this.RDBntCNPJ.AutoSize = true;
            this.RDBntCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBntCNPJ.Location = new System.Drawing.Point(358, 39);
            this.RDBntCNPJ.Name = "RDBntCNPJ";
            this.RDBntCNPJ.Size = new System.Drawing.Size(108, 35);
            this.RDBntCNPJ.TabIndex = 7;
            this.RDBntCNPJ.TabStop = true;
            this.RDBntCNPJ.Text = "CNPJ";
            this.RDBntCNPJ.UseVisualStyleBackColor = true;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validarCPFToolStripMenuItem,
            this.geradorCPFToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // validarCPFToolStripMenuItem
            // 
            this.validarCPFToolStripMenuItem.Name = "validarCPFToolStripMenuItem";
            this.validarCPFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.validarCPFToolStripMenuItem.Text = "Validar CPF/CNPJ";
            this.validarCPFToolStripMenuItem.Click += new System.EventHandler(this.validarCPFToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Menu";
            // 
            // Btngerar
            // 
            this.Btngerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btngerar.Location = new System.Drawing.Point(54, 193);
            this.Btngerar.Name = "Btngerar";
            this.Btngerar.Size = new System.Drawing.Size(147, 53);
            this.Btngerar.TabIndex = 9;
            this.Btngerar.Text = "Gerar";
            this.Btngerar.UseVisualStyleBackColor = true;
            this.Btngerar.Click += new System.EventHandler(this.Btngerar_Click);
            // 
            // geradorCPFToolStripMenuItem
            // 
            this.geradorCPFToolStripMenuItem.Name = "geradorCPFToolStripMenuItem";
            this.geradorCPFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.geradorCPFToolStripMenuItem.Text = "Gerador CPF";
            this.geradorCPFToolStripMenuItem.Click += new System.EventHandler(this.geradorCPFToolStripMenuItem_Click);
            // 
            // TxtAppSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(598, 310);
            this.Controls.Add(this.Btngerar);
            this.Controls.Add(this.RDBntCNPJ);
            this.Controls.Add(this.RDBntCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDigiteOpcao);
            this.Controls.Add(this.BntCancel);
            this.Controls.Add(this.BntValidar);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TxtAppSelecionar";
            this.Text = "APP de CPF/CNPJ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntValidar;
        private System.Windows.Forms.Button BntCancel;
        private System.Windows.Forms.TextBox TxtDigiteOpcao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RDBntCPF;
        private System.Windows.Forms.RadioButton RDBntCNPJ;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarCPFToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem geradorCPFToolStripMenuItem;
        private System.Windows.Forms.Button Btngerar;
    }
}

