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
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            F_OqueDeseja oqueDeseja = new F_OqueDeseja(this);
            oqueDeseja.Show();
            Timer timer = new Timer();
            timer.Interval = 120000;
            timer.Enabled = true;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer.Interval -= 1000;

            if(timer.Interval <= 0)
            {
                this.Close();
            }
        }

        
    
    }
      
    }

