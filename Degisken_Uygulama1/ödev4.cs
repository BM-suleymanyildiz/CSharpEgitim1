using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degisken_Uygulama1
{
    public partial class ödev4 : Form
    {
        public ödev4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urun_ad;
            double fiyat,fiyat1,fiyat2;
            urun_ad = textBox1.Text;
            fiyat = Convert.ToDouble(textBox2.Text);
            fiyat1 = (fiyat * 8 / 100) + fiyat;
            fiyat2 = (fiyat * 18) / 100 + fiyat;
            listBox1.Items.Add("Ürün Adı: " + urun_ad + " %8 KDV Fiyatı: " + fiyat1 + " %18 KDV Fiyatı: " + fiyat2);
        }
    }
}
