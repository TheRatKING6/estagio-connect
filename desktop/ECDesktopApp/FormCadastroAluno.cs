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
        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string cpfstring = msktxtCpf.Text;
            cpfstring = cpfstring.Replace(".", "").Replace("-", "");

            /*
             * string data = dateNascimento.Text.Replace("/", "");
               int dia = int.Parse(data.Substring())
                
                terminar de fazer o negocio pra validar a data de nascimento
             
             */

            if(cpfstring.Length < 11 || msktxtCep.Text.Length < 9 || String.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Preencha completamente os campos de CPF, CEP e Número para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(cbxEspecializacao.Text) || String.IsNullOrEmpty(cbxStatus.Text) || 
                String.IsNullOrEmpty(txtEscola.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(cbxAno.Text) || String.IsNullOrEmpty(txtRua.Text) ||
                String.IsNullOrEmpty(txtBairro.Text) || String.IsNullOrEmpty(txtCidade.Text) || String.IsNullOrEmpty(cbbEstado.Text) || String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Você precisa preencher todos os campos não opcionais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }


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

            //Limpa os campos de senha
            txtSenha.Text = null;
            txtConfirmaSenha.Text = null;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();

            //Descobrir como mexer no MdiParent a partir de MdiChild
            /*
            * 
            * this.MdiParent.IsMdiContainer = false;
            * this.MdiParent.Close();
            *
            */
            //Nenhum dos dois acima funciona por algum motivo. Erro: 'NullReferenceException' ou algo do tipo
        }
    }
}
