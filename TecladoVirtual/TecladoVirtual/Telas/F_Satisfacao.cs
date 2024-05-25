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
    public partial class F_Satisfacao : Form
    {
        public F_Satisfacao()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int cont = 0; cont < 5; cont++)
            {
                if (Estatica.controle.getSatifacao[cont])
                {

                    F_RelatoriaSatisfacao relatorio = new F_RelatoriaSatisfacao();
                    relatorio.Show();
                    this.Close();
                    break;
                }
                else
                {
                    panel1.Visible = true;
                }
            }
        }

        private void btnMUITORUIM_Click(object sender, EventArgs e)
        {
            Estatica.controle.setSatisfacao(true, false, false, false, false);
            btnMUITORUIM.BackColor = Color.Red;
            btnMUITOBOM.BackColor = Color.Transparent;
            btnRUIM.BackColor = Color.Transparent;
            btnBOM.BackColor = Color.Transparent;
            btnREGULAR.BackColor = Color.Transparent;
        }

        private void btnRUIM_Click(object sender, EventArgs e)
        {
            Estatica.controle.setSatisfacao(false, true, false, false, false);
            btnRUIM.BackColor = Color.OrangeRed;
            btnMUITORUIM.BackColor = Color.Transparent;
            btnMUITOBOM.BackColor = Color.Transparent;
            btnBOM.BackColor = Color.Transparent;
            btnREGULAR.BackColor = Color.Transparent;
        }

        private void btnREGULAR_Click(object sender, EventArgs e)
        {
            Estatica.controle.setSatisfacao(false, false, true, false, false);
            btnREGULAR.BackColor = Color.Yellow;
            btnMUITORUIM.BackColor = Color.Transparent;
            btnMUITOBOM.BackColor = Color.Transparent;
            btnRUIM.BackColor = Color.Transparent;
            btnBOM.BackColor = Color.Transparent;
        }

        private void btnBOM_Click(object sender, EventArgs e)
        {
            Estatica.controle.setSatisfacao(false, false, false, true, false);
            btnBOM.BackColor = Color.YellowGreen;
            btnMUITORUIM.BackColor = Color.Transparent;
            btnMUITOBOM.BackColor = Color.Transparent;
            btnRUIM.BackColor = Color.Transparent;
            btnREGULAR.BackColor = Color.Transparent;
        }

        private void btnMUITOBOM_Click(object sender, EventArgs e)
        {
            Estatica.controle.setSatisfacao(false, false, false, false, true);
            btnMUITOBOM.BackColor = Color.Green;
            btnMUITORUIM.BackColor = Color.Transparent;
            btnRUIM.BackColor = Color.Transparent;
            btnBOM.BackColor = Color.Transparent;
            btnREGULAR.BackColor = Color.Transparent;
        }
    }
}
