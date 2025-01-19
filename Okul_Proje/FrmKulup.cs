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
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        public string numara;
        void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Kulupler ", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void FrmKulupPaneli_Load(object sender, EventArgs e)
        {   
        
            liste();

            SqlCommand komut1 = new SqlCommand("select OgrtSifre from Tbl_Ogretmenler where OgrtSifre=@p1", bgl.baglanti());

            komut1.Parameters.AddWithValue("@p1", numara);

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {

                label4.Text = dr1[0].ToString();

            }

            bgl.baglanti().Close();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

    
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Purple;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKulupid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtKulupAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Kulupler where Kulupid=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtKulupid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kulüp Silme İşlemi Gerçekleşti");
            liste();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Kulupler set KulupAd=@p1 where Kulupid=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtKulupAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtKulupid.Text);
            komut.ExecuteNonQuery();    
            bgl.baglanti().Close();
            MessageBox.Show("Kulüp Bilgileri Güncelleme İşlemi Gerçekleşti");
            liste();


        }

        private void BtnEkle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Kulupler (KulupAd) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKulupAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kulüp Listeye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Purple;

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Transparent;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmOgretmen frm = new FrmOgretmen();
            frm.numara = label4.Text;
            frm.Show();
            this.Hide();
        }
    }
}
