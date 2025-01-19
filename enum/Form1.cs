using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum sehirler { Aydın, Adana, Ankara, Adıyaman, Ağrı, Afyon, Amasya, Antlaya, Artvin };
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka=Convert.ToInt32(textBox1.Text);
            sehirler s;
            s = (sehirler)(plaka-1);
            label1.Text = s.ToString();
        }
    }
}
