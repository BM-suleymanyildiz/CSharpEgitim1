using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class ödev2 : Form
    {
        public ödev2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] karakterler = { 'a', 'v', 'b', 't', 'e' };
            label1.Text=karakterler[0].ToString();
        }
    }
}
