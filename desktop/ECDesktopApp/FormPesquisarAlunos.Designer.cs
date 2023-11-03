namespace ECDesktopApp
{
    partial class FormPesquisarAlunos
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
            this.dgvBuscaAlunos = new System.Windows.Forms.DataGridView();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolaAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbBuscaAluno = new System.Windows.Forms.GroupBox();
            this.lblBuscaAluno = new System.Windows.Forms.Label();
            this.btnVerAluno = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.lblEscola = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEscola = new System.Windows.Forms.TextBox();
            this.cbxEspecializacao = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxOrganizar = new System.Windows.Forms.ComboBox();
            this.lblOrganizar = new System.Windows.Forms.Label();
            this.cidadeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaAlunos)).BeginInit();
            this.gpbBuscaAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscaAlunos
            // 
            this.dgvBuscaAlunos.AllowUserToAddRows = false;
            this.dgvBuscaAlunos.AllowUserToDeleteRows = false;
            this.dgvBuscaAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAluno,
            this.nomeAluno,
            this.nascimentoAluno,
            this.emailAluno,
            this.especialidadeAluno,
            this.escolaAluno,
            this.cidadeAluno});
            this.dgvBuscaAlunos.Location = new System.Drawing.Point(114, 359);
            this.dgvBuscaAlunos.Name = "dgvBuscaAlunos";
            this.dgvBuscaAlunos.ReadOnly = true;
            this.dgvBuscaAlunos.Size = new System.Drawing.Size(1299, 316);
            this.dgvBuscaAlunos.TabIndex = 0;
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "ID";
            this.idAluno.Name = "idAluno";
            this.idAluno.ReadOnly = true;
            // 
            // nomeAluno
            // 
            this.nomeAluno.HeaderText = "Nome";
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            // 
            // nascimentoAluno
            // 
            this.nascimentoAluno.HeaderText = "Data de Nascimento";
            this.nascimentoAluno.Name = "nascimentoAluno";
            this.nascimentoAluno.ReadOnly = true;
            // 
            // emailAluno
            // 
            this.emailAluno.HeaderText = "Email";
            this.emailAluno.Name = "emailAluno";
            this.emailAluno.ReadOnly = true;
            // 
            // especialidadeAluno
            // 
            this.especialidadeAluno.HeaderText = "Área de especialidade";
            this.especialidadeAluno.Name = "especialidadeAluno";
            this.especialidadeAluno.ReadOnly = true;
            // 
            // escolaAluno
            // 
            this.escolaAluno.HeaderText = "Escola";
            this.escolaAluno.Name = "escolaAluno";
            this.escolaAluno.ReadOnly = true;
            // 
            // gpbBuscaAluno
            // 
            this.gpbBuscaAluno.Controls.Add(this.txtCidade);
            this.gpbBuscaAluno.Controls.Add(this.lblCidade);
            this.gpbBuscaAluno.Controls.Add(this.cbxEspecializacao);
            this.gpbBuscaAluno.Controls.Add(this.txtEscola);
            this.gpbBuscaAluno.Controls.Add(this.txtEmail);
            this.gpbBuscaAluno.Controls.Add(this.txtNome);
            this.gpbBuscaAluno.Controls.Add(this.lblEscola);
            this.gpbBuscaAluno.Controls.Add(this.lblEspecialidade);
            this.gpbBuscaAluno.Controls.Add(this.lblEmail);
            this.gpbBuscaAluno.Controls.Add(this.lblNome);
            this.gpbBuscaAluno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscaAluno.Location = new System.Drawing.Point(114, 74);
            this.gpbBuscaAluno.Name = "gpbBuscaAluno";
            this.gpbBuscaAluno.Size = new System.Drawing.Size(1010, 252);
            this.gpbBuscaAluno.TabIndex = 1;
            this.gpbBuscaAluno.TabStop = false;
            this.gpbBuscaAluno.Text = "Buscar";
            // 
            // lblBuscaAluno
            // 
            this.lblBuscaAluno.AutoSize = true;
            this.lblBuscaAluno.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaAluno.Location = new System.Drawing.Point(763, 25);
            this.lblBuscaAluno.Name = "lblBuscaAluno";
            this.lblBuscaAluno.Size = new System.Drawing.Size(180, 36);
            this.lblBuscaAluno.TabIndex = 2;
            this.lblBuscaAluno.Text = "Buscar Alunos";
            // 
            // btnVerAluno
            // 
            this.btnVerAluno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAluno.Location = new System.Drawing.Point(1201, 201);
            this.btnVerAluno.Name = "btnVerAluno";
            this.btnVerAluno.Size = new System.Drawing.Size(212, 30);
            this.btnVerAluno.TabIndex = 3;
            this.btnVerAluno.Text = "Visualizar Perfil do Aluno";
            this.btnVerAluno.UseVisualStyleBackColor = true;
            this.btnVerAluno.Click += new System.EventHandler(this.btnVerAluno_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(57, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(577, 48);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(157, 19);
            this.lblEspecialidade.TabIndex = 2;
            this.lblEspecialidade.Text = "Área de especialidade:";
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Location = new System.Drawing.Point(577, 160);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(55, 19);
            this.lblEscola.TabIndex = 3;
            this.lblEscola.Text = "Escola:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(442, 27);
            this.txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(442, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // txtEscola
            // 
            this.txtEscola.Location = new System.Drawing.Point(638, 157);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(350, 27);
            this.txtEscola.TabIndex = 6;
            // 
            // cbxEspecializacao
            // 
            this.cbxEspecializacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspecializacao.FormattingEnabled = true;
            this.cbxEspecializacao.Items.AddRange(new object[] {
            "Química",
            "Desenvolvimento de Sistemas",
            "Arquitetura/Engenharia",
            "Mecânica Industrial",
            "Enfermagem",
            "Qualidade de produção"});
            this.cbxEspecializacao.Location = new System.Drawing.Point(735, 45);
            this.cbxEspecializacao.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEspecializacao.Name = "cbxEspecializacao";
            this.cbxEspecializacao.Size = new System.Drawing.Size(253, 28);
            this.cbxEspecializacao.TabIndex = 46;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1201, 160);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(212, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxOrganizar
            // 
            this.cbxOrganizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrganizar.FormattingEnabled = true;
            this.cbxOrganizar.Items.AddRange(new object[] {
            "Mais Velhos",
            "Mais Novos",
            "Nome (Alfabético Crescente)",
            "Nome (Alfabético Decrescente)",
            "Escola (Alfabético Crescente)",
            "Escola (Alfabético Decrescente)"});
            this.cbxOrganizar.Location = new System.Drawing.Point(1201, 305);
            this.cbxOrganizar.Name = "cbxOrganizar";
            this.cbxOrganizar.Size = new System.Drawing.Size(212, 27);
            this.cbxOrganizar.TabIndex = 5;
            // 
            // lblOrganizar
            // 
            this.lblOrganizar.AutoSize = true;
            this.lblOrganizar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizar.Location = new System.Drawing.Point(1198, 287);
            this.lblOrganizar.Name = "lblOrganizar";
            this.lblOrganizar.Size = new System.Drawing.Size(149, 15);
            this.lblOrganizar.TabIndex = 6;
            this.lblOrganizar.Text = "Organizar resultados por:";
            // 
            // cidadeAluno
            // 
            this.cidadeAluno.HeaderText = "Cidade";
            this.cidadeAluno.Name = "cidadeAluno";
            this.cidadeAluno.ReadOnly = true;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(577, 102);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 19);
            this.lblCidade.TabIndex = 47;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(638, 99);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(350, 27);
            this.txtCidade.TabIndex = 48;
            // 
            // FormPesquisarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 699);
            this.Controls.Add(this.lblOrganizar);
            this.Controls.Add(this.cbxOrganizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVerAluno);
            this.Controls.Add(this.lblBuscaAluno);
            this.Controls.Add(this.gpbBuscaAluno);
            this.Controls.Add(this.dgvBuscaAlunos);
            this.Name = "FormPesquisarAlunos";
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.FormPesquisarAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaAlunos)).EndInit();
            this.gpbBuscaAluno.ResumeLayout(false);
            this.gpbBuscaAluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscaAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn escolaAluno;
        private System.Windows.Forms.GroupBox gpbBuscaAluno;
        private System.Windows.Forms.Label lblBuscaAluno;
        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnVerAluno;
        private System.Windows.Forms.TextBox txtEscola;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbxEspecializacao;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxOrganizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeAluno;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblOrganizar;
        private System.Windows.Forms.TextBox txtCidade;
    }
}