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
    public partial class FormInfoVagas : Form
    {
        int vagaId;
        int tipo = 1;
        bool interessado = false;

        public FormInfoVagas()
        {
            InitializeComponent();
            
            //maximiza a janela e ativa scroll
            WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;

            //desabilita tudo pra impedir a edição
            txtDescricaoVaga.Enabled = false;
            txtNomeVaga.Enabled = false;
            txtRequisitos.Enabled = false;
            txtCarga.Enabled = false;
            cbxEspecializacao.Enabled = false;
            btnInteressado.Visible = false;
        }

        public int VagaId { get => vagaId; set => vagaId = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public bool Interessado { get => interessado; set => interessado = value; }

        private void FormInfoVagas_Load(object sender, EventArgs e)
        {
            //se for um aluno visualizando a info da vaga, some tudo e aprece so o 'demonstrar interesse'
            if(tipo == 0)
            {
                label1.Visible = false;
                dgvAlunosInteressados.Visible = false;
                btnVisualizarAluno.Visible = false;
                btnInteressado.Visible = true;

                if(interessado)
                {
                    btnInteressado.Text = "Retirar o interesse";
                    btnInteressado.BackColor = Color.Salmon;
                }
            }
        }

        private void btnVisualizarAluno_Click(object sender, EventArgs e)
        {
            //abre o perfil do aluno
            FormPerfilAluno form = new FormPerfilAluno();
            form.MdiParent = this.MdiParent;

            form.Tipo = 1; //passa o tipo como 1 pra deixar algumas coisas invisiveis
            
            form.Show();
            this.Close();
        }

        private void btnInteressado_Click(object sender, EventArgs e)
        {
            //se o aluno nao tiver interessado, ao clicar no botao ele muda o texto e seta interessado como true
            if (!interessado)
            {
                btnInteressado.Text = "Retirar o interesse";
                btnInteressado.BackColor = Color.Salmon;
                interessado = true;
                
            }
            //se o aluno tiver interessado, ao clicar no botao ele muda o texto e seta interessado como false
            else
            {
                btnInteressado.Text = "Demonstrar Interesse";
                btnInteressado.BackColor = Color.Transparent;
                interessado = false;
            }
        }
    }
}
