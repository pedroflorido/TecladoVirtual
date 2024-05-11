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
    public partial class F_QInstrucao : Form
    {

        public F_QInstrucao()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnAvancarInstrucao_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Usuario usuario = new F_Usuario();
            usuario.Show();

        }

        private void btnVoltarInstrucao_Click(object sender, EventArgs e)
        {
            this.Close();
            F_OqueDeseja oqueDeseja = new F_OqueDeseja();
            oqueDeseja.Show();
        }

        private void lblTextoInstrucao_Click(object sender, EventArgs e)
        {

        }

        private void F_QInstrucao_Load(object sender, EventArgs e)
        {

        }
    }
}
