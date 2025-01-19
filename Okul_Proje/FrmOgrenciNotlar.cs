using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Okul_Proje
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string numara;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select DersAd,Sinav1,Sinav2,Sinav3,Proje,Ortalama,Durum from Tbl_Notlar\r\ninner join Tbl_Dersler on Tbl_Notlar.Dersid=Tbl_Dersler.Dersid where Ogrid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);


            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;




            SqlCommand komut1 = new SqlCommand("select OgrAd,OgrSoyad from Tbl_Ogrenciler where Ogrid=@p1", bgl.baglanti());

            komut1.Parameters.AddWithValue("@p1", numara);

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {

                this.Text = dr1[0] + " " + dr1[1].ToString();

            }

            bgl.baglanti().Close();
        }

        private void FrmOgrenciNotlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
