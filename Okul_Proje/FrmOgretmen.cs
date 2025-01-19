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
namespace Okul_Proje
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string numara;

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulup frk = new FrmKulup();
            frk.numara = label2.Text;
            frk.Show();
            this.Hide();
        }
        private void BtnDersler_Click(object sender, EventArgs e)
        {
            FrmDersler frmDersler = new FrmDersler();
            frmDersler.number = label2.Text;
            frmDersler.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {

            SqlCommand komut1 = new SqlCommand("select OgrtAd,OgrtSoyad from Tbl_Ogretmenler where OgrtSifre=@p1", bgl.baglanti());

            komut1.Parameters.AddWithValue("@p1", numara);

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {

                label1.Text = dr1[0] + " " + dr1[1] + " Hoşgeldiniz";

            }

            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select OgrtSifre from Tbl_Ogretmenler where OgrtSifre=@p2", bgl.baglanti());

            komut2.Parameters.AddWithValue("@p2", numara);

            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {

                label2.Text = dr2[0].ToString();

            }

            bgl.baglanti().Close();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgrenci frmOgrenci = new FrmOgrenci();
            frmOgrenci.number = label2.Text;
            frmOgrenci.Show();
            this.Hide();
        }

        private void BtnSinavNotlar_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar fr= new FrmSinavNotlar();
            fr.number = label2.Text;
            fr.Show();
            this.Hide();
        }
    }
}
