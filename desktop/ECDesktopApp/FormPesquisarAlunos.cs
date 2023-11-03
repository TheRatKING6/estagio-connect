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
    public partial class FormPesquisarAlunos : Form
    {
        public FormPesquisarAlunos()
        {
            InitializeComponent();
            //maximiza a janela e habilita o scroll
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;

            //deixa o botao de entrar no perfil do aluno invisivel ate vc selecionar um aluno que vc buscou
            //btnVerAluno.Visible = false;

            //deixa imposivel editar o texto dentro da comboBox (lembra de fazer isso nos outros forms tambem)
            cbxEspecializacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOrganizar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormPesquisarAlunos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //verifica se tem pelo menos alguma coisa preenchida para poder buscar
            if(String.IsNullOrEmpty(txtNome.Text) && String.IsNullOrEmpty(txtEscola.Text) && String.IsNullOrEmpty(txtEmail.Text) && String.IsNullOrEmpty(cbxEspecializacao.Text) 
                && String.IsNullOrEmpty(txtCidade.Text)) 
            {
                MessageBox.Show("Você precisa preencher no mínimo um campo para poder realizar uma busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //realizar a buscar e exibir os resultados do dataGridView
            }
        }

        private void btnVerAluno_Click(object sender, EventArgs e)
        {
            FormPerfilAluno form = new FormPerfilAluno();
            form.MdiParent = this.MdiParent;
            form.Tipo = 2;
            form.Show();
        }
    }
}
