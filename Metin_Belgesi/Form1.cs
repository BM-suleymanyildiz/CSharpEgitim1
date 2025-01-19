using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Metin_Belgesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosya_adi, dosya_yolu;
        StreamWriter sw;

        private void button2_Click(object sender, EventArgs e)
        {
            dosya_adi = textBox2.Text;
            sw=File.CreateText(dosya_yolu+"\\"+dosya_adi+".txt");
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosya_yolu= folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosya_yolu;
            }
        }
    }
}
