﻿using System;
using System.Windows.Forms;

namespace ECDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginEmpresa_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true; //Tranforma a tela em MdiContainer

            //Deixa tudo na tela invisivel:
            lblTitulo.Visible = false;
            lblEu.Visible = false;
            lblEmpresa.Visible = false;
            lblAluno.Visible = false;
            lblCadastro.Visible = false;
            lblDescricao.Visible = false;
            lblSemCadastro.Visible = false;
            pnlAluno.Visible = false;
            pnlEmpresa.Visible = false;

            FormCadastroEmpresa form = new FormCadastroEmpresa(); //Abre o FormCadastroEmpresa como MdiChild na tela
            form.MdiParent = this;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e) //Pega as imagens e joga nos pictureBoxes
        {
            picEmpresa.ImageLocation = "../../img/enterprise.png";
            picEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;

            picAluno.ImageLocation = "../../img/graduated.png";
            picAluno.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblSemCadastro_MouseHover(object sender, EventArgs e)
        {
        }

        private void lblSemCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            //Faz a mesma coisa que o btnLoginEmpresa
            this.IsMdiContainer = true;

            lblTitulo.Visible = false;
            lblEu.Visible = false;
            lblEmpresa.Visible = false;
            lblAluno.Visible = false;
            lblCadastro.Visible = false;
            lblDescricao.Visible = false;
            lblSemCadastro.Visible = false;
            pnlAluno.Visible = false;
            pnlEmpresa.Visible = false;

            FormCadastroAluno form = new FormCadastroAluno();
            form.MdiParent = this;
            form.Show();
        }
    }
}
