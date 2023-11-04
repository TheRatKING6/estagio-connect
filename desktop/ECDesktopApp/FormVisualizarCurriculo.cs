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
    public partial class FormVisualizarCurriculo : Form
    {
        public FormVisualizarCurriculo()
        {
            InitializeComponent();
            //maximiza janela e habilita scroll
            WindowState = FormWindowState.Maximized;
            AutoScroll = true;
        }

        private void FormVisualizarCurriculo_Load(object sender, EventArgs e)
        {

        }
    }
}
