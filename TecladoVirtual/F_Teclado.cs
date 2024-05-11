using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecladoVirtual.Telas;

namespace TecladoVirtual
{
    public partial class F_Teclado : Form
    {
        F_Usuario u;
        public F_Teclado(F_Usuario u)
        {
            InitializeComponent();
            this.u = u;
            u.tbxIdade.MaxLength = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {   //btnSpace
            u.tbxNome.Text += " ";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {   //btnClear
            u.tbxNome.Text = "";
        }
        
        private void btnUm_Click(object sender, EventArgs e)
        {
            u.tbxIdade.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            u.tbxIdade.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            u.tbxIdade.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            u.tbxIdade.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            u.tbxIdade.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            u.tbxIdade.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            u.tbxIdade.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            u.tbxIdade.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            u.tbxIdade.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            u.tbxIdade.Text += "0";
        }
        private void btnQ_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "Q";
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "W";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "E";
        }

        private void btnR_Click(object sender, EventArgs e)
        {   
            u.tbxNome.Text += "R";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "T";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "Y";
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "U";
        }

        private void btnI_Click(object sender, EventArgs e)
        {   
            u.tbxNome.Text += "I";
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "O";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "P";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "A";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "S";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "D";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "F";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "G";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "H";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {   
            u.tbxNome.Text += "J";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "K";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "L";
        }

        private void btnÇ_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "Ç";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "Z";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "X";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "C";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "V";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "B";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "N";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "M";
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            u.tbxNome.Text += "    ";
        }

       
    }
}
