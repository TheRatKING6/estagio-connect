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
    public partial class FormInfoVagas : Form
    {
        private int vagaId;
        private int tipo = 1;
        private bool interessado = false;
        private string userId;

        public int VagaId { get => vagaId; set => vagaId = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public bool Interessado { get => interessado; set => interessado = value; }
        public string UserId { get => userId; set => userId = value; }

        public FormInfoVagas()
        {
            InitializeComponent();
            
            //maximiza a janela e ativa scroll
            WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;

            //desabilita tudo pra impedir a edição
            txtDescricaoVaga.Enabled = false;
            txtNomeVaga.Enabled = false;
            txtRequisitos.Enabled = false;
            txtCarga.Enabled = false;
            cbxEspecializacao.Enabled = false;
            btnInteressado.Visible = false;

            //nao pode editar os items da cbx
            cbxEspecializacao.DropDownStyle = ComboBoxStyle.DropDownList;

            //ajusta o modo de selecao do dgv
            dgvAlunosInteressados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlunosInteressados.MultiSelect = false;
        }

        private void FormInfoVagas_Load(object sender, EventArgs e)
        {
            //se for um aluno visualizando a info da vaga, some tudo e aprece so o 'demonstrar interesse'
            if(((FormLogin)this.MdiParent).TipoUsuario == 0)
            {
                label1.Visible = false;
                dgvAlunosInteressados.Visible = false;
                btnVisualizarAluno.Visible = false;
                btnInteressado.Visible = true;

                //verifica se o aluno esta interessado nessa vaga
                getInteresse();

                //dependendo se ele ja esta interessado ou nao o botao muda de cor e de texto
                if (interessado)
                {
                    btnInteressado.Text = "Retirar o interesse";
                    btnInteressado.BackColor = Color.Salmon;
                }
                else
                {
                    btnInteressado.Text = "Demonstrar Interesse";
                    btnInteressado.BackColor = Color.Transparent;
                }
            }
            else if(tipo == 1 || ((FormLogin)this.MdiParent).TipoUsuario == 7) // se for uma emprea ou adm
            {
                refreshAlunosInteressado();
            }

            if(((FormLogin)this.MdiParent).TipoUsuario != 7)
            {
                //basicamente, se o usuario for uma empresa, e estiver olhando a vaga de outra empresa, voce nao vai poder alterar nada e nem ver os alunos interessados
                //mas só se o usuario nao for adm, se for, deixa fazer tudo ai e boa
                Vaga vaga = new Vaga();

                MySqlDataReader reader = vaga.getEmpresasVagasById(vagaId);

                while (reader.Read())
                {
                    Console.WriteLine(reader["Cnpj"]);
                    Console.WriteLine(((FormLogin)this.MdiParent).IdUsuario);
                    if(((FormLogin)this.MdiParent).IdUsuario != reader["Cnpj"].ToString())
                    {
                        label1.Visible = false;
                        dgvAlunosInteressados.Visible = false;
                        btnVisualizarAluno.Visible = false;
                    }
                }
                DAO_Conexao.con.Close();

            }
            
            

            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;

            //coloca as infos da vaga
            refreshInfosVaga();

            
        }

        private void btnVisualizarAluno_Click(object sender, EventArgs e) //---------------- passar o id do aluno ----------------------
        {
            Aluno aluno = new Aluno();
            //abre o perfil do aluno
            FormPerfilAluno form = new FormPerfilAluno();
            form.MdiParent = this.MdiParent;
            int alunoId = int.Parse(dgvAlunosInteressados.SelectedRows[0].Cells[0].Value.ToString());
            form.VagaId = int.Parse(lblIdVaga.Text.Replace("#", ""));
            form.UserId1 = aluno.getCpfById(alunoId);
            form.Tipo = 1; //passa o tipo como 1 pra deixar algumas coisas invisiveis
            
            form.Show();
            this.Close();
        }

        private void btnInteressado_Click(object sender, EventArgs e) //CONTINUAR DAQUI
        {
            Vaga vaga = new Vaga();
            Aluno aluno = new Aluno(userId);

            int codigoAluno = aluno.getIdAluno();

            Console.WriteLine("\n\nCodigoAluno: " + codigoAluno + "\nidVaga: " + vagaId);

            //se o aluno nao tiver interessado, ao clicar no botao ele muda o texto e seta interessado como true
            if (!interessado)
            {
                if (vaga.insertAlunoInteressado(codigoAluno, vagaId)) //insere ele na tabela
                {
                    btnInteressado.Text = "Retirar o interesse";
                    btnInteressado.BackColor = Color.Salmon;
                    interessado = true;

                    if(vaga.connectCheck(vagaId, codigoAluno)) //verifica se a vaga ja estava interessada no aluno para criar esse connect
                    {
                        MessageBox.Show("Parabéns, você acabou de criar um Connect, olhe a aba de connects no aplicativo para saber mais!", "Connect!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao registrar seu interesse", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //se o aluno tiver interessado, ao clicar no botao ele muda o texto e seta interessado como false
            else if(vaga.deleteAlunoInteressado(codigoAluno, vagaId)) //apaga o resgistro desse aluno da tabela
            {
                btnInteressado.Text = "Demonstrar Interesse";
                btnInteressado.BackColor = Color.Transparent;
                interessado = false;
            }
            else
            {
                MessageBox.Show("Erro ao retirar seu interesse", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormInfoVagas_ClientSizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        public void refreshInfosVaga()//da load nas infos da vaga e coloca elas nos campos
        {
            //primeiro esvazia todos os campos para nao ter chance de conflito
            txtDescricaoVaga.Text = string.Empty;
            txtCarga.Text = string.Empty;
            txtNomeVaga.Text = string.Empty;
            txtRequisitos.Text = string.Empty;
            cbxEspecializacao.SelectedIndex = -1;
            lblNomeEmpresa.Text = string.Empty;
            
            //pega os dados da vaga e poe nos campos
            Vaga vaga = new Vaga();

            MySqlDataReader reader = vaga.getEmpresasVagasById(vagaId);

            while(reader.Read())
            {
                txtDescricaoVaga.Text = reader["Descricao"].ToString();
                txtCarga.Text = reader["Carga_Horaria"].ToString();
                txtNomeVaga.Text = reader[2].ToString();
                txtRequisitos.Text = reader["Requisitos"].ToString();
                cbxEspecializacao.Text = reader["Area"].ToString();
                lblNomeEmpresa.Text = reader["NomeEmpresa"].ToString();
                lblIdVaga.Text += reader["Codigo"].ToString();
            }
            DAO_Conexao.con.Close();
        }

        public void getInteresse()//verifica se o aluno ja esa interessado nessa vaga ou nao
        {
            
            Vaga vaga = new Vaga();
            Aluno aluno = new Aluno(userId);

            int codigoAluno = aluno.getIdAluno();//pega o id do aluno com base no cpf dele

            MySqlDataReader reader = aluno.getVagasInteressantes(codigoAluno);//pega todas as vagas que esse aluno esta interessado


            while(reader.Read())
            {
                if (int.Parse(reader["Codigo_Vaga"].ToString()) == vagaId) //verifica se ele esta interessado nessa ou nao
                {
                    interessado = true;
                }
            }
            DAO_Conexao.con.Close();
        }

        public void refreshAlunosInteressado()
        {
            //objeto vaga para pode invocar o metodo
            Vaga vaga = new Vaga();

            MySqlDataReader reader = vaga.getAlunosInteressados(vagaId); //pega todos os alunos interessados nessa vaga
            //e joga eles dentro do dgv 
            while(reader.Read())
            {
                int idAluno = int.Parse(reader["idAluno"].ToString());
                string nome = reader["Nome"].ToString();
                string nascimento = ManipulcaoData.formataData(reader["Nascimento"].ToString());
                //Console.WriteLine(reader["Nascimento"].ToString());
                string email = reader["Email"].ToString();
                string especializacao = reader["Especialidade"].ToString();
                string cidade = reader["Cidade"].ToString();
                string status = reader["Status"].ToString();
                string anoLetivo = reader["Ano_Letivo"].ToString();
                string escola = reader["Escola"].ToString();

                dgvAlunosInteressados.Rows.Add(idAluno, nome, nascimento, email, especializacao, cidade, status, anoLetivo, escola);
            }
            DAO_Conexao.con.Close();
        }
    }
}
