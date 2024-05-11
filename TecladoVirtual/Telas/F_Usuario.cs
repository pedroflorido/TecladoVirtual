using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TecladoVirtual.Telas
{
    public partial class F_Usuario : Form
    {
        public F_Usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            F_Teclado teclado = new F_Teclado(this);
            teclado.Show();
            
        }

        private void btnVoltarInstrucao_Click(object sender, EventArgs e)
        {
            this.Close();
            F_QInstrucao instrucao = new F_QInstrucao();
            instrucao.Show();
        }

        private void btnAvancarInstrucao_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Perguntas1 p1 = new F_Perguntas1();
            p1.Show();
        }
    }
}
