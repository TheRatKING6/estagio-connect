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
    public partial class FormConnect : Form
    {
        int tipo = 0;
        public FormConnect()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            AutoScroll = true;


        }

        public int Tipo { get => tipo; set => tipo = value; }

        private void FormConnect_Load(object sender, EventArgs e)
        {
            if(Tipo == 0)
            {
                btnVerAluno.Visible = false;

                dgvConnect.Columns.Add("idVaga", "ID da vaga");
                dgvConnect.Columns.Add("nomeVaga", "Nome");
                dgvConnect.Columns.Add("empresaVaga", "Empresa");
                dgvConnect.Columns.Add("epecializacaoVaga", "Área de Especialização");
                dgvConnect.Columns.Add("cargaVaga", "Carga Horária");
            }
            else if(tipo == 1)
            {
                dgvConnect.Columns.Add("idVaga", "ID da vaga");
                dgvConnect.Columns.Add("nomeVaga", "Nome");
                dgvConnect.Columns.Add("epecializacaoVaga", "Área de Especialização");
                dgvConnect.Columns.Add("idAluno", "ID do Aluno");
                dgvConnect.Columns.Add("nomeAluno", "Nome do Aluno");
                dgvConnect.Columns.Add("especializacaoAluno", "Área de Especialização do Aluno");
                dgvConnect.Columns.Add("escolaAluno", "Escola do Aluno");
                dgvConnect.Columns.Add("nascimentoAluno", "Data de Nascimento");
            }
        }

        private void btnVerVaga_Click(object sender, EventArgs e)
        {
            FormInfoVagas form = new FormInfoVagas();
            form.MdiParent = this.MdiParent;

            if(tipo == 0)
            {
                form.Tipo = 0;
                form.Interessado = true;
            }

            form.Show();
        }

        private void btnVerAluno_Click(object sender, EventArgs e)
        {
            FormPerfilAluno form = new FormPerfilAluno();
            form.MdiParent = this.MdiParent;
            form.Tipo = 1;
            form.Show();
        }
    }
}
