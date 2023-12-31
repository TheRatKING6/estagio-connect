﻿using System;
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
    public partial class FormVagaInteresseAluno : Form
    {
        public FormVagaInteresseAluno()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;
        }

        private void FormVagaInteresseAluno_Load(object sender, EventArgs e)
        {
            //centraliza
            lblVagas.Left = (this.ClientSize.Width - lblVagas.Width) / 2;
            tabCtrlVagasInteressadas.Left = (this.ClientSize.Width - tabCtrlVagasInteressadas.Width) / 2;
        }

        private void btnVerVagaSeuInteresse_Click(object sender, EventArgs e)
        {
            //abre as informacoes da vaga e etc
            FormInfoVagas form = new FormInfoVagas();
            form.MdiParent = this.MdiParent;
            form.Tipo = 0;
            form.Interessado = true;
            form.Show();
        }

        private void btnVerVagaInteresseVoce_Click(object sender, EventArgs e)
        {
            //abre as informacoes da vaga e etc
            FormInfoVagas form = new FormInfoVagas();
            form.MdiParent = this.MdiParent;
            form.Tipo = 0;
            form.Show();
        }

        private void FormVagaInteresseAluno_SizeChanged(object sender, EventArgs e)
        {
            //centraliza
            lblVagas.Left = (this.ClientSize.Width - lblVagas.Width) / 2;
            tabCtrlVagasInteressadas.Left = (this.ClientSize.Width - tabCtrlVagasInteressadas.Width) / 2;
        }
    }
}
