using TecladoVirtual.Telas;
using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Drawing.Text;


namespace TecladoVirtual
{
    public partial class F_TelaPrincipal : Form
    {
        private System.Timers.Timer timer;
        int tempoRestante = 120;
        public F_TelaPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            F_OqueDeseja oqueDeseja = new F_OqueDeseja(this);
            oqueDeseja.Show();
        }
<<<<<<< HEAD

        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer.Interval -= 1000;

            if (timer.Interval <= 0)
            {
                this.Close();
            }
        }

        private void F_TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
=======
    }
      
>>>>>>> c08307b76d401029f40449609fe3508415456918
    }

}

