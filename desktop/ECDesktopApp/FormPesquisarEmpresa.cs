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
    public partial class FormPesquisarEmpresa : Form
    {
        public FormPesquisarEmpresa()
        {
            InitializeComponent();
            //maximiza a janela e habilita o scroll
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;

            //deixa o botao de entrar no perfil da empresa invisivel ate vc selecionar um aluno que vc buscou
            //btnVerEmpresa.Visible = false;

            cbxOrganizar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormPesquisarEmpresa_Load(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNome.Text) && String.IsNullOrEmpty(txtRamo.Text) && String.IsNullOrEmpty(txtEmail.Text) && String.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Você precisa preencher no mínimo um campo para poder realizar uma busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //realizar a buscar e exibir os resultados do dataGridView
            }
        }

        private void btnVerEmpresa_Click(object sender, EventArgs e)
        {
            FormPerfilEmpresa form = new FormPerfilEmpresa();
            form.MdiParent = this.MdiParent;
            form.Tipo = 0;
            form.Show();
        }

        private void FormPesquisarEmpresa_SizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }
    }
}
