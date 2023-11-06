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
    public partial class FormPerfilAluno : Form
    {
        int tipo = 0;
        bool interesse = false;

        public int Tipo { get => tipo; set => tipo = value; }
        public bool Interesse { get => interesse; set => interesse = value; }

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


        }

        private void FormPerfilAluno_Load(object sender, EventArgs e)
        {
            picFoto.ImageLocation = "../../img/default_user_empresa.jpg";
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;

            //se for empresa, some os botao de editar e excluir e aparece o de interesse
            if(tipo == 1)
            {
                btnDelete.Visible = false;
                btnEditar.Visible = false;
                btnInteresse.Visible = true;
            }
            else if(tipo == 2) //se for um aluno vendo o perfil do outro, nao pode editar e o botao de interesse nao aparece
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

            btnCurriculo.Text = "Trocar currículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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

            btnCurriculo.Text = "Ver currículo";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //dialog pra deleter a conta
            DialogResult pergunta = MessageBox.Show("Cuidado, ao clicar em prosseguir, sua conta será completamente apagada do nosso banco de dados.", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (pergunta == DialogResult.OK)
            {
                DialogResult apagar = MessageBox.Show("Tem certeza que quer excluir sua conta? Ao fazer isso será impossível restaurá-la.", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (apagar == DialogResult.Yes)
                {
                    //apagar a conta
                }
            }
        }

        private void btnInteresse_Click(object sender, EventArgs e)
        {
            //se a empresa nao tiver interessado, ao clicar no botao ele muda o texto e seta interessado como true
            if (!interesse)
            {
                btnInteresse.Text = "Retirar o interesse";
                btnInteresse.BackColor = Color.Salmon;
                interesse = true;

            }
            //se a empresa tiver interessado, ao clicar no botao ele muda o texto e seta interessado como false
            else
            {
                btnInteresse.Text = "Demonstrar Interesse";
                btnInteresse.BackColor = Color.Transparent;
                interesse = false;
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
    }
}
