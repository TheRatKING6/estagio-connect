namespace ECDesktopApp
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.pnlAluno = new System.Windows.Forms.Panel();
            this.picEmpresa = new System.Windows.Forms.PictureBox();
            this.picAluno = new System.Windows.Forms.PictureBox();
            this.btnCadEmpresa = new System.Windows.Forms.Button();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.lblSemCadastro = new System.Windows.Forms.Label();
            this.lblEu = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.pnlEmpresa.SuspendLayout();
            this.pnlAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(320, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(929, 161);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Estágio Connect";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(239, 170);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(1079, 37);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Bem-vindo ao Estágio Connect, a plataforma de divulgação e busca de vagas de está" +
    "gio";
            // 
            // pnlEmpresa
            // 
            this.pnlEmpresa.BackColor = System.Drawing.SystemColors.Info;
            this.pnlEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmpresa.Controls.Add(this.lblEmpresa);
            this.pnlEmpresa.Controls.Add(this.btnCadEmpresa);
            this.pnlEmpresa.Controls.Add(this.picEmpresa);
            this.pnlEmpresa.Location = new System.Drawing.Point(246, 400);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(440, 352);
            this.pnlEmpresa.TabIndex = 3;
            // 
            // pnlAluno
            // 
            this.pnlAluno.BackColor = System.Drawing.SystemColors.Info;
            this.pnlAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAluno.Controls.Add(this.lblAluno);
            this.pnlAluno.Controls.Add(this.btnCadAluno);
            this.pnlAluno.Controls.Add(this.picAluno);
            this.pnlAluno.Location = new System.Drawing.Point(878, 400);
            this.pnlAluno.Name = "pnlAluno";
            this.pnlAluno.Size = new System.Drawing.Size(440, 352);
            this.pnlAluno.TabIndex = 4;
            // 
            // picEmpresa
            // 
            this.picEmpresa.Location = new System.Drawing.Point(159, 36);
            this.picEmpresa.Name = "picEmpresa";
            this.picEmpresa.Size = new System.Drawing.Size(128, 128);
            this.picEmpresa.TabIndex = 0;
            this.picEmpresa.TabStop = false;
            // 
            // picAluno
            // 
            this.picAluno.Location = new System.Drawing.Point(149, 36);
            this.picAluno.Name = "picAluno";
            this.picAluno.Size = new System.Drawing.Size(128, 128);
            this.picAluno.TabIndex = 0;
            this.picAluno.TabStop = false;
            // 
            // btnCadEmpresa
            // 
            this.btnCadEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadEmpresa.Location = new System.Drawing.Point(146, 298);
            this.btnCadEmpresa.Name = "btnCadEmpresa";
            this.btnCadEmpresa.Size = new System.Drawing.Size(153, 40);
            this.btnCadEmpresa.TabIndex = 1;
            this.btnCadEmpresa.Text = "Cadastrar-se";
            this.btnCadEmpresa.UseVisualStyleBackColor = true;
            this.btnCadEmpresa.Click += new System.EventHandler(this.btnLoginEmpresa_Click);
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadAluno.Location = new System.Drawing.Point(135, 298);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(153, 40);
            this.btnCadAluno.TabIndex = 1;
            this.btnCadAluno.Text = "Cadastrar-se";
            this.btnCadAluno.UseVisualStyleBackColor = true;
            this.btnCadAluno.Click += new System.EventHandler(this.btnCadAluno_Click);
            // 
            // lblSemCadastro
            // 
            this.lblSemCadastro.AutoSize = true;
            this.lblSemCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSemCadastro.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemCadastro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSemCadastro.Location = new System.Drawing.Point(717, 777);
            this.lblSemCadastro.Name = "lblSemCadastro";
            this.lblSemCadastro.Size = new System.Drawing.Size(131, 21);
            this.lblSemCadastro.TabIndex = 5;
            this.lblSemCadastro.Text = "... já me cadastrei";
            this.lblSemCadastro.Click += new System.EventHandler(this.lblSemCadastro_Click);
            this.lblSemCadastro.MouseHover += new System.EventHandler(this.lblSemCadastro_MouseHover);
            // 
            // lblEu
            // 
            this.lblEu.AutoSize = true;
            this.lblEu.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEu.Location = new System.Drawing.Point(757, 349);
            this.lblEu.Name = "lblEu";
            this.lblEu.Size = new System.Drawing.Size(53, 28);
            this.lblEu.TabIndex = 6;
            this.lblEu.Text = "Eu...";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(94, 211);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(250, 35);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "... Sou uma Empresa";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(112, 211);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(204, 35);
            this.lblAluno.TabIndex = 2;
            this.lblAluno.Text = "... Sou um Aluno";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(703, 263);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(170, 49);
            this.lblCadastro.TabIndex = 7;
            this.lblCadastro.Text = "Cadastro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 1135);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.pnlAluno);
            this.Controls.Add(this.lblEu);
            this.Controls.Add(this.lblSemCadastro);
            this.Controls.Add(this.pnlEmpresa);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Estágio Connect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlEmpresa.ResumeLayout(false);
            this.pnlEmpresa.PerformLayout();
            this.pnlAluno.ResumeLayout(false);
            this.pnlAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.PictureBox picEmpresa;
        private System.Windows.Forms.Panel pnlAluno;
        private System.Windows.Forms.PictureBox picAluno;
        private System.Windows.Forms.Button btnCadEmpresa;
        private System.Windows.Forms.Button btnCadAluno;
        private System.Windows.Forms.Label lblSemCadastro;
        private System.Windows.Forms.Label lblEu;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblCadastro;
    }
}

