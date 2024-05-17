﻿using System;
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
            this.Close();
            F_Perguntas2 p2 = new F_Perguntas2();
            p2.Show();
        }

        private void F_Perguntas1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerdadeiro1_Click(object sender, EventArgs e)
        {
           Estatica.controle.ReceberP1(true);
        }

        private void btnFalso1_Click(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP1(false);
        }

        private void btnVerdadeiro2_Click(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP2(true);
        }

        private void btnFalso2_Click(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP3(false);
        }
    }
}