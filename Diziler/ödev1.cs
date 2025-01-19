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
    public partial class ödev1 : Form
    {
        public ödev1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] dizi = { 1.2, 1.5, 6.7, 4.6, 7.6 };
            label1.Text = dizi[2].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
