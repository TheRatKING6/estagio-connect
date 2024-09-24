using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ECDesktopApp
{
    public partial class FormPerfilEmpresa : Form
    {
        private int tipo = 1;
        private string cnpj_empresa = "";
        public String caminhoFoto = "";

        public int Tipo { get => tipo; set => tipo = value; }
        public string Cnpj_empresa { get => Cnpj_empresa; set => Cnpj_empresa = value; }
        public string Cnpj_empresa1 { get => cnpj_empresa; set => cnpj_empresa = value; }

        public FormPerfilEmpresa()
        {
            InitializeComponent();
            //Maximiza a janela e habilita scroll
            WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;
            tabPgPerfil.AutoScroll = true;

            //desabilita tudo do perfil pra deixar como ReadOnly as informacoes --- PERFIL ---
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnMudarFoto.Visible = false;

            txtEmail.Enabled = false;
            msktxtTelefone.Enabled = false;

            msktxtCep.Enabled = false;
            txtRua.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            txtComplmento.Enabled = false;
            cbbEstado.Enabled = false;

            msktxtCnpj.Enabled = false;
            txtNome.Enabled = false;
            txtRamo.Enabled = false;
            txtDescricao.Enabled = false;

            //tudo o que nao e pra ver na parte das vagas some --- VAGAS ---
            gpbInfoVaga.Visible = false;
            btnCancelarVaga .Visible = false;
            btnConfirmaCriar.Visible = false;
            btnConfirmaEditar.Visible = false;
            btnEditarVaga.Visible = false;
            btnExcluirVaga.Visible = false;
            btnAlunosInteressados.Visible = false;

            //btnAlunosInteressados.Visible = false;

            //faz com que o usuario so possa selecionar um dos itens da combobox (sem poder editar eles)
            cbxEspecializacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            //altera o modo de selecao do dataGridView (seleciona a fileira inteira e nao diexa selecionar mais de uma fileira)
            dgvVagasEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVagasEmpresa.MultiSelect = false;
            //dgvVagasEmpresa.
        }

        private void FormPerfilEmpresa_Load(object sender, EventArgs e)
        {
            //coloca a foto default (se nao tiver foto cadastrada no bd)
            picFoto.Image = Image.FromFile("../../img/default_user_empresa.jpg");
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;

            if(tipo == 0)
            {
                btnEditar.Visible = false;
                btnDelete.Visible = false;
                btnCriarVaga.Visible = false;
                btnAlunosInteressados.Text = "Ver detalhes da vaga";
                tabPage2.Text = "Vagas";
            }

            //centraliza
            tabCtrlPerfilEmpresa.Left = (this.ClientSize.Width - tabCtrlPerfilEmpresa.Width) / 2;
            lblNomeEmpresa.Left = (this.ClientSize.Width - lblNomeEmpresa.Width) / 2;

            refreshListaVagas(); //da load nas vagas e coloca elas no dgv (basicamente faz oq esse comentario enorme de baixo faz, so q melhor)

            ////da load nas vagas
            //int id_empresa = -1;

            //Empresa empresa = new Empresa(cnpj_empresa);
            //id_empresa = empresa.getCodigo_Empresa(); //obtem o codigo da empresa


            //Vaga vaga = new Vaga();
            //MySqlDataReader reader = vaga.getVagas();

            ////DataGridViewRow row;
            //while (reader.Read())
            //{
            //    //row = (DataGridViewRow)dgvVagasEmpresa.Rows[0];
            //    Console.WriteLine("\n\nFunciona\n\n" + id_empresa.ToString());
            //    if (reader["idEmpresa"].ToString().Equals(id_empresa.ToString()))
            //    {
            //        /*
            //        row.Cells[0].Value = reader["Codigo"].ToString();
            //        row.Cells[1].Value = reader["Nome"].ToString();
            //        row.Cells[2].Value = reader["Descricao"].ToString();
            //        row.Cells[3].Value = reader["Area"].ToString();
            //        row.Cells[4].Value = reader["Requisitos"].ToString();
            //        row.Cells[5].Value = reader["Carga_Horaria"].ToString();
            //        */
            //        string cod = reader["Codigo"].ToString();
            //        string nome = reader["Nome"].ToString();
            //        string desc = reader["Descricao"].ToString();
            //        string area = reader["Area"].ToString();
            //        string requisitos = reader["Requisitos"].ToString();
            //        string carga = reader["Carga_Horaria"].ToString();

            //        Console.WriteLine("\n\n" + cod + nome + desc + area + requisitos + "\n\n");

            //        dgvVagasEmpresa.Rows.Add(cod, nome, desc, area, requisitos, carga);
            //    }
            //}
            //DAO_Conexao.con.Close();



            //exibe as informações no perfil da empresa
            //Empresa empresa = new Empresa(cnpj_empresa);

            //MySqlDataReader reader = empresa.getInfosEmpresa();

            //while (reader.Read())
            //{
            //    //colocar as info nos campos
            //    msktxtCnpj.Text = reader["CNPJ"].ToString();
            //    txtNome.Text = reader["Nome"].ToString();
            //    txtRua.Text = reader["Rua"].ToString();
            //    txtNumero.Text = reader["Numero"].ToString();
            //    txtBairro.Text = reader["Bairro"].ToString();
            //    txtComplmento.Text = reader["Complemento"].ToString();
            //    txtCidade.Text = reader["Cidade"].ToString();
            //    cbbEstado.Text = reader["Estado"].ToString();
            //    msktxtCep.Text = reader["CEP"].ToString();
            //    txtEmail.Text = reader["Email"].ToString();
            //    msktxtTelefone.Text = reader["Telefone"].ToString();
            //    txtRamo.Text = reader["Ramo"].ToString();
            //    txtDescricao.Text = reader["Descricao"].ToString();
            //}
            //DAO_Conexao.con.Close();

            refreshInfoEmpresa(); //faz a msm coisa desse comentario giga aqui em cima (lol)

            carregarFoto();
        }

        public void carregarFoto()
        {
            Empresa empresa = new Empresa(cnpj_empresa);
            empresa.PegarFoto(cnpj_empresa, empresa);
            using (var foto = new MemoryStream(empresa.foto))
            {
                picFoto.Image = Image.FromStream(foto);
            }
        }

        private void tabPgPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnMudarFoto.Visible = true;
            btnEditar.Visible = false;

            //habilita todos os campos para permitir edicao
            txtEmail.Enabled = true;
            msktxtTelefone.Enabled = true;

            msktxtCep.Enabled = true;
            txtRua.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtComplmento.Enabled = true;
            cbbEstado.Enabled = true;

            txtNome.Enabled = true;
            txtRamo.Enabled = true;
            txtDescricao.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnMudarFoto.Visible= false;
            btnEditar.Visible = true;

            //desabilita tudo de novo
            txtEmail.Enabled = false;
            msktxtTelefone.Enabled = false;

            msktxtCep.Enabled = false;
            txtRua.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            txtComplmento.Enabled = false;
            cbbEstado.Enabled = false;

            txtNome.Enabled = false;
            txtRamo.Enabled = false;
            txtDescricao.Enabled = false;

            refreshInfoEmpresa();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnMudarFoto.Visible = false;
            btnEditar.Visible = true;

            //desabilita tudo de novo
            txtEmail.Enabled = false;
            msktxtTelefone.Enabled = false;

            msktxtCep.Enabled = false;
            txtRua.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            txtComplmento.Enabled = false;
            cbbEstado.Enabled = false;

            txtNome.Enabled = false;
            txtRamo.Enabled = false;
            txtDescricao.Enabled = false;

            //verifica se tudo foi preenchido corretamente
            if(String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtRamo.Text) || String.IsNullOrEmpty(txtRua.Text)
                || String.IsNullOrEmpty(txtBairro.Text) || String.IsNullOrEmpty(txtCidade.Text)
                || String.IsNullOrEmpty(cbbEstado.Text) || String.IsNullOrEmpty(txtNumero.Text) || String.IsNullOrEmpty(txtEmail.Text)
                || msktxtCep.Text.Trim().Length != 9)
            {
                MessageBox.Show("Preencha corretamente todas as informações obrigatórias para cadastro (nome fantasia, ramo, rua, bairro, cidade, estado, numero e email de contato)", "Atenção, preencha os dados corretamente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(msktxtCep.Text.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("Preencha corretamente o campo 'CEP'", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //try pra garantir que o numero é um numero msm
                try
                {
                    int numero = int.Parse(txtNumero.Text);

                    string nome = txtNome.Text;
                    string ramo = txtRamo.Text;
                    string rua = txtRua.Text;
                    string bairro = txtBairro.Text;
                    string complemento = txtComplmento.Text;
                    string cidade = txtCidade.Text;
                    string estado = cbbEstado.Text;
                    string cep = msktxtCep.Text;
                    string email = txtEmail.Text;
                    string tel = msktxtTelefone.Text;
                    string desc = txtDescricao.Text;


                    if (Validacao.ValidarEmail(email))
                    {
                        Empresa empresa = new Empresa(cnpj_empresa, nome, rua, numero, bairro, complemento, cidade, estado, cep, email, tel, ramo, desc);
                        empresa.caminhoFoto = caminhoFoto;

                        if (empresa.editarEmpresa())
                        {
                            empresa.SalvarFoto();
                            MessageBox.Show("Informações de cadastro atualizadas com sucesso!", "Dados Atualizados!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            refreshInfoEmpresa(); //da refresh nas infos
                            
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar as informações do seu cadastro", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //refreshInfoEmpresa();
                            btnCancelar_Click(this, e); //desabilita tudo de novo e da refresh nas infos
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha corretamente o campo de e-mail", "Campo preenchido incorretamente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Preencha os campos numéricos de forma correta", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //dialog pra deleter a conta
            DialogResult pergunta = MessageBox.Show("Cuidado, ao clicar em prosseguir, sua conta será completamente apagada do nosso banco de dados. Esta é uma ação irreversível!", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(pergunta == DialogResult.OK)
            {
                DialogResult apagar = MessageBox.Show("Tem certeza que quer excluir sua conta? Ao fazer isso será impossível restaurá-la.", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(apagar == DialogResult.Yes)
                {
                    Empresa empresa = new Empresa(cnpj_empresa); //obejto empresa para poder excluí-la

                    int id_empresa = empresa.getCodigo_Empresa(); //pega o id da empresa

                    Vaga vg = new Vaga(id_empresa);

                    if (vg.deleteAllVagasEmpresa())
                    {
                        if (empresa.deleteEmpresa())
                        {
                            MessageBox.Show("O cadastro da sua empresa e todas as vagas associadas a ela foram permantentemente excluídos de nosso banco de dados",
                                "Cadastro excluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            ((FormLogin)this.MdiParent).FormGoBack(); //faz o Log out
                            this.Close(); //fechar o form
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir seu cadastro", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        private void btnCriarVaga_Click(object sender, EventArgs e)
        {
            //deixa tudo o que precisa visivel
            gpbInfoVaga.Visible = true;
            btnCancelarVaga.Visible = true;
            btnConfirmaCriar.Visible = true;

            btnEditarVaga.Visible = false;
            btnCriarVaga.Visible = false;

            //deixa tudo editavel
            txtDescricaoVaga.Enabled = true;
            txtNomeVaga.Enabled = true;
            txtRequisitos.Enabled = true;
            txtCarga.Enabled = true;
            cbxEspecializacao.Enabled = true;
        }

        private void btnEditarVaga_Click(object sender, EventArgs e)
        {
            //deixa tudo o que precisa visivel
            btnCancelarVaga.Visible = true;
            btnConfirmaEditar.Visible = true;

            btnExcluirVaga.Visible = false;
            btnEditarVaga.Visible = false;
            btnCriarVaga.Visible = false;

            //deixa possivel editar os treco
            txtDescricaoVaga.Enabled = true;
            txtNomeVaga.Enabled = true;
            txtRequisitos.Enabled = true;
            txtCarga.Enabled = true;
            cbxEspecializacao.Enabled = true;
        }

        private void btnConfirmaCriar_Click(object sender, EventArgs e) //cria uma nova vaga
        {
            //faz o oposto do btnCriarVaga
            gpbInfoVaga.Visible = false;
            btnCancelarVaga.Visible = false;
            btnConfirmaCriar.Visible = false;

            btnCriarVaga.Visible = true;

            //deixa possivel de editar as infos
            txtDescricaoVaga.Enabled = true;
            txtNomeVaga.Enabled = true;
            txtRequisitos.Enabled = true;
            txtCarga.Enabled = true;
            cbxEspecializacao.Enabled = true;

            if (String.IsNullOrEmpty(txtNomeVaga.Text) || String.IsNullOrEmpty(txtDescricaoVaga.Text) || String.IsNullOrEmpty(cbxEspecializacao.Text) || 
                String.IsNullOrEmpty(txtRequisitos.Text) || String.IsNullOrEmpty(txtCarga.Text)) //verifica se ha alguma informacao que nao foi dada na hora de criar a vaga
            {
                MessageBox.Show("É necessário que todos os campos sejam preenchidos antes de criar a vaga", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //atributos da classe vaga
                int id_empresa = -1;
                string nome = txtNomeVaga.Text;
                string desc = txtDescricaoVaga.Text;
                string area = cbxEspecializacao.Text;
                string requisitos = txtRequisitos.Text;
                string carga = txtCarga.Text;

                //criar uma empresa para obter o codigo a partir do cnpj
                Empresa empresa = new Empresa(cnpj_empresa);
                id_empresa = empresa.getCodigo_Empresa();

                //cria um objeto vaga
                Vaga vaga = new Vaga(id_empresa, nome, desc, area, requisitos, carga);

                if(id_empresa == -1)
                {
                    MessageBox.Show("Há algo de errado no cadastro da sua empresa, entre em contato para que possamos resolver", "Atenção: Erro fatal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (vaga.cadastrarVaga())
                {
                    MessageBox.Show("Vaga de estágio/emprego criada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshListaVagas();

                    txtDescricaoVaga.Text = string.Empty;
                    txtNomeVaga.Text = string.Empty;
                    cbxEspecializacao.SelectedIndex = -1; //limpa o texto dentro da comboBox
                    txtRequisitos.Text = string.Empty;
                    txtCarga.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Erro ao criar a vaga", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            
        }

        private void btnConfirmaEditar_Click(object sender, EventArgs e)
        {
            //deixa tudo o que precisa visivel
            gpbInfoVaga.Visible = false;
            btnCancelarVaga.Visible = false;
            btnConfirmaEditar.Visible = false;
            btnExcluirVaga.Visible = false;
            btnEditarVaga.Visible = false;
            btnAlunosInteressados.Visible = false;
            btnEditarVaga.Visible = false;

            btnCriarVaga.Visible = true;

            //pega os atributos nos campos e cria um objeto vaga
            string nome = txtNomeVaga.Text;
            string desc = txtDescricaoVaga.Text;
            string area = cbxEspecializacao.Text;
            string requisitos = txtRequisitos.Text;
            string carga = txtCarga.Text;

            Vaga vaga = new Vaga(nome, desc, area, requisitos, carga);

            int id_vaga = Int32.Parse(lblIdVaga.Text.Replace("#", null)); //pega o id da vaga

            if (String.IsNullOrEmpty(txtNomeVaga.Text) || String.IsNullOrEmpty(txtDescricaoVaga.Text) || String.IsNullOrEmpty(cbxEspecializacao.Text) ||
                String.IsNullOrEmpty(txtRequisitos.Text) || String.IsNullOrEmpty(txtCarga.Text)) //verifica se ha alguma informacao que nao foi dada na hora de editar a vaga
            {
                MessageBox.Show("É necessário que todos os campos sejam preenchidos antes de editar a vaga", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(vaga.editarVaga(id_vaga)) //ediata a vaga
            {
                MessageBox.Show("Vaga editada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshListaVagas();
            }
            else
            {
                MessageBox.Show("Erro ao editar a vaga", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarVaga_Click(object sender, EventArgs e)
        {
            //deixa tudo invisivel
            gpbInfoVaga.Visible = false;
            btnCancelarVaga.Visible = false;
            btnConfirmaCriar.Visible = false;
            btnConfirmaEditar.Visible = false;
            btnExcluirVaga.Visible = false;
            btnEditarVaga.Visible = false;
            btnAlunosInteressados.Visible = false;

            btnCriarVaga.Visible = true;

            //limpa os campos
            txtDescricaoVaga.Text = string.Empty;
            txtNomeVaga.Text = string.Empty;
            cbxEspecializacao.SelectedIndex = -1; //limpa o texto dentro da comboBox
            txtRequisitos.Text = string.Empty;
            txtCarga.Text = string.Empty;
        }

        private void btnAlunosInteressados_Click(object sender, EventArgs e)
        {
            //abre o form de informacoes sobre a vaga selecionada como MdiChild do MdiParent do form atual
            FormInfoVagas form = new FormInfoVagas();
            form.MdiParent = this.MdiParent;
            
             //lembrar! Se eu fzr o form.Show(); antes de passar os atributos, ele vai iniciar o form com os atributos errados
            try
            {
                form.VagaId = int.Parse(lblIdVaga.Text.Replace("#", "")); //passa o id da vaga sendo visualizada
                form.Tipo = 1;
                
            }
            catch(Exception ex)
            {
                form.VagaId=0;
            }
            
            form.Show();
        }

        private void FormPerfilEmpresa_ClientSizeChanged(object sender, EventArgs e)
        {
            //centraliza
            tabCtrlPerfilEmpresa.Left = (this.ClientSize.Width - tabCtrlPerfilEmpresa.Width) / 2;
            lblNomeEmpresa.Left = (this.ClientSize.Width - lblNomeEmpresa.Width) / 2;
        }

        private void dgvVagasEmpresa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) //ao dar double click em uma das vagas
        {
            //deixata tudo visisvel
            gpbInfoVaga.Visible = true;
            btnAlunosInteressados.Visible = true;
            btnEditarVaga.Visible = true;
            btnExcluirVaga.Visible = true;
            btnCancelarVaga.Visible = true;

            btnCriarVaga.Visible = false;

            //deixa impossivel de editar as infos
            txtDescricaoVaga.Enabled = false;
            txtNomeVaga.Enabled = false;
            txtRequisitos.Enabled = false;
            txtCarga.Enabled = false;
            cbxEspecializacao.Enabled = false;

            //seleciona o id da vaga que voce clicou e usa pra dar get na vaga
            int id_vaga = Int32.Parse(dgvVagasEmpresa.SelectedCells[0].Value.ToString());

            Vaga vaga = new Vaga();

            MySqlDataReader reader = vaga.getVagaById(id_vaga);

            while (reader.Read())//coloca as infos da vaga nos campos
            {
                txtDescricaoVaga.Text = reader["Descricao"].ToString();
                txtNomeVaga.Text = reader["Nome"].ToString();
                txtRequisitos.Text = reader["Requisitos"].ToString();
                txtCarga.Text = reader["Carga_Horaria"].ToString();
                cbxEspecializacao.Text = reader["Area"].ToString();
                lblIdVaga.Text += id_vaga;
            }
            DAO_Conexao.con.Close();

        }

        private void btnExcluirVaga_Click(object sender, EventArgs e)
        {
            int vagaId = Int32.Parse(lblIdVaga.Text.Replace("#", null)); //pega o codigo da vaga selecionada

            Vaga vaga = new Vaga();

            DialogResult pergunta = MessageBox.Show("Atenção! Excluir uma vaga é uma ação irreversível. Tem certeza que deseja prosseguir?", "Atenção!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if(DialogResult.Yes == pergunta) //se o usuario confirmar que quer excluir a vaga
            {
                if (vaga.excluirVaga(vagaId))
                {
                    MessageBox.Show("Vaga excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshListaVagas();

                    //deixa tudo invisivel de novo
                    gpbInfoVaga.Visible = false;
                    btnAlunosInteressados.Visible = false;
                    btnEditarVaga.Visible = false;
                    btnExcluirVaga.Visible = false;
                    btnCancelarVaga.Visible = false;

                    btnCriarVaga.Visible = true;
                }
                else
                {
                    MessageBox.Show("Erro ao excluir a vaga", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        public void refreshListaVagas()
        {
            //limpa as vagas que ja estao no dgv
            dgvVagasEmpresa.Rows.Clear();


            //da load nas vagas
            int id_empresa = -1;

            Empresa empresa = new Empresa(cnpj_empresa);
            id_empresa = empresa.getCodigo_Empresa(); //obtem o codigo da empresa


            Vaga vaga = new Vaga();
            MySqlDataReader reader = vaga.getVagas();

            
            while (reader.Read())
            {
                //row = (DataGridViewRow)dgvVagasEmpresa.Rows[0];
                
                if (reader["idEmpresa"].ToString().Equals(id_empresa.ToString()))
                {
                    /*
                    row.Cells[0].Value = reader["Codigo"].ToString();
                    row.Cells[1].Value = reader["Nome"].ToString();
                    row.Cells[2].Value = reader["Descricao"].ToString();
                    row.Cells[3].Value = reader["Area"].ToString();
                    row.Cells[4].Value = reader["Requisitos"].ToString();
                    row.Cells[5].Value = reader["Carga_Horaria"].ToString();
                    */
                    string cod = reader["Codigo"].ToString();
                    string nome = reader["Nome"].ToString();
                    string desc = reader["Descricao"].ToString();
                    string area = reader["Area"].ToString();
                    string requisitos = reader["Requisitos"].ToString();
                    string carga = reader["Carga_Horaria"].ToString();

                    //Console.WriteLine("\n\n" + cod + nome + desc + area + requisitos + "\n\n");

                    dgvVagasEmpresa.Rows.Add(cod, nome, desc, area, requisitos, carga);
                }
            }
            DAO_Conexao.con.Close();
        }

        public void refreshInfoEmpresa()
        {
            Empresa empresa = new Empresa(cnpj_empresa);

            MySqlDataReader reader = empresa.getInfosEmpresa();

            while (reader.Read())
            {
                //colocar as info nos campos
                lblNomeEmpresa.Text = reader["Nome"].ToString();
                msktxtCnpj.Text = reader["CNPJ"].ToString();
                txtNome.Text = reader["Nome"].ToString();
                txtRua.Text = reader["Rua"].ToString();
                txtNumero.Text = reader["Numero"].ToString();
                txtBairro.Text = reader["Bairro"].ToString();
                txtComplmento.Text = reader["Complemento"].ToString();
                txtCidade.Text = reader["Cidade"].ToString();
                cbbEstado.Text = reader["Estado"].ToString();
                msktxtCep.Text = reader["CEP"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                msktxtTelefone.Text = reader["Telefone"].ToString();
                txtRamo.Text = reader["Ramo"].ToString();
                txtDescricao.Text = reader["Descricao"].ToString();
            }
            DAO_Conexao.con.Close();
        }

        private void picFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnMudarFoto_Click(object sender, EventArgs e)
        {
            trocarFoto();
        }
        private void trocarFoto()
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos de imagens jpg e png|*.jpg; *.png;";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
                caminhoFoto = openFile.FileName;
            Console.WriteLine(caminhoFoto);

            if (caminhoFoto != "")
            {
                picFoto.Load(caminhoFoto);
            }
        }
    }
}
