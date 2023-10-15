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

        public int Tipo { get => tipo; set => tipo = value; }

        public FormPerfilAluno()
        {
            InitializeComponent();

            //habilita scroll etc
            WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;

            //desabilita tudo pra nao modificar
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;

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

            

        }

        private void FormPerfilAluno_Load(object sender, EventArgs e)
        {
            picFoto.ImageLocation = "../../img/default_user_empresa.jpg";
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;

            //se for empresa, some os botao de editar e excluir
            if(tipo == 1)
            {
                btnDelete.Visible = false;
                btnEditar.Visible = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //habilita tudo pra modificar
            btnEditar.Visible = false;

            btnCancelar.Visible = true;
            btnSalvar.Visible = true;

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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = true;

            btnCancelar.Visible = false;
            btnSalvar.Visible = false;

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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = true;

            btnCancelar.Visible = false;
            btnSalvar.Visible = false;

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
    }
}
