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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string number;

        //ileri geri başalangıç
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select OgrtSifre from Tbl_Ogretmenler where OgrtSifre=@p1", bgl.baglanti());

            komut1.Parameters.AddWithValue("@p1", number);

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {

                label4.Text = dr1[0].ToString();

            }

            bgl.baglanti().Close();
            dataGridView1.DataSource = ds.OgrenciListesi();
            SqlCommand komut2 = new SqlCommand("Select* from Tbl_Kulupler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut2);

            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KulupAd";
            comboBox1.ValueMember = "Kulupid";
            comboBox1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmOgretmen frm = new FrmOgretmen();
            frm.numara = label4.Text;
            frm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Purple;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Purple;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Transparent;
        }
        //ileri geri son
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        string c = "";
        private void BtnEkle_Click(object sender, EventArgs e)
        {

          


            ds.OgrenciEkle(TxtAd.Text, TxtSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci Ekleme Yapılıdı");

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Txtid.Text = comboBox1.SelectedValue.ToString();    
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.OgrSil(int.Parse(Txtid.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
          
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()=="KIZ"|| dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Kız")
            {
                radioButton1.Checked = true;
            }
            if(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()=="ERKEK" || dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Erkek")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(TxtAd.Text, TxtSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c, int.Parse(Txtid.Text));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "KIZ";

            }
            if (radioButton2.Checked == true)
            {
                c = "ERKEK";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "KIZ";

            }
            if (radioButton2.Checked == true)
            {
                c = "ERKEK";
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
             dataGridView1.DataSource = ds.OgrAra(TxtAra.Text);
           
        }
    }
}
