﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degisken_string
{
    public partial class ödev1 : Form
    {
        public ödev1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, yas, meslek, cinsiyet;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            yas = maskedTextBox1.Text;
            cinsiyet = textBox3.Text;
            meslek = textBox4.Text;

            listBox1.Items.Add(ad+" "+soyad + " " +yas + " " +cinsiyet + " " +meslek);
        }
    }
}
