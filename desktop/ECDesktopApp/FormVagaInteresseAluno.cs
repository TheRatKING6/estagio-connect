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
    public partial class FormVagaInteresseAluno : Form
    {
        private string userId;

        public string UserId { get => userId; set => userId = value; }

        public FormVagaInteresseAluno()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;

            //muda o mod de selecao dos DGVs
            dgvSeuInteresse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSeuInteresse.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void FormVagaInteresseAluno_Load(object sender, EventArgs e)
        {
            //centraliza
            lblVagas.Left = (this.ClientSize.Width - lblVagas.Width) / 2;
            tabCtrlVagasInteressadas.Left = (this.ClientSize.Width - tabCtrlVagasInteressadas.Width) / 2;

            //carrega as infos nos dgv's
            refreshVagas();

            if(dgvSeuInteresse.Rows.Count < 1)
            {
                btnVerVagaSeuInteresse.Visible = false;
            }
            if(dataGridView1.Rows.Count < 1)
            {
                btnVerVagaInteresseVoce.Visible = false;
            }
        }

        private void btnVerVagaSeuInteresse_Click(object sender, EventArgs e)
        {
            //abre as informacoes da vaga e etc
            FormInfoVagas form = new FormInfoVagas();
            form.MdiParent = this.MdiParent;
            form.Tipo = 0;
            form.UserId = userId;
            form.VagaId = int.Parse(dgvSeuInteresse.SelectedCells[0].Value.ToString());
            //form.Interessado = true;
            form.Show();
        }

        private void btnVerVagaInteresseVoce_Click(object sender, EventArgs e)
        {
            //abre as informacoes da vaga e etc
            FormInfoVagas form = new FormInfoVagas();
            form.MdiParent = this.MdiParent;
            form.Tipo = 0;
            form.UserId = userId;
            form.VagaId = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            form.Tipo = 0;
            form.Show();
        }

        private void FormVagaInteresseAluno_SizeChanged(object sender, EventArgs e)
        {
            //centraliza
            lblVagas.Left = (this.ClientSize.Width - lblVagas.Width) / 2;
            tabCtrlVagasInteressadas.Left = (this.ClientSize.Width - tabCtrlVagasInteressadas.Width) / 2;
        }

        public void refreshVagas()
        {
            //obj aluno usado para obter o id do usuario
            Aluno aluno = new Aluno(userId);
            int idAluno = aluno.getIdAluno();

            //pega as infos das vagas que o aluno esta interessado e das que estao interessadas nele e joga nos dgv's
            MySqlDataReader reader = aluno.getInfosVagasInteressantes(idAluno);

            while(reader.Read())
            {
                int idVaga = int.Parse(reader["Codigo"].ToString());
                string nomeVaga = reader["NomeVaga"].ToString();
                string nomeEmpresa = reader["NomeEmpresa"].ToString();
                string area = reader["Area"].ToString();
                string carga = reader["Carga_Horaria"].ToString();

                dgvSeuInteresse.Rows.Add(idVaga, nomeVaga, nomeEmpresa, area, carga);
            }
            DAO_Conexao.con.Close();

            reader = aluno.getInfosVagasInteressadas(idAluno);

            while(reader.Read())
            {
                int idVaga = int.Parse(reader["Codigo"].ToString());
                string nomeVaga = reader["NomeVaga"].ToString();
                string nomeEmpresa = reader["NomeEmpresa"].ToString();
                string area = reader["Area"].ToString();
                string carga = reader["Carga_Horaria"].ToString();

                dataGridView1.Rows.Add(idVaga, nomeVaga, nomeEmpresa, area, carga);
            }
            DAO_Conexao.con.Close();
        }
    }
}
