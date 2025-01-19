using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_switch
{
    public partial class ödev1 : Form
    {
        public ödev1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, toplam, fark, carp;
            char op;
            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            op = Convert.ToChar(textBox3.Text);

            switch (op)
            {
                case '+':
                    toplam = s1 + s2;
                    label4.Text=toplam.ToString();
                    break;
                case '-':
                    fark = s1 - s2;
                    label4.Text = fark.ToString();
                    break;
                case '*':
                    carp = s1 * s2;
                    label4.Text = carp.ToString();
                    break;
                default: label4.Text = "Hatalı operatör girişi";
                    break;

            }

        }
    }
}
