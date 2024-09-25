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
    public partial class FormCadastroEmpresa : Form
    {
        private byte[] foto = null;

        public byte[] Foto { get => foto; set => foto = value; }

        public FormCadastroEmpresa()
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

            //formata a mask do msktxtCnpj
            msktxtCnpj.Mask = "00.000.000/0000-00";

            //faz a imagem caber exatamente na picBox
            picFotoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FormCadastroEmpresa_Load(object sender, EventArgs e)
        {
            cbbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Verifica se tudo foi preenchido corretamente
            string stringCnpj = msktxtCnpj.Text;
            stringCnpj = stringCnpj.Replace(".", "").Replace("/", "").Replace("-", "").Trim();

            if (stringCnpj.Length != 14 || String.IsNullOrEmpty(txtNumero.Text) || msktxtCep.Text.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("Preencha completamente os campos de CNPJ, Número e CEP para prosseguir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtRua.Text) || String.IsNullOrEmpty(txtBairro.Text) || String.IsNullOrEmpty(txtCidade.Text) ||
                String.IsNullOrEmpty(cbbEstado.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtRamo.Text))
            {
                MessageBox.Show("Todos os campos não opcionais devem ser preenchidos para que seu cadastro seja efetuado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(Validacao.ValidarEmail(txtEmail.Text)))
            {
                MessageBox.Show("Preencha corretamente o campo de e-mail", "Campo preenchido incorretamente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                //try catch pra verificarse alguem pos letra no campo numero
                try
                {
                    int numero = int.Parse(txtNumero.Text);
                    //Deixa a parte da senha visivel
                    lblQuaseLa.Visible = true;
                    btnVoltar.Visible = true;
                    gpbSenha.Visible = true;
                    btnCadastro.Visible = true;

                    //torna a si mesmo invisivel
                    btnNext.Visible = false;

                    //Desbilita a edição de todos os campos
                    msktxtCnpj.ReadOnly = true;
                    msktxtCep.ReadOnly = true;
                    msktxtTelefone.ReadOnly = true;

                    txtNome.ReadOnly = true;
                    txtRamo.ReadOnly = true;
                    txtRua.ReadOnly = true;
                    txtBairro.ReadOnly = true;
                    txtCidade.ReadOnly = true;
                    txtComplmento.ReadOnly = true;
                    txtDescricao.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtNumero.ReadOnly = true;

                    cbbEstado.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Por favor, preencha corretamente o campo 'número'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            msktxtCnpj.ReadOnly = false;
            msktxtCep.ReadOnly = false;
            msktxtTelefone.ReadOnly = false;

            txtNome.ReadOnly = false;
            txtRamo.ReadOnly = false;
            txtRua.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtCidade.ReadOnly = false;
            txtComplmento.ReadOnly = false;
            txtDescricao.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtNumero.ReadOnly = false;

            cbbEstado.Enabled = true;

            //Limpa os campos de senha
            txtSenha.Text = null;
            txtConfirmaSenha.Text = null;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //verifica se a senha ta certa
            if(String.IsNullOrEmpty(txtSenha.Text) || (txtSenha.Text.Length < 8))
            {
                MessageBox.Show("Você precisa criar uma senha com ao menos 8 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(txtSenha.Text.Equals(txtConfirmaSenha.Text)))
            {
                MessageBox.Show("Você deve digitar a senha de forma igual nos campos 'senha' e 'confirmar senha'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //cria um objeto Empresa
                string cnpj = msktxtCnpj.Text.Replace(",", ".");
                string nome = txtNome.Text;
                string rua = txtRua.Text;
                int numero = int.Parse(txtNumero.Text);
                string bairro = txtBairro.Text;
                string complemento = txtComplmento.Text;
                string cidade = txtCidade.Text;
                string estado = cbbEstado.Text;
                string cep = msktxtCep.Text;
                string email = txtEmail.Text;
                string telefone = msktxtTelefone.Text;
                string ramo = txtRamo.Text;
                string descricao = txtDescricao.Text;
                string senha = txtSenha.Text;

                if(telefone.Length < 14)
                {
                    telefone = null;
                }

                Empresa empresa = new Empresa(cnpj, nome, rua, numero, bairro, complemento, cidade, estado, cep, email, telefone, ramo, foto, descricao, senha);

                //faz o cadastro no BD
                if (empresa.verificaCadastroEmpresa())
                {
                    MessageBox.Show("O CNPJ da sua empresa já está cadastradoem nosso sistema. Verifique se você digitou seu CNPJ corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(empresa.cadastrarEmpresa())
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrado", MessageBoxButtons.OK);
                    
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

        private void FormCadastroEmpresa_ClientSizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            //nao faco ideia de como isso funssiona, mas funsciona, ent vai ficar por isso msm
            if (foto == null)
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Title = "Abrir arquivo";
                ofd.Filter = "JPG (*.jpg)|*.jpg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picFotoEmpresa.Image = new Bitmap(ofd.OpenFile());

                        using (var stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = new BinaryReader(stream))
                            {
                                foto = reader.ReadBytes((int)stream.Length);
                                btnSelectImg.Text = "Cancelar";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Aconteceu um erro ao carregar o arquivo selecionado\nErro: " + ex.ToString(), "Erro ao carregar imagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                ofd.Dispose();
            }
            else
            {
                picFotoEmpresa.Image = null;
                foto = null;
                btnSelectImg.Text = "Escolher Foto...";
            }
        }

        private async void msktxtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) //se a tecla apertada for enter
            {
                if (msktxtCep.Text.Replace("-", "").Trim().Count() == 8) //verifica se o cep foi preenchido corretamente
                {
                    //passa o cep pra conseguir um objeto da classe endereco e dps coloca as propriedades do obj nos campos
                    string cep = msktxtCep.Text.Replace("-", "").Trim();
                    Endereco endereco = await Apis.getEnderecoFromCEP(cep);

                    if (endereco != null)
                    {
                        txtRua.Text = endereco.Logradouro.ToString();
                        txtBairro.Text = endereco.Bairro.ToString();
                        txtCidade.Text = endereco.Localidade.ToString();
                        txtComplmento.Text = endereco.Complemento.ToString();
                        cbbEstado.Text = endereco.Uf.ToString();
                    }
                }
            }
        }
    }
}
