using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECDesktopApp
{
    public partial class FormCadastroAluno : Form
    {
        public FormCadastroAluno()
        {
            InitializeComponent();

            //coloca a tela em fullscreen e habilita o scroll do mouse
            this.WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;

            //deixa toda a parte final do cadastro invisivel
            lblQuaseLa.Visible = false;
            btnVoltar.Visible = false;
            gpbSenha.Visible = false;
            btnCadastro.Visible = false;
            
            //o txt do nome do arqiov sempre vai ser impossivel de editar
            txtArquivoCurriculo.Enabled = false;

            //faz com que o usuario so possa selecionar uma das opcoes dadas a ele
            cbxAno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEspecializacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            //Faz com que o formato da data no DateTimePicker seja dd/MM/yyyy, assim, independente se o computador da pessoa está em ingles ou portugues,
            //a data sempre terá o msm formato, assim o código nao buga :)
            dateNascimento.Format = DateTimePickerFormat.Custom;
            dateNascimento.CustomFormat = "dd/MM/yyyy";

            //formata a mask do msktxtCpf
            msktxtCpf.Mask = "000.000.000-00";
        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;

            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string cpfstring = msktxtCpf.Text;
            cpfstring = cpfstring.Replace(".", "").Replace("-", "").Trim();

            //pega a data selecionada no DateTimePicker e transfroma em um objeto DateTime
            DateTime selecionado = ManipulcaoData.getDataNascimento(dateNascimento.Text.ToString()); 

            //faz as verificacoes em busca de campos vazios
            if(cpfstring.Length < 11 || msktxtCep.Text.Trim().Length < 9 || String.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Preencha completamente os campos de CPF, CEP e Número para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(cbxEspecializacao.Text) || String.IsNullOrEmpty(cbxStatus.Text) || 
                String.IsNullOrEmpty(txtEscola.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(cbxAno.Text) || String.IsNullOrEmpty(txtRua.Text) ||
                String.IsNullOrEmpty(txtBairro.Text) || String.IsNullOrEmpty(txtCidade.Text) || String.IsNullOrEmpty(cbbEstado.Text) || String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Você precisa preencher todos os campos não opcionais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            else if (!(Validacao.ValidarEmail(txtEmail.Text)))
            {
                MessageBox.Show("Preencha corretamente o campo de e-mail", "Campo preenchido incorretamente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //se o aluno tiver menos de 15 anos rejeita o cadastro
            else if(ManipulcaoData.verificaMaiorIdade(selecionado))
            {
                MessageBox.Show("Você precisa ter ao menos 15 anos para se cadastrar no nosso sistema.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try //verifica se alguem nao colocou letra nos campo de numero
                {
                    int serie = int.Parse(cbxAno.Text);
                    int num = int.Parse(txtNumero.Text);


                    //Deixa a parte da senha visivel
                    lblQuaseLa.Visible = true;
                    btnVoltar.Visible = true;
                    gpbSenha.Visible = true;
                    btnCadastro.Visible = true;

                    //torna a si mesmo invisivel
                    btnNext.Visible = false;

                    //Desbilita a edição de todos os campos
                    msktxtCpf.ReadOnly = true;
                    msktxtCep.ReadOnly = true;
                    msktxtTelefone.ReadOnly = true;

                    txtNome.ReadOnly = true;
                    txtEscola.ReadOnly = true;
                    txtRua.ReadOnly = true;
                    txtBairro.ReadOnly = true;
                    txtCidade.ReadOnly = true;
                    txtComplmento.ReadOnly = true;
                    txtDescricao.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtNumero.ReadOnly = true;

                    cbbEstado.Enabled = false;
                    cbxAno.Enabled = false;
                    cbxEspecializacao.Enabled = false;
                    cbxStatus.Enabled = false;

                    dateNascimento.Enabled = false;

                    btnEscolherCurriculo.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Por favor, preencha corretamente os campos 'número' e 'ano letivo'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //faz o exato oposto do btnNext
            lblQuaseLa.Visible = false;
            btnVoltar.Visible = false;
            gpbSenha.Visible = false;
            btnCadastro.Visible = false;

            btnNext.Visible = true;

            msktxtCpf.ReadOnly = false;
            msktxtCep.ReadOnly = false;
            msktxtTelefone.ReadOnly = false;

            txtNome.ReadOnly = false;
            txtEscola.ReadOnly = false;
            txtRua.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtCidade.ReadOnly = false;
            txtComplmento.ReadOnly = false;
            txtDescricao.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtNumero.ReadOnly = false;

            cbbEstado.Enabled = true;
            cbxAno.Enabled = true;
            cbxEspecializacao.Enabled = true;
            cbxStatus.Enabled = true;

            dateNascimento.Enabled = true;

            btnEscolherCurriculo.Enabled = true;

            //Limpa os campos de senha
            txtSenha.Text = null;
            txtConfirmaSenha.Text = null;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //verifica se a senha ta certa
            if (String.IsNullOrEmpty(txtSenha.Text) || txtSenha.Text.Length < 8)
            {
                MessageBox.Show("Você deve criar uma senha com ao menos 8 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(txtSenha.Text.Equals(txtConfirmaSenha.Text)))
            {
                MessageBox.Show("Você deve digitar a senha de forma igual nos campos 'senha' e 'confirmar senha'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //cria um objeto Aluno

                string cpf = msktxtCpf.Text;
                string matricula = txtMatricula.Text;
                string nome = txtNome.Text;

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
                string senha = txtSenha.Text;

                if(msktxtTelefone.Text.Length < 14)
                {
                    telefone = null;
                }

                //Console.WriteLine(data.ToString());
                //Console.WriteLine(nascimento.ToShortDateString().ToString());

                Aluno al1 = new Aluno(cpf, matricula, nome, nascimento, email, telefone, especialidade, descricao, rua, numero, bairro, complemento, cidade, estado, cep, status, 
                    ano, escola, senha);

                //faz o cadastro no BD
                if (al1.verificaCpfCadastrado())
                {
                    MessageBox.Show("Já existem um aluno com seu CPF cadastrado no nosso sistema. Verifique se você digitou seu CPF corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (al1.cadastrarAluno())
                {
                    MessageBox.Show("Cadastro realizado com sucesso.", "Cadastrado", MessageBoxButtons.OK);

                    //Faz com que o MdiParent deixe de ser um MdiContainer e fecha o form atual
                    Form1 form = (Form1)this.MdiParent;
                    this.Close();
                    form.Close();
                    //form.IsMdiContainer = false;
                }
                else
                {
                    MessageBox.Show("Erro ao efetuar o cadastro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void FormCadastroAluno_ClientSizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }
    }
}
