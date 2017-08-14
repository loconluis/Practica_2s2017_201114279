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
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void btnmessages_Click(object sender, EventArgs e)
        {
            Mensajes ms = new Mensajes();
            ms.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            Reportes rp = new Reportes();
        }
    }
}
