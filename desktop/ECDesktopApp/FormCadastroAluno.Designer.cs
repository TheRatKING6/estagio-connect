namespace ECDesktopApp
{
    partial class FormCadastroAluno
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
            this.lblCadastroAluno = new System.Windows.Forms.Label();
            this.lblDescricaoCadAluno = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.msktxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.gpbInfoContato = new System.Windows.Forms.GroupBox();
            this.lblTelOpcional = new System.Windows.Forms.Label();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEspecializacao = new System.Windows.Forms.Label();
            this.cbxEspecializacao = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.msktxtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplmento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblEscola = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxAno = new System.Windows.Forms.ComboBox();
            this.txtEscola = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbSenha = new System.Windows.Forms.GroupBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblQuaseLa = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.gpbInfoContato.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.gpbSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastroAluno
            // 
            this.lblCadastroAluno.AutoSize = true;
            this.lblCadastroAluno.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroAluno.Location = new System.Drawing.Point(391, 16);
            this.lblCadastroAluno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCadastroAluno.Name = "lblCadastroAluno";
            this.lblCadastroAluno.Size = new System.Drawing.Size(212, 46);
            this.lblCadastroAluno.TabIndex = 1;
            this.lblCadastroAluno.Text = "Cadastrar-se";
            // 
            // lblDescricaoCadAluno
            // 
            this.lblDescricaoCadAluno.AutoSize = true;
            this.lblDescricaoCadAluno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoCadAluno.Location = new System.Drawing.Point(280, 63);
            this.lblDescricaoCadAluno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricaoCadAluno.Name = "lblDescricaoCadAluno";
            this.lblDescricaoCadAluno.Size = new System.Drawing.Size(428, 19);
            this.lblDescricaoCadAluno.TabIndex = 2;
            this.lblDescricaoCadAluno.Text = "Cadastre-se agora para achar a vaga de estágio ideal para você!";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(292, 154);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(437, 20);
            this.txtNome.TabIndex = 10;
            // 
            // msktxtCpf
            // 
            this.msktxtCpf.Location = new System.Drawing.Point(292, 122);
            this.msktxtCpf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msktxtCpf.Mask = "000,000,000-00";
            this.msktxtCpf.Name = "msktxtCpf";
            this.msktxtCpf.Size = new System.Drawing.Size(119, 20);
            this.msktxtCpf.TabIndex = 9;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(244, 157);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(244, 124);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(244, 192);
            this.lblNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblNascimento.TabIndex = 11;
            this.lblNascimento.Text = "Data de Nascimento:";
            // 
            // dateNascimento
            // 
            this.dateNascimento.CustomFormat = "";
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNascimento.Location = new System.Drawing.Point(349, 188);
            this.dateNascimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(111, 20);
            this.dateNascimento.TabIndex = 12;
            // 
            // gpbInfoContato
            // 
            this.gpbInfoContato.Controls.Add(this.lblTelOpcional);
            this.gpbInfoContato.Controls.Add(this.msktxtTelefone);
            this.gpbInfoContato.Controls.Add(this.txtEmail);
            this.gpbInfoContato.Controls.Add(this.lblEmail);
            this.gpbInfoContato.Controls.Add(this.lblTelefone);
            this.gpbInfoContato.Location = new System.Drawing.Point(239, 538);
            this.gpbInfoContato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbInfoContato.Name = "gpbInfoContato";
            this.gpbInfoContato.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbInfoContato.Size = new System.Drawing.Size(518, 101);
            this.gpbInfoContato.TabIndex = 13;
            this.gpbInfoContato.TabStop = false;
            this.gpbInfoContato.Text = "Informações de contato";
            // 
            // lblTelOpcional
            // 
            this.lblTelOpcional.AutoSize = true;
            this.lblTelOpcional.Location = new System.Drawing.Point(271, 67);
            this.lblTelOpcional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelOpcional.Name = "lblTelOpcional";
            this.lblTelOpcional.Size = new System.Drawing.Size(55, 13);
            this.lblTelOpcional.TabIndex = 11;
            this.lblTelOpcional.Text = "(Opcional)";
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Location = new System.Drawing.Point(130, 67);
            this.msktxtTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msktxtTelefone.Mask = "(00) 0000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(121, 20);
            this.msktxtTelefone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 31);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 31);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(102, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-Mail para contato:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(18, 67);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(115, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone para contato:";
            // 
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Location = new System.Drawing.Point(243, 223);
            this.lblEspecializacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(121, 13);
            this.lblEspecializacao.TabIndex = 14;
            this.lblEspecializacao.Text = "Área de Especialização:";
            // 
            // cbxEspecializacao
            // 
            this.cbxEspecializacao.FormattingEnabled = true;
            this.cbxEspecializacao.Items.AddRange(new object[] {
            "Química",
            "Desenvolvimento de Sistemas",
            "Arquitetura/Engenharia",
            "Mecânica Industrial",
            "Enfermagem",
            "Qualidade de produção"});
            this.cbxEspecializacao.Location = new System.Drawing.Point(363, 221);
            this.cbxEspecializacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEspecializacao.Name = "cbxEspecializacao";
            this.cbxEspecializacao.Size = new System.Drawing.Size(171, 21);
            this.cbxEspecializacao.TabIndex = 15;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(247, 691);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(426, 90);
            this.txtDescricao.TabIndex = 17;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(244, 663);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(107, 13);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descrição: (opcional)";
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
            this.gpbEndereco.Location = new System.Drawing.Point(239, 335);
            this.gpbEndereco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbEndereco.Size = new System.Drawing.Size(518, 181);
            this.gpbEndereco.TabIndex = 18;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço:";
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cbbEstado.Location = new System.Drawing.Point(63, 143);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(92, 21);
            this.cbbEstado.TabIndex = 13;
            // 
            // msktxtCep
            // 
            this.msktxtCep.Location = new System.Drawing.Point(421, 109);
            this.msktxtCep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msktxtCep.Mask = "00000-000";
            this.msktxtCep.Name = "msktxtCep";
            this.msktxtCep.Size = new System.Drawing.Size(78, 20);
            this.msktxtCep.TabIndex = 12;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(63, 109);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(322, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(436, 36);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 20);
            this.txtNumero.TabIndex = 10;
            // 
            // txtComplmento
            // 
            this.txtComplmento.Location = new System.Drawing.Point(370, 76);
            this.txtComplmento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComplmento.Name = "txtComplmento";
            this.txtComplmento.Size = new System.Drawing.Size(144, 20);
            this.txtComplmento.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(57, 76);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(236, 20);
            this.txtBairro.TabIndex = 8;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(49, 36);
            this.txtRua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(336, 20);
            this.txtRua.TabIndex = 7;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(388, 111);
            this.lblCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(18, 143);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(18, 111);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(295, 79);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 3;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(388, 36);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(47, 13);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Número:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(18, 76);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 1;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(18, 36);
            this.lblRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 0;
            this.lblRua.Text = "Rua:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(244, 261);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(635, 292);
            this.lblAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(57, 13);
            this.lblAno.TabIndex = 20;
            this.lblAno.Text = "Ano letivo:";
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Location = new System.Drawing.Point(244, 292);
            this.lblEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(42, 13);
            this.lblEscola.TabIndex = 21;
            this.lblEscola.Text = "Escola:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Estudando",
            "Estudos Concluidos",
            "Empregado",
            "Empregado e Estudando"});
            this.cbxStatus.Location = new System.Drawing.Point(292, 261);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(243, 21);
            this.cbxStatus.TabIndex = 22;
            // 
            // cbxAno
            // 
            this.cbxAno.FormattingEnabled = true;
            this.cbxAno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxAno.Location = new System.Drawing.Point(692, 290);
            this.cbxAno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxAno.Name = "cbxAno";
            this.cbxAno.Size = new System.Drawing.Size(59, 21);
            this.cbxAno.TabIndex = 23;
            // 
            // txtEscola
            // 
            this.txtEscola.Location = new System.Drawing.Point(288, 292);
            this.txtEscola.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(336, 20);
            this.txtEscola.TabIndex = 24;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(283, 1022);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(348, 34);
            this.btnCadastro.TabIndex = 29;
            this.btnCadastro.Text = "Finalizar Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(668, 826);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 19);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gpbSenha
            // 
            this.gpbSenha.Controls.Add(this.txtConfirmaSenha);
            this.gpbSenha.Controls.Add(this.txtSenha);
            this.gpbSenha.Controls.Add(this.lblConfirmaSenha);
            this.gpbSenha.Controls.Add(this.lblSenha);
            this.gpbSenha.Location = new System.Drawing.Point(247, 849);
            this.gpbSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbSenha.Name = "gpbSenha";
            this.gpbSenha.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbSenha.Size = new System.Drawing.Size(418, 145);
            this.gpbSenha.TabIndex = 27;
            this.gpbSenha.TabStop = false;
            this.gpbSenha.Text = "Senha";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(18, 99);
            this.txtConfirmaSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(367, 20);
            this.txtConfirmaSenha.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(57, 32);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(328, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(16, 75);
            this.lblConfirmaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(103, 13);
            this.lblConfirmaSenha.TabIndex = 1;
            this.lblConfirmaSenha.Text = "Confirme sua senha:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(16, 34);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            // 
            // lblQuaseLa
            // 
            this.lblQuaseLa.AutoSize = true;
            this.lblQuaseLa.Location = new System.Drawing.Point(244, 802);
            this.lblQuaseLa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuaseLa.Name = "lblQuaseLa";
            this.lblQuaseLa.Size = new System.Drawing.Size(449, 13);
            this.lblQuaseLa.TabIndex = 26;
            this.lblQuaseLa.Text = "Está quase tudo pronto. Tudo o que falta agora é colocar uma senha para proteger " +
    "sua conta";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(668, 797);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 24);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = "Continuar";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(479, 192);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(110, 13);
            this.lblMatricula.TabIndex = 30;
            this.lblMatricula.Text = "Número de Matrícula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(592, 189);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(159, 20);
            this.txtMatricula.TabIndex = 31;
            // 
            // FormCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 1061);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbSenha);
            this.Controls.Add(this.lblQuaseLa);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtEscola);
            this.Controls.Add(this.cbxAno);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.lblEscola);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.cbxEspecializacao);
            this.Controls.Add(this.lblEspecializacao);
            this.Controls.Add(this.gpbInfoContato);
            this.Controls.Add(this.dateNascimento);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.msktxtCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDescricaoCadAluno);
            this.Controls.Add(this.lblCadastroAluno);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCadastroAluno";
            this.Text = "Cadastrar-se";
            this.Load += new System.EventHandler(this.FormCadastroAluno_Load);
            this.gpbInfoContato.ResumeLayout(false);
            this.gpbInfoContato.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.gpbSenha.ResumeLayout(false);
            this.gpbSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroAluno;
        private System.Windows.Forms.Label lblDescricaoCadAluno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox msktxtCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.GroupBox gpbInfoContato;
        private System.Windows.Forms.Label lblTelOpcional;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEspecializacao;
        private System.Windows.Forms.ComboBox cbxEspecializacao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.MaskedTextBox msktxtCep;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplmento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ComboBox cbxAno;
        private System.Windows.Forms.TextBox txtEscola;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gpbSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblQuaseLa;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
    }
}