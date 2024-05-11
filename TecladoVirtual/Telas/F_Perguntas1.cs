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
    public partial class F_Perguntas1 : Form
    {
        public F_Perguntas1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAvancarPerguntas1_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Perguntas2 p2 = new F_Perguntas2();
            p2.Show();
        }
    }
}
