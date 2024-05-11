using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecladoVirtual
{
    public partial class F_Teclado : Form
    {
        Telas.F_Usuario a;
        int um = 1;
        public F_Teclado(Telas.F_Usuario texte)
        {
            InitializeComponent();
            a = texte;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {   //btnSpace
            a.tbxNome.Text+= " ";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   //btnClear
            a.tbxNome.Text = "";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "0";
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "Q";
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "W";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "E";
        }

        private void btnR_Click(object sender, EventArgs e)
        {   
            a.tbxNome.Text += "R";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "T";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "Y";
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "U";
        }

        private void btnI_Click(object sender, EventArgs e)
        {   
            a.tbxNome.Text += "I";
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "O";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "P";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "A";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "S";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "D";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "F";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "G";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "H";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "J";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "K";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "L";
        }

        private void btnÇ_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "Ç";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "Z";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "X";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "C";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "V";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "B";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "N";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "M";
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            a.tbxNome.Text += "    ";
        }
    }
}
