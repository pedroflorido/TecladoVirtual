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
            
        }
        public F_OqueDeseja()
        {
            InitializeComponent();
            
        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            this.Close();
            F_TelaPrincipal telaPrincipal = new F_TelaPrincipal();
            telaPrincipal.Show();
        }

        private void btnMuseu_Click(object sender, EventArgs e)
        {
            this.Close();
            F_TelaMuseu telaMuseu = new F_TelaMuseu();
            telaMuseu.Show();
        }

        private void btnLua_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Lua telaLua = new F_Lua();
            telaLua.Show();
        }

        private void btnQuestionario_Click(object sender, EventArgs e)
        {
            this.Close();
            F_QInstrucao intrucao = new F_QInstrucao();
            intrucao.Show();
        }


       
        
    }
}
