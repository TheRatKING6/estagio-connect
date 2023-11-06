namespace ECDesktopApp
{
    partial class FormPerfilAluno
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gpbInfoContato = new System.Windows.Forms.GroupBox();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
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
            this.lblFoto = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtEscola = new System.Windows.Forms.TextBox();
            this.cbxAno = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblEscola = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxEspecializacao = new System.Windows.Forms.ComboBox();
            this.lblEspecializacao = new System.Windows.Forms.Label();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.msktxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInteresse = new System.Windows.Forms.Button();
            this.btnMudarFoto = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnCurriculo = new System.Windows.Forms.Button();
            this.txtArquivoCurriculo = new System.Windows.Forms.TextBox();
            this.lblCurriculo = new System.Windows.Forms.Label();
            this.gpbInfoContato.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(27, 921);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 38);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Excluir meu perfil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1035, 918);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 38);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(907, 918);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 38);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1216, 918);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 38);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(665, 359);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(426, 264);
            this.txtDescricao.TabIndex = 32;
            // 
            // gpbInfoContato
            // 
            this.gpbInfoContato.BackColor = System.Drawing.SystemColors.Control;
            this.gpbInfoContato.Controls.Add(this.msktxtTelefone);
            this.gpbInfoContato.Controls.Add(this.txtEmail);
            this.gpbInfoContato.Controls.Add(this.lblEmail);
            this.gpbInfoContato.Controls.Add(this.lblTelefone);
            this.gpbInfoContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoContato.Location = new System.Drawing.Point(16, 489);
            this.gpbInfoContato.Margin = new System.Windows.Forms.Padding(2);
            this.gpbInfoContato.Name = "gpbInfoContato";
            this.gpbInfoContato.Padding = new System.Windows.Forms.Padding(2);
            this.gpbInfoContato.Size = new System.Drawing.Size(627, 134);
            this.gpbInfoContato.TabIndex = 31;
            this.gpbInfoContato.TabStop = false;
            this.gpbInfoContato.Text = "Informações de contato";
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Location = new System.Drawing.Point(178, 93);
            this.msktxtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.msktxtTelefone.Mask = "(00) 0000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(230, 24);
            this.msktxtTelefone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 28);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(460, 24);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 31);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(141, 18);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-Mail para contato:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(18, 96);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(156, 18);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone para contato:";
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
            this.gpbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(16, 674);
            this.gpbEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Padding = new System.Windows.Forms.Padding(2);
            this.gpbEndereco.Size = new System.Drawing.Size(969, 207);
            this.gpbEndereco.TabIndex = 30;
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
            this.cbbEstado.Location = new System.Drawing.Point(631, 141);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(91, 28);
            this.cbbEstado.TabIndex = 13;
            // 
            // msktxtCep
            // 
            this.msktxtCep.Location = new System.Drawing.Point(798, 141);
            this.msktxtCep.Margin = new System.Windows.Forms.Padding(2);
            this.msktxtCep.Mask = "00000-000";
            this.msktxtCep.Name = "msktxtCep";
            this.msktxtCep.Size = new System.Drawing.Size(142, 26);
            this.msktxtCep.TabIndex = 12;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(98, 141);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(403, 26);
            this.txtCidade.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(818, 36);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(122, 26);
            this.txtNumero.TabIndex = 10;
            // 
            // txtComplmento
            // 
            this.txtComplmento.Location = new System.Drawing.Point(716, 79);
            this.txtComplmento.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplmento.Name = "txtComplmento";
            this.txtComplmento.Size = new System.Drawing.Size(224, 26);
            this.txtComplmento.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(77, 85);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(431, 26);
            this.txtBairro.TabIndex = 8;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(70, 36);
            this.txtRua.Margin = new System.Windows.Forms.Padding(2);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(630, 26);
            this.txtRua.TabIndex = 7;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(745, 144);
            this.lblCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(45, 20);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(546, 144);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(18, 144);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(600, 82);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(112, 20);
            this.lblComplemento.TabIndex = 3;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(745, 36);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(69, 20);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Número:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(18, 88);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 1;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(18, 36);
            this.lblRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(43, 20);
            this.lblRua.TabIndex = 0;
            this.lblRua.Text = "Rua:";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(1234, 359);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(101, 19);
            this.lblFoto.TabIndex = 29;
            this.lblFoto.Text = "Foto de Perfil";
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(1159, 106);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(250, 250);
            this.picFoto.TabIndex = 28;
            this.picFoto.TabStop = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(661, 325);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricao.TabIndex = 37;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(686, 266);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(285, 26);
            this.txtMatricula.TabIndex = 53;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(525, 269);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(159, 20);
            this.lblMatricula.TabIndex = 52;
            this.lblMatricula.Text = "Número de Matrícula:";
            // 
            // txtEscola
            // 
            this.txtEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscola.Location = new System.Drawing.Point(76, 385);
            this.txtEscola.Margin = new System.Windows.Forms.Padding(2);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(410, 26);
            this.txtEscola.TabIndex = 51;
            // 
            // cbxAno
            // 
            this.cbxAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAno.FormattingEnabled = true;
            this.cbxAno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxAno.Location = new System.Drawing.Point(98, 438);
            this.cbxAno.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAno.Name = "cbxAno";
            this.cbxAno.Size = new System.Drawing.Size(103, 28);
            this.cbxAno.TabIndex = 50;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Estudando",
            "Estudos Concluidos",
            "Empregado",
            "Empregado e Estudando"});
            this.cbxStatus.Location = new System.Drawing.Point(76, 325);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(297, 28);
            this.cbxStatus.TabIndex = 49;
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscola.Location = new System.Drawing.Point(12, 388);
            this.lblEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(61, 20);
            this.lblEscola.TabIndex = 48;
            this.lblEscola.Text = "Escola:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(12, 441);
            this.lblAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(82, 20);
            this.lblAno.TabIndex = 47;
            this.lblAno.Text = "Ano letivo:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 328);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 46;
            this.lblStatus.Text = "Status:";
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
            this.cbxEspecializacao.Location = new System.Drawing.Point(195, 269);
            this.cbxEspecializacao.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEspecializacao.Name = "cbxEspecializacao";
            this.cbxEspecializacao.Size = new System.Drawing.Size(270, 28);
            this.cbxEspecializacao.TabIndex = 45;
            // 
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecializacao.Location = new System.Drawing.Point(12, 272);
            this.lblEspecializacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(179, 20);
            this.lblEspecializacao.TabIndex = 44;
            this.lblEspecializacao.Text = "Área de Especialização:";
            // 
            // dateNascimento
            // 
            this.dateNascimento.CustomFormat = "";
            this.dateNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNascimento.Location = new System.Drawing.Point(174, 211);
            this.dateNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(111, 26);
            this.dateNascimento.TabIndex = 43;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(12, 216);
            this.lblNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(158, 20);
            this.lblNascimento.TabIndex = 42;
            this.lblNascimento.Text = "Data de Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(71, 162);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(572, 26);
            this.txtNome.TabIndex = 41;
            // 
            // msktxtCpf
            // 
            this.msktxtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCpf.Location = new System.Drawing.Point(60, 103);
            this.msktxtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.msktxtCpf.Mask = "000,000,000-00";
            this.msktxtCpf.Name = "msktxtCpf";
            this.msktxtCpf.Size = new System.Drawing.Size(165, 26);
            this.msktxtCpf.TabIndex = 40;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 165);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 39;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(12, 106);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 20);
            this.lblCpf.TabIndex = 38;
            this.lblCpf.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 59);
            this.label1.TabIndex = 54;
            this.label1.Text = "nomealuno";
            // 
            // btnInteresse
            // 
            this.btnInteresse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteresse.Location = new System.Drawing.Point(27, 966);
            this.btnInteresse.Name = "btnInteresse";
            this.btnInteresse.Size = new System.Drawing.Size(174, 35);
            this.btnInteresse.TabIndex = 55;
            this.btnInteresse.Text = "Demonstrar Interesse";
            this.btnInteresse.UseVisualStyleBackColor = true;
            this.btnInteresse.Click += new System.EventHandler(this.btnInteresse_Click);
            // 
            // btnMudarFoto
            // 
            this.btnMudarFoto.Location = new System.Drawing.Point(1228, 381);
            this.btnMudarFoto.Name = "btnMudarFoto";
            this.btnMudarFoto.Size = new System.Drawing.Size(133, 23);
            this.btnMudarFoto.TabIndex = 56;
            this.btnMudarFoto.Text = "Mudar Foto de Perfil";
            this.btnMudarFoto.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnCurriculo);
            this.pnlContent.Controls.Add(this.txtArquivoCurriculo);
            this.pnlContent.Controls.Add(this.lblCurriculo);
            this.pnlContent.Controls.Add(this.lblCpf);
            this.pnlContent.Controls.Add(this.btnMudarFoto);
            this.pnlContent.Controls.Add(this.picFoto);
            this.pnlContent.Controls.Add(this.btnInteresse);
            this.pnlContent.Controls.Add(this.lblFoto);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.gpbEndereco);
            this.pnlContent.Controls.Add(this.txtMatricula);
            this.pnlContent.Controls.Add(this.gpbInfoContato);
            this.pnlContent.Controls.Add(this.lblMatricula);
            this.pnlContent.Controls.Add(this.txtDescricao);
            this.pnlContent.Controls.Add(this.txtEscola);
            this.pnlContent.Controls.Add(this.btnEditar);
            this.pnlContent.Controls.Add(this.cbxAno);
            this.pnlContent.Controls.Add(this.btnSalvar);
            this.pnlContent.Controls.Add(this.cbxStatus);
            this.pnlContent.Controls.Add(this.btnCancelar);
            this.pnlContent.Controls.Add(this.lblEscola);
            this.pnlContent.Controls.Add(this.btnDelete);
            this.pnlContent.Controls.Add(this.lblAno);
            this.pnlContent.Controls.Add(this.lblDescricao);
            this.pnlContent.Controls.Add(this.lblStatus);
            this.pnlContent.Controls.Add(this.lblNome);
            this.pnlContent.Controls.Add(this.cbxEspecializacao);
            this.pnlContent.Controls.Add(this.msktxtCpf);
            this.pnlContent.Controls.Add(this.lblEspecializacao);
            this.pnlContent.Controls.Add(this.txtNome);
            this.pnlContent.Controls.Add(this.dateNascimento);
            this.pnlContent.Controls.Add(this.lblNascimento);
            this.pnlContent.Location = new System.Drawing.Point(47, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1425, 1090);
            this.pnlContent.TabIndex = 57;
            // 
            // btnCurriculo
            // 
            this.btnCurriculo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurriculo.Location = new System.Drawing.Point(1028, 735);
            this.btnCurriculo.Name = "btnCurriculo";
            this.btnCurriculo.Size = new System.Drawing.Size(174, 28);
            this.btnCurriculo.TabIndex = 59;
            this.btnCurriculo.Text = "Escolher Arquivo...";
            this.btnCurriculo.UseVisualStyleBackColor = true;
            this.btnCurriculo.Click += new System.EventHandler(this.btnCurriculo_Click);
            // 
            // txtArquivoCurriculo
            // 
            this.txtArquivoCurriculo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoCurriculo.Location = new System.Drawing.Point(1028, 702);
            this.txtArquivoCurriculo.Name = "txtArquivoCurriculo";
            this.txtArquivoCurriculo.Size = new System.Drawing.Size(347, 27);
            this.txtArquivoCurriculo.TabIndex = 58;
            // 
            // lblCurriculo
            // 
            this.lblCurriculo.AutoSize = true;
            this.lblCurriculo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurriculo.Location = new System.Drawing.Point(1031, 674);
            this.lblCurriculo.Name = "lblCurriculo";
            this.lblCurriculo.Size = new System.Drawing.Size(71, 19);
            this.lblCurriculo.TabIndex = 57;
            this.lblCurriculo.Text = "Currículo:";
            // 
            // FormPerfilAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1677, 1061);
            this.Controls.Add(this.pnlContent);
            this.Name = "FormPerfilAluno";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.Text = "Meu Perfil";
            this.Load += new System.EventHandler(this.FormPerfilAluno_Load);
            this.ClientSizeChanged += new System.EventHandler(this.FormPerfilAluno_ClientSizeChanged);
            this.gpbInfoContato.ResumeLayout(false);
            this.gpbInfoContato.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox gpbInfoContato;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
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
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtEscola;
        private System.Windows.Forms.ComboBox cbxAno;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxEspecializacao;
        private System.Windows.Forms.Label lblEspecializacao;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox msktxtCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInteresse;
        private System.Windows.Forms.Button btnMudarFoto;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnCurriculo;
        private System.Windows.Forms.TextBox txtArquivoCurriculo;
        private System.Windows.Forms.Label lblCurriculo;
    }
}