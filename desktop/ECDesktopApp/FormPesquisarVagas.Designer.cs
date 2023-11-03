namespace ECDesktopApp
{
    partial class FormPesquisarVagas
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
            this.dgvBuscaVaga = new System.Windows.Forms.DataGridView();
            this.idVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gpbBuscaVaga = new System.Windows.Forms.GroupBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEspecializacao = new System.Windows.Forms.Label();
            this.lblCarga = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtNomeVaga = new System.Windows.Forms.TextBox();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.cbxEspecializacao = new System.Windows.Forms.ComboBox();
            this.lblOrganizar = new System.Windows.Forms.Label();
            this.cbxOrganizar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVerVaga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaVaga)).BeginInit();
            this.gpbBuscaVaga.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscaVaga
            // 
            this.dgvBuscaVaga.AllowUserToAddRows = false;
            this.dgvBuscaVaga.AllowUserToDeleteRows = false;
            this.dgvBuscaVaga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaVaga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVaga,
            this.empresaVaga,
            this.nomeVaga,
            this.areaVaga,
            this.cargaVaga});
            this.dgvBuscaVaga.Location = new System.Drawing.Point(91, 305);
            this.dgvBuscaVaga.Name = "dgvBuscaVaga";
            this.dgvBuscaVaga.ReadOnly = true;
            this.dgvBuscaVaga.Size = new System.Drawing.Size(1297, 341);
            this.dgvBuscaVaga.TabIndex = 0;
            // 
            // idVaga
            // 
            this.idVaga.HeaderText = "ID";
            this.idVaga.Name = "idVaga";
            this.idVaga.ReadOnly = true;
            // 
            // empresaVaga
            // 
            this.empresaVaga.HeaderText = "Empresa";
            this.empresaVaga.Name = "empresaVaga";
            this.empresaVaga.ReadOnly = true;
            // 
            // nomeVaga
            // 
            this.nomeVaga.HeaderText = "Nome";
            this.nomeVaga.Name = "nomeVaga";
            this.nomeVaga.ReadOnly = true;
            // 
            // areaVaga
            // 
            this.areaVaga.HeaderText = "Area de Especialização";
            this.areaVaga.Name = "areaVaga";
            this.areaVaga.ReadOnly = true;
            // 
            // cargaVaga
            // 
            this.cargaVaga.HeaderText = "Carga Horária";
            this.cargaVaga.Name = "cargaVaga";
            this.cargaVaga.ReadOnly = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(638, 9);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(298, 36);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Burcar Vagas e Emprego";
            // 
            // gpbBuscaVaga
            // 
            this.gpbBuscaVaga.Controls.Add(this.cbxEspecializacao);
            this.gpbBuscaVaga.Controls.Add(this.txtCarga);
            this.gpbBuscaVaga.Controls.Add(this.txtNomeVaga);
            this.gpbBuscaVaga.Controls.Add(this.txtEmpresa);
            this.gpbBuscaVaga.Controls.Add(this.lblCarga);
            this.gpbBuscaVaga.Controls.Add(this.lblEspecializacao);
            this.gpbBuscaVaga.Controls.Add(this.lblNome);
            this.gpbBuscaVaga.Controls.Add(this.lblEmpresa);
            this.gpbBuscaVaga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscaVaga.Location = new System.Drawing.Point(91, 78);
            this.gpbBuscaVaga.Name = "gpbBuscaVaga";
            this.gpbBuscaVaga.Size = new System.Drawing.Size(1010, 195);
            this.gpbBuscaVaga.TabIndex = 2;
            this.gpbBuscaVaga.TabStop = false;
            this.gpbBuscaVaga.Text = "Buscar";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(30, 37);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(69, 19);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 133);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(107, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome da Vaga:";
            // 
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Location = new System.Drawing.Point(592, 37);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(108, 19);
            this.lblEspecializacao.TabIndex = 2;
            this.lblEspecializacao.Text = "Especialização:";
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Location = new System.Drawing.Point(592, 133);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(103, 19);
            this.lblCarga.TabIndex = 3;
            this.lblCarga.Text = "Carga Horária:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(105, 34);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(452, 27);
            this.txtEmpresa.TabIndex = 4;
            // 
            // txtNomeVaga
            // 
            this.txtNomeVaga.Location = new System.Drawing.Point(143, 130);
            this.txtNomeVaga.Name = "txtNomeVaga";
            this.txtNomeVaga.Size = new System.Drawing.Size(414, 27);
            this.txtNomeVaga.TabIndex = 5;
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(701, 130);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(293, 27);
            this.txtCarga.TabIndex = 6;
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
            this.cbxEspecializacao.Location = new System.Drawing.Point(705, 33);
            this.cbxEspecializacao.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEspecializacao.Name = "cbxEspecializacao";
            this.cbxEspecializacao.Size = new System.Drawing.Size(289, 28);
            this.cbxEspecializacao.TabIndex = 47;
            // 
            // lblOrganizar
            // 
            this.lblOrganizar.AutoSize = true;
            this.lblOrganizar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizar.Location = new System.Drawing.Point(1173, 242);
            this.lblOrganizar.Name = "lblOrganizar";
            this.lblOrganizar.Size = new System.Drawing.Size(149, 15);
            this.lblOrganizar.TabIndex = 10;
            this.lblOrganizar.Text = "Organizar resultados por:";
            // 
            // cbxOrganizar
            // 
            this.cbxOrganizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrganizar.FormattingEnabled = true;
            this.cbxOrganizar.Items.AddRange(new object[] {
            "Nome (Alfabético Crescente)",
            "Nome (Alfabético Decrescente)",
            "Empresa (Alfabético Crescente)",
            "Empresa (Alfabético Decrescente)",
            "Mais Antigas",
            "Mais Recentes"});
            this.cbxOrganizar.Location = new System.Drawing.Point(1176, 260);
            this.cbxOrganizar.Name = "cbxOrganizar";
            this.cbxOrganizar.Size = new System.Drawing.Size(212, 27);
            this.cbxOrganizar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1176, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(212, 35);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerVaga
            // 
            this.btnVerVaga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVaga.Location = new System.Drawing.Point(1176, 156);
            this.btnVerVaga.Name = "btnVerVaga";
            this.btnVerVaga.Size = new System.Drawing.Size(212, 30);
            this.btnVerVaga.TabIndex = 7;
            this.btnVerVaga.Text = "Visualizar Detalhes da Vaga";
            this.btnVerVaga.UseVisualStyleBackColor = true;
            this.btnVerVaga.Click += new System.EventHandler(this.btnVerVaga_Click);
            // 
            // FormPesquisarVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 658);
            this.Controls.Add(this.lblOrganizar);
            this.Controls.Add(this.cbxOrganizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVerVaga);
            this.Controls.Add(this.gpbBuscaVaga);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvBuscaVaga);
            this.Name = "FormPesquisarVagas";
            this.Text = "FormPesquisarVagas";
            this.Load += new System.EventHandler(this.FormPesquisarVagas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaVaga)).EndInit();
            this.gpbBuscaVaga.ResumeLayout(false);
            this.gpbBuscaVaga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscaVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaVaga;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.GroupBox gpbBuscaVaga;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.Label lblEspecializacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.TextBox txtNomeVaga;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.ComboBox cbxEspecializacao;
        private System.Windows.Forms.Label lblOrganizar;
        private System.Windows.Forms.ComboBox cbxOrganizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVerVaga;
    }
}