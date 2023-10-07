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
            this.lblLogin = new System.Windows.Forms.Label();
            this.rdbEmpresa = new System.Windows.Forms.RadioButton();
            this.rdbAluno = new System.Windows.Forms.RadioButton();
            this.lblPK = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.msktxtPK = new System.Windows.Forms.MaskedTextBox();
            this.lblEuSou = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gpbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSemCadastro
            // 
            this.lblSemCadastro.AutoSize = true;
            this.lblSemCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSemCadastro.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemCadastro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSemCadastro.Location = new System.Drawing.Point(684, 659);
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
            this.lblDescricao.Location = new System.Drawing.Point(223, 170);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(1079, 37);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Bem-vindo ao Estágio Connect, a plataforma de divulgação e busca de vagas de está" +
    "gio";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(304, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(929, 161);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Estágio Connect";
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.btnLogin);
            this.gpbLogin.Controls.Add(this.lblEuSou);
            this.gpbLogin.Controls.Add(this.msktxtPK);
            this.gpbLogin.Controls.Add(this.textBox1);
            this.gpbLogin.Controls.Add(this.lblSenha);
            this.gpbLogin.Controls.Add(this.lblPK);
            this.gpbLogin.Controls.Add(this.rdbAluno);
            this.gpbLogin.Controls.Add(this.rdbEmpresa);
            this.gpbLogin.Location = new System.Drawing.Point(390, 323);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(660, 313);
            this.gpbLogin.TabIndex = 9;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Login";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(715, 249);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(141, 35);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "Fazer Login";
            // 
            // rdbEmpresa
            // 
            this.rdbEmpresa.AutoSize = true;
            this.rdbEmpresa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEmpresa.Location = new System.Drawing.Point(258, 49);
            this.rdbEmpresa.Name = "rdbEmpresa";
            this.rdbEmpresa.Size = new System.Drawing.Size(113, 32);
            this.rdbEmpresa.TabIndex = 0;
            this.rdbEmpresa.TabStop = true;
            this.rdbEmpresa.Text = "Empresa";
            this.rdbEmpresa.UseVisualStyleBackColor = true;
            this.rdbEmpresa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbAluno
            // 
            this.rdbAluno.AutoSize = true;
            this.rdbAluno.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAluno.Location = new System.Drawing.Point(258, 87);
            this.rdbAluno.Name = "rdbAluno";
            this.rdbAluno.Size = new System.Drawing.Size(87, 32);
            this.rdbAluno.TabIndex = 1;
            this.rdbAluno.TabStop = true;
            this.rdbAluno.Text = "Aluno";
            this.rdbAluno.UseVisualStyleBackColor = true;
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
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(130, 193);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(75, 28);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(211, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 30);
            this.textBox1.TabIndex = 4;
            // 
            // msktxtPK
            // 
            this.msktxtPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtPK.Location = new System.Drawing.Point(211, 144);
            this.msktxtPK.Name = "msktxtPK";
            this.msktxtPK.Size = new System.Drawing.Size(217, 30);
            this.msktxtPK.TabIndex = 5;
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
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(135, 251);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(373, 38);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 959);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.gpbLogin);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSemCadastro);
            this.Name = "FormLogin";
            this.Text = "Estágio Connect - Login";
            this.Load += new System.EventHandler(this.FormCadastroInicio_Load);
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEuSou;
        private System.Windows.Forms.Button btnLogin;
    }
}