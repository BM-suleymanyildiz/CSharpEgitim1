using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_Uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitap_adet;
            double fiyat, toplam;

            kitap_adet = Convert.ToInt32(textBox1.Text);

            if (kitap_adet > 0 && kitap_adet <= 20)
            {
                fiyat = kitap_adet * 8;

                toplam = fiyat - (fiyat * 20 / 100);
                label3.Text = toplam.ToString();

            }

            if (kitap_adet <= 40 && kitap_adet >= 21)
            {
                fiyat = kitap_adet * 8;

                toplam = fiyat - (fiyat * 40 / 100);
                label3.Text = toplam.ToString();
            }
            if (kitap_adet >= 41)
            {
                fiyat = kitap_adet * 8;

                toplam = fiyat - (fiyat * 50 / 100);
                label3.Text = toplam.ToString();
            }
            else
            {
                label3.Text = "Geçersiz değer girişi";
            }
        }
        // 0-20 ==> %20
        // 21-40 ==> %40
        // 41+ ==> %50
        // Kitap=8 tl
    }
}
