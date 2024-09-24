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
            this.picBoxFotoAluno = new System.Windows.Forms.PictureBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnLimparCurriculo = new System.Windows.Forms.Button();
            this.btnEscolherCurriculo = new System.Windows.Forms.Button();
            this.txtArquivoCurriculo = new System.Windows.Forms.TextBox();
            this.lblCurriculo = new System.Windows.Forms.Label();
            this.gpbInfoContato.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.gpbSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFotoAluno)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastroAluno
            // 
            this.lblCadastroAluno.AutoSize = true;
            this.lblCadastroAluno.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroAluno.Location = new System.Drawing.Point(239, 5);
            this.lblCadastroAluno.Name = "lblCadastroAluno";
            this.lblCadastroAluno.Size = new System.Drawing.Size(262, 58);
            this.lblCadastroAluno.TabIndex = 1;
            this.lblCadastroAluno.Text = "Cadastrar-se";
            // 
            // lblDescricaoCadAluno
            // 
            this.lblDescricaoCadAluno.AutoSize = true;
            this.lblDescricaoCadAluno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoCadAluno.Location = new System.Drawing.Point(91, 63);
            this.lblDescricaoCadAluno.Name = "lblDescricaoCadAluno";
            this.lblDescricaoCadAluno.Size = new System.Drawing.Size(542, 24);
            this.lblDescricaoCadAluno.TabIndex = 2;
            this.lblDescricaoCadAluno.Text = "Cadastre-se agora para achar a vaga de estágio ideal para você!";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(107, 175);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(581, 22);
            this.txtNome.TabIndex = 10;
            // 
            // msktxtCpf
            // 
            this.msktxtCpf.Location = new System.Drawing.Point(107, 135);
            this.msktxtCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxtCpf.Mask = "000,000,000-00";
            this.msktxtCpf.Name = "msktxtCpf";
            this.msktxtCpf.Size = new System.Drawing.Size(157, 22);
            this.msktxtCpf.TabIndex = 9;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(43, 178);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(43, 138);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(36, 16);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(43, 222);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(133, 16);
            this.lblNascimento.TabIndex = 11;
            this.lblNascimento.Text = "Data de Nascimento:";
            // 
            // dateNascimento
            // 
            this.dateNascimento.CustomFormat = "";
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNascimento.Location = new System.Drawing.Point(183, 217);
            this.dateNascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(147, 22);
            this.dateNascimento.TabIndex = 12;
            // 
            // gpbInfoContato
            // 
            this.gpbInfoContato.BackColor = System.Drawing.SystemColors.Control;
            this.gpbInfoContato.Controls.Add(this.lblTelOpcional);
            this.gpbInfoContato.Controls.Add(this.msktxtTelefone);
            this.gpbInfoContato.Controls.Add(this.txtEmail);
            this.gpbInfoContato.Controls.Add(this.lblEmail);
            this.gpbInfoContato.Controls.Add(this.lblTelefone);
            this.gpbInfoContato.Location = new System.Drawing.Point(36, 647);
            this.gpbInfoContato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInfoContato.Name = "gpbInfoContato";
            this.gpbInfoContato.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInfoContato.Size = new System.Drawing.Size(691, 124);
            this.gpbInfoContato.TabIndex = 13;
            this.gpbInfoContato.TabStop = false;
            this.gpbInfoContato.Text = "Informações de contato";
            // 
            // lblTelOpcional
            // 
            this.lblTelOpcional.AutoSize = true;
            this.lblTelOpcional.Location = new System.Drawing.Point(361, 82);
            this.lblTelOpcional.Name = "lblTelOpcional";
            this.lblTelOpcional.Size = new System.Drawing.Size(69, 16);
            this.lblTelOpcional.TabIndex = 11;
            this.lblTelOpcional.Text = "(Opcional)";
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Location = new System.Drawing.Point(173, 82);
            this.msktxtTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxtTelefone.Mask = "(00) 0000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(160, 22);
            this.msktxtTelefone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 38);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(457, 22);
            this.txtEmail.TabIndex = 9;
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
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Location = new System.Drawing.Point(41, 260);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(154, 16);
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
            this.cbxEspecializacao.Location = new System.Drawing.Point(201, 257);
            this.cbxEspecializacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEspecializacao.Name = "cbxEspecializacao";
            this.cbxEspecializacao.Size = new System.Drawing.Size(227, 24);
            this.cbxEspecializacao.TabIndex = 15;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(47, 836);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(567, 110);
            this.txtDescricao.TabIndex = 17;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(43, 801);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(135, 16);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descrição: (opcional)";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.BackColor = System.Drawing.SystemColors.Control;
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
            this.gpbEndereco.Location = new System.Drawing.Point(36, 398);
            this.gpbEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbEndereco.Size = new System.Drawing.Size(691, 223);
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
            this.cbbEstado.Location = new System.Drawing.Point(84, 176);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbbEstado.TabIndex = 13;
            // 
            // msktxtCep
            // 
            this.msktxtCep.Location = new System.Drawing.Point(561, 134);
            this.msktxtCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxtCep.Mask = "00000-000";
            this.msktxtCep.Name = "msktxtCep";
            this.msktxtCep.Size = new System.Drawing.Size(103, 22);
            this.msktxtCep.TabIndex = 12;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(84, 134);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(428, 22);
            this.txtCidade.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(581, 44);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(103, 22);
            this.txtNumero.TabIndex = 10;
            // 
            // txtComplmento
            // 
            this.txtComplmento.Location = new System.Drawing.Point(493, 94);
            this.txtComplmento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplmento.Name = "txtComplmento";
            this.txtComplmento.Size = new System.Drawing.Size(191, 22);
            this.txtComplmento.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(76, 94);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(313, 22);
            this.txtBairro.TabIndex = 8;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(65, 44);
            this.txtRua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(447, 22);
            this.txtRua.TabIndex = 7;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(517, 137);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(37, 16);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP:";
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
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(24, 137);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 16);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade:";
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
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(517, 44);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(58, 16);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Número:";
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
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(24, 44);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(35, 16);
            this.lblRua.TabIndex = 0;
            this.lblRua.Text = "Rua:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(43, 306);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(564, 345);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(69, 16);
            this.lblAno.TabIndex = 20;
            this.lblAno.Text = "Ano letivo:";
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Location = new System.Drawing.Point(43, 345);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(52, 16);
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
            this.cbxStatus.Location = new System.Drawing.Point(107, 306);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(323, 24);
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
            this.cbxAno.Location = new System.Drawing.Point(640, 342);
            this.cbxAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAno.Name = "cbxAno";
            this.cbxAno.Size = new System.Drawing.Size(77, 24);
            this.cbxAno.TabIndex = 23;
            // 
            // txtEscola
            // 
            this.txtEscola.Location = new System.Drawing.Point(101, 345);
            this.txtEscola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(447, 22);
            this.txtEscola.TabIndex = 24;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(263, 1230);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 30);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(464, 42);
            this.btnCadastro.TabIndex = 29;
            this.btnCadastro.Text = "Finalizar Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(608, 1002);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 23);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gpbSenha
            // 
            this.gpbSenha.BackColor = System.Drawing.SystemColors.Control;
            this.gpbSenha.Controls.Add(this.txtConfirmaSenha);
            this.gpbSenha.Controls.Add(this.txtSenha);
            this.gpbSenha.Controls.Add(this.lblConfirmaSenha);
            this.gpbSenha.Controls.Add(this.lblSenha);
            this.gpbSenha.Location = new System.Drawing.Point(47, 1030);
            this.gpbSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbSenha.Name = "gpbSenha";
            this.gpbSenha.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbSenha.Size = new System.Drawing.Size(557, 178);
            this.gpbSenha.TabIndex = 27;
            this.gpbSenha.TabStop = false;
            this.gpbSenha.Text = "Senha";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(24, 122);
            this.txtConfirmaSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(488, 22);
            this.txtConfirmaSenha.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(76, 39);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(436, 22);
            this.txtSenha.TabIndex = 2;
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
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(21, 42);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 16);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            // 
            // lblQuaseLa
            // 
            this.lblQuaseLa.AutoSize = true;
            this.lblQuaseLa.Location = new System.Drawing.Point(43, 972);
            this.lblQuaseLa.Name = "lblQuaseLa";
            this.lblQuaseLa.Size = new System.Drawing.Size(561, 16);
            this.lblQuaseLa.TabIndex = 26;
            this.lblQuaseLa.Text = "Está quase tudo pronto. Tudo o que falta agora é colocar uma senha para proteger " +
    "sua conta";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(608, 966);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(129, 30);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = "Continuar";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(356, 222);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(134, 16);
            this.lblMatricula.TabIndex = 30;
            this.lblMatricula.Text = "Número de Matrícula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(507, 218);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(181, 22);
            this.txtMatricula.TabIndex = 31;
            // 
            // picBoxFotoAluno
            // 
            this.picBoxFotoAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxFotoAluno.Location = new System.Drawing.Point(736, 138);
            this.picBoxFotoAluno.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxFotoAluno.Name = "picBoxFotoAluno";
            this.picBoxFotoAluno.Size = new System.Drawing.Size(199, 184);
            this.picBoxFotoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFotoAluno.TabIndex = 32;
            this.picBoxFotoAluno.TabStop = false;
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Location = new System.Drawing.Point(803, 338);
            this.btnSelectImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(133, 28);
            this.btnSelectImg.TabIndex = 33;
            this.btnSelectImg.Text = "Escolher Foto...";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnLimparCurriculo);
            this.pnlContent.Controls.Add(this.btnEscolherCurriculo);
            this.pnlContent.Controls.Add(this.txtArquivoCurriculo);
            this.pnlContent.Controls.Add(this.lblCurriculo);
            this.pnlContent.Controls.Add(this.lblDescricaoCadAluno);
            this.pnlContent.Controls.Add(this.btnCadastro);
            this.pnlContent.Controls.Add(this.btnSelectImg);
            this.pnlContent.Controls.Add(this.lblCadastroAluno);
            this.pnlContent.Controls.Add(this.picBoxFotoAluno);
            this.pnlContent.Controls.Add(this.lblCpf);
            this.pnlContent.Controls.Add(this.txtMatricula);
            this.pnlContent.Controls.Add(this.lblNome);
            this.pnlContent.Controls.Add(this.lblMatricula);
            this.pnlContent.Controls.Add(this.msktxtCpf);
            this.pnlContent.Controls.Add(this.txtNome);
            this.pnlContent.Controls.Add(this.btnVoltar);
            this.pnlContent.Controls.Add(this.lblNascimento);
            this.pnlContent.Controls.Add(this.gpbSenha);
            this.pnlContent.Controls.Add(this.dateNascimento);
            this.pnlContent.Controls.Add(this.lblQuaseLa);
            this.pnlContent.Controls.Add(this.gpbInfoContato);
            this.pnlContent.Controls.Add(this.btnNext);
            this.pnlContent.Controls.Add(this.lblEspecializacao);
            this.pnlContent.Controls.Add(this.txtEscola);
            this.pnlContent.Controls.Add(this.cbxEspecializacao);
            this.pnlContent.Controls.Add(this.cbxAno);
            this.pnlContent.Controls.Add(this.lblDescricao);
            this.pnlContent.Controls.Add(this.cbxStatus);
            this.pnlContent.Controls.Add(this.txtDescricao);
            this.pnlContent.Controls.Add(this.lblEscola);
            this.pnlContent.Controls.Add(this.gpbEndereco);
            this.pnlContent.Controls.Add(this.lblAno);
            this.pnlContent.Controls.Add(this.lblStatus);
            this.pnlContent.Location = new System.Drawing.Point(184, 4);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(957, 1329);
            this.pnlContent.TabIndex = 34;
            // 
            // btnLimparCurriculo
            // 
            this.btnLimparCurriculo.Location = new System.Drawing.Point(845, 868);
            this.btnLimparCurriculo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparCurriculo.Name = "btnLimparCurriculo";
            this.btnLimparCurriculo.Size = new System.Drawing.Size(91, 28);
            this.btnLimparCurriculo.TabIndex = 37;
            this.btnLimparCurriculo.Text = "Limpar";
            this.btnLimparCurriculo.UseVisualStyleBackColor = true;
            this.btnLimparCurriculo.Click += new System.EventHandler(this.btnLimparCurriculo_Click);
            // 
            // btnEscolherCurriculo
            // 
            this.btnEscolherCurriculo.Location = new System.Drawing.Point(687, 868);
            this.btnEscolherCurriculo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEscolherCurriculo.Name = "btnEscolherCurriculo";
            this.btnEscolherCurriculo.Size = new System.Drawing.Size(151, 28);
            this.btnEscolherCurriculo.TabIndex = 36;
            this.btnEscolherCurriculo.Text = "Escolher Arquivo...";
            this.btnEscolherCurriculo.UseVisualStyleBackColor = true;
            this.btnEscolherCurriculo.Click += new System.EventHandler(this.btnEscolherCurriculo_Click);
            // 
            // txtArquivoCurriculo
            // 
            this.txtArquivoCurriculo.Location = new System.Drawing.Point(687, 836);
            this.txtArquivoCurriculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtArquivoCurriculo.Name = "txtArquivoCurriculo";
            this.txtArquivoCurriculo.Size = new System.Drawing.Size(248, 22);
            this.txtArquivoCurriculo.TabIndex = 35;
            this.txtArquivoCurriculo.TextChanged += new System.EventHandler(this.txtArquivoCurriculo_TextChanged);
            // 
            // lblCurriculo
            // 
            this.lblCurriculo.AutoSize = true;
            this.lblCurriculo.Location = new System.Drawing.Point(691, 801);
            this.lblCurriculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurriculo.Name = "lblCurriculo";
            this.lblCurriculo.Size = new System.Drawing.Size(62, 16);
            this.lblCurriculo.TabIndex = 34;
            this.lblCurriculo.Text = "Currículo:";
            // 
            // FormCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1340, 1055);
            this.Controls.Add(this.pnlContent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroAluno";
            this.Text = "Cadastrar-se";
            this.Load += new System.EventHandler(this.FormCadastroAluno_Load);
            this.ClientSizeChanged += new System.EventHandler(this.FormCadastroAluno_ClientSizeChanged);
            this.gpbInfoContato.ResumeLayout(false);
            this.gpbInfoContato.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.gpbSenha.ResumeLayout(false);
            this.gpbSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFotoAluno)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox picBoxFotoAluno;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnEscolherCurriculo;
        private System.Windows.Forms.TextBox txtArquivoCurriculo;
        private System.Windows.Forms.Label lblCurriculo;
        private System.Windows.Forms.Button btnLimparCurriculo;
    }
}