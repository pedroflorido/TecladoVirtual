using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecladoVirtual.Telas
{
    public partial class F_Perguntas3 : Form
    {
        public F_Perguntas3()
        {
            InitializeComponent();
        }

        private void btnFinalizarPerguntas_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Feedback fedbacks = new F_Feedback();
            fedbacks.Show();
        }
    }
}
