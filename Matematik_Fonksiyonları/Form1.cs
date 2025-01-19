using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Fonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1=Convert.ToDouble(textBox1.Text);
            label2.Text=Math.Abs(s1).ToString();
            label2.Text = Math.Ceiling(s1).ToString();
            label2.Text = Math.Floor(s1).ToString();
            label2.Text = Math.Pow(s1,2).ToString();
            label2.Text = Math.Sqrt(s1).ToString();
            label2.Text = Math.PI.ToString();
            label2.Text = Math.Cos(0).ToString();
        }
    }
}
