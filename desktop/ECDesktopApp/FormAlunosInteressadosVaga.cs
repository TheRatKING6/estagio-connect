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
    public partial class FormAlunosInteressadosVaga : Form
    {
        private string cnpj;

        public string Cnpj { get => cnpj; set => cnpj = value; }

        public FormAlunosInteressadosVaga()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            AutoScroll = true;

            //deixa os btn invisivel ate selecionar um registro do dataGridView
            btnVerAluno.Visible = false;
            btnVerVaga.Visible = false;

            //altera o modo de selecao do dgv
            dgvAlunosInteressadosVaga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlunosInteressadosVaga.MultiSelect = false;
        }

        private void btnVerAluno_Click(object sender, EventArgs e)
        {
            //obj aluno para obter o cpf dele
            Aluno aluno = new Aluno();

            FormPerfilAluno form = new FormPerfilAluno();
            form.MdiParent = this.MdiParent;
            form.Tipo = 1;

            //pega o cpf do aluno com base no id disponiblilizado no dgv e joga com UserId para o form de perfil do aluno
            string cpfAluno = aluno.getCpfById(int.Parse(dgvAlunosInteressadosVaga.SelectedCells[3].Value.ToString()));
            form.UserId1 = cpfAluno;

            //joga o id da vaga para o perfil do aluno
            form.VagaId = int.Parse(dgvAlunosInteressadosVaga.SelectedCells[0].Value.ToString());

            form.Show();
        }

        private void btnVerVaga_Click(object sender, EventArgs e)
        {
            FormInfoVagas form = new FormInfoVagas();
            form.MdiParent = this.MdiParent;
            form.VagaId = int.Parse(dgvAlunosInteressadosVaga.SelectedCells[0].Value.ToString());
            form.Show();
        }

        private void FormAlunosInteressadosVaga_Load(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;

            //coloca as infos no dgv
            refreshInteressados();

            if(dgvAlunosInteressadosVaga.Rows.Count < 1)
            {
                btnVerAluno.Visible = false;
                btnVerVaga.Visible = false;
            }
        }

        private void FormAlunosInteressadosVaga_SizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        public void refreshInteressados()
        {
            //cria objetos para usar metodos de select e de get
            Vaga vaga = new Vaga();
            Empresa empresa = new Empresa(cnpj);

            int idEmpresa = empresa.getCodigo_Empresa(); //getCodigo_Empresa tem que vir antes de chamar o reader, senao ele vai fechar a conexao

            MySqlDataReader reader = vaga.getAllAlunosInteressados();
            
            
            while(reader.Read())
            {
                if (int.Parse(reader["idEmpresa"].ToString()) == idEmpresa) //se o id da empresa for igual ao id do usuario
                {
                    //ele coloca as infos no dgv
                    int codigoVaga = int.Parse(reader["Codigo"].ToString());
                    string nomeVaga = reader["NomeVaga"].ToString();
                    string areaVaga = reader["Area"].ToString();
                    int idAluno = int.Parse(reader["idAluno"].ToString());
                    string nomeAluno = reader["NomeAluno"].ToString();
                    string especialidadeAluno = reader["Especialidade"].ToString();
                    string escola = reader["Escola"].ToString();
                    string nascimento = ManipulcaoData.formataData(reader["Nascimento"].ToString());

                    dgvAlunosInteressadosVaga.Rows.Add(codigoVaga, nomeVaga, areaVaga, idAluno, nomeAluno, especialidadeAluno, escola, nascimento);
                }
            }
            DAO_Conexao.con.Close();
        }

        private void dgvAlunosInteressadosVaga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //deixa os botoes visiveis assim que o usuario clicar em uma celula
            btnVerAluno.Visible = true;
            btnVerVaga.Visible = true;
        }
    }
}
