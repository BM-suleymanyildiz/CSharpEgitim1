using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar_deger_dondurmeyenler
{
    public partial class ödev1 : Form
    {
        public ödev1()
        {
            InitializeComponent();
        }

        void yazdir()
        {
            textBox1.Text = "Süleyman";
            textBox2.Text = "Yıldız";
            textBox3.Text = "Uşak";
            textBox4.Text = "21";


        }
        private void button1_Click(object sender, EventArgs e)
        {
            yazdir();
        }
    }
}
