namespace ECDesktopApp
{
    partial class FormInfoVagas
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
            this.gpbInfoVaga = new System.Windows.Forms.GroupBox();
            this.lblIdVaga = new System.Windows.Forms.Label();
            this.txtNomeVaga = new System.Windows.Forms.TextBox();
            this.lblNomeVaga = new System.Windows.Forms.Label();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.cbxEspecializacao = new System.Windows.Forms.ComboBox();
            this.txtRequisitos = new System.Windows.Forms.TextBox();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.lblCarga = new System.Windows.Forms.Label();
            this.lblEspecializacao = new System.Windows.Forms.Label();
            this.txtDescricaoVaga = new System.Windows.Forms.TextBox();
            this.lblDescricaoVaga = new System.Windows.Forms.Label();
            this.lblVaga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlunosInteressados = new System.Windows.Forms.DataGridView();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolaAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVisualizarAluno = new System.Windows.Forms.Button();
            this.btnInteressado = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.gpbInfoVaga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosInteressados)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInfoVaga
            // 
            this.gpbInfoVaga.BackColor = System.Drawing.SystemColors.Control;
            this.gpbInfoVaga.Controls.Add(this.lblIdVaga);
            this.gpbInfoVaga.Controls.Add(this.txtNomeVaga);
            this.gpbInfoVaga.Controls.Add(this.lblNomeVaga);
            this.gpbInfoVaga.Controls.Add(this.txtCarga);
            this.gpbInfoVaga.Controls.Add(this.cbxEspecializacao);
            this.gpbInfoVaga.Controls.Add(this.txtRequisitos);
            this.gpbInfoVaga.Controls.Add(this.lblRequisitos);
            this.gpbInfoVaga.Controls.Add(this.lblCarga);
            this.gpbInfoVaga.Controls.Add(this.lblEspecializacao);
            this.gpbInfoVaga.Controls.Add(this.txtDescricaoVaga);
            this.gpbInfoVaga.Controls.Add(this.lblDescricaoVaga);
            this.gpbInfoVaga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoVaga.Location = new System.Drawing.Point(40, 107);
            this.gpbInfoVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbInfoVaga.Name = "gpbInfoVaga";
            this.gpbInfoVaga.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbInfoVaga.Size = new System.Drawing.Size(1587, 274);
            this.gpbInfoVaga.TabIndex = 2;
            this.gpbInfoVaga.TabStop = false;
            this.gpbInfoVaga.Text = "Informações da Vaga";
            // 
            // lblIdVaga
            // 
            this.lblIdVaga.AutoSize = true;
            this.lblIdVaga.Location = new System.Drawing.Point(1473, 16);
            this.lblIdVaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdVaga.Name = "lblIdVaga";
            this.lblIdVaga.Size = new System.Drawing.Size(20, 24);
            this.lblIdVaga.TabIndex = 20;
            this.lblIdVaga.Text = "#";
            // 
            // txtNomeVaga
            // 
            this.txtNomeVaga.Location = new System.Drawing.Point(1112, 207);
            this.txtNomeVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeVaga.Name = "txtNomeVaga";
            this.txtNomeVaga.Size = new System.Drawing.Size(383, 32);
            this.txtNomeVaga.TabIndex = 19;
            // 
            // lblNomeVaga
            // 
            this.lblNomeVaga.AutoSize = true;
            this.lblNomeVaga.Location = new System.Drawing.Point(1036, 210);
            this.lblNomeVaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeVaga.Name = "lblNomeVaga";
            this.lblNomeVaga.Size = new System.Drawing.Size(65, 24);
            this.lblNomeVaga.TabIndex = 18;
            this.lblNomeVaga.Text = "Nome:";
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(1296, 148);
            this.txtCarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(199, 32);
            this.txtCarga.TabIndex = 17;
            // 
            // cbxEspecializacao
            // 
            this.cbxEspecializacao.FormattingEnabled = true;
            this.cbxEspecializacao.Items.AddRange(new object[] {
            "Química",
            "Desenvolvimento de Sistemas",
            "Arquitetura/Engenharia",
            "Mecânica Industrial",
            "Enfermagem",
            "Qualidade de produção"});
            this.cbxEspecializacao.Location = new System.Drawing.Point(1156, 76);
            this.cbxEspecializacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEspecializacao.Name = "cbxEspecializacao";
            this.cbxEspecializacao.Size = new System.Drawing.Size(339, 32);
            this.cbxEspecializacao.TabIndex = 16;
            // 
            // txtRequisitos
            // 
            this.txtRequisitos.Location = new System.Drawing.Point(668, 76);
            this.txtRequisitos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRequisitos.Multiline = true;
            this.txtRequisitos.Name = "txtRequisitos";
            this.txtRequisitos.Size = new System.Drawing.Size(329, 169);
            this.txtRequisitos.TabIndex = 5;
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.Location = new System.Drawing.Point(663, 48);
            this.lblRequisitos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(203, 24);
            this.lblRequisitos.TabIndex = 4;
            this.lblRequisitos.Text = "Requisitos para a vaga:";
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Location = new System.Drawing.Point(1151, 150);
            this.lblCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(129, 24);
            this.lblCarga.TabIndex = 3;
            this.lblCarga.Text = "Carga Horária:";
            // 
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Location = new System.Drawing.Point(1151, 48);
            this.lblEspecializacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(204, 24);
            this.lblEspecializacao.TabIndex = 2;
            this.lblEspecializacao.Text = "Área de especialização:";
            // 
            // txtDescricaoVaga
            // 
            this.txtDescricaoVaga.Location = new System.Drawing.Point(65, 75);
            this.txtDescricaoVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricaoVaga.Multiline = true;
            this.txtDescricaoVaga.Name = "txtDescricaoVaga";
            this.txtDescricaoVaga.Size = new System.Drawing.Size(545, 170);
            this.txtDescricaoVaga.TabIndex = 1;
            // 
            // lblDescricaoVaga
            // 
            this.lblDescricaoVaga.AutoSize = true;
            this.lblDescricaoVaga.Location = new System.Drawing.Point(60, 48);
            this.lblDescricaoVaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoVaga.Name = "lblDescricaoVaga";
            this.lblDescricaoVaga.Size = new System.Drawing.Size(163, 24);
            this.lblDescricaoVaga.TabIndex = 0;
            this.lblDescricaoVaga.Text = "Descrição da vaga:";
            // 
            // lblVaga
            // 
            this.lblVaga.AutoSize = true;
            this.lblVaga.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaga.Location = new System.Drawing.Point(765, 33);
            this.lblVaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVaga.Name = "lblVaga";
            this.lblVaga.Size = new System.Drawing.Size(123, 54);
            this.lblVaga.TabIndex = 3;
            this.lblVaga.Text = "Vaga:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 561);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alunos Interessados nessa vaga: ";
            // 
            // dgvAlunosInteressados
            // 
            this.dgvAlunosInteressados.AllowUserToAddRows = false;
            this.dgvAlunosInteressados.AllowUserToDeleteRows = false;
            this.dgvAlunosInteressados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosInteressados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAluno,
            this.nomeAluno,
            this.nascimentoAluno,
            this.emailAluno,
            this.especialidadeAluno,
            this.cidadeAluno,
            this.statusAluno,
            this.anoAluno,
            this.escolaAluno});
            this.dgvAlunosInteressados.Location = new System.Drawing.Point(33, 610);
            this.dgvAlunosInteressados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAlunosInteressados.Name = "dgvAlunosInteressados";
            this.dgvAlunosInteressados.ReadOnly = true;
            this.dgvAlunosInteressados.RowHeadersWidth = 51;
            this.dgvAlunosInteressados.Size = new System.Drawing.Size(1593, 505);
            this.dgvAlunosInteressados.TabIndex = 5;
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "ID";
            this.idAluno.MinimumWidth = 6;
            this.idAluno.Name = "idAluno";
            this.idAluno.ReadOnly = true;
            this.idAluno.Width = 125;
            // 
            // nomeAluno
            // 
            this.nomeAluno.HeaderText = "Nome";
            this.nomeAluno.MinimumWidth = 6;
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            this.nomeAluno.Width = 125;
            // 
            // nascimentoAluno
            // 
            this.nascimentoAluno.HeaderText = "Nascimento";
            this.nascimentoAluno.MinimumWidth = 6;
            this.nascimentoAluno.Name = "nascimentoAluno";
            this.nascimentoAluno.ReadOnly = true;
            this.nascimentoAluno.Width = 125;
            // 
            // emailAluno
            // 
            this.emailAluno.HeaderText = "Email de Contato";
            this.emailAluno.MinimumWidth = 6;
            this.emailAluno.Name = "emailAluno";
            this.emailAluno.ReadOnly = true;
            this.emailAluno.Width = 125;
            // 
            // especialidadeAluno
            // 
            this.especialidadeAluno.HeaderText = "Especialização";
            this.especialidadeAluno.MinimumWidth = 6;
            this.especialidadeAluno.Name = "especialidadeAluno";
            this.especialidadeAluno.ReadOnly = true;
            this.especialidadeAluno.Width = 125;
            // 
            // cidadeAluno
            // 
            this.cidadeAluno.HeaderText = "Cidade";
            this.cidadeAluno.MinimumWidth = 6;
            this.cidadeAluno.Name = "cidadeAluno";
            this.cidadeAluno.ReadOnly = true;
            this.cidadeAluno.Width = 125;
            // 
            // statusAluno
            // 
            this.statusAluno.HeaderText = "Status";
            this.statusAluno.MinimumWidth = 6;
            this.statusAluno.Name = "statusAluno";
            this.statusAluno.ReadOnly = true;
            this.statusAluno.Width = 125;
            // 
            // anoAluno
            // 
            this.anoAluno.HeaderText = "Ano Letivo";
            this.anoAluno.MinimumWidth = 6;
            this.anoAluno.Name = "anoAluno";
            this.anoAluno.ReadOnly = true;
            this.anoAluno.Width = 125;
            // 
            // escolaAluno
            // 
            this.escolaAluno.HeaderText = "Escola Cursada";
            this.escolaAluno.MinimumWidth = 6;
            this.escolaAluno.Name = "escolaAluno";
            this.escolaAluno.ReadOnly = true;
            this.escolaAluno.Width = 125;
            // 
            // btnVisualizarAluno
            // 
            this.btnVisualizarAluno.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarAluno.Location = new System.Drawing.Point(1236, 469);
            this.btnVisualizarAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVisualizarAluno.Name = "btnVisualizarAluno";
            this.btnVisualizarAluno.Size = new System.Drawing.Size(391, 44);
            this.btnVisualizarAluno.TabIndex = 6;
            this.btnVisualizarAluno.Text = "Visualizar perfil do aluno";
            this.btnVisualizarAluno.UseVisualStyleBackColor = true;
            this.btnVisualizarAluno.Click += new System.EventHandler(this.btnVisualizarAluno_Click);
            // 
            // btnInteressado
            // 
            this.btnInteressado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteressado.Location = new System.Drawing.Point(40, 469);
            this.btnInteressado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInteressado.Name = "btnInteressado";
            this.btnInteressado.Size = new System.Drawing.Size(225, 44);
            this.btnInteressado.TabIndex = 7;
            this.btnInteressado.Text = "Demonstrar Interesse";
            this.btnInteressado.UseVisualStyleBackColor = true;
            this.btnInteressado.Click += new System.EventHandler(this.btnInteressado_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblNomeEmpresa);
            this.pnlContent.Controls.Add(this.gpbInfoVaga);
            this.pnlContent.Controls.Add(this.btnInteressado);
            this.pnlContent.Controls.Add(this.lblVaga);
            this.pnlContent.Controls.Add(this.btnVisualizarAluno);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.dgvAlunosInteressados);
            this.pnlContent.Location = new System.Drawing.Point(164, 15);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1676, 1179);
            this.pnlContent.TabIndex = 8;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(60, 385);
            this.lblNomeEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(366, 68);
            this.lblNomeEmpresa.TabIndex = 8;
            this.lblNomeEmpresa.Text = "NomeEmpresa";
            // 
            // FormInfoVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(2041, 1225);
            this.Controls.Add(this.pnlContent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormInfoVagas";
            this.Text = "Informações da Vaga";
            this.Load += new System.EventHandler(this.FormInfoVagas_Load);
            this.ClientSizeChanged += new System.EventHandler(this.FormInfoVagas_ClientSizeChanged);
            this.gpbInfoVaga.ResumeLayout(false);
            this.gpbInfoVaga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosInteressados)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInfoVaga;
        private System.Windows.Forms.Label lblIdVaga;
        private System.Windows.Forms.TextBox txtNomeVaga;
        private System.Windows.Forms.Label lblNomeVaga;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.ComboBox cbxEspecializacao;
        private System.Windows.Forms.TextBox txtRequisitos;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.Label lblEspecializacao;
        private System.Windows.Forms.TextBox txtDescricaoVaga;
        private System.Windows.Forms.Label lblDescricaoVaga;
        private System.Windows.Forms.Label lblVaga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlunosInteressados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn escolaAluno;
        private System.Windows.Forms.Button btnVisualizarAluno;
        private System.Windows.Forms.Button btnInteressado;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblNomeEmpresa;
    }
}