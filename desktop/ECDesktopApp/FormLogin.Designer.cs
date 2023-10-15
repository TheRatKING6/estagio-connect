namespace ECDesktopApp
{
    partial class FormLogin
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
            this.lblSemCadastro = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEuSou = new System.Windows.Forms.Label();
            this.msktxtPK = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblPK = new System.Windows.Forms.Label();
            this.rdbAluno = new System.Windows.Forms.RadioButton();
            this.rdbEmpresa = new System.Windows.Forms.RadioButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meuPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbLogin.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSemCadastro
            // 
            this.lblSemCadastro.AutoSize = true;
            this.lblSemCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSemCadastro.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemCadastro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSemCadastro.Location = new System.Drawing.Point(513, 535);
            this.lblSemCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSemCadastro.Name = "lblSemCadastro";
            this.lblSemCadastro.Size = new System.Drawing.Size(154, 17);
            this.lblSemCadastro.TabIndex = 6;
            this.lblSemCadastro.Text = "... ainda não me cadastrei";
            this.lblSemCadastro.Click += new System.EventHandler(this.lblSemCadastro_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(167, 138);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(867, 29);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Bem-vindo ao Estágio Connect, a plataforma de divulgação e busca de vagas de está" +
    "gio";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(228, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(745, 129);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Estágio Connect";
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.btnLogin);
            this.gpbLogin.Controls.Add(this.lblEuSou);
            this.gpbLogin.Controls.Add(this.msktxtPK);
            this.gpbLogin.Controls.Add(this.txtSenha);
            this.gpbLogin.Controls.Add(this.lblSenha);
            this.gpbLogin.Controls.Add(this.lblPK);
            this.gpbLogin.Controls.Add(this.rdbAluno);
            this.gpbLogin.Controls.Add(this.rdbEmpresa);
            this.gpbLogin.Location = new System.Drawing.Point(292, 262);
            this.gpbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Padding = new System.Windows.Forms.Padding(2);
            this.gpbLogin.Size = new System.Drawing.Size(495, 254);
            this.gpbLogin.TabIndex = 9;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(101, 204);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(280, 31);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEuSou
            // 
            this.lblEuSou.AutoSize = true;
            this.lblEuSou.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuSou.Location = new System.Drawing.Point(190, 15);
            this.lblEuSou.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEuSou.Name = "lblEuSou";
            this.lblEuSou.Size = new System.Drawing.Size(109, 23);
            this.lblEuSou.TabIndex = 6;
            this.lblEuSou.Text = "Eu sou um ...";
            // 
            // msktxtPK
            // 
            this.msktxtPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtPK.Location = new System.Drawing.Point(158, 117);
            this.msktxtPK.Margin = new System.Windows.Forms.Padding(2);
            this.msktxtPK.Name = "msktxtPK";
            this.msktxtPK.Size = new System.Drawing.Size(164, 26);
            this.msktxtPK.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(158, 157);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(224, 26);
            this.txtSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(98, 157);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(62, 23);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // lblPK
            // 
            this.lblPK.AutoSize = true;
            this.lblPK.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPK.Location = new System.Drawing.Point(112, 117);
            this.lblPK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPK.Name = "lblPK";
            this.lblPK.Size = new System.Drawing.Size(46, 23);
            this.lblPK.TabIndex = 2;
            this.lblPK.Text = "label";
            this.lblPK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdbAluno
            // 
            this.rdbAluno.AutoSize = true;
            this.rdbAluno.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAluno.Location = new System.Drawing.Point(194, 71);
            this.rdbAluno.Margin = new System.Windows.Forms.Padding(2);
            this.rdbAluno.Name = "rdbAluno";
            this.rdbAluno.Size = new System.Drawing.Size(73, 27);
            this.rdbAluno.TabIndex = 1;
            this.rdbAluno.Text = "Aluno";
            this.rdbAluno.UseVisualStyleBackColor = true;
            // 
            // rdbEmpresa
            // 
            this.rdbEmpresa.AutoSize = true;
            this.rdbEmpresa.Checked = true;
            this.rdbEmpresa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEmpresa.Location = new System.Drawing.Point(194, 40);
            this.rdbEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.rdbEmpresa.Name = "rdbEmpresa";
            this.rdbEmpresa.Size = new System.Drawing.Size(95, 27);
            this.rdbEmpresa.TabIndex = 0;
            this.rdbEmpresa.TabStop = true;
            this.rdbEmpresa.Text = "Empresa";
            this.rdbEmpresa.UseVisualStyleBackColor = true;
            this.rdbEmpresa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(536, 202);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(113, 27);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "Fazer Login";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.meuPerfilToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1662, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Início";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inícioToolStripMenuItem_Click_1);
            // 
            // meuPerfilToolStripMenuItem
            // 
            this.meuPerfilToolStripMenuItem.Name = "meuPerfilToolStripMenuItem";
            this.meuPerfilToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.meuPerfilToolStripMenuItem.Text = "Meu Perfil";
            this.meuPerfilToolStripMenuItem.Click += new System.EventHandler(this.meuPerfilToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 829);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.gpbLogin);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSemCadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.Text = "Estágio Connect - Login";
            this.Load += new System.EventHandler(this.FormCadastroInicio_Load);
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSemCadastro;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblPK;
        private System.Windows.Forms.RadioButton rdbAluno;
        private System.Windows.Forms.RadioButton rdbEmpresa;
        private System.Windows.Forms.MaskedTextBox msktxtPK;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblEuSou;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meuPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
    }
}