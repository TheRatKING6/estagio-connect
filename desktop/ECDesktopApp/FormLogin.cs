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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //Estabelece a conexao com o banco de dados + arte ascii maneirinha
            if(DAO_Conexao.GetConexao("143.106.241.3", "cl202249", "cl202249", "cl*01102006"))
            {
                Console.WriteLine("\r\n   _____                      _            _       \r\n  / ____|                    | |          | |      \r\n | |     ___  _ __   ___  ___| |_ __ _  __| | ___  \r\n | |    / _ \\| '_ \\ / _ \\/ __| __/ _` |/ _` |/ _ \\ \r\n | |___| (_) | | | |  __/ (__| || (_| | (_| | (_) |\r\n  \\_____\\___/|_| |_|\\___|\\___|\\__\\__,_|\\__,_|\\___/ \r\n                                                   \r\n                                                   \r\n");
            }
            else
            {
                Console.WriteLine("\r\n  ______                      _         _____                                         __\r\n |  ____|                    | |       / ____|                                   _   / /\r\n | |__   _ __ _ __ ___     __| | ___  | |     ___  _ __   _____  ____ _  ___    (_) | | \r\n |  __| | '__| '__/ _ \\   / _` |/ _ \\ | |    / _ \\| '_ \\ / _ \\ \\/ / _` |/ _ \\       | | \r\n | |____| |  | | | (_) | | (_| |  __/ | |___| (_) | | | |  __/>  < (_| | (_) |   _  | | \r\n |______|_|  |_|  \\___/   \\__,_|\\___|  \\_____\\___/|_| |_|\\___/_/\\_\\__,_|\\___/   (_) | | \r\n                                                                                     \\_\\\r\n                                                                                        \r\n");
            }
        }

        private void FormCadastroInicio_Load(object sender, EventArgs e)
        {
            //inicia a maskedBox como formato de cnpj pq o radiobutton do cnpj é carregado já checkado
            lblPK.Text = "CNPJ:";
            msktxtPK.Mask = "00,000,000/0000-00";
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblSemCadastro_Click(object sender, EventArgs e)
        {
            //Cria um novo Form1.cs
            Form1 form = new Form1();
            form.Show();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //dependendo do radiobutton checkado, muda a mask da maskedbox
            if (rdbAluno.Checked)
            {
                lblPK.Text = "CPF:";
                msktxtPK.Mask = "000,000,000-00";
            }
            else if (rdbEmpresa.Checked)
            {
                lblPK.Text = "CNPJ:";
                msktxtPK.Mask = "00,000,000/0000-00";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int tipo = 1; //1 é o padrão (empresa)
            if (rdbAluno.Checked)
            {
                tipo = 0;
            }

            

            //pega os valores dos campos e efetua login
            string userId = msktxtPK.Text;
            userId = userId.Replace(".", "").Replace("-", "").Replace("/", "");
            string password = txtSenha.Text;

            //Console.WriteLine(userId);

            if (msktxtPK.Text.Count() == 18 || msktxtPK.Text.Count() == 14 && !(String.IsNullOrEmpty(txtSenha.Text))) //ve se voce preencheu os campos
            {
                if(DAO_Conexao.VerificaLogin(userId, password, tipo))
                {
                    //Tranforma em MdiContainer
                    this.IsMdiContainer = true;

                    //Deixa tudo invisivel
                    lblDescricao.Visible = false;
                    lblLogin.Visible = false;
                    lblTitulo.Visible = false;
                    lblSemCadastro.Visible = false;

                    gpbLogin.Visible = false;

                    //Abre o FormInicio
                    FormInicioAluno form = new FormInicioAluno();
                    form.MdiParent = this;
                    form.Show();

                    //Muda o texto na janela do FormLogin
                    this.Text = "Estágio Connect";


                    MessageBox.Show("Login efetuado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao fazer login -> Acesso negado: \nCPF/CNPJ ou senha incorreto(s)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Você precisa preencher completamente os campos de CPF/CNPJ e senha");
            }


            

            
        }
    }
}
