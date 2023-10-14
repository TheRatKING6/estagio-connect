namespace ECDesktopApp
{
    partial class FormPerfilEmpresa
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
            this.tabCtrlPerfilEmpresa = new System.Windows.Forms.TabControl();
            this.tabPgPerfil = new System.Windows.Forms.TabPage();
            this.tabPgVagas = new System.Windows.Forms.TabPage();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtRamo = new System.Windows.Forms.TextBox();
            this.lblRamo = new System.Windows.Forms.Label();
            this.gpbInfoContato = new System.Windows.Forms.GroupBox();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.msktxtCnpj = new System.Windows.Forms.MaskedTextBox();
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requisitosVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verVaga = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabCtrlPerfilEmpresa.SuspendLayout();
            this.tabPgPerfil.SuspendLayout();
            this.tabPgVagas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.gpbInfoContato.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlPerfilEmpresa
            // 
            this.tabCtrlPerfilEmpresa.Controls.Add(this.tabPgPerfil);
            this.tabCtrlPerfilEmpresa.Controls.Add(this.tabPgVagas);
            this.tabCtrlPerfilEmpresa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlPerfilEmpresa.Location = new System.Drawing.Point(21, 79);
            this.tabCtrlPerfilEmpresa.Name = "tabCtrlPerfilEmpresa";
            this.tabCtrlPerfilEmpresa.SelectedIndex = 0;
            this.tabCtrlPerfilEmpresa.Size = new System.Drawing.Size(1472, 797);
            this.tabCtrlPerfilEmpresa.TabIndex = 0;
            // 
            // tabPgPerfil
            // 
            this.tabPgPerfil.Controls.Add(this.btnDelete);
            this.tabPgPerfil.Controls.Add(this.btnCancelar);
            this.tabPgPerfil.Controls.Add(this.btnSalvar);
            this.tabPgPerfil.Controls.Add(this.btnEditar);
            this.tabPgPerfil.Controls.Add(this.txtDescricao);
            this.tabPgPerfil.Controls.Add(this.lblDescricao);
            this.tabPgPerfil.Controls.Add(this.txtRamo);
            this.tabPgPerfil.Controls.Add(this.lblRamo);
            this.tabPgPerfil.Controls.Add(this.gpbInfoContato);
            this.tabPgPerfil.Controls.Add(this.txtNome);
            this.tabPgPerfil.Controls.Add(this.msktxtCnpj);
            this.tabPgPerfil.Controls.Add(this.gpbEndereco);
            this.tabPgPerfil.Controls.Add(this.lblNome);
            this.tabPgPerfil.Controls.Add(this.lblCnpj);
            this.tabPgPerfil.Controls.Add(this.lblFoto);
            this.tabPgPerfil.Controls.Add(this.picFoto);
            this.tabPgPerfil.Controls.Add(this.lblNomeEmpresa);
            this.tabPgPerfil.Location = new System.Drawing.Point(4, 28);
            this.tabPgPerfil.Name = "tabPgPerfil";
            this.tabPgPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgPerfil.Size = new System.Drawing.Size(1464, 765);
            this.tabPgPerfil.TabIndex = 0;
            this.tabPgPerfil.Text = "Meu Perfil";
            this.tabPgPerfil.UseVisualStyleBackColor = true;
            this.tabPgPerfil.Click += new System.EventHandler(this.tabPgPerfil_Click);
            // 
            // tabPgVagas
            // 
            this.tabPgVagas.Controls.Add(this.dataGridView1);
            this.tabPgVagas.Location = new System.Drawing.Point(4, 28);
            this.tabPgVagas.Name = "tabPgVagas";
            this.tabPgVagas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgVagas.Size = new System.Drawing.Size(1464, 765);
            this.tabPgVagas.TabIndex = 1;
            this.tabPgVagas.Text = "Minhas Vagas";
            this.tabPgVagas.UseVisualStyleBackColor = true;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(562, 12);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(306, 59);
            this.lblNomeEmpresa.TabIndex = 0;
            this.lblNomeEmpresa.Text = "nomeempresa";
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(1153, 98);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(250, 250);
            this.picFoto.TabIndex = 1;
            this.picFoto.TabStop = false;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(1228, 351);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(101, 19);
            this.lblFoto.TabIndex = 2;
            this.lblFoto.Text = "Foto de Perfil";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(689, 138);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(426, 264);
            this.txtDescricao.TabIndex = 23;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(685, 100);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricao.TabIndex = 22;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtRamo
            // 
            this.txtRamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRamo.Location = new System.Drawing.Point(307, 181);
            this.txtRamo.Margin = new System.Windows.Forms.Padding(2);
            this.txtRamo.Name = "txtRamo";
            this.txtRamo.Size = new System.Drawing.Size(345, 26);
            this.txtRamo.TabIndex = 21;
            // 
            // lblRamo
            // 
            this.lblRamo.AutoSize = true;
            this.lblRamo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamo.Location = new System.Drawing.Point(36, 182);
            this.lblRamo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRamo.Name = "lblRamo";
            this.lblRamo.Size = new System.Drawing.Size(267, 23);
            this.lblRamo.TabIndex = 20;
            this.lblRamo.Text = "Ramo das atividades da empresa:";
            // 
            // gpbInfoContato
            // 
            this.gpbInfoContato.Controls.Add(this.msktxtTelefone);
            this.gpbInfoContato.Controls.Add(this.txtEmail);
            this.gpbInfoContato.Controls.Add(this.lblEmail);
            this.gpbInfoContato.Controls.Add(this.lblTelefone);
            this.gpbInfoContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoContato.Location = new System.Drawing.Point(40, 268);
            this.gpbInfoContato.Margin = new System.Windows.Forms.Padding(2);
            this.gpbInfoContato.Name = "gpbInfoContato";
            this.gpbInfoContato.Padding = new System.Windows.Forms.Padding(2);
            this.gpbInfoContato.Size = new System.Drawing.Size(627, 134);
            this.gpbInfoContato.TabIndex = 19;
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
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(168, 138);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(437, 26);
            this.txtNome.TabIndex = 18;
            // 
            // msktxtCnpj
            // 
            this.msktxtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCnpj.Location = new System.Drawing.Point(92, 97);
            this.msktxtCnpj.Margin = new System.Windows.Forms.Padding(2);
            this.msktxtCnpj.Mask = "00,000,000/0000-00";
            this.msktxtCnpj.Name = "msktxtCnpj";
            this.msktxtCnpj.Size = new System.Drawing.Size(193, 26);
            this.msktxtCnpj.TabIndex = 17;
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
            this.gpbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(40, 453);
            this.gpbEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Padding = new System.Windows.Forms.Padding(2);
            this.gpbEndereco.Size = new System.Drawing.Size(969, 207);
            this.gpbEndereco.TabIndex = 16;
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(36, 139);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(128, 23);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome Fantasia:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(36, 98);
            this.lblCnpj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(52, 23);
            this.lblCnpj.TabIndex = 14;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1261, 716);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 38);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(945, 716);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 38);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1103, 716);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 38);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(77, 716);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 38);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Excluir meu perfil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVaga,
            this.descricaoVaga,
            this.areaVaga,
            this.requisitosVaga,
            this.cargaVaga,
            this.verVaga});
            this.dataGridView1.Location = new System.Drawing.Point(116, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // idVaga
            // 
            this.idVaga.HeaderText = "ID";
            this.idVaga.Name = "idVaga";
            // 
            // descricaoVaga
            // 
            this.descricaoVaga.HeaderText = "Descricao";
            this.descricaoVaga.Name = "descricaoVaga";
            // 
            // areaVaga
            // 
            this.areaVaga.HeaderText = "Area de Atuação";
            this.areaVaga.Name = "areaVaga";
            // 
            // requisitosVaga
            // 
            this.requisitosVaga.HeaderText = "Requisitos";
            this.requisitosVaga.Name = "requisitosVaga";
            // 
            // cargaVaga
            // 
            this.cargaVaga.HeaderText = "Carga Horária";
            this.cargaVaga.Name = "cargaVaga";
            // 
            // verVaga
            // 
            this.verVaga.HeaderText = "";
            this.verVaga.Name = "verVaga";
            this.verVaga.Text = "Editar";
            // 
            // FormPerfilEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 907);
            this.Controls.Add(this.tabCtrlPerfilEmpresa);
            this.Name = "FormPerfilEmpresa";
            this.Text = "FormPerfilEmpresa";
            this.Load += new System.EventHandler(this.FormPerfilEmpresa_Load);
            this.tabCtrlPerfilEmpresa.ResumeLayout(false);
            this.tabPgPerfil.ResumeLayout(false);
            this.tabPgPerfil.PerformLayout();
            this.tabPgVagas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.gpbInfoContato.ResumeLayout(false);
            this.gpbInfoContato.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlPerfilEmpresa;
        private System.Windows.Forms.TabPage tabPgPerfil;
        private System.Windows.Forms.TabPage tabPgVagas;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtRamo;
        private System.Windows.Forms.Label lblRamo;
        private System.Windows.Forms.GroupBox gpbInfoContato;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox msktxtCnpj;
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
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn requisitosVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaVaga;
        private System.Windows.Forms.DataGridViewButtonColumn verVaga;
    }
}