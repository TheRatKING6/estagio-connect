using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECDesktopApp
{
    public partial class FormPesquisarVagas : Form
    {
        private string userId;
        private int tipo;

        public string UserId { get => userId; set => userId = value; }
        public int Tipo { get => tipo; set => tipo = value; }

        public FormPesquisarVagas()
        {
            InitializeComponent();
            //maximiza janela e habilita scroll
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;

            //deixa tudo em DropDownList pra nao poder eitar o texto diretamente
            cbxEspecializacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOrganizar.DropDownStyle = ComboBoxStyle.DropDownList;

            //desabilita o botao de visualizar ate vc selecionar alguma coisa no dgv
            btnVerVaga.Visible = false;

            //ajusta a forma de selecao do dgv
            dgvBuscaVaga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscaVaga.MultiSelect = false;
        }

        private void FormPesquisarVagas_Load(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //limpa a dgv antes de realizar uma nova busca
            dgvBuscaVaga.Rows.Clear();

            //verifica se tem pelo menos alguma coisa preenchida para poder buscar
            if (String.IsNullOrEmpty(cbxEspecializacao.Text) && String.IsNullOrEmpty(txtCarga.Text) && String.IsNullOrEmpty(txtEmpresa.Text) && String.IsNullOrEmpty(txtNomeVaga.Text))
            {
                MessageBox.Show("Você precisa preencher no mínimo um campo para poder realizar uma busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //pega os inputs de ppesquisa
                string nomeVaga = txtNomeVaga.Text.Trim();
                string nomeEmpresa = txtEmpresa.Text.Trim();
                string cargaVaga = txtCarga.Text.Trim();
                string area = cbxEspecializacao.Text.Trim();
                
                //cria um obj vaga e pega o DataReader
                Vaga vaga = new Vaga(nomeVaga, area, cargaVaga);

                MySqlDataReader reader = vaga.searchVagas(nomeEmpresa);

                while (reader.Read())
                {
                    //le as info e coloca no dgv
                    int idVaga = int.Parse(reader["Codigo"].ToString());
                    string empresa = reader["NomeEmpresa"].ToString();
                    string nome = reader["NomeVaga"].ToString();
                    string especialidade = reader["Area"].ToString();
                    string carga = reader["Carga_Horaria"].ToString();

                    dgvBuscaVaga.Rows.Add(idVaga, empresa, nome, especialidade, carga);
                }
                DAO_Conexao.con.Close();

                //limpa os inputs
                txtCarga.Text = null;
                txtEmpresa.Text = null;
                txtNomeVaga.Text = null;
                cbxEspecializacao.SelectedIndex = -1;

            }
        }

        private void btnVerVaga_Click(object sender, EventArgs e)
        {
            FormInfoVagas form = new FormInfoVagas();
            form.MdiParent = this.MdiParent;
            form.VagaId = int.Parse(dgvBuscaVaga.SelectedCells[0].Value.ToString());
            form.UserId = userId;

            //se for uma enmpresa, passa como usuario anonimo (nao tem nenhuma permissao)
            if (userId.Replace(".", "").Replace("-", "").Replace("/", "").Length == 14)
            {
                form.Tipo = 3;
            }
            else //se for aluno passa como aluno
            {
                form.Tipo = 0;
            }
            
            form.Show();
        }

        private void FormPesquisarVagas_SizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        private void dgvBuscaVaga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //deixa o btn de ver a vaga visivel de novo
            btnVerVaga.Visible = true;
        }
    }
}
