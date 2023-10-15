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
            this.gpbInfoVaga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosInteressados)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInfoVaga
            // 
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
            this.gpbInfoVaga.Location = new System.Drawing.Point(216, 111);
            this.gpbInfoVaga.Name = "gpbInfoVaga";
            this.gpbInfoVaga.Size = new System.Drawing.Size(1190, 223);
            this.gpbInfoVaga.TabIndex = 2;
            this.gpbInfoVaga.TabStop = false;
            this.gpbInfoVaga.Text = "Informações da Vaga";
            // 
            // lblIdVaga
            // 
            this.lblIdVaga.AutoSize = true;
            this.lblIdVaga.Location = new System.Drawing.Point(1105, 13);
            this.lblIdVaga.Name = "lblIdVaga";
            this.lblIdVaga.Size = new System.Drawing.Size(17, 19);
            this.lblIdVaga.TabIndex = 20;
            this.lblIdVaga.Text = "#";
            // 
            // txtNomeVaga
            // 
            this.txtNomeVaga.Location = new System.Drawing.Point(834, 168);
            this.txtNomeVaga.Name = "txtNomeVaga";
            this.txtNomeVaga.Size = new System.Drawing.Size(288, 27);
            this.txtNomeVaga.TabIndex = 19;
            // 
            // lblNomeVaga
            // 
            this.lblNomeVaga.AutoSize = true;
            this.lblNomeVaga.Location = new System.Drawing.Point(777, 171);
            this.lblNomeVaga.Name = "lblNomeVaga";
            this.lblNomeVaga.Size = new System.Drawing.Size(51, 19);
            this.lblNomeVaga.TabIndex = 18;
            this.lblNomeVaga.Text = "Nome:";
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(972, 120);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(150, 27);
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
            this.cbxEspecializacao.Location = new System.Drawing.Point(867, 62);
            this.cbxEspecializacao.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEspecializacao.Name = "cbxEspecializacao";
            this.cbxEspecializacao.Size = new System.Drawing.Size(255, 27);
            this.cbxEspecializacao.TabIndex = 16;
            // 
            // txtRequisitos
            // 
            this.txtRequisitos.Location = new System.Drawing.Point(501, 62);
            this.txtRequisitos.Multiline = true;
            this.txtRequisitos.Name = "txtRequisitos";
            this.txtRequisitos.Size = new System.Drawing.Size(248, 138);
            this.txtRequisitos.TabIndex = 5;
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.Location = new System.Drawing.Point(497, 39);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(161, 19);
            this.lblRequisitos.TabIndex = 4;
            this.lblRequisitos.Text = "Requisitos para a vaga:";
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Location = new System.Drawing.Point(863, 122);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(103, 19);
            this.lblCarga.TabIndex = 3;
            this.lblCarga.Text = "Carga Horária:";
            // 
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Location = new System.Drawing.Point(863, 39);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(162, 19);
            this.lblEspecializacao.TabIndex = 2;
            this.lblEspecializacao.Text = "Área de especialização:";
            // 
            // txtDescricaoVaga
            // 
            this.txtDescricaoVaga.Location = new System.Drawing.Point(49, 61);
            this.txtDescricaoVaga.Multiline = true;
            this.txtDescricaoVaga.Name = "txtDescricaoVaga";
            this.txtDescricaoVaga.Size = new System.Drawing.Size(410, 139);
            this.txtDescricaoVaga.TabIndex = 1;
            // 
            // lblDescricaoVaga
            // 
            this.lblDescricaoVaga.AutoSize = true;
            this.lblDescricaoVaga.Location = new System.Drawing.Point(45, 39);
            this.lblDescricaoVaga.Name = "lblDescricaoVaga";
            this.lblDescricaoVaga.Size = new System.Drawing.Size(132, 19);
            this.lblDescricaoVaga.TabIndex = 0;
            this.lblDescricaoVaga.Text = "Descrição da vaga:";
            // 
            // lblVaga
            // 
            this.lblVaga.AutoSize = true;
            this.lblVaga.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaga.Location = new System.Drawing.Point(760, 51);
            this.lblVaga.Name = "lblVaga";
            this.lblVaga.Size = new System.Drawing.Size(97, 42);
            this.lblVaga.TabIndex = 3;
            this.lblVaga.Text = "Vaga:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(624, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 29);
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
            this.dgvAlunosInteressados.Location = new System.Drawing.Point(211, 520);
            this.dgvAlunosInteressados.Name = "dgvAlunosInteressados";
            this.dgvAlunosInteressados.ReadOnly = true;
            this.dgvAlunosInteressados.Size = new System.Drawing.Size(1195, 410);
            this.dgvAlunosInteressados.TabIndex = 5;
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
            this.nascimentoAluno.HeaderText = "Nascimento";
            this.nascimentoAluno.Name = "nascimentoAluno";
            this.nascimentoAluno.ReadOnly = true;
            // 
            // emailAluno
            // 
            this.emailAluno.HeaderText = "Email de Contato";
            this.emailAluno.Name = "emailAluno";
            this.emailAluno.ReadOnly = true;
            // 
            // especialidadeAluno
            // 
            this.especialidadeAluno.HeaderText = "Especialização";
            this.especialidadeAluno.Name = "especialidadeAluno";
            this.especialidadeAluno.ReadOnly = true;
            // 
            // cidadeAluno
            // 
            this.cidadeAluno.HeaderText = "Cidade";
            this.cidadeAluno.Name = "cidadeAluno";
            this.cidadeAluno.ReadOnly = true;
            // 
            // statusAluno
            // 
            this.statusAluno.HeaderText = "Status";
            this.statusAluno.Name = "statusAluno";
            this.statusAluno.ReadOnly = true;
            // 
            // anoAluno
            // 
            this.anoAluno.HeaderText = "Ano Letivo";
            this.anoAluno.Name = "anoAluno";
            this.anoAluno.ReadOnly = true;
            // 
            // escolaAluno
            // 
            this.escolaAluno.HeaderText = "Escola Cursada";
            this.escolaAluno.Name = "escolaAluno";
            this.escolaAluno.ReadOnly = true;
            // 
            // btnVisualizarAluno
            // 
            this.btnVisualizarAluno.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarAluno.Location = new System.Drawing.Point(1113, 405);
            this.btnVisualizarAluno.Name = "btnVisualizarAluno";
            this.btnVisualizarAluno.Size = new System.Drawing.Size(293, 36);
            this.btnVisualizarAluno.TabIndex = 6;
            this.btnVisualizarAluno.Text = "Visualizar perfil do aluno";
            this.btnVisualizarAluno.UseVisualStyleBackColor = true;
            this.btnVisualizarAluno.Click += new System.EventHandler(this.btnVisualizarAluno_Click);
            // 
            // FormInfoVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 995);
            this.Controls.Add(this.btnVisualizarAluno);
            this.Controls.Add(this.dgvAlunosInteressados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVaga);
            this.Controls.Add(this.gpbInfoVaga);
            this.Name = "FormInfoVagas";
            this.Text = "Informações da Vaga";
            this.Load += new System.EventHandler(this.FormInfoVagas_Load);
            this.gpbInfoVaga.ResumeLayout(false);
            this.gpbInfoVaga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosInteressados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}