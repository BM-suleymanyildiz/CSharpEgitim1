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

namespace Kitaplik_Proje
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* from Tbl_Kitaplar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtKitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtKitapYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtKitapSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbKitapTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                radioButton1.Checked = true;
            }
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "False")
            {
                radioButton2.Checked = true;
            }
        }





        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Kitaplar (KitapAd,Yazar,Tur,Sayfa,Durum) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komut1.Parameters.AddWithValue("@p2", TxtKitapYazar.Text);
            komut1.Parameters.AddWithValue("@p3", CmbKitapTur.Text);
            komut1.Parameters.AddWithValue("@p4", TxtKitapSayfa.Text);
            if (radioButton1.Checked == true)
            {
                komut1.Parameters.AddWithValue("@p5", "0");

            }
            if (radioButton2.Checked == true)
            {
                komut1.Parameters.AddWithValue("@p5", "1");
            }
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete from Tbl_Kitaplar where Kitapid=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtKitapid.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Sistemden Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }



        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Kitaplar set KitapAd=@p1,Yazar=@p2,Tur=@p3,Sayfa=@p4,Durum=@p5 where Kitapid=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p6", TxtKitapid.Text);
            komut.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtKitapYazar.Text);
            komut.Parameters.AddWithValue("@p3", CmbKitapTur.Text);
            komut.Parameters.AddWithValue("@p4", TxtKitapSayfa.Text);
            if (radioButton1.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", "1");
            }
            if (radioButton2.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", "0");
            }
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
        }

        private void BtnArama_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Select *From Tbl_Kitaplar where KitapAd=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", TxtAra.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut3);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Select *From Tbl_Kitaplar where KitapAd like '%"+TxtAra.Text+"%'", bgl.baglanti());
          
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut4);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void TxtAra_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Select *From Tbl_Kitaplar where KitapAd like '%" + TxtAra.Text + "%'", bgl.baglanti());

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut4);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
    }
}
