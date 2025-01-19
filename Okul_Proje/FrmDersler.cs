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
    public partial class FrmDersler : Form
    {

        public FrmDersler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl=new SqlBaglanti();
        public string number;
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();

        private void FrmDersler_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select OgrtSifre from Tbl_Ogretmenler where OgrtSifre=@p1", bgl.baglanti());

            komut1.Parameters.AddWithValue("@p1", number);

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {

                label4.Text = dr1[0].ToString();

            }

            bgl.baglanti().Close();

            dataGridView1.DataSource = ds.DersListesi();

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmOgretmen frm = new FrmOgretmen();
            frm.numara = label4.Text;
            frm.Show();
            this.Hide();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(TxtDersAd.Text);
            MessageBox.Show("Ders Ekleme İşlemi Yapılmıştır");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(TxtDersAd.Text,byte.Parse(TxtDersid.Text));
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(TxtDersid.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDersid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtDersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
       

        
     

      

        private void pictureBox6_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Purple;
        }

        private void pictureBox6_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox7_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Purple;
        }

        private void pictureBox7_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Transparent;
        }
    }
}
