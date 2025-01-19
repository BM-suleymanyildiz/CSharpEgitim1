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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.renk = "Kırmızı";
            rb.durum = 'S';
            rb.hiz = 150;
            rb.fiyat = 45000;
            rb.motor = 194.43;
            rb.YIL = -2016;
            rb.MARKA = "Fiat";
            
            label1.Text= rb.renk; 
            label2.Text=rb.durum.ToString();
            label3.Text=rb.fiyat.ToString();
            label4.Text=rb.motor.ToString();
            label5.Text=rb.hiz.ToString();
            label6.Text=rb.YIL.ToString();
            label7.Text=rb.MARKA.ToString();
            this.BackColor=Color.Brown;
        }
    }
}
