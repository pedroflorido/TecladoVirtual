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
    public partial class F_Perguntas3 : Form
    {
       
        public F_Perguntas3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void btnFinalizarPerguntas_Click(object sender, EventArgs e)
        {
            Estatica.controle.executar();
            this.Close();
            F_Feedback fedbacks = new F_Feedback();
            fedbacks.Show();
            
        }

        private void F_Perguntas3_Load(object sender, EventArgs e)
        {

        }

        private void btnVerdadeiro5_Click(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP5(true);
        }

        private void btnFalso5_Click(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP5(false);
        }
    }
}