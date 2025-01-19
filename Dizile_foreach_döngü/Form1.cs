using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizile_foreach_döngü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int[] sinavlar = { 70, 65, 85, 100, 90 };
            int toplam = 0;
           
            foreach (int x in sinavlar) 
            {
                toplam = toplam + x;
            listBox1.Items.Add(x);
            }
            label1.Text=toplam.ToString();
            int ort=toplam/sinavlar.Length;
            label2.Text=ort.ToString(); 


        }
    }
}
