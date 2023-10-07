namespace ECDesktopApp
{
    partial class FormCadastroEmpresa
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
            this.lblCadastroEmpresa = new System.Windows.Forms.Label();
            this.lblDescricaoCadEmpresa = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplmento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.msktxtCep = new System.Windows.Forms.MaskedTextBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.msktxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.gpbInfoContato = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelOpcional = new System.Windows.Forms.Label();
            this.lblRamo = new System.Windows.Forms.Label();
            this.txtRamo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblQuaseLa = new System.Windows.Forms.Label();
            this.gpbSenha = new System.Windows.Forms.GroupBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.gpbEndereco.SuspendLayout();
            this.gpbInfoContato.SuspendLayout();
            this.gpbSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastroEmpresa
            // 
            this.lblCadastroEmpresa.AutoSize = true;
            this.lblCadastroEmpresa.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroEmpresa.Location = new System.Drawing.Point(416, 28);
            this.lblCadastroEmpresa.Name = "lblCadastroEmpresa";
            this.lblCadastroEmpresa.Size = new System.Drawing.Size(461, 58);
            this.lblCadastroEmpresa.TabIndex = 0;
            this.lblCadastroEmpresa.Text = "Cadastrar sua empresa";
            // 
            // lblDescricaoCadEmpresa
            // 
            this.lblDescricaoCadEmpresa.AutoSize = true;
            this.lblDescricaoCadEmpresa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoCadEmpresa.Location = new System.Drawing.Point(329, 86);
            this.lblDescricaoCadEmpresa.Name = "lblDescricaoCadEmpresa";
            this.lblDescricaoCadEmpresa.Size = new System.Drawing.Size(670, 24);
            this.lblDescricaoCadEmpresa.TabIndex = 1;
            this.lblDescricaoCadEmpresa.Text = "Cadastre sua empresa agora para facilitar e agilizar o processo de contratação!";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(306, 190);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(45, 16);
            this.lblCnpj.TabIndex = 2;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(309, 230);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(102, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome Fantasia:";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.cbbEstado);
            this.gpbEndereco.Controls.Add(this.msktxtCep);
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.txtComplmento);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.txtRua);
            this.gpbEndereco.Controls.Add(this.lblCep);
            this.gpbEndereco.Controls.Add(this.lblEstado);
            this.gpbEndereco.Controls.Add(this.lblCidade);
            this.gpbEndereco.Controls.Add(this.lblComplemento);
            this.gpbEndereco.Controls.Add(this.lblNum);
            this.gpbEndereco.Controls.Add(this.lblBairro);
            this.gpbEndereco.Controls.Add(this.lblRua);
            this.gpbEndereco.Location = new System.Drawing.Point(309, 323);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(690, 223);
            this.gpbEndereco.TabIndex = 4;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(24, 44);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(35, 16);
            this.lblRua.TabIndex = 0;
            this.lblRua.Text = "Rua:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(24, 94);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 16);
            this.lblBairro.TabIndex = 1;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(518, 44);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(58, 16);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Número:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(393, 97);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(94, 16);
            this.lblComplemento.TabIndex = 3;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(24, 137);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 16);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(24, 176);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(518, 137);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(37, 16);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(65, 44);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(447, 22);
            this.txtRua.TabIndex = 7;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(76, 94);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(314, 22);
            this.txtBairro.TabIndex = 8;
            // 
            // txtComplmento
            // 
            this.txtComplmento.Location = new System.Drawing.Point(493, 94);
            this.txtComplmento.Name = "txtComplmento";
            this.txtComplmento.Size = new System.Drawing.Size(191, 22);
            this.txtComplmento.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(582, 44);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(102, 22);
            this.txtNumero.TabIndex = 10;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(84, 134);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(428, 22);
            this.txtCidade.TabIndex = 11;
            // 
            // msktxtCep
            // 
            this.msktxtCep.Location = new System.Drawing.Point(561, 134);
            this.msktxtCep.Mask = "00000-000";
            this.msktxtCep.Name = "msktxtCep";
            this.msktxtCep.Size = new System.Drawing.Size(102, 22);
            this.msktxtCep.TabIndex = 12;
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(84, 176);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbbEstado.TabIndex = 13;
            // 
            // msktxtCnpj
            // 
            this.msktxtCnpj.Location = new System.Drawing.Point(370, 187);
            this.msktxtCnpj.Mask = "00,000,000/0000-00";
            this.msktxtCnpj.Name = "msktxtCnpj";
            this.msktxtCnpj.Size = new System.Drawing.Size(157, 22);
            this.msktxtCnpj.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(418, 227);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(581, 22);
            this.txtNome.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 38);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(126, 16);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-Mail para contato:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(24, 82);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(142, 16);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone para contato:";
            // 
            // gpbInfoContato
            // 
            this.gpbInfoContato.Controls.Add(this.lblTelOpcional);
            this.gpbInfoContato.Controls.Add(this.msktxtTelefone);
            this.gpbInfoContato.Controls.Add(this.txtEmail);
            this.gpbInfoContato.Controls.Add(this.lblEmail);
            this.gpbInfoContato.Controls.Add(this.lblTelefone);
            this.gpbInfoContato.Location = new System.Drawing.Point(309, 573);
            this.gpbInfoContato.Name = "gpbInfoContato";
            this.gpbInfoContato.Size = new System.Drawing.Size(690, 124);
            this.gpbInfoContato.TabIndex = 9;
            this.gpbInfoContato.TabStop = false;
            this.gpbInfoContato.Text = "Informações de contato";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(457, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Location = new System.Drawing.Point(173, 82);
            this.msktxtTelefone.Mask = "(00) 0000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(160, 22);
            this.msktxtTelefone.TabIndex = 10;
            // 
            // lblTelOpcional
            // 
            this.lblTelOpcional.AutoSize = true;
            this.lblTelOpcional.Location = new System.Drawing.Point(372, 88);
            this.lblTelOpcional.Name = "lblTelOpcional";
            this.lblTelOpcional.Size = new System.Drawing.Size(69, 16);
            this.lblTelOpcional.TabIndex = 11;
            this.lblTelOpcional.Text = "(Opcional)";
            // 
            // lblRamo
            // 
            this.lblRamo.AutoSize = true;
            this.lblRamo.Location = new System.Drawing.Point(312, 271);
            this.lblRamo.Name = "lblRamo";
            this.lblRamo.Size = new System.Drawing.Size(215, 16);
            this.lblRamo.TabIndex = 10;
            this.lblRamo.Text = "Ramo das atividades da empresa:";
            // 
            // txtRamo
            // 
            this.txtRamo.Location = new System.Drawing.Point(540, 268);
            this.txtRamo.Name = "txtRamo";
            this.txtRamo.Size = new System.Drawing.Size(459, 22);
            this.txtRamo.TabIndex = 11;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(315, 733);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(135, 16);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Descrição: (opcional)";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(318, 767);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(567, 110);
            this.txtDescricao.TabIndex = 13;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(870, 921);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(129, 29);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Continuar";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblQuaseLa
            // 
            this.lblQuaseLa.AutoSize = true;
            this.lblQuaseLa.Location = new System.Drawing.Point(306, 927);
            this.lblQuaseLa.Name = "lblQuaseLa";
            this.lblQuaseLa.Size = new System.Drawing.Size(561, 16);
            this.lblQuaseLa.TabIndex = 15;
            this.lblQuaseLa.Text = "Está quase tudo pronto. Tudo o que falta agora é colocar uma senha para proteger " +
    "sua conta";
            // 
            // gpbSenha
            // 
            this.gpbSenha.Controls.Add(this.txtConfirmaSenha);
            this.gpbSenha.Controls.Add(this.txtSenha);
            this.gpbSenha.Controls.Add(this.lblConfirmaSenha);
            this.gpbSenha.Controls.Add(this.lblSenha);
            this.gpbSenha.Location = new System.Drawing.Point(309, 985);
            this.gpbSenha.Name = "gpbSenha";
            this.gpbSenha.Size = new System.Drawing.Size(558, 178);
            this.gpbSenha.TabIndex = 16;
            this.gpbSenha.TabStop = false;
            this.gpbSenha.Text = "Senha";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(21, 42);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 16);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(21, 92);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(128, 16);
            this.lblConfirmaSenha.TabIndex = 1;
            this.lblConfirmaSenha.Text = "Confirme sua senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(76, 39);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(436, 22);
            this.txtSenha.TabIndex = 2;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(24, 122);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(488, 22);
            this.txtConfirmaSenha.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(870, 956);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 23);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(357, 1198);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(464, 42);
            this.btnCadastro.TabIndex = 18;
            this.btnCadastro.Text = "Finalizar Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // FormCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 1365);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbSenha);
            this.Controls.Add(this.lblQuaseLa);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtRamo);
            this.Controls.Add(this.lblRamo);
            this.Controls.Add(this.gpbInfoContato);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.msktxtCnpj);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblDescricaoCadEmpresa);
            this.Controls.Add(this.lblCadastroEmpresa);
            this.Name = "FormCadastroEmpresa";
            this.Text = "Cadastrar-se";
            this.Load += new System.EventHandler(this.FormCadastroEmpresa_Load);
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.gpbInfoContato.ResumeLayout(false);
            this.gpbInfoContato.PerformLayout();
            this.gpbSenha.ResumeLayout(false);
            this.gpbSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroEmpresa;
        private System.Windows.Forms.Label lblDescricaoCadEmpresa;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplmento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.MaskedTextBox msktxtCep;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox msktxtCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.GroupBox gpbInfoContato;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelOpcional;
        private System.Windows.Forms.Label lblRamo;
        private System.Windows.Forms.TextBox txtRamo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblQuaseLa;
        private System.Windows.Forms.GroupBox gpbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastro;
    }
}