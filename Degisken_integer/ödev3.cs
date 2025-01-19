using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEgisken_integer
{
    public partial class ödev3 : Form
    {
        public ödev3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not1, not2, not3, ortalama;
            not1 = 12;
            not2 = 27;
            not3 = 49;
            ortalama = (not1 + not2 + not3) / 3;
            label1.Text=ortalama.ToString();
        }
    }
}
