using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECDesktopApp
{
    public partial class FormPesquisarVagas : Form
    {
        public FormPesquisarVagas()
        {
            InitializeComponent();
            //maximiza janela e habilita scroll
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;

            //deixa tudo em DropDownList pra nao poder eitar o texto diretamente
            cbxEspecializacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOrganizar.DropDownStyle = ComboBoxStyle.DropDownList;

            //desabilita o botao de visualizar ate vc selecionar alguma coisa no dgv
            //btnVerVaga.Visible = false;
        }

        private void FormPesquisarVagas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //verifica se tem pelo menos alguma coisa preenchida para poder buscar
            if (String.IsNullOrEmpty(cbxEspecializacao.Text) && String.IsNullOrEmpty(txtCarga.Text) && String.IsNullOrEmpty(txtEmpresa.Text) && String.IsNullOrEmpty(txtNomeVaga.Text))
            {
                MessageBox.Show("Você precisa preencher no mínimo um campo para poder realizar uma busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //realizar a buscar e exibir os resultados do dataGridView
            }
        }

        private void btnVerVaga_Click(object sender, EventArgs e)
        {
            FormInfoVagas form = new FormInfoVagas();
            form.MdiParent = this.MdiParent;
            form.Tipo = 0;
            form.Show();
        }
    }
}
