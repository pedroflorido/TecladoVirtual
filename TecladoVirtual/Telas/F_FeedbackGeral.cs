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

namespace TecladoVirtual.Telas
{
    public partial class F_FeedbackGeral : Form
    {
        private Form f1;
        public F_FeedbackGeral(F_TelaPrincipal f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        public F_FeedbackGeral()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            F_TelaPrincipal telaPriicipal = new F_TelaPrincipal();
            telaPriicipal.Show();
        }

        private void F_FeedbackGeral_Load(object sender, EventArgs e)
        {

        }
    }
}
