﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            
            if (sayac==2)
            {
                  
                this.BackColor = Color.Red;
            }
            if (sayac == 4)
            {
            
                this.BackColor = Color.Green;
            }
            if (sayac == 6)
            {
                this.BackColor = Color.Blue;
            }
            if (sayac ==7)
            {
                sayac=0;
            }

        }
    }
}
