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
using TecladoVirtual.Modelos;

namespace TecladoVirtual.Telas
{
    public partial class F_FeedbackGeral : Form
    {
        private Controle controle;
        public F_FeedbackGeral(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            lblNumeroVisitante.Text = Convert.ToString(controle.pessoa);
            lblNumeroAcertos.Text = Convert.ToString(controle.media) + "%";
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
