﻿using System;
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

        }

        public F_FeedbackGeral()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            lblNumeroVisitante.Text = Convert.ToString(Estatica.numeroDePessoas);
            lblNumeroAcertos.Text = Convert.ToString(Estatica.mediaGeral) + "%";
            lblNome.Text = Estatica.controle.usuario.getNome;
            lblIdade.Text = Convert.ToString(Estatica.controle.usuario.getIdade);
            lblMedia.Text = Convert.ToString(Estatica.controle.mensagem) + "%";
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            
            F_TelaPrincipal telaPriicipal = new F_TelaPrincipal();
            telaPriicipal.Show();
            this.Close();
        }

        private void F_FeedbackGeral_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
