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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormCadastroInicio_Load(object sender, EventArgs e)
        {
            //inicia a maskedBox como formato de cnpj pq o radiobutton do cnpj é carregado já checkado
            lblPK.Text = "CNPJ:";
            msktxtPK.Mask = "00,000,000/0000-00";
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblSemCadastro_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //dependendo do radiobutton checkado, muda a mask da maskedbox
            if (rdbAluno.Checked)
            {
                lblPK.Text = "CPF:";
                msktxtPK.Mask = "000,000,000-00";
            }
            else if (rdbEmpresa.Checked)
            {
                lblPK.Text = "CNPJ:";
                msktxtPK.Mask = "00,000,000/0000-00";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
