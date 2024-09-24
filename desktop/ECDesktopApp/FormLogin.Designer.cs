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
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vagasDeEmpregoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suasInformaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosInteressadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.gpbLogin.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSemCadastro
            // 
            this.lblSemCadastro.AutoSize = true;
            this.lblSemCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSemCadastro.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemCadastro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSemCadastro.Location = new System.Drawing.Point(709, 657);
            this.lblSemCadastro.Name = "lblSemCadastro";
            this.lblSemCadastro.Size = new System.Drawing.Size(187, 21);
            this.lblSemCadastro.TabIndex = 6;
            this.lblSemCadastro.Text = "... ainda não me cadastrei";
            this.lblSemCadastro.Click += new System.EventHandler(this.lblSemCadastro_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(259, 182);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(1079, 37);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Bem-vindo ao Estágio Connect, a plataforma de divulgação e busca de vagas de está" +
    "gio";
            // 
            // gpbLogin
            // 
            this.gpbLogin.BackColor = System.Drawing.SystemColors.Control;
            this.gpbLogin.Controls.Add(this.btnLogin);
            this.gpbLogin.Controls.Add(this.lblEuSou);
            this.gpbLogin.Controls.Add(this.msktxtPK);
            this.gpbLogin.Controls.Add(this.txtSenha);
            this.gpbLogin.Controls.Add(this.lblSenha);
            this.gpbLogin.Controls.Add(this.lblPK);
            this.gpbLogin.Controls.Add(this.rdbAluno);
            this.gpbLogin.Controls.Add(this.rdbEmpresa);
            this.gpbLogin.Location = new System.Drawing.Point(485, 314);
            this.gpbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbLogin.Size = new System.Drawing.Size(660, 313);
            this.gpbLogin.TabIndex = 9;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(135, 251);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(373, 38);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEuSou
            // 
            this.lblEuSou.AutoSize = true;
            this.lblEuSou.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuSou.Location = new System.Drawing.Point(253, 18);
            this.lblEuSou.Name = "lblEuSou";
            this.lblEuSou.Size = new System.Drawing.Size(131, 28);
            this.lblEuSou.TabIndex = 6;
            this.lblEuSou.Text = "Eu sou um ...";
            // 
            // msktxtPK
            // 
            this.msktxtPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtPK.Location = new System.Drawing.Point(211, 144);
            this.msktxtPK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxtPK.Name = "msktxtPK";
            this.msktxtPK.Size = new System.Drawing.Size(217, 30);
            this.msktxtPK.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(211, 193);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(297, 30);
            this.txtSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(131, 193);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(75, 28);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // lblPK
            // 
            this.lblPK.AutoSize = true;
            this.lblPK.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPK.Location = new System.Drawing.Point(149, 144);
            this.lblPK.Name = "lblPK";
            this.lblPK.Size = new System.Drawing.Size(56, 28);
            this.lblPK.TabIndex = 2;
            this.lblPK.Text = "label";
            this.lblPK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdbAluno
            // 
            this.rdbAluno.AutoSize = true;
            this.rdbAluno.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAluno.Location = new System.Drawing.Point(259, 87);
            this.rdbAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbAluno.Name = "rdbAluno";
            this.rdbAluno.Size = new System.Drawing.Size(87, 32);
            this.rdbAluno.TabIndex = 1;
            this.rdbAluno.Text = "Aluno";
            this.rdbAluno.UseVisualStyleBackColor = true;
            // 
            // rdbEmpresa
            // 
            this.rdbEmpresa.AutoSize = true;
            this.rdbEmpresa.Checked = true;
            this.rdbEmpresa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEmpresa.Location = new System.Drawing.Point(259, 49);
            this.rdbEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbEmpresa.Name = "rdbEmpresa";
            this.rdbEmpresa.Size = new System.Drawing.Size(113, 32);
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
            this.lblLogin.Location = new System.Drawing.Point(739, 247);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(141, 35);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "Fazer Login";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.meuPerfilToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.suasInformaçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2216, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.inicioToolStripMenuItem.Text = "Início";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inícioToolStripMenuItem_Click_1);
            // 
            // meuPerfilToolStripMenuItem
            // 
            this.meuPerfilToolStripMenuItem.Name = "meuPerfilToolStripMenuItem";
            this.meuPerfilToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.meuPerfilToolStripMenuItem.Text = "Meu Perfil";
            this.meuPerfilToolStripMenuItem.Click += new System.EventHandler(this.meuPerfilToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.vagasDeEmpregoToolStripMenuItem});
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // vagasDeEmpregoToolStripMenuItem
            // 
            this.vagasDeEmpregoToolStripMenuItem.Name = "vagasDeEmpregoToolStripMenuItem";
            this.vagasDeEmpregoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.vagasDeEmpregoToolStripMenuItem.Text = "Vagas de emprego";
            this.vagasDeEmpregoToolStripMenuItem.Click += new System.EventHandler(this.vagasDeEmpregoToolStripMenuItem_Click);
            // 
            // suasInformaçõesToolStripMenuItem
            // 
            this.suasInformaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vagasToolStripMenuItem,
            this.alunosInteressadosToolStripMenuItem,
            this.connectsToolStripMenuItem});
            this.suasInformaçõesToolStripMenuItem.Name = "suasInformaçõesToolStripMenuItem";
            this.suasInformaçõesToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.suasInformaçõesToolStripMenuItem.Text = "Suas Informações";
            // 
            // vagasToolStripMenuItem
            // 
            this.vagasToolStripMenuItem.Name = "vagasToolStripMenuItem";
            this.vagasToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.vagasToolStripMenuItem.Text = "Vagas Interessadas";
            this.vagasToolStripMenuItem.Click += new System.EventHandler(this.vagasToolStripMenuItem_Click);
            // 
            // alunosInteressadosToolStripMenuItem
            // 
            this.alunosInteressadosToolStripMenuItem.Name = "alunosInteressadosToolStripMenuItem";
            this.alunosInteressadosToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.alunosInteressadosToolStripMenuItem.Text = "Alunos Interessados";
            this.alunosInteressadosToolStripMenuItem.Click += new System.EventHandler(this.alunosInteressadosToolStripMenuItem_Click);
            // 
            // connectsToolStripMenuItem
            // 
            this.connectsToolStripMenuItem.Name = "connectsToolStripMenuItem";
            this.connectsToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.connectsToolStripMenuItem.Text = "Connects";
            this.connectsToolStripMenuItem.Click += new System.EventHandler(this.connectsToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogo.Location = new System.Drawing.Point(611, 0);
            this.picBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(439, 178);
            this.picBoxLogo.TabIndex = 12;
            this.picBoxLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(2216, 1020);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.gpbLogin);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblSemCadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.Text = "Estágio Connect - Login";
            this.Load += new System.EventHandler(this.FormCadastroInicio_Load);
            this.ResizeEnd += new System.EventHandler(this.FormLogin_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FormLogin_SizeChanged);
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSemCadastro;
        private System.Windows.Forms.Label lblDescricao;
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
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vagasDeEmpregoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suasInformaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vagasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosInteressadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectsToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
    }
}