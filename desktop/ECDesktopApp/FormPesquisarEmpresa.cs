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
    public partial class FormPesquisarEmpresa : Form
    {
        public FormPesquisarEmpresa()
        {
            InitializeComponent();
            //maximiza a janela e habilita o scroll
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;

            //deixa o botao de entrar no perfil da empresa invisivel ate vc selecionar um aluno que vc buscou
            btnVerEmpresa.Visible = false;

            cbxOrganizar.DropDownStyle = ComboBoxStyle.DropDownList;

            //ajusta a forma de selecao do dgv
            dgvBuscaEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscaEmpresa.MultiSelect = false;
        }

        private void FormPesquisarEmpresa_Load(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //limpa a dgv antes de fzr uma nova busca
            dgvBuscaEmpresa.Rows.Clear();

            if(String.IsNullOrEmpty(txtNome.Text) && String.IsNullOrEmpty(txtRamo.Text) && String.IsNullOrEmpty(txtEmail.Text) && String.IsNullOrEmpty(txtCidade.Text) 
                && ((FormLogin)this.MdiParent).TipoUsuario != 7)
            {
                MessageBox.Show("Você precisa preencher no mínimo um campo para poder realizar uma busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //pega os os argumentos e cria um objeto
                string nomeBusca = txtNome.Text.Trim();
                string ramoBusca = txtRamo.Text.Trim();
                string emailBusca = txtEmail.Text.Trim();
                string cidadeBusca = txtCidade.Text.Trim();

                Empresa empresa = new Empresa(null, nomeBusca, ramoBusca, emailBusca, cidadeBusca);

                MySqlDataReader reader = empresa.seearchEmpresas();

                while (reader.Read())
                {
                    //coloca os dados no dgv
                    int idEmpresa = int.Parse(reader["idEmpresa"].ToString());
                    string nome = reader["Nome"].ToString();
                    string email = reader["Email"].ToString();
                    string ramo = reader["Ramo"].ToString();
                    string cidade = reader["Cidade"].ToString();

                    dgvBuscaEmpresa.Rows.Add(idEmpresa, nome, email, ramo, cidade);
                }
                DAO_Conexao.con.Close();

                //limpa os campos depois
                txtNome.Text = null;
                txtRamo.Text = null;
                txtEmail.Text = null;
                txtCidade.Text = null;

                //se a pesquisa nao tiver resultados, o botao de ver o perfil da empresa desaparece
                if(dgvBuscaEmpresa.Rows.Count < 1)
                {
                    btnVerEmpresa.Visible = false;
                }
            }
        }

        private void btnVerEmpresa_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa(); //cria um obl Empresa pra poder obter o cnpj atraves do id

            FormPerfilEmpresa form = new FormPerfilEmpresa();
            form.MdiParent = this.MdiParent;
            form.Tipo = 0;

            form.Cnpj_empresa1 = empresa.getCnpjById(int.Parse(dgvBuscaEmpresa.SelectedCells[0].Value.ToString()));

            form.Show();
        }

        private void FormPesquisarEmpresa_SizeChanged(object sender, EventArgs e)
        {
            //centraliza
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
        }

        private void dgvBuscaEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //faz com que o botao fique visivel assim que clicar em uma celula do dgv
            btnVerEmpresa.Visible = true;
        }

        private void cbxOrganizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOrganizar.SelectedIndex == 0)
            {
                dgvBuscaEmpresa.Sort(dgvBuscaEmpresa.Columns[1], ListSortDirection.Ascending);
            }
            else if (cbxOrganizar.SelectedIndex == 1)
            {
                dgvBuscaEmpresa.Sort(dgvBuscaEmpresa.Columns[1], ListSortDirection.Descending);
            }
            else if (cbxOrganizar.SelectedIndex == 2)
            {
                dgvBuscaEmpresa.Sort(dgvBuscaEmpresa.Columns[4], ListSortDirection.Ascending);
            }
            else if (cbxOrganizar.SelectedIndex == 3)
            {
                dgvBuscaEmpresa.Sort(dgvBuscaEmpresa.Columns[4], ListSortDirection.Descending);
            }
            else if (cbxOrganizar.SelectedIndex == 4)
            {
                dgvBuscaEmpresa.Sort(dgvBuscaEmpresa.Columns[3], ListSortDirection.Ascending);
            }
            else if (cbxOrganizar.SelectedIndex == 5)
            {
                dgvBuscaEmpresa.Sort(dgvBuscaEmpresa.Columns[3], ListSortDirection.Descending);
            }

        }
    }
}
