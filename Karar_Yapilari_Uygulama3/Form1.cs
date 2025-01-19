using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_Uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru_no = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            label8.Text = BtnB.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
            BtnA.Enabled =false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            label8.Text = BtnC.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            label8.Text = BtnD.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            label8.Text = BtnA.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            soru_no++;
            label4.Text = soru_no.ToString();
            if (soru_no == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label7.Text = "1923";
            }
            if (soru_no == 2)
            {
                richTextBox1.Text = "Hangi şehir Ege bölgesinde bulunmaz ?";
                BtnA.Text = "Gaziantep";
                BtnB.Text = "Uşak";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label7.Text = "Gaziantep";
            }
            if (soru_no == 3)
            {
                richTextBox1.Text = "Son Kuşlar hanngi yazarımıza aittir ?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Atilla İlhan";
                BtnD.Text = "Reşat Nuri";
                label7.Text = "Sait Faik";
                button5.Text = "Sonuçlar";
            }
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            button5.Enabled = false;
            
            if (soru_no == 4)
            {
                label4.Text = "3";
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }
        }
    }
}
