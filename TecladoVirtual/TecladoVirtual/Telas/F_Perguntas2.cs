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
    public partial class F_Perguntas2 : Form
    {
        Boolean p3 = false;
        Boolean p4 = false;//variavel para verificacao de resposta
        public F_Perguntas2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
           
        }

        private void btnAvancarPerguntas2_Click(object sender, EventArgs e)
        {
            if(p3 && p4)
            {
                F_Perguntas3 p3 = new F_Perguntas3();
                p3.Show();
                this.Close();
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void F_Perguntas2_Load(object sender, EventArgs e)
        {

        }

        private void btnVerdadeiro3_Click(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP3(true);
            p3 = true;
            btnVerdadeiro3.BackColor = Color.Green;
            btnFalso3.BackColor = Color.DimGray;

        }

        private void btnFalso3_Click(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP3(false);
            p3 = true;
            btnVerdadeiro3.BackColor = Color.DimGray;
            btnFalso3.BackColor = Color.Red;
        }

        private void btnVerdadeiro4_Click(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP4(true);
            p4 = true;
            btnVerdadeiro4.BackColor = Color.Green;
            btnFalso4.BackColor = Color.DimGray;
        }

        private void btnFalso4_Click(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP4(false);
            p4 = true;
            btnVerdadeiro4.BackColor = Color.DimGray;
            btnFalso4.BackColor = Color.Red;
        }
    }
}
