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
    public partial class F_Lua : Form
    {
        public F_Lua()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnVoltarLua_Click(object sender, EventArgs e)
        {
            
            F_OqueDeseja oqueDeseja = new F_OqueDeseja();
            oqueDeseja.Show();
            this.Close();
        }

        private void F_Lua_Load(object sender, EventArgs e)
        {

        }
    }
}
