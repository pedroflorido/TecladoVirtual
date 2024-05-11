using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecladoVirtual.Telas
{
    public partial class F_Perguntas2 : Form
    {
        public F_Perguntas2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnAvancarPerguntas2_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Perguntas3 p3 = new F_Perguntas3();
            p3.Show();
        }

        private void F_Perguntas2_Load(object sender, EventArgs e)
        {

        }
    }
}
