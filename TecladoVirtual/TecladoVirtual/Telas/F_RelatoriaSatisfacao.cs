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
using Timer = System.Windows.Forms.Timer;

namespace TecladoVirtual.Telas
{
    public partial class F_RelatoriaSatisfacao : Form
    {
        int tempo = 15;
        private Timer timer;
        public F_RelatoriaSatisfacao()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MediaDeStisfacao mediaDeStisfacao = new MediaDeStisfacao();
            lblRelatorio.Text = Estatica.MediaDassatisfacaoMensagem;


            //temporizador para voltar a tela inicial
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Temporisador;
            timer.Start();
        }
        private void Temporisador(Object semder, EventArgs e)
        {

            if (tempo > 0)
            {
                tempo--;
            }
            else
            {
                timer.Stop();
                F_TelaPrincipal telaPriicipal = new F_TelaPrincipal();
                telaPriicipal.Show();
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            F_TelaPrincipal f1 = new F_TelaPrincipal();
            f1.Show();
            this.Close();
        }
    }
}
