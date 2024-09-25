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
    public partial class FormSelectVagaInteressada : Form
    {
        private int idAluno;
        
        public int IdAluno { get => idAluno; set => idAluno = value; }

        public FormSelectVagaInteressada()
        {
            InitializeComponent();

            //maximiza a janela e habilita scroll
            WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;

            //deixa o botao de selecionar a vaga invisivel ate uma vaga ser selecionada
            btnSelectVaga.Visible = false;

            //altera o modo de selecao do dataGridView (seleciona a fileira inteira e nao diexa selecionar mais de uma fileira)
            dgvVagas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVagas.MultiSelect = false;
        }

        

        private void FormSelectVagaInteressada_Load(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;

            refreshListaVagas();

            if(dgvVagas.Rows.Count > 0)
            {
                btnSelectVaga.Visible = true;
            }
        }

        public void refreshListaVagas()
        {
            //limpa oq tiver no dgv
            dgvVagas.Rows.Clear();

            int idEmpresa = -1;
            Empresa empresa = new Empresa(((FormLogin)this.MdiParent).IdUsuario);

            idEmpresa = empresa.getCodigo_Empresa();

            Vaga vaga = new Vaga();
            MySqlDataReader reader = vaga.getVagas();

            while (reader.Read())
            {
                //row = (DataGridViewRow)dgvVagasEmpresa.Rows[0];

                if (reader["idEmpresa"].ToString().Equals(idEmpresa.ToString()))
                {
                    string cod = reader["Codigo"].ToString();
                    string nome = reader["Nome"].ToString();
                    string desc = reader["Descricao"].ToString();
                    string area = reader["Area"].ToString();
                    string requisitos = reader["Requisitos"].ToString();
                    string carga = reader["Carga_Horaria"].ToString();

                    //Console.WriteLine("\n\n" + cod + nome + desc + area + requisitos + "\n\n");

                    dgvVagas.Rows.Add(cod, nome, desc, area, requisitos, carga);
                }
            }
            DAO_Conexao.con.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectVaga_Click(object sender, EventArgs e)
        {
            bool jaInteressado = false;

            int idVaga = Int32.Parse(dgvVagas.SelectedCells[0].Value.ToString());

            Vaga vaga = new Vaga();

            MySqlDataReader reader = vaga.getAlunosInteressantes(idVaga);

            while (reader.Read())
            {
                if (Int32.Parse(reader["idAluno"].ToString()) == idAluno)
                {
                    jaInteressado = true;
                }
            }
            DAO_Conexao.con.Close();

            if (jaInteressado)
            {
                DialogResult retirar = MessageBox.Show("Esta vaga ja demonstrou interesse por esse aluno, deseja retirar esse interesse?", "Já interessado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(retirar == DialogResult.Yes)
                {
                    if(vaga.deleteInteresseVaga(idVaga, idAluno))
                    {
                        MessageBox.Show("Você retirou o interesse que tinha nesse aluno", "Interesse retirado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                if(vaga.setInteresseVaga(idVaga, idAluno))
                {
                    if(vaga.connectCheck(idVaga, idAluno))
                    {
                        MessageBox.Show("Parabéns, você acabou de criar um Connect, olhe a aba de connects no aplicativo para saber mais!", "Connect!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Interesse settado com sucesso");
                    }
                }
            }
        }

        private void FormSelectVagaInteressada_ClientSizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }
    }
}
