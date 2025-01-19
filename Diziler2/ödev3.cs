using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler2
{
    public partial class ödev3 : Form
    {
        public ödev3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = {21,34,5,7,8,24,53,67,89,99 };
            for (int i=0;i<sayilar.Length;i++)
            {
                if (sayilar[i]>10 && sayilar[i]%2==0)
                {
                    listBox1.Items.Add(sayilar[i]); 
                }
            }
        }
    }
}
