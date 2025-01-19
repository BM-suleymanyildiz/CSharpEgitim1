using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degisken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasa = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, tutar;
            misir=Convert.ToInt32(textBox1.Text);
            su=Convert.ToInt32(textBox2.Text);
            cay=Convert.ToInt32(textBox3.Text);
            bilet=Convert.ToInt32(textBox4.Text);

            tutar = misir * 4 + su + cay * 2 + bilet * 8;
            label10.Text=tutar.ToString()+" TL";
            kasa = kasa + tutar;
            label13.Text=kasa.ToString() + " TL";   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label10.Text = "00 TL";
            textBox1.Focus();
        }
    }
}
