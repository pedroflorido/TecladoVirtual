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
    public partial class F_Lua2 : Form
    {
        public F_Lua2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnVoltarLua1_Click(object sender, EventArgs e)
        {
            F_Lua f_lua = new F_Lua();
            f_lua.Show();
            this.Close();
        }
    }
}
