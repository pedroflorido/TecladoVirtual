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
    
    public partial class F_Perguntas3 : Form
    {
        Boolean p5 = false; //variavel para verificacao de resposta
        int verificaSeRespondeu = 0;
       
        public F_Perguntas3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void btnFinalizarPerguntas_Click(object sender, EventArgs e)
        {
            if (p5)
            {
                    Estatica.controle.executar();

                    F_Feedback fedbacks = new F_Feedback();
                    fedbacks.Show();
                    this.Close();
            }
            else
            {
                panel1.Visible = true;
            }

        }

        private void F_Perguntas3_Load(object sender, EventArgs e)
        {

        }

        private void btnVerdadeiro5_Click(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP5(true);
            p5 = true;
            btnVerdadeiro5.BackColor = Color.Green;
            btnFalso5.BackColor = Color.DimGray;
        }

        private void btnFalso5_Click(object sender, EventArgs e)
        {
            Estatica.controle.ReceberP5(false);
            p5 = true;
            btnVerdadeiro5.BackColor = Color.DimGray;
            btnFalso5.BackColor = Color.Red;
        }
    }
}
