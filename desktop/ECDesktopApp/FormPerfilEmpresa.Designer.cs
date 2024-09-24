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
            this.btnMudarFoto = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
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
            this.lblFoto = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAlunosInteressados = new System.Windows.Forms.Button();
            this.btnExcluirVaga = new System.Windows.Forms.Button();
            this.btnConfirmaCriar = new System.Windows.Forms.Button();
            this.btnConfirmaEditar = new System.Windows.Forms.Button();
            this.btnEditarVaga = new System.Windows.Forms.Button();
            this.btnCancelarVaga = new System.Windows.Forms.Button();
            this.btnCriarVaga = new System.Windows.Forms.Button();
            this.gpbInfoVaga = new System.Windows.Forms.GroupBox();
            this.lblIdVaga = new System.Windows.Forms.Label();
            this.txtNomeVaga = new System.Windows.Forms.TextBox();
            this.lblNomeVaga = new System.Windows.Forms.Label();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.cbxEspecializacao = new System.Windows.Forms.ComboBox();
            this.txtRequisitos = new System.Windows.Forms.TextBox();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.lblCarga = new System.Windows.Forms.Label();
            this.lblEspecializacao = new System.Windows.Forms.Label();
            this.txtDescricaoVaga = new System.Windows.Forms.TextBox();
            this.lblDescricaoVaga = new System.Windows.Forms.Label();
            this.dgvVagasEmpresa = new System.Windows.Forms.DataGridView();
            this.vagaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vagaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vagaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vagaArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requisitosVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.tabCtrlPerfilEmpresa.SuspendLayout();
            this.tabPgPerfil.SuspendLayout();
            this.gpbInfoContato.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gpbInfoVaga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagasEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlPerfilEmpresa
            // 
            this.tabCtrlPerfilEmpresa.Controls.Add(this.tabPgPerfil);
            this.tabCtrlPerfilEmpresa.Controls.Add(this.tabPage2);
            this.tabCtrlPerfilEmpresa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlPerfilEmpresa.Location = new System.Drawing.Point(28, 97);
            this.tabCtrlPerfilEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCtrlPerfilEmpresa.Name = "tabCtrlPerfilEmpresa";
            this.tabCtrlPerfilEmpresa.SelectedIndex = 0;
            this.tabCtrlPerfilEmpresa.Size = new System.Drawing.Size(1963, 1066);
            this.tabCtrlPerfilEmpresa.TabIndex = 0;
            // 
            // tabPgPerfil
            // 
            this.tabPgPerfil.Controls.Add(this.btnMudarFoto);
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
            this.tabPgPerfil.Location = new System.Drawing.Point(4, 33);
            this.tabPgPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPgPerfil.Name = "tabPgPerfil";
            this.tabPgPerfil.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPgPerfil.Size = new System.Drawing.Size(1955, 1029);
            this.tabPgPerfil.TabIndex = 0;
            this.tabPgPerfil.Text = "Meu Perfil";
            this.tabPgPerfil.UseVisualStyleBackColor = true;
            this.tabPgPerfil.Click += new System.EventHandler(this.tabPgPerfil_Click);
            // 
            // btnMudarFoto
            // 
            this.btnMudarFoto.Location = new System.Drawing.Point(1593, 459);
            this.btnMudarFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMudarFoto.Name = "btnMudarFoto";
            this.btnMudarFoto.Size = new System.Drawing.Size(215, 36);
            this.btnMudarFoto.TabIndex = 57;
            this.btnMudarFoto.Text = "Mudar Foto de Perfil";
            this.btnMudarFoto.UseVisualStyleBackColor = true;
            this.btnMudarFoto.Click += new System.EventHandler(this.btnMudarFoto_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(103, 881);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 47);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Excluir meu perfil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1471, 881);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 47);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(1260, 881);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(145, 47);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1681, 881);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(159, 47);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(919, 170);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(567, 324);
            this.txtDescricao.TabIndex = 23;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(913, 123);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(105, 25);
            this.lblDescricao.TabIndex = 22;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtRamo
            // 
            this.txtRamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRamo.Location = new System.Drawing.Point(409, 223);
            this.txtRamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRamo.Name = "txtRamo";
            this.txtRamo.Size = new System.Drawing.Size(459, 30);
            this.txtRamo.TabIndex = 21;
            // 
            // lblRamo
            // 
            this.lblRamo.AutoSize = true;
            this.lblRamo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamo.Location = new System.Drawing.Point(48, 224);
            this.lblRamo.Name = "lblRamo";
            this.lblRamo.Size = new System.Drawing.Size(341, 29);
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
            this.gpbInfoContato.Location = new System.Drawing.Point(53, 330);
            this.gpbInfoContato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInfoContato.Name = "gpbInfoContato";
            this.gpbInfoContato.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInfoContato.Size = new System.Drawing.Size(836, 165);
            this.gpbInfoContato.TabIndex = 19;
            this.gpbInfoContato.TabStop = false;
            this.gpbInfoContato.Text = "Informações de contato";
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Location = new System.Drawing.Point(237, 114);
            this.msktxtTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxtTelefone.Mask = "(00) 0000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(305, 29);
            this.msktxtTelefone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(217, 34);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(612, 29);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 38);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(176, 24);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-Mail para contato:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(24, 118);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(198, 24);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone para contato:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(224, 170);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(581, 30);
            this.txtNome.TabIndex = 18;
            // 
            // msktxtCnpj
            // 
            this.msktxtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCnpj.Location = new System.Drawing.Point(123, 119);
            this.msktxtCnpj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxtCnpj.Mask = "00.000.000/0000-00";
            this.msktxtCnpj.Name = "msktxtCnpj";
            this.msktxtCnpj.Size = new System.Drawing.Size(256, 30);
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
            this.gpbEndereco.Location = new System.Drawing.Point(53, 558);
            this.gpbEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbEndereco.Size = new System.Drawing.Size(1292, 255);
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
            this.cbbEstado.Location = new System.Drawing.Point(841, 174);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(120, 33);
            this.cbbEstado.TabIndex = 13;
            // 
            // msktxtCep
            // 
            this.msktxtCep.Location = new System.Drawing.Point(1064, 174);
            this.msktxtCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxtCep.Mask = "00000-000";
            this.msktxtCep.Name = "msktxtCep";
            this.msktxtCep.Size = new System.Drawing.Size(188, 30);
            this.msktxtCep.TabIndex = 12;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(131, 174);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(536, 30);
            this.txtCidade.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(1091, 44);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(161, 30);
            this.txtNumero.TabIndex = 10;
            // 
            // txtComplmento
            // 
            this.txtComplmento.Location = new System.Drawing.Point(955, 97);
            this.txtComplmento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplmento.Name = "txtComplmento";
            this.txtComplmento.Size = new System.Drawing.Size(297, 30);
            this.txtComplmento.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(103, 105);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(573, 30);
            this.txtBairro.TabIndex = 8;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(93, 44);
            this.txtRua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(839, 30);
            this.txtRua.TabIndex = 7;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(993, 177);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(59, 25);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(728, 177);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(79, 25);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(24, 177);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(81, 25);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(800, 101);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(140, 25);
            this.lblComplemento.TabIndex = 3;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(993, 44);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(87, 25);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Número:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(24, 108);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(69, 25);
            this.lblBairro.TabIndex = 1;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(24, 44);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(53, 25);
            this.lblRua.TabIndex = 0;
            this.lblRua.Text = "Rua:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(48, 171);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(166, 29);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome Fantasia:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(48, 121);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(66, 29);
            this.lblCnpj.TabIndex = 14;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(1637, 432);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(123, 24);
            this.lblFoto.TabIndex = 2;
            this.lblFoto.Text = "Foto de Perfil";
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(1537, 121);
            this.picFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(333, 307);
            this.picFoto.TabIndex = 1;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAlunosInteressados);
            this.tabPage2.Controls.Add(this.btnExcluirVaga);
            this.tabPage2.Controls.Add(this.btnConfirmaCriar);
            this.tabPage2.Controls.Add(this.btnConfirmaEditar);
            this.tabPage2.Controls.Add(this.btnEditarVaga);
            this.tabPage2.Controls.Add(this.btnCancelarVaga);
            this.tabPage2.Controls.Add(this.btnCriarVaga);
            this.tabPage2.Controls.Add(this.gpbInfoVaga);
            this.tabPage2.Controls.Add(this.dgvVagasEmpresa);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1955, 1029);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Minhas Vagas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAlunosInteressados
            // 
            this.btnAlunosInteressados.Location = new System.Drawing.Point(875, 350);
            this.btnAlunosInteressados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlunosInteressados.Name = "btnAlunosInteressados";
            this.btnAlunosInteressados.Size = new System.Drawing.Size(291, 37);
            this.btnAlunosInteressados.TabIndex = 8;
            this.btnAlunosInteressados.Text = "Vizualizar Alunos Interessados";
            this.btnAlunosInteressados.UseVisualStyleBackColor = true;
            this.btnAlunosInteressados.Click += new System.EventHandler(this.btnAlunosInteressados_Click);
            // 
            // btnExcluirVaga
            // 
            this.btnExcluirVaga.BackColor = System.Drawing.Color.Salmon;
            this.btnExcluirVaga.Location = new System.Drawing.Point(223, 350);
            this.btnExcluirVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluirVaga.Name = "btnExcluirVaga";
            this.btnExcluirVaga.Size = new System.Drawing.Size(188, 37);
            this.btnExcluirVaga.TabIndex = 7;
            this.btnExcluirVaga.Text = "Excluir Vaga";
            this.btnExcluirVaga.UseVisualStyleBackColor = false;
            this.btnExcluirVaga.Click += new System.EventHandler(this.btnExcluirVaga_Click);
            // 
            // btnConfirmaCriar
            // 
            this.btnConfirmaCriar.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmaCriar.Location = new System.Drawing.Point(1475, 394);
            this.btnConfirmaCriar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmaCriar.Name = "btnConfirmaCriar";
            this.btnConfirmaCriar.Size = new System.Drawing.Size(135, 37);
            this.btnConfirmaCriar.TabIndex = 6;
            this.btnConfirmaCriar.Text = "Confirmar";
            this.btnConfirmaCriar.UseVisualStyleBackColor = false;
            this.btnConfirmaCriar.Click += new System.EventHandler(this.btnConfirmaCriar_Click);
            // 
            // btnConfirmaEditar
            // 
            this.btnConfirmaEditar.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmaEditar.Location = new System.Drawing.Point(1379, 350);
            this.btnConfirmaEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmaEditar.Name = "btnConfirmaEditar";
            this.btnConfirmaEditar.Size = new System.Drawing.Size(231, 37);
            this.btnConfirmaEditar.TabIndex = 5;
            this.btnConfirmaEditar.Text = "Confirmar Alterações";
            this.btnConfirmaEditar.UseVisualStyleBackColor = false;
            this.btnConfirmaEditar.Click += new System.EventHandler(this.btnConfirmaEditar_Click);
            // 
            // btnEditarVaga
            // 
            this.btnEditarVaga.Location = new System.Drawing.Point(1641, 350);
            this.btnEditarVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarVaga.Name = "btnEditarVaga";
            this.btnEditarVaga.Size = new System.Drawing.Size(168, 37);
            this.btnEditarVaga.TabIndex = 4;
            this.btnEditarVaga.Text = "Editar Vaga";
            this.btnEditarVaga.UseVisualStyleBackColor = true;
            this.btnEditarVaga.Click += new System.EventHandler(this.btnEditarVaga_Click);
            // 
            // btnCancelarVaga
            // 
            this.btnCancelarVaga.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelarVaga.Location = new System.Drawing.Point(223, 394);
            this.btnCancelarVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarVaga.Name = "btnCancelarVaga";
            this.btnCancelarVaga.Size = new System.Drawing.Size(119, 37);
            this.btnCancelarVaga.TabIndex = 3;
            this.btnCancelarVaga.Text = "Cancelar";
            this.btnCancelarVaga.UseVisualStyleBackColor = false;
            this.btnCancelarVaga.Click += new System.EventHandler(this.btnCancelarVaga_Click);
            // 
            // btnCriarVaga
            // 
            this.btnCriarVaga.Location = new System.Drawing.Point(1641, 394);
            this.btnCriarVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCriarVaga.Name = "btnCriarVaga";
            this.btnCriarVaga.Size = new System.Drawing.Size(168, 37);
            this.btnCriarVaga.TabIndex = 2;
            this.btnCriarVaga.Text = "Criar nova vaga";
            this.btnCriarVaga.UseVisualStyleBackColor = true;
            this.btnCriarVaga.Click += new System.EventHandler(this.btnCriarVaga_Click);
            // 
            // gpbInfoVaga
            // 
            this.gpbInfoVaga.Controls.Add(this.lblIdVaga);
            this.gpbInfoVaga.Controls.Add(this.txtNomeVaga);
            this.gpbInfoVaga.Controls.Add(this.lblNomeVaga);
            this.gpbInfoVaga.Controls.Add(this.txtCarga);
            this.gpbInfoVaga.Controls.Add(this.cbxEspecializacao);
            this.gpbInfoVaga.Controls.Add(this.txtRequisitos);
            this.gpbInfoVaga.Controls.Add(this.lblRequisitos);
            this.gpbInfoVaga.Controls.Add(this.lblCarga);
            this.gpbInfoVaga.Controls.Add(this.lblEspecializacao);
            this.gpbInfoVaga.Controls.Add(this.txtDescricaoVaga);
            this.gpbInfoVaga.Controls.Add(this.lblDescricaoVaga);
            this.gpbInfoVaga.Location = new System.Drawing.Point(223, 41);
            this.gpbInfoVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbInfoVaga.Name = "gpbInfoVaga";
            this.gpbInfoVaga.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbInfoVaga.Size = new System.Drawing.Size(1587, 274);
            this.gpbInfoVaga.TabIndex = 1;
            this.gpbInfoVaga.TabStop = false;
            this.gpbInfoVaga.Text = "Informações da Vaga";
            // 
            // lblIdVaga
            // 
            this.lblIdVaga.AutoSize = true;
            this.lblIdVaga.Location = new System.Drawing.Point(1473, 16);
            this.lblIdVaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdVaga.Name = "lblIdVaga";
            this.lblIdVaga.Size = new System.Drawing.Size(20, 24);
            this.lblIdVaga.TabIndex = 20;
            this.lblIdVaga.Text = "#";
            // 
            // txtNomeVaga
            // 
            this.txtNomeVaga.Location = new System.Drawing.Point(1112, 207);
            this.txtNomeVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeVaga.Name = "txtNomeVaga";
            this.txtNomeVaga.Size = new System.Drawing.Size(383, 32);
            this.txtNomeVaga.TabIndex = 19;
            // 
            // lblNomeVaga
            // 
            this.lblNomeVaga.AutoSize = true;
            this.lblNomeVaga.Location = new System.Drawing.Point(1036, 210);
            this.lblNomeVaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeVaga.Name = "lblNomeVaga";
            this.lblNomeVaga.Size = new System.Drawing.Size(65, 24);
            this.lblNomeVaga.TabIndex = 18;
            this.lblNomeVaga.Text = "Nome:";
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(1296, 148);
            this.txtCarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(199, 32);
            this.txtCarga.TabIndex = 17;
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
            this.cbxEspecializacao.Location = new System.Drawing.Point(1156, 76);
            this.cbxEspecializacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEspecializacao.Name = "cbxEspecializacao";
            this.cbxEspecializacao.Size = new System.Drawing.Size(339, 32);
            this.cbxEspecializacao.TabIndex = 16;
            // 
            // txtRequisitos
            // 
            this.txtRequisitos.Location = new System.Drawing.Point(668, 76);
            this.txtRequisitos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRequisitos.Multiline = true;
            this.txtRequisitos.Name = "txtRequisitos";
            this.txtRequisitos.Size = new System.Drawing.Size(329, 169);
            this.txtRequisitos.TabIndex = 5;
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.Location = new System.Drawing.Point(663, 48);
            this.lblRequisitos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(203, 24);
            this.lblRequisitos.TabIndex = 4;
            this.lblRequisitos.Text = "Requisitos para a vaga:";
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Location = new System.Drawing.Point(1151, 150);
            this.lblCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(129, 24);
            this.lblCarga.TabIndex = 3;
            this.lblCarga.Text = "Carga Horária:";
            // 
            // lblEspecializacao
            // 
            this.lblEspecializacao.AutoSize = true;
            this.lblEspecializacao.Location = new System.Drawing.Point(1151, 48);
            this.lblEspecializacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecializacao.Name = "lblEspecializacao";
            this.lblEspecializacao.Size = new System.Drawing.Size(204, 24);
            this.lblEspecializacao.TabIndex = 2;
            this.lblEspecializacao.Text = "Área de especialização:";
            // 
            // txtDescricaoVaga
            // 
            this.txtDescricaoVaga.Location = new System.Drawing.Point(65, 75);
            this.txtDescricaoVaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricaoVaga.Multiline = true;
            this.txtDescricaoVaga.Name = "txtDescricaoVaga";
            this.txtDescricaoVaga.Size = new System.Drawing.Size(545, 170);
            this.txtDescricaoVaga.TabIndex = 1;
            // 
            // lblDescricaoVaga
            // 
            this.lblDescricaoVaga.AutoSize = true;
            this.lblDescricaoVaga.Location = new System.Drawing.Point(60, 48);
            this.lblDescricaoVaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoVaga.Name = "lblDescricaoVaga";
            this.lblDescricaoVaga.Size = new System.Drawing.Size(163, 24);
            this.lblDescricaoVaga.TabIndex = 0;
            this.lblDescricaoVaga.Text = "Descrição da vaga:";
            // 
            // dgvVagasEmpresa
            // 
            this.dgvVagasEmpresa.AllowUserToAddRows = false;
            this.dgvVagasEmpresa.AllowUserToDeleteRows = false;
            this.dgvVagasEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVagasEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vagaId,
            this.vagaNome,
            this.vagaDescricao,
            this.vagaArea,
            this.requisitosVaga,
            this.cargaVaga});
            this.dgvVagasEmpresa.Location = new System.Drawing.Point(223, 468);
            this.dgvVagasEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVagasEmpresa.Name = "dgvVagasEmpresa";
            this.dgvVagasEmpresa.ReadOnly = true;
            this.dgvVagasEmpresa.RowHeadersWidth = 51;
            this.dgvVagasEmpresa.Size = new System.Drawing.Size(1587, 500);
            this.dgvVagasEmpresa.TabIndex = 0;
            this.dgvVagasEmpresa.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVagasEmpresa_CellMouseDoubleClick);
            // 
            // vagaId
            // 
            this.vagaId.HeaderText = "ID";
            this.vagaId.MinimumWidth = 6;
            this.vagaId.Name = "vagaId";
            this.vagaId.ReadOnly = true;
            this.vagaId.Width = 125;
            // 
            // vagaNome
            // 
            this.vagaNome.HeaderText = "Nome";
            this.vagaNome.MinimumWidth = 6;
            this.vagaNome.Name = "vagaNome";
            this.vagaNome.ReadOnly = true;
            this.vagaNome.Width = 125;
            // 
            // vagaDescricao
            // 
            this.vagaDescricao.HeaderText = "Descrição da vaga";
            this.vagaDescricao.MinimumWidth = 6;
            this.vagaDescricao.Name = "vagaDescricao";
            this.vagaDescricao.ReadOnly = true;
            this.vagaDescricao.Width = 125;
            // 
            // vagaArea
            // 
            this.vagaArea.HeaderText = "Área de especialização procurada";
            this.vagaArea.MinimumWidth = 6;
            this.vagaArea.Name = "vagaArea";
            this.vagaArea.ReadOnly = true;
            this.vagaArea.Width = 125;
            // 
            // requisitosVaga
            // 
            this.requisitosVaga.HeaderText = "Requisitos";
            this.requisitosVaga.MinimumWidth = 6;
            this.requisitosVaga.Name = "requisitosVaga";
            this.requisitosVaga.ReadOnly = true;
            this.requisitosVaga.Width = 125;
            // 
            // cargaVaga
            // 
            this.cargaVaga.HeaderText = "Carga Horária";
            this.cargaVaga.MinimumWidth = 6;
            this.cargaVaga.Name = "cargaVaga";
            this.cargaVaga.ReadOnly = true;
            this.cargaVaga.Width = 125;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(807, 21);
            this.lblNomeEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(386, 73);
            this.lblNomeEmpresa.TabIndex = 0;
            this.lblNomeEmpresa.Text = "nomeempresa";
            // 
            // FormPerfilEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tabCtrlPerfilEmpresa);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPerfilEmpresa";
            this.Text = "Seu Perfil";
            this.Load += new System.EventHandler(this.FormPerfilEmpresa_Load);
            this.ClientSizeChanged += new System.EventHandler(this.FormPerfilEmpresa_ClientSizeChanged);
            this.tabCtrlPerfilEmpresa.ResumeLayout(false);
            this.tabPgPerfil.ResumeLayout(false);
            this.tabPgPerfil.PerformLayout();
            this.gpbInfoContato.ResumeLayout(false);
            this.gpbInfoContato.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gpbInfoVaga.ResumeLayout(false);
            this.gpbInfoVaga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagasEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlPerfilEmpresa;
        private System.Windows.Forms.TabPage tabPgPerfil;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.DataGridView dgvVagasEmpresa;
        private System.Windows.Forms.GroupBox gpbInfoVaga;
        private System.Windows.Forms.Label lblDescricaoVaga;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.Label lblEspecializacao;
        private System.Windows.Forms.TextBox txtDescricaoVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn vagaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn vagaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn vagaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn vagaArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn requisitosVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaVaga;
        private System.Windows.Forms.TextBox txtRequisitos;
        private System.Windows.Forms.Label lblNomeVaga;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.ComboBox cbxEspecializacao;
        private System.Windows.Forms.TextBox txtNomeVaga;
        private System.Windows.Forms.Button btnEditarVaga;
        private System.Windows.Forms.Button btnCancelarVaga;
        private System.Windows.Forms.Button btnCriarVaga;
        private System.Windows.Forms.Button btnConfirmaCriar;
        private System.Windows.Forms.Button btnConfirmaEditar;
        private System.Windows.Forms.Label lblIdVaga;
        private System.Windows.Forms.Button btnExcluirVaga;
        private System.Windows.Forms.Button btnAlunosInteressados;
        private System.Windows.Forms.Button btnMudarFoto;
    }
}