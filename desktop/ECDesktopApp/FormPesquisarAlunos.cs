using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECDesktopApp
{
    public partial class FormPesquisarAlunos : Form
    {
        public FormPesquisarAlunos()
        {
            InitializeComponent();
            //maximiza a janela e habilita o scroll
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;

            //deixa o botao de entrar no perfil do aluno invisivel ate vc selecionar um aluno que vc buscou
            btnVerAluno.Visible = false;

            //deixa imposivel editar o texto dentro da comboBox (lembra de fazer isso nos outros forms tambem)
            cbxEspecializacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOrganizar.DropDownStyle = ComboBoxStyle.DropDownList;

            //muda o modo de selecao do dgv
            dgvBuscaAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscaAlunos.MultiSelect = false;
        }

        private void FormPesquisarAlunos_Load(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //limpa o conteudo do dgv antes de realizar uma nova busca
            dgvBuscaAlunos.Rows.Clear();

            //verifica se tem pelo menos alguma coisa preenchida para poder buscar
            if(String.IsNullOrEmpty(txtNome.Text) && String.IsNullOrEmpty(txtEscola.Text) && String.IsNullOrEmpty(txtEmail.Text) && String.IsNullOrEmpty(cbxEspecializacao.Text) 
                && String.IsNullOrEmpty(txtCidade.Text)) 
            {
                MessageBox.Show("Você precisa preencher no mínimo um campo para poder realizar uma busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //pega todo os textos no campo e da trim() pra checar se esta vazio
                string nome = txtNome.Text.Trim();
                string escola = txtEscola.Text.Trim();
                string email = txtEmail.Text.Trim();
                string cidade = txtCidade.Text.Trim();
                string especialidade = cbxEspecializacao.Text.Trim();

                Aluno aluno = new Aluno(null, nome, escola, email, cidade, especialidade); //cria um obj Aluno

                MySqlDataReader reader = aluno.searchAlunos();

                //coloca as informacoes nos campos
                while (reader.Read())
                {
                    int idAluno = int.Parse(reader["idAluno"].ToString());
                    string nomeAluno = reader["Nome"].ToString();
                    //CultureInfo.CurrentCulture.DateTimeFormat = 
                    string nascimento = ManipulcaoData.formataData(reader["Nascimento"].ToString());
                    string emailAluno = reader["email"].ToString();
                    string especialidadeAluno = reader["Especialidade"].ToString();
                    string escolaAluno = reader["Escola"].ToString();
                    string cidadeAluno = reader["Cidade"].ToString();

                    dgvBuscaAlunos.Rows.Add(idAluno, nomeAluno, nascimento, emailAluno, especialidadeAluno, escolaAluno, cidadeAluno);
                }
                DAO_Conexao.con.Close();

                //limpa tudo dps
                txtNome.Text = null;
                txtEmail.Text = null;
                txtCidade.Text = null;
                txtEscola.Text = null;
                cbxEspecializacao.SelectedIndex = -1;

                //se a pesquisa nao tiver resultados, o botao de ver o perfil some
                if(dgvBuscaAlunos.Rows.Count < 1)
                {
                    btnVerAluno.Visible = false;
                }
            }
        }

        private void btnVerAluno_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            
            FormPerfilAluno form = new FormPerfilAluno();
            form.MdiParent = this.MdiParent;
            form.Tipo = 2;

            form.UserId1 = aluno.getCpfById(int.Parse(dgvBuscaAlunos.SelectedCells[0].Value.ToString()));

            form.Show();
        }

        private void FormPesquisarAlunos_SizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        private void dgvBuscaAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //deixa o botao visivel novamente assim que voce clicar na celula
            btnVerAluno.Visible = true;
        }

        private void cbxOrganizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxOrganizar.SelectedIndex == 0)
            {
                dgvBuscaAlunos.Sort(dgvBuscaAlunos.Columns[0], ListSortDirection.Descending);
            }
            else if(cbxOrganizar.SelectedIndex == 1)
            {
                dgvBuscaAlunos.Sort(dgvBuscaAlunos.Columns[0], ListSortDirection.Ascending);
            }
            else if(cbxOrganizar.SelectedIndex == 2)
            {
                dgvBuscaAlunos.Sort(dgvBuscaAlunos.Columns[1], ListSortDirection.Ascending);
            }
            else if (cbxOrganizar.SelectedIndex == 3)
            {
                dgvBuscaAlunos.Sort(dgvBuscaAlunos.Columns[1], ListSortDirection.Descending);
            }
            else if (cbxOrganizar.SelectedIndex == 4)
            {
                dgvBuscaAlunos.Sort(dgvBuscaAlunos.Columns[5], ListSortDirection.Ascending);
            }
            else if (cbxOrganizar.SelectedIndex == 5)
            {
                dgvBuscaAlunos.Sort(dgvBuscaAlunos.Columns[5], ListSortDirection.Descending);
            }
        }
    }
}
