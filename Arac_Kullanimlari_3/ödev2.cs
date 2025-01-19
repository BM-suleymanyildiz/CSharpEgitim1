using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari_3
{
    public partial class ödev2 : Form
    {
        public ödev2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text);
        }
    }
}
