﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDClient_
{
    public partial class RMensajes : Form
    {
        public RMensajes()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Mensajes m = new Mensajes();
            m.MdiParent = this.MdiParent;
            m.Show();
            Close();
        }
    }
}
