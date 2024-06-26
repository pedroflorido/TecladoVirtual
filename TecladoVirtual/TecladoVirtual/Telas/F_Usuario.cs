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
using static System.Windows.Forms.DataFormats;

namespace TecladoVirtual.Telas
{
    public partial class F_Usuario : Form
    {
        F_Teclado teclado;
        public F_Usuario()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (teclado == null) 
            {
                teclado = new F_Teclado(this);
                teclado.Show();
            }

        }

        private void btnVoltarInstrucao_Click(object sender, EventArgs e)
        {
            if(teclado != null)
            {
                teclado.Close();
            }
            F_QInstrucao instrucao = new F_QInstrucao();
            instrucao.Show();
            this.Close();
        }

        private void btnAvancarInstrucao_Click(object sender, EventArgs e)
        {
            if (this.tbxNome.Text.Equals("ADMIN") && this.tbxIdade.Text.Equals("123456"))
            {
                Application.Exit();
            }
            else
            {
                try
                {
                    if (this.tbxNome.Equals("") || this.tbxIdade.Equals(""))
                    {
                        alertaPainel.Visible = true;
                    }
                    else
                    {
                        if (teclado != null)
                        {
                            teclado.Close();
                        }
                        if (this.tbxNome.Text != "" && this.tbxIdade.Text != "")
                        {
                            Estatica.controle = new Controle(this.tbxNome.Text, Convert.ToInt32(this.tbxIdade.Text));
                            this.Close();
                            F_Perguntas1 p1 = new F_Perguntas1();
                            p1.Show();

                        }
                        else
                        {
                            alertaPainel.Visible = true;
                        }
                    }
                }
                catch (Exception err)
                {
                    alertaPainel.Visible = true;
                }
            }
        }

        private void F_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnLIMPARnome_Click(object sender, EventArgs e)
        {
            tbxNome.Text = "";
        }

        private void btnLIMPARidade_Click(object sender, EventArgs e)
        {
            tbxIdade.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
