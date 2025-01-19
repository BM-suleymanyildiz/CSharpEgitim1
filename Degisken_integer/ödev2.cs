using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEgisken_integer
{
    public partial class ödev2 : Form
    {
        public ödev2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa_kenar, uzun_kenar, alan, cevre;
            kisa_kenar= 10;
            uzun_kenar=20;
            alan = uzun_kenar * kisa_kenar;
            cevre=uzun_kenar*2+kisa_kenar*2;
            label1.Text = "Alan: " + alan + " Çevre: " + cevre;
        }
    }
}
