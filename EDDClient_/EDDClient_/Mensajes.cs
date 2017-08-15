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
    public partial class Mensajes : Form
    {
        public Mensajes()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            Envio s = new Envio();
            s.MdiParent = this.MdiParent;
            s.Show();
            this.Close();
        }

        private void btnQmess_Click(object sender, EventArgs e)
        {
            ColaMensajes c = new ColaMensajes();
            c.MdiParent = this.MdiParent;
            c.Show();
            this.Close();
        }

        private void btnAnswers_Click(object sender, EventArgs e)
        {
            RMensajes r = new RMensajes();
            r.MdiParent = this.MdiParent;
            r.Show();
            this.Close();
        }
    }
}
