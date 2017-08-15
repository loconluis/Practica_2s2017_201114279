using System;
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
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void correrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_home s = new frm_home();
            s.MdiParent = this;
            s.Show();
        }
    }
}
