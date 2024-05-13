using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecladoVirtual.Modelos;

namespace TecladoVirtual.Telas
{
    public partial class F_Perguntas3 : Form
    {
        Controle controle;
        public F_Perguntas3(Controle controle)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.controle = controle;
        }

        private void btnFinalizarPerguntas_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Feedback fedbacks = new F_Feedback(this.controle);
            fedbacks.Show();
        }

        private void F_Perguntas3_Load(object sender, EventArgs e)
        {

        }

        private void btnVerdadeiro5_Click(object sender, EventArgs e)
        {
            this.controle.ReceberP5(true);
        }

        private void btnFalso5_Click(object sender, EventArgs e)
        {
            this.controle.ReceberP5(false);
        }
    }
}
