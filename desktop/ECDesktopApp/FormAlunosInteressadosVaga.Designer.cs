namespace ECDesktopApp
{
    partial class FormAlunosInteressadosVaga
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
            this.dgvAlunosInteressadosVaga = new System.Windows.Forms.DataGridView();
            this.btnVerAluno = new System.Windows.Forms.Button();
            this.btnVerVaga = new System.Windows.Forms.Button();
            this.lblAlunosInteresse = new System.Windows.Forms.Label();
            this.idVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especializacaoVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especializacaoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolaAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosInteressadosVaga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunosInteressadosVaga
            // 
            this.dgvAlunosInteressadosVaga.AllowUserToAddRows = false;
            this.dgvAlunosInteressadosVaga.AllowUserToDeleteRows = false;
            this.dgvAlunosInteressadosVaga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosInteressadosVaga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVaga,
            this.nomeVaga,
            this.especializacaoVaga,
            this.idAluno,
            this.nomeAluno,
            this.especializacaoAluno,
            this.escolaAluno,
            this.nascimentoAluno});
            this.dgvAlunosInteressadosVaga.Location = new System.Drawing.Point(90, 184);
            this.dgvAlunosInteressadosVaga.Name = "dgvAlunosInteressadosVaga";
            this.dgvAlunosInteressadosVaga.ReadOnly = true;
            this.dgvAlunosInteressadosVaga.Size = new System.Drawing.Size(1311, 382);
            this.dgvAlunosInteressadosVaga.TabIndex = 0;
            // 
            // btnVerAluno
            // 
            this.btnVerAluno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAluno.Location = new System.Drawing.Point(91, 136);
            this.btnVerAluno.Name = "btnVerAluno";
            this.btnVerAluno.Size = new System.Drawing.Size(155, 27);
            this.btnVerAluno.TabIndex = 1;
            this.btnVerAluno.Text = "Ver Perfil do Aluno";
            this.btnVerAluno.UseVisualStyleBackColor = true;
            this.btnVerAluno.Click += new System.EventHandler(this.btnVerAluno_Click);
            // 
            // btnVerVaga
            // 
            this.btnVerVaga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVaga.Location = new System.Drawing.Point(278, 136);
            this.btnVerVaga.Name = "btnVerVaga";
            this.btnVerVaga.Size = new System.Drawing.Size(202, 27);
            this.btnVerVaga.TabIndex = 2;
            this.btnVerVaga.Text = "Ver Informações da Vaga";
            this.btnVerVaga.UseVisualStyleBackColor = true;
            this.btnVerVaga.Click += new System.EventHandler(this.btnVerVaga_Click);
            // 
            // lblAlunosInteresse
            // 
            this.lblAlunosInteresse.AutoSize = true;
            this.lblAlunosInteresse.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunosInteresse.Location = new System.Drawing.Point(520, 42);
            this.lblAlunosInteresse.Name = "lblAlunosInteresse";
            this.lblAlunosInteresse.Size = new System.Drawing.Size(445, 36);
            this.lblAlunosInteresse.TabIndex = 3;
            this.lblAlunosInteresse.Text = "Alunos Interessados em suas vagas";
            // 
            // idVaga
            // 
            this.idVaga.HeaderText = "ID da Vaga";
            this.idVaga.Name = "idVaga";
            this.idVaga.ReadOnly = true;
            // 
            // nomeVaga
            // 
            this.nomeVaga.HeaderText = "Nome da vaga";
            this.nomeVaga.Name = "nomeVaga";
            this.nomeVaga.ReadOnly = true;
            // 
            // especializacaoVaga
            // 
            this.especializacaoVaga.HeaderText = "Área de Especialização da Vaga";
            this.especializacaoVaga.Name = "especializacaoVaga";
            this.especializacaoVaga.ReadOnly = true;
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "ID do Aluno";
            this.idAluno.Name = "idAluno";
            this.idAluno.ReadOnly = true;
            // 
            // nomeAluno
            // 
            this.nomeAluno.HeaderText = "Nome do Aluno";
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            // 
            // especializacaoAluno
            // 
            this.especializacaoAluno.HeaderText = "Área de Especialização do Aluno";
            this.especializacaoAluno.Name = "especializacaoAluno";
            this.especializacaoAluno.ReadOnly = true;
            // 
            // escolaAluno
            // 
            this.escolaAluno.HeaderText = "Escola do Aluno";
            this.escolaAluno.Name = "escolaAluno";
            this.escolaAluno.ReadOnly = true;
            // 
            // nascimentoAluno
            // 
            this.nascimentoAluno.HeaderText = "Data de Nascimento";
            this.nascimentoAluno.Name = "nascimentoAluno";
            this.nascimentoAluno.ReadOnly = true;
            // 
            // FormAlunosInteressadosVaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 698);
            this.Controls.Add(this.lblAlunosInteresse);
            this.Controls.Add(this.btnVerVaga);
            this.Controls.Add(this.btnVerAluno);
            this.Controls.Add(this.dgvAlunosInteressadosVaga);
            this.Name = "FormAlunosInteressadosVaga";
            this.Text = "Alunos Interessados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosInteressadosVaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunosInteressadosVaga;
        private System.Windows.Forms.Button btnVerAluno;
        private System.Windows.Forms.Button btnVerVaga;
        private System.Windows.Forms.Label lblAlunosInteresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn especializacaoVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn especializacaoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn escolaAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoAluno;
    }
}