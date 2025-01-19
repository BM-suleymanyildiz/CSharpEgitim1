using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar_Uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kup(int a)
        {
            return a * a * a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int b=Convert.ToInt32(textBox1.Text);
            label1.Text=kup(b).ToString();

        }
    }
}
