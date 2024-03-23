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
        public string UserId { get => userId; set => userId = value; }
        public FormInicioAluno()
        {
            InitializeComponent();

            //maximiza a janela e habilita o scroll do mouse
            WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;

            //altera o modo de selecao do dataGridView (seleciona a fileira inteira e nao diexa selecionar mais de uma fileira)
            dgvVagasRecomendadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVagasRecomendadas.MultiSelect = false;
            dgvTodasVagas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTodasVagas.MultiSelect = false;
        }

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


            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
            pnlContent.Top = (this.ClientSize.Height - pnlContent.Height) / 2;

            refreshVagas(); //preenche os DGV
        }

        private void btnVerVaga_Click(object sender, EventArgs e)
        {   
            FormInfoVagas form = new FormInfoVagas();
            form.MdiParent = this.MdiParent;

            //ve qual das duas paginas esta selecionada e pega o id na dgv correspondente
            if(tabctrlInicoAluno.SelectedTab == tabPgRecommended)
            {
                int idVaga = int.Parse(dgvVagasRecomendadas.SelectedCells[0].Value.ToString());

                form.VagaId = idVaga;
            }
            else if(tabctrlInicoAluno.SelectedTab == tabPgTodas)
            {
                int idVaga = int.Parse(dgvTodasVagas.SelectedCells[0].Value.ToString());
                
                form.VagaId = idVaga;
            }
            form.UserId = userId;
            form.Tipo = 0;

            form.Show();
        }
         
        public void refreshVagas()
        {
            //limpa as vagas que ja estao no dgv
            dgvVagasRecomendadas.Rows.Clear();
            dgvTodasVagas.Rows.Clear();

            Aluno aluno = new Aluno(userId); //cria um obj aluno com o cpf dele

            string especializacao = aluno.getEspecializacaoAluno(); //pega a especializacao e cria uma string

            //cria um obj vaga para pegar todas as vagas no reader usando uma funcao com multi select
            Vaga vaga = new Vaga();
            MySqlDataReader reader = vaga.getEmpresasVagas();

            while (reader.Read())
            {
                if (reader["Area"].ToString().Equals(especializacao)) //se a area da vaga for a msm da especilizacao do aluno
                {
                    int idVaga = int.Parse(reader["Codigo"].ToString());

                    string nomeEmpresa = reader["NomeEMpresa"].ToString();
                    string nome = reader["Nome"].ToString();
                    string carga = reader["Carga_horaria"].ToString();

                    dgvVagasRecomendadas.Rows.Add(idVaga, nomeEmpresa, nome, especializacao, carga);
                }

                //todas as vagas disponiveis no BD
                int idVagaTodas = int.Parse(reader["Codigo"].ToString());

                string nomeEmpresaTodas = reader["NomeEmpresa"].ToString();
                string nomeTodas = reader["Nome"].ToString();
                string especializacaoTodas = reader["Area"].ToString();
                string cargaTodas = reader["Carga_horaria"].ToString();

                dgvTodasVagas.Rows.Add(idVagaTodas, nomeEmpresaTodas, nomeTodas, especializacaoTodas, cargaTodas);
            }
            DAO_Conexao.con.Close();
            
        }

        
    }
}
