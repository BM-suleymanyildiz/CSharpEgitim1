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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int toplam(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=toplam(2,3).ToString();
            label2.Text = toplam(8, 4).ToString();
            label3.Text = toplam(2, 5).ToString();
        }

        
    }
}
