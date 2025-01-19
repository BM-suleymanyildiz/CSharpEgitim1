using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Uygulama2
{
    public partial class ödev1 : Form
    {
        public ödev1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int faktor=1,sayi=Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi; i++) 
            {
                faktor = i * faktor;
            }
            label2.Text = faktor.ToString();    
        }
    }
}
