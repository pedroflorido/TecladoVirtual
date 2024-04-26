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
        F_TelaPrincipal a;
        public F_Teclado(F_TelaPrincipal texte)
        {
            InitializeComponent();
            a = texte;

        }

        private void button1_Click(object sender, EventArgs e)
        {   //btnSpace
            a.lblTextoPrincipal.Text += " ";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   //btnClear
            a.lblTextoPrincipal.Text = "";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "0";
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "Q";
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "W";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "E";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "R";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "T";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "Y";
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "U";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "I";
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "O";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "P";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "A";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "S";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "D";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "F";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "G";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "H";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "J";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "K";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "L";
        }

        private void btnÇ_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "Ç";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "Z";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "X";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "C";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "V";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "B";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "N";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "M";
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            a.lblTextoPrincipal.Text += "    ";
        }
    }
}
