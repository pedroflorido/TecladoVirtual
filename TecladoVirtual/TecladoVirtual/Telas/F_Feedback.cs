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
    public partial class F_Feedback : Form
    {
        
        public F_Feedback()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            lblMediaDeAcerto.Text = Estatica.controle.setMedia + "%";
            lblNumeroDeAcertos.Text = Estatica.controle.setMensagemDeAcertosEerros;
        }
       
        private void btnAvancarFeedbackGeral_Click(object sender, EventArgs e)
        {
           
            F_FeedbackGeral relatorio = new F_FeedbackGeral();
            relatorio.Show();
            this.Close();
        }

        private void F_Feedback_Load(object sender, EventArgs e)
        {

        }
        
    }
}
