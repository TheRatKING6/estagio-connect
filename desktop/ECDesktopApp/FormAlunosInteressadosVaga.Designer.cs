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
            this.idVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especializacaoVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especializacaoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolaAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerAluno = new System.Windows.Forms.Button();
            this.btnVerVaga = new System.Windows.Forms.Button();
            this.lblAlunosInteresse = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosInteressadosVaga)).BeginInit();
            this.pnlContent.SuspendLayout();
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
            this.dgvAlunosInteressadosVaga.Location = new System.Drawing.Point(20, 209);
            this.dgvAlunosInteressadosVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAlunosInteressadosVaga.Name = "dgvAlunosInteressadosVaga";
            this.dgvAlunosInteressadosVaga.ReadOnly = true;
            this.dgvAlunosInteressadosVaga.RowHeadersWidth = 51;
            this.dgvAlunosInteressadosVaga.Size = new System.Drawing.Size(1748, 470);
            this.dgvAlunosInteressadosVaga.TabIndex = 0;
            this.dgvAlunosInteressadosVaga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunosInteressadosVaga_CellContentClick);
            // 
            // idVaga
            // 
            this.idVaga.HeaderText = "ID da Vaga";
            this.idVaga.MinimumWidth = 6;
            this.idVaga.Name = "idVaga";
            this.idVaga.ReadOnly = true;
            this.idVaga.Width = 125;
            // 
            // nomeVaga
            // 
            this.nomeVaga.HeaderText = "Nome da vaga";
            this.nomeVaga.MinimumWidth = 6;
            this.nomeVaga.Name = "nomeVaga";
            this.nomeVaga.ReadOnly = true;
            this.nomeVaga.Width = 125;
            // 
            // especializacaoVaga
            // 
            this.especializacaoVaga.HeaderText = "Área de Especialização da Vaga";
            this.especializacaoVaga.MinimumWidth = 6;
            this.especializacaoVaga.Name = "especializacaoVaga";
            this.especializacaoVaga.ReadOnly = true;
            this.especializacaoVaga.Width = 125;
            // 
            // idAluno
            // 
            this.idAluno.HeaderText = "ID do Aluno";
            this.idAluno.MinimumWidth = 6;
            this.idAluno.Name = "idAluno";
            this.idAluno.ReadOnly = true;
            this.idAluno.Width = 125;
            // 
            // nomeAluno
            // 
            this.nomeAluno.HeaderText = "Nome do Aluno";
            this.nomeAluno.MinimumWidth = 6;
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            this.nomeAluno.Width = 125;
            // 
            // especializacaoAluno
            // 
            this.especializacaoAluno.HeaderText = "Área de Especialização do Aluno";
            this.especializacaoAluno.MinimumWidth = 6;
            this.especializacaoAluno.Name = "especializacaoAluno";
            this.especializacaoAluno.ReadOnly = true;
            this.especializacaoAluno.Width = 125;
            // 
            // escolaAluno
            // 
            this.escolaAluno.HeaderText = "Escola do Aluno";
            this.escolaAluno.MinimumWidth = 6;
            this.escolaAluno.Name = "escolaAluno";
            this.escolaAluno.ReadOnly = true;
            this.escolaAluno.Width = 125;
            // 
            // nascimentoAluno
            // 
            this.nascimentoAluno.HeaderText = "Data de Nascimento";
            this.nascimentoAluno.MinimumWidth = 6;
            this.nascimentoAluno.Name = "nascimentoAluno";
            this.nascimentoAluno.ReadOnly = true;
            this.nascimentoAluno.Width = 125;
            // 
            // btnVerAluno
            // 
            this.btnVerAluno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAluno.Location = new System.Drawing.Point(21, 150);
            this.btnVerAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerAluno.Name = "btnVerAluno";
            this.btnVerAluno.Size = new System.Drawing.Size(207, 33);
            this.btnVerAluno.TabIndex = 1;
            this.btnVerAluno.Text = "Ver Perfil do Aluno";
            this.btnVerAluno.UseVisualStyleBackColor = true;
            this.btnVerAluno.Click += new System.EventHandler(this.btnVerAluno_Click);
            // 
            // btnVerVaga
            // 
            this.btnVerVaga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVaga.Location = new System.Drawing.Point(271, 150);
            this.btnVerVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerVaga.Name = "btnVerVaga";
            this.btnVerVaga.Size = new System.Drawing.Size(269, 33);
            this.btnVerVaga.TabIndex = 2;
            this.btnVerVaga.Text = "Ver Informações da Vaga";
            this.btnVerVaga.UseVisualStyleBackColor = true;
            this.btnVerVaga.Click += new System.EventHandler(this.btnVerVaga_Click);
            // 
            // lblAlunosInteresse
            // 
            this.lblAlunosInteresse.AutoSize = true;
            this.lblAlunosInteresse.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunosInteresse.Location = new System.Drawing.Point(593, 34);
            this.lblAlunosInteresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlunosInteresse.Name = "lblAlunosInteresse";
            this.lblAlunosInteresse.Size = new System.Drawing.Size(557, 45);
            this.lblAlunosInteresse.TabIndex = 3;
            this.lblAlunosInteresse.Text = "Alunos Interessados em suas vagas";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnVerAluno);
            this.pnlContent.Controls.Add(this.lblAlunosInteresse);
            this.pnlContent.Controls.Add(this.dgvAlunosInteressadosVaga);
            this.pnlContent.Controls.Add(this.btnVerVaga);
            this.pnlContent.Location = new System.Drawing.Point(95, 15);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1791, 786);
            this.pnlContent.TabIndex = 4;
            // 
            // FormAlunosInteressadosVaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(2101, 859);
            this.Controls.Add(this.pnlContent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAlunosInteressadosVaga";
            this.Text = "Alunos Interessados";
            this.Load += new System.EventHandler(this.FormAlunosInteressadosVaga_Load);
            this.SizeChanged += new System.EventHandler(this.FormAlunosInteressadosVaga_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosInteressadosVaga)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel pnlContent;
    }
}