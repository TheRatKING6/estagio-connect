namespace ECDesktopApp
{
    partial class FormInicioAluno
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblVagasTitle = new System.Windows.Forms.Label();
            this.tabctrlInicoAluno = new System.Windows.Forms.TabControl();
            this.tabPgRecommended = new System.Windows.Forms.TabPage();
            this.dgvVagasRecomendadas = new System.Windows.Forms.DataGridView();
            this.idvaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPgTodas = new System.Windows.Forms.TabPage();
            this.dgvTodasVagas = new System.Windows.Forms.DataGridView();
            this.idVagaTodas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaVagaTodas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVagaTodas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaVagaTodas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaVagaTodas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerVaga = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tabctrlInicoAluno.SuspendLayout();
            this.tabPgRecommended.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagasRecomendadas)).BeginInit();
            this.tabPgTodas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodasVagas)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(58, 26);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(652, 59);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bem vindo ao Estágio Connect, ";
            // 
            // lblVagasTitle
            // 
            this.lblVagasTitle.AutoSize = true;
            this.lblVagasTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVagasTitle.Location = new System.Drawing.Point(660, 153);
            this.lblVagasTitle.Name = "lblVagasTitle";
            this.lblVagasTitle.Size = new System.Drawing.Size(80, 33);
            this.lblVagasTitle.TabIndex = 4;
            this.lblVagasTitle.Text = "Vagas";
            // 
            // tabctrlInicoAluno
            // 
            this.tabctrlInicoAluno.Controls.Add(this.tabPgRecommended);
            this.tabctrlInicoAluno.Controls.Add(this.tabPgTodas);
            this.tabctrlInicoAluno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctrlInicoAluno.Location = new System.Drawing.Point(64, 192);
            this.tabctrlInicoAluno.Name = "tabctrlInicoAluno";
            this.tabctrlInicoAluno.SelectedIndex = 0;
            this.tabctrlInicoAluno.Size = new System.Drawing.Size(1190, 559);
            this.tabctrlInicoAluno.TabIndex = 5;
            // 
            // tabPgRecommended
            // 
            this.tabPgRecommended.Controls.Add(this.dgvVagasRecomendadas);
            this.tabPgRecommended.Location = new System.Drawing.Point(4, 28);
            this.tabPgRecommended.Name = "tabPgRecommended";
            this.tabPgRecommended.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgRecommended.Size = new System.Drawing.Size(1182, 527);
            this.tabPgRecommended.TabIndex = 0;
            this.tabPgRecommended.Text = "Vagas para você";
            this.tabPgRecommended.UseVisualStyleBackColor = true;
            // 
            // dgvVagasRecomendadas
            // 
            this.dgvVagasRecomendadas.AllowUserToAddRows = false;
            this.dgvVagasRecomendadas.AllowUserToDeleteRows = false;
            this.dgvVagasRecomendadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVagasRecomendadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvaga,
            this.empresaVaga,
            this.nomeVaga,
            this.areaVaga,
            this.cargaVaga});
            this.dgvVagasRecomendadas.Location = new System.Drawing.Point(23, 16);
            this.dgvVagasRecomendadas.Name = "dgvVagasRecomendadas";
            this.dgvVagasRecomendadas.ReadOnly = true;
            this.dgvVagasRecomendadas.Size = new System.Drawing.Size(1133, 480);
            this.dgvVagasRecomendadas.TabIndex = 0;
            // 
            // idvaga
            // 
            this.idvaga.HeaderText = "ID";
            this.idvaga.Name = "idvaga";
            this.idvaga.ReadOnly = true;
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
            this.areaVaga.HeaderText = "Especialização";
            this.areaVaga.Name = "areaVaga";
            this.areaVaga.ReadOnly = true;
            // 
            // cargaVaga
            // 
            this.cargaVaga.HeaderText = "Carga Horária";
            this.cargaVaga.Name = "cargaVaga";
            this.cargaVaga.ReadOnly = true;
            // 
            // tabPgTodas
            // 
            this.tabPgTodas.Controls.Add(this.dgvTodasVagas);
            this.tabPgTodas.Location = new System.Drawing.Point(4, 28);
            this.tabPgTodas.Name = "tabPgTodas";
            this.tabPgTodas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgTodas.Size = new System.Drawing.Size(1182, 527);
            this.tabPgTodas.TabIndex = 1;
            this.tabPgTodas.Text = "Todas";
            this.tabPgTodas.UseVisualStyleBackColor = true;
            // 
            // dgvTodasVagas
            // 
            this.dgvTodasVagas.AllowUserToAddRows = false;
            this.dgvTodasVagas.AllowUserToDeleteRows = false;
            this.dgvTodasVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodasVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVagaTodas,
            this.empresaVagaTodas,
            this.nomeVagaTodas,
            this.areaVagaTodas,
            this.cargaVagaTodas});
            this.dgvTodasVagas.Location = new System.Drawing.Point(23, 16);
            this.dgvTodasVagas.Name = "dgvTodasVagas";
            this.dgvTodasVagas.ReadOnly = true;
            this.dgvTodasVagas.Size = new System.Drawing.Size(1133, 480);
            this.dgvTodasVagas.TabIndex = 0;
            // 
            // idVagaTodas
            // 
            this.idVagaTodas.HeaderText = "ID";
            this.idVagaTodas.Name = "idVagaTodas";
            this.idVagaTodas.ReadOnly = true;
            // 
            // empresaVagaTodas
            // 
            this.empresaVagaTodas.HeaderText = "Empresa";
            this.empresaVagaTodas.Name = "empresaVagaTodas";
            this.empresaVagaTodas.ReadOnly = true;
            // 
            // nomeVagaTodas
            // 
            this.nomeVagaTodas.HeaderText = "Nome";
            this.nomeVagaTodas.Name = "nomeVagaTodas";
            this.nomeVagaTodas.ReadOnly = true;
            // 
            // areaVagaTodas
            // 
            this.areaVagaTodas.HeaderText = "Especialização";
            this.areaVagaTodas.Name = "areaVagaTodas";
            this.areaVagaTodas.ReadOnly = true;
            // 
            // cargaVagaTodas
            // 
            this.cargaVagaTodas.HeaderText = "Carga Horária";
            this.cargaVagaTodas.Name = "cargaVagaTodas";
            this.cargaVagaTodas.ReadOnly = true;
            // 
            // btnVerVaga
            // 
            this.btnVerVaga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVaga.Location = new System.Drawing.Point(1071, 156);
            this.btnVerVaga.Name = "btnVerVaga";
            this.btnVerVaga.Size = new System.Drawing.Size(179, 30);
            this.btnVerVaga.TabIndex = 6;
            this.btnVerVaga.Text = "Visualizar Detalhes...";
            this.btnVerVaga.UseVisualStyleBackColor = true;
            this.btnVerVaga.Click += new System.EventHandler(this.btnVerVaga_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblWelcome);
            this.pnlContent.Controls.Add(this.tabctrlInicoAluno);
            this.pnlContent.Controls.Add(this.btnVerVaga);
            this.pnlContent.Controls.Add(this.lblVagasTitle);
            this.pnlContent.Location = new System.Drawing.Point(72, 44);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1295, 800);
            this.pnlContent.TabIndex = 7;
            // 
            // FormInicioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1834, 1061);
            this.Controls.Add(this.pnlContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInicioAluno";
            this.Text = "Início";
            this.Load += new System.EventHandler(this.FormInicioAluno_Load);
            this.tabctrlInicoAluno.ResumeLayout(false);
            this.tabPgRecommended.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagasRecomendadas)).EndInit();
            this.tabPgTodas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodasVagas)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblVagasTitle;
        private System.Windows.Forms.TabControl tabctrlInicoAluno;
        private System.Windows.Forms.TabPage tabPgRecommended;
        private System.Windows.Forms.TabPage tabPgTodas;
        private System.Windows.Forms.DataGridView dgvVagasRecomendadas;
        private System.Windows.Forms.DataGridView dgvTodasVagas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVagaTodas;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaVagaTodas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVagaTodas;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaVagaTodas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaVagaTodas;
        private System.Windows.Forms.Button btnVerVaga;
        private System.Windows.Forms.Panel pnlContent;
    }
}