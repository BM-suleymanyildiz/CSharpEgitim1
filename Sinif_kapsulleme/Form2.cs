using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_kapsulleme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();
            rb2.renk = "Beyaz";
            rb2.durum = 'İ';
            rb2.hiz = 150;
            rb2.fiyat = 45000;
            rb2.motor = 194.43;

            label1.Text = rb2.renk;
            label2.Text = rb2.durum.ToString();
            label3.Text = rb2.fiyat.ToString();
            label4.Text = rb2.motor.ToString();
            label5.Text = rb2.hiz.ToString();
            this.BackColor = Color.Brown;
        }
    }
}
