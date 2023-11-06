namespace ECDesktopApp
{
    partial class FormPesquisarEmpresa
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
            this.dgvBuscaEmpresa = new System.Windows.Forms.DataGridView();
            this.idEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuscaEmpresa = new System.Windows.Forms.Label();
            this.gpbBuscaAluno = new System.Windows.Forms.GroupBox();
            this.txtRamo = new System.Windows.Forms.TextBox();
            this.lblRamo = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblOrganizar = new System.Windows.Forms.Label();
            this.cbxOrganizar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVerEmpresa = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaEmpresa)).BeginInit();
            this.gpbBuscaAluno.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscaEmpresa
            // 
            this.dgvBuscaEmpresa.AllowUserToAddRows = false;
            this.dgvBuscaEmpresa.AllowUserToDeleteRows = false;
            this.dgvBuscaEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpresa,
            this.nomeEmpresa,
            this.emailEmpresa,
            this.ramoEmpresa,
            this.cidadeEmpresa});
            this.dgvBuscaEmpresa.Location = new System.Drawing.Point(15, 365);
            this.dgvBuscaEmpresa.Name = "dgvBuscaEmpresa";
            this.dgvBuscaEmpresa.ReadOnly = true;
            this.dgvBuscaEmpresa.Size = new System.Drawing.Size(1290, 296);
            this.dgvBuscaEmpresa.TabIndex = 0;
            // 
            // idEmpresa
            // 
            this.idEmpresa.HeaderText = "ID";
            this.idEmpresa.Name = "idEmpresa";
            this.idEmpresa.ReadOnly = true;
            // 
            // nomeEmpresa
            // 
            this.nomeEmpresa.HeaderText = "Nome";
            this.nomeEmpresa.Name = "nomeEmpresa";
            this.nomeEmpresa.ReadOnly = true;
            // 
            // emailEmpresa
            // 
            this.emailEmpresa.HeaderText = "Email";
            this.emailEmpresa.Name = "emailEmpresa";
            this.emailEmpresa.ReadOnly = true;
            // 
            // ramoEmpresa
            // 
            this.ramoEmpresa.HeaderText = "Ramo de Atividades";
            this.ramoEmpresa.Name = "ramoEmpresa";
            this.ramoEmpresa.ReadOnly = true;
            // 
            // cidadeEmpresa
            // 
            this.cidadeEmpresa.HeaderText = "Cidade";
            this.cidadeEmpresa.Name = "cidadeEmpresa";
            this.cidadeEmpresa.ReadOnly = true;
            // 
            // lblBuscaEmpresa
            // 
            this.lblBuscaEmpresa.AutoSize = true;
            this.lblBuscaEmpresa.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaEmpresa.Location = new System.Drawing.Point(581, 4);
            this.lblBuscaEmpresa.Name = "lblBuscaEmpresa";
            this.lblBuscaEmpresa.Size = new System.Drawing.Size(219, 36);
            this.lblBuscaEmpresa.TabIndex = 3;
            this.lblBuscaEmpresa.Text = "Buscar Empresas";
            // 
            // gpbBuscaAluno
            // 
            this.gpbBuscaAluno.BackColor = System.Drawing.SystemColors.Control;
            this.gpbBuscaAluno.Controls.Add(this.txtRamo);
            this.gpbBuscaAluno.Controls.Add(this.lblRamo);
            this.gpbBuscaAluno.Controls.Add(this.txtCidade);
            this.gpbBuscaAluno.Controls.Add(this.lblCidade);
            this.gpbBuscaAluno.Controls.Add(this.txtEmail);
            this.gpbBuscaAluno.Controls.Add(this.txtNome);
            this.gpbBuscaAluno.Controls.Add(this.lblEmail);
            this.gpbBuscaAluno.Controls.Add(this.lblNome);
            this.gpbBuscaAluno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscaAluno.Location = new System.Drawing.Point(15, 60);
            this.gpbBuscaAluno.Name = "gpbBuscaAluno";
            this.gpbBuscaAluno.Size = new System.Drawing.Size(1010, 252);
            this.gpbBuscaAluno.TabIndex = 4;
            this.gpbBuscaAluno.TabStop = false;
            this.gpbBuscaAluno.Text = "Buscar";
            // 
            // txtRamo
            // 
            this.txtRamo.Location = new System.Drawing.Point(641, 48);
            this.txtRamo.Name = "txtRamo";
            this.txtRamo.Size = new System.Drawing.Size(350, 27);
            this.txtRamo.TabIndex = 50;
            // 
            // lblRamo
            // 
            this.lblRamo.AutoSize = true;
            this.lblRamo.Location = new System.Drawing.Point(580, 51);
            this.lblRamo.Name = "lblRamo";
            this.lblRamo.Size = new System.Drawing.Size(50, 19);
            this.lblRamo.TabIndex = 49;
            this.lblRamo.Text = "Ramo:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(641, 157);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(350, 27);
            this.txtCidade.TabIndex = 48;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(580, 160);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 19);
            this.lblCidade.TabIndex = 47;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(442, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(442, 27);
            this.txtNome.TabIndex = 4;
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(57, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblOrganizar
            // 
            this.lblOrganizar.AutoSize = true;
            this.lblOrganizar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizar.Location = new System.Drawing.Point(1090, 295);
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
            "Cidade (Alfabético Crescente)",
            "Cidade (Alfabético Decrescente)",
            "Ramo (Alfabético Crescente)",
            "Ramo (Alfabético Decrescente)"});
            this.cbxOrganizar.Location = new System.Drawing.Point(1093, 313);
            this.cbxOrganizar.Name = "cbxOrganizar";
            this.cbxOrganizar.Size = new System.Drawing.Size(212, 27);
            this.cbxOrganizar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1093, 168);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(212, 35);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerEmpresa
            // 
            this.btnVerEmpresa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEmpresa.Location = new System.Drawing.Point(1093, 209);
            this.btnVerEmpresa.Name = "btnVerEmpresa";
            this.btnVerEmpresa.Size = new System.Drawing.Size(212, 30);
            this.btnVerEmpresa.TabIndex = 7;
            this.btnVerEmpresa.Text = "Visualizar Perfil da Empresa";
            this.btnVerEmpresa.UseVisualStyleBackColor = true;
            this.btnVerEmpresa.Click += new System.EventHandler(this.btnVerEmpresa_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.gpbBuscaAluno);
            this.pnlContent.Controls.Add(this.lblOrganizar);
            this.pnlContent.Controls.Add(this.dgvBuscaEmpresa);
            this.pnlContent.Controls.Add(this.cbxOrganizar);
            this.pnlContent.Controls.Add(this.lblBuscaEmpresa);
            this.pnlContent.Controls.Add(this.btnBuscar);
            this.pnlContent.Controls.Add(this.btnVerEmpresa);
            this.pnlContent.Location = new System.Drawing.Point(69, 12);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1336, 702);
            this.pnlContent.TabIndex = 11;
            // 
            // FormPesquisarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1526, 707);
            this.Controls.Add(this.pnlContent);
            this.Name = "FormPesquisarEmpresa";
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.FormPesquisarEmpresa_Load);
            this.SizeChanged += new System.EventHandler(this.FormPesquisarEmpresa_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaEmpresa)).EndInit();
            this.gpbBuscaAluno.ResumeLayout(false);
            this.gpbBuscaAluno.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscaEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ramoEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeEmpresa;
        private System.Windows.Forms.Label lblBuscaEmpresa;
        private System.Windows.Forms.GroupBox gpbBuscaAluno;
        private System.Windows.Forms.TextBox txtRamo;
        private System.Windows.Forms.Label lblRamo;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblOrganizar;
        private System.Windows.Forms.ComboBox cbxOrganizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVerEmpresa;
        private System.Windows.Forms.Panel pnlContent;
    }
}