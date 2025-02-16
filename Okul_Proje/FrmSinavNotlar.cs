﻿using System;
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
    public partial class FrmSinavNotlar : Form
    {
        public string number;
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(Txtid.Text));
        }

        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select OgrtSifre from Tbl_Ogretmenler where OgrtSifre=@p1", bgl.baglanti());

            komut1.Parameters.AddWithValue("@p1", number);

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {

                Lbl5.Text = dr1[0].ToString();

            }

            bgl.baglanti().Close();


            SqlCommand komut2 = new SqlCommand("Select* from Tbl_Dersler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut2);

            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "DersAd";
            comboBox1.ValueMember = "Dersid";
            comboBox1.DataSource = dt;
            bgl.baglanti().Close();
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmOgretmen frm = new FrmOgretmen();
            frm.numara = Lbl5.Text;
            frm.Show();
            this.Hide();
        }



        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Transparent;
        }

        private void pictureBox7_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Purple;
        }

        private void pictureBox6_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Purple;

        }
        int notid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            Txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtSinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtSinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtSinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();



        }
        int sinav1, sinav2, sinav3, proje;
        double ortalama;
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            
            //string durum;
            sinav1 = Convert.ToInt32(TxtSinav1.Text);
            sinav2 = Convert.ToInt32(TxtSinav1.Text);
            sinav3 = Convert.ToInt32(TxtSinav1.Text);
            proje = Convert.ToInt32(TxtSinav1.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            TxtOrtalama.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                TxtDurum.Text = "True";
            }
            else
            {
                TxtDurum.Text = "False";
            }


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(comboBox1.SelectedValue.ToString()),int.Parse(Txtid.Text),byte.Parse(TxtSinav1.Text), byte.Parse(TxtSinav2.Text), byte.Parse(TxtSinav3.Text), byte.Parse(TxtProje.Text), decimal.Parse(TxtOrtalama.Text), bool.Parse(TxtDurum.Text),notid);
        }
    }
}
