﻿using System;
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
    public partial class F_TelaMuseu : Form
    {
        public F_TelaMuseu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void lblTextoMuseu1_Click(object sender, EventArgs e)
        {

        }

        private void lblTextoMuseu2_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarMuseu_Click(object sender, EventArgs e)
        {
            
            F_OqueDeseja oqueDeseja = new F_OqueDeseja();
            oqueDeseja.Show();
            this.Close();

        }

        private void F_TelaMuseu_Load(object sender, EventArgs e)
        {

        }
    }
}
