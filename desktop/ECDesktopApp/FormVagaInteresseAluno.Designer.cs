namespace ECDesktopApp
{
    partial class FormVagaInteresseAluno
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
            this.tabCtrlVagasInteressadas = new System.Windows.Forms.TabControl();
            this.tabPgInteresseSeu = new System.Windows.Forms.TabPage();
            this.btnVerVagaSeuInteresse = new System.Windows.Forms.Button();
            this.lblSeuInteresse = new System.Windows.Forms.Label();
            this.dgvSeuInteresse = new System.Windows.Forms.DataGridView();
            this.idVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especializacaoVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPgInteressadaVoce = new System.Windows.Forms.TabPage();
            this.btnVerVagaInteresseVoce = new System.Windows.Forms.Button();
            this.lblInteresseVoce = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idVagaVoce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVagaVoce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaVagaVoce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especializacaoVagaVoce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaVagaVoce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVagas = new System.Windows.Forms.Label();
            this.tabCtrlVagasInteressadas.SuspendLayout();
            this.tabPgInteresseSeu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeuInteresse)).BeginInit();
            this.tabPgInteressadaVoce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlVagasInteressadas
            // 
            this.tabCtrlVagasInteressadas.Controls.Add(this.tabPgInteresseSeu);
            this.tabCtrlVagasInteressadas.Controls.Add(this.tabPgInteressadaVoce);
            this.tabCtrlVagasInteressadas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlVagasInteressadas.Location = new System.Drawing.Point(103, 86);
            this.tabCtrlVagasInteressadas.Name = "tabCtrlVagasInteressadas";
            this.tabCtrlVagasInteressadas.SelectedIndex = 0;
            this.tabCtrlVagasInteressadas.Size = new System.Drawing.Size(1282, 721);
            this.tabCtrlVagasInteressadas.TabIndex = 0;
            // 
            // tabPgInteresseSeu
            // 
            this.tabPgInteresseSeu.Controls.Add(this.btnVerVagaSeuInteresse);
            this.tabPgInteresseSeu.Controls.Add(this.lblSeuInteresse);
            this.tabPgInteresseSeu.Controls.Add(this.dgvSeuInteresse);
            this.tabPgInteresseSeu.Location = new System.Drawing.Point(4, 28);
            this.tabPgInteresseSeu.Name = "tabPgInteresseSeu";
            this.tabPgInteresseSeu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgInteresseSeu.Size = new System.Drawing.Size(1274, 689);
            this.tabPgInteresseSeu.TabIndex = 0;
            this.tabPgInteresseSeu.Text = "Seus Interesses";
            this.tabPgInteresseSeu.UseVisualStyleBackColor = true;
            // 
            // btnVerVagaSeuInteresse
            // 
            this.btnVerVagaSeuInteresse.Location = new System.Drawing.Point(1062, 34);
            this.btnVerVagaSeuInteresse.Name = "btnVerVagaSeuInteresse";
            this.btnVerVagaSeuInteresse.Size = new System.Drawing.Size(163, 28);
            this.btnVerVagaSeuInteresse.TabIndex = 2;
            this.btnVerVagaSeuInteresse.Text = "Ver detalhes da vaga";
            this.btnVerVagaSeuInteresse.UseVisualStyleBackColor = true;
            this.btnVerVagaSeuInteresse.Click += new System.EventHandler(this.btnVerVagaSeuInteresse_Click);
            // 
            // lblSeuInteresse
            // 
            this.lblSeuInteresse.AutoSize = true;
            this.lblSeuInteresse.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeuInteresse.Location = new System.Drawing.Point(33, 34);
            this.lblSeuInteresse.Name = "lblSeuInteresse";
            this.lblSeuInteresse.Size = new System.Drawing.Size(204, 36);
            this.lblSeuInteresse.TabIndex = 1;
            this.lblSeuInteresse.Text = "Seus Interesses";
            // 
            // dgvSeuInteresse
            // 
            this.dgvSeuInteresse.AllowUserToAddRows = false;
            this.dgvSeuInteresse.AllowUserToDeleteRows = false;
            this.dgvSeuInteresse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeuInteresse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVaga,
            this.nomeVaga,
            this.empresaVaga,
            this.especializacaoVaga,
            this.cargaVaga});
            this.dgvSeuInteresse.Location = new System.Drawing.Point(39, 97);
            this.dgvSeuInteresse.Name = "dgvSeuInteresse";
            this.dgvSeuInteresse.ReadOnly = true;
            this.dgvSeuInteresse.Size = new System.Drawing.Size(1186, 572);
            this.dgvSeuInteresse.TabIndex = 0;
            // 
            // idVaga
            // 
            this.idVaga.HeaderText = "ID";
            this.idVaga.Name = "idVaga";
            this.idVaga.ReadOnly = true;
            // 
            // nomeVaga
            // 
            this.nomeVaga.HeaderText = "Nome";
            this.nomeVaga.Name = "nomeVaga";
            this.nomeVaga.ReadOnly = true;
            // 
            // empresaVaga
            // 
            this.empresaVaga.HeaderText = "Empresa";
            this.empresaVaga.Name = "empresaVaga";
            this.empresaVaga.ReadOnly = true;
            // 
            // especializacaoVaga
            // 
            this.especializacaoVaga.HeaderText = "Área de Especialização";
            this.especializacaoVaga.Name = "especializacaoVaga";
            this.especializacaoVaga.ReadOnly = true;
            // 
            // cargaVaga
            // 
            this.cargaVaga.HeaderText = "Carga Horária";
            this.cargaVaga.Name = "cargaVaga";
            this.cargaVaga.ReadOnly = true;
            // 
            // tabPgInteressadaVoce
            // 
            this.tabPgInteressadaVoce.Controls.Add(this.btnVerVagaInteresseVoce);
            this.tabPgInteressadaVoce.Controls.Add(this.lblInteresseVoce);
            this.tabPgInteressadaVoce.Controls.Add(this.dataGridView1);
            this.tabPgInteressadaVoce.Location = new System.Drawing.Point(4, 28);
            this.tabPgInteressadaVoce.Name = "tabPgInteressadaVoce";
            this.tabPgInteressadaVoce.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgInteressadaVoce.Size = new System.Drawing.Size(1274, 689);
            this.tabPgInteressadaVoce.TabIndex = 1;
            this.tabPgInteressadaVoce.Text = "Interessadas em você";
            this.tabPgInteressadaVoce.UseVisualStyleBackColor = true;
            // 
            // btnVerVagaInteresseVoce
            // 
            this.btnVerVagaInteresseVoce.Location = new System.Drawing.Point(1062, 34);
            this.btnVerVagaInteresseVoce.Name = "btnVerVagaInteresseVoce";
            this.btnVerVagaInteresseVoce.Size = new System.Drawing.Size(163, 28);
            this.btnVerVagaInteresseVoce.TabIndex = 2;
            this.btnVerVagaInteresseVoce.Text = "Ver detalhes da vaga";
            this.btnVerVagaInteresseVoce.UseVisualStyleBackColor = true;
            this.btnVerVagaInteresseVoce.Click += new System.EventHandler(this.btnVerVagaInteresseVoce_Click);
            // 
            // lblInteresseVoce
            // 
            this.lblInteresseVoce.AutoSize = true;
            this.lblInteresseVoce.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteresseVoce.Location = new System.Drawing.Point(33, 34);
            this.lblInteresseVoce.Name = "lblInteresseVoce";
            this.lblInteresseVoce.Size = new System.Drawing.Size(279, 36);
            this.lblInteresseVoce.TabIndex = 1;
            this.lblInteresseVoce.Text = "Interessadas em você";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVagaVoce,
            this.nomeVagaVoce,
            this.empresaVagaVoce,
            this.especializacaoVagaVoce,
            this.cargaVagaVoce});
            this.dataGridView1.Location = new System.Drawing.Point(39, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1186, 572);
            this.dataGridView1.TabIndex = 0;
            // 
            // idVagaVoce
            // 
            this.idVagaVoce.HeaderText = "ID";
            this.idVagaVoce.Name = "idVagaVoce";
            this.idVagaVoce.ReadOnly = true;
            // 
            // nomeVagaVoce
            // 
            this.nomeVagaVoce.HeaderText = "Nome";
            this.nomeVagaVoce.Name = "nomeVagaVoce";
            this.nomeVagaVoce.ReadOnly = true;
            // 
            // empresaVagaVoce
            // 
            this.empresaVagaVoce.HeaderText = "Empresa";
            this.empresaVagaVoce.Name = "empresaVagaVoce";
            this.empresaVagaVoce.ReadOnly = true;
            // 
            // especializacaoVagaVoce
            // 
            this.especializacaoVagaVoce.HeaderText = "Área de Especialização";
            this.especializacaoVagaVoce.Name = "especializacaoVagaVoce";
            this.especializacaoVagaVoce.ReadOnly = true;
            // 
            // cargaVagaVoce
            // 
            this.cargaVagaVoce.HeaderText = "Carga Horária";
            this.cargaVagaVoce.Name = "cargaVagaVoce";
            this.cargaVagaVoce.ReadOnly = true;
            // 
            // lblVagas
            // 
            this.lblVagas.AutoSize = true;
            this.lblVagas.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVagas.Location = new System.Drawing.Point(668, 9);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(139, 59);
            this.lblVagas.TabIndex = 1;
            this.lblVagas.Text = "Vagas";
            // 
            // FormVagaInteresseAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1535, 925);
            this.Controls.Add(this.lblVagas);
            this.Controls.Add(this.tabCtrlVagasInteressadas);
            this.Name = "FormVagaInteresseAluno";
            this.Text = "Vagas Interessadas";
            this.Load += new System.EventHandler(this.FormVagaInteresseAluno_Load);
            this.SizeChanged += new System.EventHandler(this.FormVagaInteresseAluno_SizeChanged);
            this.tabCtrlVagasInteressadas.ResumeLayout(false);
            this.tabPgInteresseSeu.ResumeLayout(false);
            this.tabPgInteresseSeu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeuInteresse)).EndInit();
            this.tabPgInteressadaVoce.ResumeLayout(false);
            this.tabPgInteressadaVoce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlVagasInteressadas;
        private System.Windows.Forms.TabPage tabPgInteresseSeu;
        private System.Windows.Forms.TabPage tabPgInteressadaVoce;
        private System.Windows.Forms.DataGridView dgvSeuInteresse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn especializacaoVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaVaga;
        private System.Windows.Forms.Label lblSeuInteresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVagaVoce;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVagaVoce;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaVagaVoce;
        private System.Windows.Forms.DataGridViewTextBoxColumn especializacaoVagaVoce;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaVagaVoce;
        private System.Windows.Forms.Button btnVerVagaSeuInteresse;
        private System.Windows.Forms.Button btnVerVagaInteresseVoce;
        private System.Windows.Forms.Label lblInteresseVoce;
        private System.Windows.Forms.Label lblVagas;
    }
}