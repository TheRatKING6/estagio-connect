using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECDesktopApp
{
    public partial class FormPerfilAluno : Form
    {
        int tipo = 0;
        bool interesse = false;
        string UserId;
        int vagaId;
        byte[] foto = null;

        public int Tipo { get => tipo; set => tipo = value; }
        public bool Interesse { get => interesse; set => interesse = value; }
        public string UserId1 { get => UserId; set => UserId = value; }
        public int VagaId { get => vagaId; set => vagaId = value; }
        public byte[] Foto { get => foto; set => foto = value; }

        public FormPerfilAluno()
        {
            InitializeComponent();

            //habilita scroll etc
            WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;

            //desabilita tudo pra nao modificar
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
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            
            cbxAno.Enabled = false;
            cbxEspecializacao.Enabled = false;
            txtEscola.Enabled = false;
            txtMatricula.Enabled = false;
            dateNascimento.Enabled = false;
            cbxStatus.Enabled = false;
            msktxtCpf.Enabled = false;

            txtArquivoCurriculo.Enabled = false;

            btnInteresse.Visible = false;

            //deixa impossivel de editar a combobox
            cbxEspecializacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            //Faz com que o formato da data no DateTimePicker seja dd/MM/yyyy, assim, independente se o computador da pessoa está em ingles ou portugues,
            //a data sempre terá o msm formato, assim o código nao buga :)
            dateNascimento.Format = DateTimePickerFormat.Custom;
            dateNascimento.CustomFormat = "dd/MM/yyyy";

            //formata a mask do cpf
            msktxtCpf.Mask = "000.000.000-00";
        }

        private void FormPerfilAluno_Load(object sender, EventArgs e)
        {
            //picFoto.ImageLocation = "../../img/default_user_empresa.jpg"; //jeito errado de se colocar uma img no pictureBox LOL

            //coloca a foto default no picBox e muda o sizeMode pra foto caber perfeitamente dentro dela
            picFoto.Image = Image.FromFile("../../img/default_user_empresa.jpg");
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;

            //verifica se a vaga ja esta interessada no aluno
            getInteresse();

            //coloca as infos do aluno nos campos
            refreshInfosAluno();

            //se for empresa, some os botao de editar e excluir e aparece o de interesse
            //if(tipo == 1)
            if (((FormLogin)this.MdiParent).TipoUsuario == 7) { }
            else if (((FormLogin)this.MdiParent).TipoUsuario == 1)
            {
                btnDelete.Visible = false;
                btnEditar.Visible = false;
                btnInteresse.Visible = true;
            }
            else if (((FormLogin)this.MdiParent).IdUsuario != msktxtCpf.Text.Replace(",", ".")) //se for um aluno vendo o perfil do outro, nao pode editar e o botao de interesse nao aparece (cpf eh diferente)
            {

                btnDelete.Visible = false;
                btnEditar.Visible = false;
            }

            if (interesse)
            {
                btnInteresse.Text = "Retirar o interesse";
                btnInteresse.BackColor = Color.Salmon;
            }

            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;

            btnCurriculo.Text = "Ver currículo";

            //refreshFoto();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //habilita tudo pra modificar
            btnEditar.Visible = false;

            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnMudarFoto.Visible = true;

            txtEmail.Enabled = true;
            msktxtTelefone.Enabled = true;

            msktxtCep.Enabled = true;
            txtRua.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtComplmento.Enabled = true;
            cbbEstado.Enabled = true;
            txtDescricao.Enabled = true;

            cbxAno.Enabled = true;
            cbxEspecializacao.Enabled = true;
            txtEscola.Enabled = true;
            txtMatricula.Enabled = true;
            cbxStatus.Enabled = true;

            //se for adm, vai poder editar cpf, nome e nascimento
            if(((FormLogin)this.MdiParent).TipoUsuario == 7)
            {
                msktxtCpf.Enabled = true;
                txtNome.Enabled = true;
                dateNascimento.Enabled = true;
            }

            btnCurriculo.Text = "Trocar currículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //desabilita a modificacao
            btnEditar.Visible = true;

            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnMudarFoto .Visible = false;

            txtEmail.Enabled = false;
            msktxtTelefone.Enabled = false;

            msktxtCep.Enabled = false;
            txtRua.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            txtComplmento.Enabled = false;
            cbbEstado.Enabled = false;
            txtDescricao.Enabled = false;

            cbxAno.Enabled = false;
            cbxEspecializacao.Enabled = false;
            txtEscola.Enabled = false;
            txtMatricula.Enabled = false;
            cbxStatus.Enabled = false;

            msktxtCpf.Enabled = false;
            txtNome.Enabled = false;
            dateNascimento.Enabled = false;

            btnCurriculo.Text = "Ver currículo";

            refreshInfosAluno();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try //try pra ver se ele nao deixou o campo numero vazio ou com um caracter invalido
            {
                string cpf = msktxtCpf.Text.Replace(",", ".");
                string matricula = txtMatricula.Text;
                string nome = txtNome.Text;
                //string nascimento = dateNascimento.Text;

                //pega a data do nascimento e transforma numa string
                DateTime data = ManipulcaoData.getDataNascimento(dateNascimento.Text.ToString());
                string nascimento = data.Date.ToString("yyyMMdd").Replace("/", "-");

                string email = txtEmail.Text;
                string telefone = msktxtTelefone.Text;
                string especialidade = cbxEspecializacao.Text;
                string descricao = txtDescricao.Text;
                string rua = txtRua.Text;
                int numero = int.Parse(txtNumero.Text);
                string bairro = txtBairro.Text;
                string complemento = txtComplmento.Text;
                string cidade = txtCidade.Text;
                string estado = cbbEstado.Text;
                string cep = msktxtCep.Text;
                string status = cbxStatus.Text;
                int ano = int.Parse(cbxAno.Text);
                string escola = txtEscola.Text;
                string senha = null;


                if(((FormLogin)this.MdiParent).TipoUsuario == 7)
                {
                    //cria o objeto com as modificacoes que foram feitas
                    Aluno aluno = new Aluno(cpf, matricula, nome, nascimento, email, telefone, especialidade, descricao, rua, numero, bairro,
                        complemento, cidade, estado, cep, status, ano, escola, senha); //cria um obj aluno

                    //como o cpf pode ser editado, e preciso puxar o cpf do aluno atraves do UserId e usar ele pra pegar o Id do Aluno no BD
                    Aluno alunoOg = new Aluno(UserId);
                    
                    int idAluno = alunoOg.getIdAluno();

                    //faz a edicao cmo adm
                    if (aluno.editarInfosById(idAluno))
                    {
                        MessageBox.Show("Informações de perfil modificadas com sucesso", "Sucesso ao editar perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //desabilita a modificacao
                        btnEditar.Visible = true;

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
                        txtDescricao.Enabled = false;

                        cbxAno.Enabled = false;
                        cbxEspecializacao.Enabled = false;
                        txtEscola.Enabled = false;
                        txtMatricula.Enabled = false;
                        cbxStatus.Enabled = false;

                        msktxtCpf.Enabled = false;
                        txtNome.Enabled = false;
                        dateNascimento.Enabled = false;


                        btnCurriculo.Text = "Ver currículo";
                    }
                }
                //ve se nao tem nenhum campo vazio e se o cep e email foi preenchido corretamente
                else if(!(String.IsNullOrEmpty(matricula) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(rua) || String.IsNullOrEmpty(bairro) ||
                    String.IsNullOrEmpty(cidade) || String.IsNullOrEmpty(estado) || String.IsNullOrEmpty(cep) || String.IsNullOrEmpty(escola))
                    && msktxtCep.Text.Trim().Length == 9 && Validacao.ValidarEmail(txtEmail.Text))
                {
                    Aluno aluno = new Aluno(cpf, matricula, nome, nascimento, email, telefone, especialidade, descricao, rua, numero, bairro,
                        complemento, cidade, estado, cep, status, ano, escola, senha); //cria um obj aluno

                    if (aluno.editarInfosAluno()) //usa o metodo pra editar o cadastro
                    {
                        MessageBox.Show("Informações de perfil modificadas com sucesso", "Sucesso ao editar perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        //desabilita a modificacao
                        btnEditar.Visible = true;

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
                        txtDescricao.Enabled = false;

                        cbxAno.Enabled = false;
                        cbxEspecializacao.Enabled = false;
                        txtEscola.Enabled = false;
                        txtMatricula.Enabled = false;
                        cbxStatus.Enabled = false;

                        btnCurriculo.Text = "Ver currículo";
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao tentarmos modificar suas informações", "Erro ao editar perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha corretamente todas as informações necessárias", "Erro: Informações faltando!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Por favor, preencha os campos numéricos corretamente!", "Erro ao converter os campos numéricos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(ex.Message);
            } 
            

            refreshInfosAluno(); //da refresh nas informacoes (pq sim)

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //cria um obj aluno e usa para obter o ID
            Aluno aluno = new Aluno(UserId);
            int idAluno = aluno.getIdAluno();

            //dialog pra deleter a conta
            DialogResult pergunta = MessageBox.Show("Cuidado! Ao clicar em prosseguir, sua conta será completamente apagada do nosso banco de dados.", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (pergunta == DialogResult.OK)
            {
                DialogResult apagar = MessageBox.Show("Tem certeza que quer excluir sua conta? Ao fazer isso será impossível restaurá-la.", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (apagar == DialogResult.Yes) 
                {
                    if(aluno.deleteAluno(idAluno))//se o usuario confirmar tudo e o script de deletar der certo sua conta vai ser apagada
                    {
                        MessageBox.Show("Sua conta foi excluída com sucesso! Seus dados foram completamente apagados de nossa base de dados", 
                            "Sucesso em apagar dados!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ((FormLogin)this.MdiParent).FormGoBack();//faz o log-out
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir sua conta", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnInteresse_Click(object sender, EventArgs e)
        {
            Vaga vaga = new Vaga();
            Aluno aluno = new Aluno(UserId);
            int idAluno = aluno.getIdAluno();
            //se a empresa nao tiver interessado, ao clicar no botao ele muda o texto e seta interessado como true
            if (!interesse)
            {
                if(vaga.setInteresseVaga(vagaId, idAluno))
                {
                    btnInteresse.Text = "Retirar o interesse";
                    btnInteresse.BackColor = Color.Salmon;
                    interesse = true;

                    if(vaga.connectCheck(vagaId, idAluno)) //verifica se o aluno ja esta interessado na vaga e cria o connect, brabo
                    {
                        MessageBox.Show("Parabéns, você acabou de criar um Connect, olhe a aba de connects no aplicativo para saber mais!", "Connect!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar interesse no aluno", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            //se a empresa tiver interessado, ao clicar no botao ele muda o texto e seta interessado como false
            else if(vaga.deleteInteresseVaga(vagaId, idAluno))
            {
                btnInteresse.Text = "Demonstrar Interesse";
                btnInteresse.BackColor = Color.Transparent;
                interesse = false;
            }
            else
            {
                MessageBox.Show("Erro ao atualizar interesse", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void FormPerfilAluno_ClientSizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        private void btnCurriculo_Click(object sender, EventArgs e)
        {
            if(btnCurriculo.Text.Equals("Trocar currículo"))
            {
                //abrir o menu de arquivo e fzr upload
            }
            else
            {
                FormVisualizarCurriculo form = new FormVisualizarCurriculo();
                form.MdiParent = this.MdiParent;
                form.Show();
            }
        }

        public void refreshInfosAluno()
        {
            //cria obj aluno pra usar o metodo de pegar os dados e jogar nos campos
            Aluno aluno = new Aluno(UserId);

            MySqlDataReader reader = aluno.getInfoAluno();

            while(reader.Read())
            {
                msktxtCpf.Text = reader["CPF"].ToString();
                txtNome.Text = reader["Nome"].ToString();
                label1.Text = reader["Nome"].ToString();
                dateNascimento.Value = ManipulcaoData.getDataNascimento(ManipulcaoData.formataData(reader["Nascimento"].ToString()));
                cbxEspecializacao.Text = reader["Especialidade"].ToString();
                txtMatricula.Text = reader["Matricula"].ToString();
                cbxStatus.Text = reader["Status"].ToString();
                txtEscola.Text = reader["Escola"].ToString();
                cbxAno.Text = reader["Ano_Letivo"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                msktxtTelefone.Text = reader["Telefone"].ToString();
                txtDescricao.Text = reader["Descricao"].ToString();
                txtRua.Text = reader["Rua"].ToString();
                txtBairro.Text = reader["Bairro"].ToString();
                txtCidade.Text = reader["Cidade"].ToString();
                txtNumero.Text = reader["Numero"].ToString();
                txtComplmento.Text = reader["Complemento"].ToString();
                cbbEstado.Text = reader["Estado"].ToString();
                msktxtCep.Text = reader["CEP"].ToString();

                //TA DANDO ERRO, CACETE EU ODEIO MINHA VIDA, DESGRAÇA, EU LITERALMENTE VOU ME MATAR DIA 09/08/2024
                //jeito q encontrei na net:
                //try
                //{
                //    foto = (byte[])reader["Foto"];
                //    if (foto.Length > 0)
                //    {
                //        Console.WriteLine("\n\nfoto.Lenght > 0\n\n");
                //        MemoryStream coisa = new MemoryStream(foto);
                //        picFoto.Image = new Bitmap(coisa);
                //        string imagem = Convert.ToString("../../img/" + DateTime.Now.ToFileTime() + ".jpg");
                //        Console.WriteLine("\n\n" + imagem + "\n\n");
                //        byte[] bimage = (byte[])reader["Foto"];
                //        FileStream fs = new FileStream(imagem, FileMode.CreateNew, FileAccess.Write);
                //        fs.Write(bimage, 0, bimage.Length - 1);


                //        picFoto.Image = Image.FromFile(imagem);
                //        fs.Close();

                //        MemoryStream strm = new MemoryStream(foto);
                //        picFoto.Image = Image.FromStream(strm);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    picFoto.Image = Image.FromFile("../../img/default_user_empresa.jpg");
                //    Console.WriteLine(ex.Message);
                //    MessageBox.Show("Erro ao carregar sua imagem de perfil", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}




                //jeito q a priscila ensinou em aula:
                //try
                //{
                //    foto = (byte[])reader["Foto"];
                //    if (foto.Length > 0)
                //    {
                //        picFoto.Image = null;
                //        string imagem = Convert.ToString(DateTime.Now.ToFileTime());
                //        FileStream fs = new FileStream(imagem, FileMode.CreateNew, FileAccess.Write);
                //        fs.Write(foto, 0, foto.Length - 1);
                //        fs.Close();
                        
                //        picFoto.Image = Image.FromFile(imagem);
                //        reader.Close();
                //    }

                //}
                //catch (Exception ex)
                //{
                //    picFoto.Image = Image.FromFile("../../img/default_user_empresa.jpg");
                //    Console.WriteLine(ex.Message);
                //    MessageBox.Show("Erro ao carregar sua imagem de perfil", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}


                //NEM UM DOS DOIS JEITOS FUNCIONAM, FODASE, EU ODEEEEEEEEEEEEEEEEEEEEIO PROGRAMAR, EU ODEIO MINHA VIDA, E EU ODEIO ESSE CURSO DE MERDA, FODAM-SE VOCES TODOS, MORRAM DE FORMA LENTA E DOLOROSA
            }
            DAO_Conexao.con.Close();
        }
        public void getInteresse()
        {
            Vaga vaga = new Vaga();
            Aluno aluno = new Aluno(UserId);
            int idAluno = aluno.getIdAluno();

            MySqlDataReader reader = vaga.getAlunosInteressantes(vagaId);

            while(reader.Read())
            {
                if (int.Parse(reader["idAluno"].ToString()) == idAluno)
                {
                    interesse = true;
                }
            }
            DAO_Conexao.con.Close();
        }

        //public void refreshFoto()
        //{
        //    Aluno aluno = new Aluno(UserId);

        //    Image fotoAluno = aluno.getFotoAluno();

        //    picFoto.Image = fotoAluno;
        //}
    }
}
