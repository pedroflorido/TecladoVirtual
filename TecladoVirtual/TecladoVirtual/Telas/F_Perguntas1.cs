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
    public partial class F_Perguntas1 : Form
    {

           Boolean p1 = false;
           Boolean p2 = false;//variavel para verificacao de resposta
        public F_Perguntas1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAvancarPerguntas1_Click(object sender, EventArgs e)
        {
           if(p1 && p2)
            {
                F_Perguntas2 p2 = new F_Perguntas2();
                p2.Show();
                this.Close();
            }
            else
            {
                panel1.Visible = true;
            }
                
            
        }

        private void F_Perguntas1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerdadeiro1_Click(object sender, EventArgs e)
        {
            p1 = true;
            Estatica.controle.ReceberP1(true);
            btnVerdadeiro1.BackColor = Color.Green;
            btnFalso1.BackColor = Color.DimGray;
        }

        private void btnFalso1_Click(object sender, EventArgs e)
        {
            p1 = true;
            Estatica.controle.ReceberP1(false);
            btnFalso1.BackColor = Color.Red;
            btnVerdadeiro1.BackColor = Color.DimGray;
        }

        private void btnVerdadeiro2_Click(object sender, EventArgs e)
        {
            p2 = true;
            Estatica.controle.ReceberP2(true);
            btnVerdadeiro2.BackColor = Color.Green;
            btnFalso2.BackColor = Color.DimGray;
        }

        private void btnFalso2_Click(object sender, EventArgs e)
        {
            p2 = true;
            Estatica.controle.ReceberP3(false);
            btnFalso2.BackColor = Color.Red;
            btnVerdadeiro2.BackColor = Color.DimGray;
        }

        private void btnVerdadeiro1_CheckStateChanged(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP1(true);
        }

        private void btnFalso1_CheckStateChanged(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP1(false);
        }

        private void btnVerdadeiro2_CheckStateChanged(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP2(true);
        }
    }
}
