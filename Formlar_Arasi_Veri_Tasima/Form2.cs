﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arasi_Veri_Tasima
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       public string mesaj;
        public string kimden;
        public string kime;
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(kimden + " " + kime + " " + mesaj);
        }
    }
}
