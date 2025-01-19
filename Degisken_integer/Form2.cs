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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi,sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi * sayi;
            label2.Text = "Girilen sayının küpü: "+sonuc.ToString();
        }
    }
}
