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
    public partial class FormAlunosInteressadosVaga : Form
    {
        public FormAlunosInteressadosVaga()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            AutoScroll = true;

            //deixa os btn invisivel ate selecionar um registro do dataGridView
            //btnVerAluno.Visible = false;
            //btnVerVaga.Visible = false;
        }

        private void btnVerAluno_Click(object sender, EventArgs e)
        {
            FormPerfilAluno form = new FormPerfilAluno();
            form.MdiParent = this.MdiParent;
            form.Tipo = 1;
            form.Show();
        }

        private void btnVerVaga_Click(object sender, EventArgs e)
        {
            FormInfoVagas form = new FormInfoVagas();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void FormAlunosInteressadosVaga_Load(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        private void FormAlunosInteressadosVaga_SizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }
    }
}
