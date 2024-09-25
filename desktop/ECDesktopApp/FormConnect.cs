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
    public partial class FormConnect : Form
    {
        int tipo = 0;
        string userId;

        public int Tipo { get => tipo; set => tipo = value; }
        public string UserId { get => userId; set => userId = value; }
        
        public FormConnect()
        {
            InitializeComponent();

            //deixa em fullScreen e habilita scroll
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;

            //concerta a forma de selecao do dgv (seleciona uma row por vez e ela inteira)
            dgvConnect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConnect.MultiSelect = false;
        }

        private void FormConnect_Load(object sender, EventArgs e)
        {
            //coloca as colunas no DataGridView (muda dependendo se for empresa ou aluno)
            if(Tipo == 0)
            {
                btnVerAluno.Visible = false;

                dgvConnect.Columns.Add("idVaga", "ID da vaga");
                dgvConnect.Columns.Add("nomeVaga", "Nome");
                dgvConnect.Columns.Add("empresaVaga", "Empresa");
                dgvConnect.Columns.Add("epecializacaoVaga", "Área de Especialização");
                dgvConnect.Columns.Add("cargaVaga", "Carga Horária");
                dgvConnect.Columns.Add("emailEmpresa", "Email de Contato");
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
                dgvConnect.Columns.Add("emailAluno", "Email de Contato");
            }

            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;

            //coloca todos os connects no dgv
            refreshConnects();
        }

        private void btnVerVaga_Click(object sender, EventArgs e)
        {
            //se tiver algum connect em primeiro lugar
            if(dgvConnect.Rows.Count > 0)
            {
                //passa o id da vaga e o id do usuário pro formInfoVagas e dps mostra
                FormInfoVagas form = new FormInfoVagas();
                form.MdiParent = this.MdiParent;
                form.VagaId = int.Parse(dgvConnect.SelectedCells[0].Value.ToString());
                form.UserId = userId;

                if(tipo == 0)
                {
                    form.Tipo = 0;
                    //form.Interessado = true;
                }

                form.Show();
            }
            
        }

        private void btnVerAluno_Click(object sender, EventArgs e)
        {
            //apenas se houver algum connect em primeiro
            if(dgvConnect.Rows.Count > 0)
            {
                //pega o CPF do aluno de acordo com o ID mostrado na tabela
                Aluno aluno = new Aluno();
                int idAluno = int.Parse(dgvConnect.SelectedCells[3].Value.ToString());
                string cpfAluno = aluno.getCpfById(idAluno);

                //cria um FormPerfilAluno e coloca todas as infos necessarias
                FormPerfilAluno form = new FormPerfilAluno();
                form.MdiParent = this.MdiParent;
                form.Tipo = 1;
                form.VagaId = int.Parse(dgvConnect.SelectedCells[0].Value.ToString());
                form.UserId1 = cpfAluno;

                //form.Interesse = true;
                form.Show();
            }
            
        }

        private void FormConnect_SizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        public void refreshConnects()
        {
            //cria o obj vaga e pega todos os connects
            Vaga vaga = new Vaga();
            MySqlDataReader reader = vaga.getConnects();
            
            while(reader.Read())
            {
                if(tipo == 0 && reader["CPF"].ToString().Equals(userId)) //se for um aluno e o cpf for o msm
                {
                    
                    int idVaga = int.Parse(reader["Codigo"].ToString());
                    string nomeVaga = reader["NomeVaga"].ToString();
                    string empresa = reader["NomeEmpresa"].ToString();
                    string area = reader["Area"].ToString();
                    string carga = reader["Carga_Horaria"].ToString();
                    string emailEmpresa = reader["EmailEmpresa"].ToString();

                    dgvConnect.Rows.Add(idVaga, nomeVaga, empresa, area, carga, emailEmpresa); //coloca tudo no dgv
                    
                }
                else if(tipo == 1 && reader["CNPJ"].ToString().Equals(userId)) //se for uma empresa e o cnpj for o msm
                {
                    
                    int idVaga = int.Parse(reader["Codigo"].ToString());
                    string nomeVaga = reader["NomeVaga"].ToString();
                    string area = reader["Area"].ToString();
                    int idAluno = int.Parse(reader["idAluno"].ToString());
                    string nomeAluno = reader["NomeAluno"].ToString();
                    string especializacaoAluno = reader["Especialidade"].ToString();
                    string escola = reader["Escola"].ToString();
                    string nascimento = ManipulcaoData.formataData(reader["Nascimento"].ToString());
                    string emailAluno = reader["EmailAluno"].ToString();

                    dgvConnect.Rows.Add(idVaga, nomeVaga, area, idAluno, nomeAluno, especializacaoAluno, escola, nascimento, emailAluno); //coloca tudo no dgv
                }
            }
            DAO_Conexao.con.Close();
        }
    }
}
