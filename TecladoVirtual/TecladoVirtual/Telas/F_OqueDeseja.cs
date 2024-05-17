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

    public partial class F_OqueDeseja : Form
    {
        private Form f1;
        public F_OqueDeseja(F_TelaPrincipal f1)
        {
            InitializeComponent();
            f1 = f1;

            this.WindowState = FormWindowState.Maximized;

        }
        public F_OqueDeseja()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            
            F_TelaPrincipal telaPrincipal = new F_TelaPrincipal();
            telaPrincipal.Show();
            this.Close();
        }

        private void btnMuseu_Click(object sender, EventArgs e)
        {
            
            F_TelaMuseu telaMuseu = new F_TelaMuseu();
            telaMuseu.Show();
            this.Close();
        }

        private void btnLua_Click(object sender, EventArgs e)
        {
            
            F_Lua telaLua = new F_Lua();
            telaLua.Show();
            this.Close();
        }

        private void btnQuestionario_Click(object sender, EventArgs e)
        {
           
            F_QInstrucao intrucao = new F_QInstrucao();
            intrucao.Show();
            this.Close();
        }

        private void F_OqueDeseja_Load(object sender, EventArgs e)
        {

        }
    }
}
