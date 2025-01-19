using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Okul_Proje
{
    public partial class FrmGirisPaneli : Form
    {
        public FrmGirisPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            


            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Tbl_Ogrenciler WHERE Ogrid= @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);


            int count = (int)komut.ExecuteScalar();

            if (count > 0)
            {
                FrmOgrenciNotlar fr = new FrmOgrenciNotlar();
                fr.numara = textBox1.Text;
                fr.Show();
                this.Hide();
                bgl.baglanti().Close();
            }
            else
            {

                MessageBox.Show("Hatalı Şifre Girişi");
                bgl.baglanti().Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Tbl_Ogretmenler WHERE OgrtSifre = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);


            int count = (int)komut.ExecuteScalar();

            if (count > 0)
            {  
               
                FrmOgretmen frogrt = new FrmOgretmen();
                frogrt.numara = textBox1.Text;

                frogrt.Show();
                this.Hide();
                bgl.baglanti().Close();
            }
            else
            {

                MessageBox.Show("Hatalı Şifre Girişi");
                bgl.baglanti().Close();
            }
        }


        private void FrmGirisPaneli_Load(object sender, EventArgs e)
        {

        }
    }


}


