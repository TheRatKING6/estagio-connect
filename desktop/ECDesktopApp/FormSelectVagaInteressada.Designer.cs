namespace ECDesktopApp
{
    partial class FormSelectVagaInteressada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvVagas = new System.Windows.Forms.DataGridView();
            this.idVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especializacaoVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requisitosVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectVaga = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSelectVaga = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblSelectVaga);
            this.pnlContent.Controls.Add(this.btnCancelar);
            this.pnlContent.Controls.Add(this.btnSelectVaga);
            this.pnlContent.Controls.Add(this.dgvVagas);
            this.pnlContent.Location = new System.Drawing.Point(105, 36);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1248, 554);
            this.pnlContent.TabIndex = 0;
            // 
            // dgvVagas
            // 
            this.dgvVagas.AllowUserToAddRows = false;
            this.dgvVagas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVagas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVaga,
            this.nomeVaga,
            this.descricaoVaga,
            this.especializacaoVaga,
            this.requisitosVaga,
            this.cargaVaga});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVagas.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVagas.Location = new System.Drawing.Point(44, 111);
            this.dgvVagas.Name = "dgvVagas";
            this.dgvVagas.ReadOnly = true;
            this.dgvVagas.RowHeadersWidth = 51;
            this.dgvVagas.Size = new System.Drawing.Size(1157, 419);
            this.dgvVagas.TabIndex = 0;
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
            // descricaoVaga
            // 
            this.descricaoVaga.HeaderText = "Descrição da Vaga";
            this.descricaoVaga.Name = "descricaoVaga";
            this.descricaoVaga.ReadOnly = true;
            // 
            // especializacaoVaga
            // 
            this.especializacaoVaga.HeaderText = "Área de especialização procurada";
            this.especializacaoVaga.Name = "especializacaoVaga";
            this.especializacaoVaga.ReadOnly = true;
            // 
            // requisitosVaga
            // 
            this.requisitosVaga.HeaderText = "Requisitos";
            this.requisitosVaga.Name = "requisitosVaga";
            this.requisitosVaga.ReadOnly = true;
            // 
            // cargaVaga
            // 
            this.cargaVaga.HeaderText = "Carga Horária";
            this.cargaVaga.Name = "cargaVaga";
            this.cargaVaga.ReadOnly = true;
            // 
            // btnSelectVaga
            // 
            this.btnSelectVaga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectVaga.Location = new System.Drawing.Point(44, 59);
            this.btnSelectVaga.Name = "btnSelectVaga";
            this.btnSelectVaga.Size = new System.Drawing.Size(152, 31);
            this.btnSelectVaga.TabIndex = 1;
            this.btnSelectVaga.Text = "Selecionar vaga";
            this.btnSelectVaga.UseVisualStyleBackColor = true;
            this.btnSelectVaga.Click += new System.EventHandler(this.btnSelectVaga_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1115, 59);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Voltar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSelectVaga
            // 
            this.lblSelectVaga.AutoSize = true;
            this.lblSelectVaga.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVaga.Location = new System.Drawing.Point(374, 10);
            this.lblSelectVaga.Name = "lblSelectVaga";
            this.lblSelectVaga.Size = new System.Drawing.Size(505, 26);
            this.lblSelectVaga.TabIndex = 3;
            this.lblSelectVaga.Text = "Selecione a vaga que demonstrará interesse neste aluno:";
            // 
            // FormSelectVagaInteressada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1492, 616);
            this.Controls.Add(this.pnlContent);
            this.Name = "FormSelectVagaInteressada";
            this.Text = "Selecione a vaga interessada";
            this.Load += new System.EventHandler(this.FormSelectVagaInteressada_Load);
            this.ClientSizeChanged += new System.EventHandler(this.FormSelectVagaInteressada_ClientSizeChanged);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridView dgvVagas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn especializacaoVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn requisitosVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaVaga;
        private System.Windows.Forms.Label lblSelectVaga;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSelectVaga;
    }
}