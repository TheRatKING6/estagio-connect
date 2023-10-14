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
    public partial class FormPerfilEmpresa : Form
    {
        public FormPerfilEmpresa()
        {
            InitializeComponent();
            //Maximiza a janela e habilita scroll
            WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;
            tabPgPerfil.AutoScroll = true;

            //desabilita tudo pra deixar como ReadOnly as informacoes
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

            msktxtCnpj.Enabled = false;
            txtNome.Enabled = false;
            txtRamo.Enabled = false;
            txtDescricao.Enabled = false;

        }

        private void FormPerfilEmpresa_Load(object sender, EventArgs e)
        {
            //coloca a foto default (se nao tiver foto cadastrada no bd)
            picFoto.ImageLocation = "../../img/default_user_empresa.jpg";
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tabPgPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //dialog pra deleter a conta
            DialogResult pergunta = MessageBox.Show("Cuidado, ao clicar em prosseguir, sua conta será completamente apagada do nosso banco de dados.", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(pergunta == DialogResult.OK)
            {
                DialogResult apagar = MessageBox.Show("Tem certeza que quer excluir sua conta? Ao fazer isso será impossível restaurá-la.", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(apagar == DialogResult.Yes)
                {
                    //apagar a conta
                }
            }
        }
    }
}
