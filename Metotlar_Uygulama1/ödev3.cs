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
    public partial class ödev3 : Form
    {
        public ödev3()
        {
            InitializeComponent();
        }
        int topla(int a,int b)
        {
            return a + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(textBox1.Text),b=Convert.ToInt32(textBox2.Text);
            label1.Text=topla(a,b).ToString();  
        }
    }
}
