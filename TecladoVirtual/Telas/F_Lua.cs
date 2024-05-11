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
        }

        private void btnVoltarLua_Click(object sender, EventArgs e)
        {
            this.Close();
            F_OqueDeseja oqueDeseja = new F_OqueDeseja();
            oqueDeseja.Show();
        }
    }
}
