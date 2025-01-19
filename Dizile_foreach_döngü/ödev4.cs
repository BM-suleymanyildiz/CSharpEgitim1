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
    public partial class ödev4 : Form
    {
        public ödev4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = {8,12,45,78,90,34,56,87,91,23 };
            int sayac = 0,toplam=0;
            foreach (int i in sayilar) 
            {
                if( i%4==0)
                {
                    sayac++;
                    listBox1.Items.Add(i);
                    toplam += i;
                }
            }
            label1.Text=sayac.ToString();
            label2.Text=toplam.ToString();
            
        }
    }
}
