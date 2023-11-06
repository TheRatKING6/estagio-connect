namespace ECDesktopApp
{
    partial class FormConnect
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConnect = new System.Windows.Forms.DataGridView();
            this.btnVerVaga = new System.Windows.Forms.Button();
            this.btnVerAluno = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnect)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seus Connects";
            // 
            // dgvConnect
            // 
            this.dgvConnect.AllowUserToAddRows = false;
            this.dgvConnect.AllowUserToDeleteRows = false;
            this.dgvConnect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnect.Location = new System.Drawing.Point(22, 190);
            this.dgvConnect.Name = "dgvConnect";
            this.dgvConnect.ReadOnly = true;
            this.dgvConnect.Size = new System.Drawing.Size(1294, 345);
            this.dgvConnect.TabIndex = 1;
            // 
            // btnVerVaga
            // 
            this.btnVerVaga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVaga.Location = new System.Drawing.Point(22, 136);
            this.btnVerVaga.Name = "btnVerVaga";
            this.btnVerVaga.Size = new System.Drawing.Size(179, 27);
            this.btnVerVaga.TabIndex = 2;
            this.btnVerVaga.Text = "Ver Detalhes da Vaga";
            this.btnVerVaga.UseVisualStyleBackColor = true;
            this.btnVerVaga.Click += new System.EventHandler(this.btnVerVaga_Click);
            // 
            // btnVerAluno
            // 
            this.btnVerAluno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAluno.Location = new System.Drawing.Point(245, 136);
            this.btnVerAluno.Name = "btnVerAluno";
            this.btnVerAluno.Size = new System.Drawing.Size(153, 27);
            this.btnVerAluno.TabIndex = 3;
            this.btnVerAluno.Text = "Ver Perfil do Aluno";
            this.btnVerAluno.UseVisualStyleBackColor = true;
            this.btnVerAluno.Click += new System.EventHandler(this.btnVerAluno_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnVerVaga);
            this.pnlContent.Controls.Add(this.btnVerAluno);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.dgvConnect);
            this.pnlContent.Location = new System.Drawing.Point(86, 21);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1343, 637);
            this.pnlContent.TabIndex = 4;
            // 
            // FormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1643, 743);
            this.Controls.Add(this.pnlContent);
            this.Name = "FormConnect";
            this.Text = "Connects";
            this.Load += new System.EventHandler(this.FormConnect_Load);
            this.SizeChanged += new System.EventHandler(this.FormConnect_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnect)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConnect;
        private System.Windows.Forms.Button btnVerVaga;
        private System.Windows.Forms.Button btnVerAluno;
        private System.Windows.Forms.Panel pnlContent;
    }
}