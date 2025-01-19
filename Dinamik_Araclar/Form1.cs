using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Araclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnKonum = new Point(20, 10);

            btn.Location = btnKonum;
            btn.Name = "Button1";
            btn.Text = "Tıkla";
            btn.BackColor = Color.Green;
            this.Controls.Add(btn);
            btn.Height = 50;
            btn.Width = 75;

            Label lbl = new Label();
            Point lblKonum = new Point(90, 100);

            lbl.Location = lblKonum;
            lbl.Name = "Label1";
            lbl.Text = "Mehaba";
            lbl.BackColor = Color.Yellow;
            this.Controls.Add(lbl);

            for(int i=1;i<=5;i++)
            {
                TextBox txt = new TextBox();
                Point txtKonum = new Point(350,i*50);
                txt.Location = txtKonum;
                txt.Width = 50;
                txt.Name = "TextBox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt); 
            }








        }
    }
}
