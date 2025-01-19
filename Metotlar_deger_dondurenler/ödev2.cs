using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar_deger_dondurenler
{
    public partial class ödev2 : Form
    {
        public ödev2()
        {
            InitializeComponent();
        }
        int carpim(int a,int b, int c)
        {
            return a * b * c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=carpim(2,3,4).ToString();
        }
    }
}
