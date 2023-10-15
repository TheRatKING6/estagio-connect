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
        }

        public int VagaId { get => vagaId; set => vagaId = value; }

        private void FormInfoVagas_Load(object sender, EventArgs e)
        {

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
    }
}
