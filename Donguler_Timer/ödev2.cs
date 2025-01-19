using System;
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
    public partial class ödev2 : Form
    {
        public ödev2()
        {
            InitializeComponent();
        }
        int sayac = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {  
            sayac++;

            if (0 < sayac && sayac <= 30)
            {
                this.BackColor = Color.Red;
            }
            if (30 < sayac && sayac <= 40)
            {
                this.BackColor = Color.Yellow;
            }

            if (40 < sayac && sayac <= 70)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Black;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
