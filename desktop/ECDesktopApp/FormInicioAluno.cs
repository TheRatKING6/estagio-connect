using MySql.Data.MySqlClient;
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
    public partial class FormInicioAluno : Form
    {
        //cria uma propriedade userId que permite identificar o aluno que acabou de logar pelo cpf dele
        private string userId;
        public FormInicioAluno()
        {
            InitializeComponent();

            //maximiza a janela e habilita o scroll do mouse
            WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;
        }

        public string UserId { get => userId; set => userId = value; }

        private void FormInicioAluno_Load(object sender, EventArgs e)
        {
            //pega o nome da pessoa e joga na lblWelcome
            Aluno user = new Aluno(userId);
            MySqlDataReader reader = user.getInfoAluno();
            string nome = "erro (?)";

            while (reader.Read())
            {
                nome = reader["Nome"].ToString().Trim(); //se alguem colocar um so nome no campo 'nome', provavelmente vai dar erro
            }
            DAO_Conexao.con.Close();

            nome = nome.Substring(0, nome.IndexOf(" "));

            lblWelcome.Text += nome;
        }
    }
}
