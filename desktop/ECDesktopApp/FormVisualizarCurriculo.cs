using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECDesktopApp
{
    public partial class FormVisualizarCurriculo : Form
    {
        string UserId;
        public string UserId1 { get => UserId; set => UserId = value; }

        public FormVisualizarCurriculo()
        {
            InitializeComponent();
            //maximiza janela e habilita scroll
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;
        }

        private void FormVisualizarCurriculo_Load(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Left = (this.ClientSize.Width - pictureBox.Width) / 2;
            pictureBox.Image = Image.FromFile("../../img/placeholder.jpg");

            carregarCurriculo();
        }

        public void carregarCurriculo()
        {
            Aluno aluno = new Aluno(UserId);
            int idAluno = aluno.getIdAluno();
            aluno.PegarCurriculo(idAluno, aluno);
            if (aluno.curriculo != null)
            {
                using (var curriculo = new MemoryStream(aluno.curriculo))
                {
                    if(curriculo.Length > 0)
                    {
                        pictureBox.Image = Image.FromStream(curriculo);
                    }

                }
            }

        }
    }
}
