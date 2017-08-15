using Newtonsoft.Json;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
        }

        private void btnloadJSON_Click(object sender, EventArgs e)
        {

            string json = @"{
                            'nodos': {
                                'local': '192.168.0.1',
                                'mascara': '255.255.255.0',
                                'nodo': [
                                    {
                                        'ip': '192.168.0.8',
                                        'mascara': '255.255.255.0'
                                    },
                                    {
                                        'ip': '192.168.0.23',
                                        'mascara': '255.255.255.0'
                                    },
                                    {
                                        'ip': '192.168.0.87',
                                        'mascara': '255.255.255.0'
                                    }
                                ]
                            }
                        }";


            RootObject nodos = JsonConvert.DeserializeObject<RootObject>(json);
            
            


        }
    }
}
