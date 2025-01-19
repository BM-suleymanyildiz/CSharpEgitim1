namespace Kitaplik_Proje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKitapAd = new System.Windows.Forms.TextBox();
            this.TxtKitapYazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKitapSayfa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbKitapTur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtKitapid = new System.Windows.Forms.TextBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnArama = new System.Windows.Forms.Button();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(663, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Ad:";
            // 
            // TxtKitapAd
            // 
            this.TxtKitapAd.Location = new System.Drawing.Point(121, 177);
            this.TxtKitapAd.Name = "TxtKitapAd";
            this.TxtKitapAd.Size = new System.Drawing.Size(209, 30);
            this.TxtKitapAd.TabIndex = 2;
            // 
            // TxtKitapYazar
            // 
            this.TxtKitapYazar.Location = new System.Drawing.Point(121, 225);
            this.TxtKitapYazar.Name = "TxtKitapYazar";
            this.TxtKitapYazar.Size = new System.Drawing.Size(209, 30);
            this.TxtKitapYazar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar:";
            // 
            // TxtKitapSayfa
            // 
            this.TxtKitapSayfa.Location = new System.Drawing.Point(121, 279);
            this.TxtKitapSayfa.Name = "TxtKitapSayfa";
            this.TxtKitapSayfa.Size = new System.Drawing.Size(209, 30);
            this.TxtKitapSayfa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sayfa:";
            // 
            // CmbKitapTur
            // 
            this.CmbKitapTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKitapTur.FormattingEnabled = true;
            this.CmbKitapTur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Tarih",
            "Bilişim",
            "Tiyatro"});
            this.CmbKitapTur.Location = new System.Drawing.Point(121, 327);
            this.CmbKitapTur.Name = "CmbKitapTur";
            this.CmbKitapTur.Size = new System.Drawing.Size(209, 34);
            this.CmbKitapTur.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tür:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(121, 379);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 27);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İkinci El";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(260, 379);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 27);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sıfır";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Durum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kitap id:";
            // 
            // TxtKitapid
            // 
            this.TxtKitapid.Enabled = false;
            this.TxtKitapid.Location = new System.Drawing.Point(121, 131);
            this.TxtKitapid.Name = "TxtKitapid";
            this.TxtKitapid.Size = new System.Drawing.Size(209, 30);
            this.TxtKitapid.TabIndex = 1;
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(367, 131);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(171, 54);
            this.BtnListele.TabIndex = 6;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(367, 191);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(171, 53);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click_1);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(367, 250);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(171, 56);
            this.BtnSil.TabIndex = 8;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click_1);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(367, 312);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(171, 60);
            this.BtnGuncelle.TabIndex = 9;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(98, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(497, 48);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kütüphane Yönetim Sistemi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(557, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // BtnArama
            // 
            this.BtnArama.Location = new System.Drawing.Point(557, 81);
            this.BtnArama.Name = "BtnArama";
            this.BtnArama.Size = new System.Drawing.Size(70, 30);
            this.BtnArama.TabIndex = 20;
            this.BtnArama.Text = "Ara1";
            this.BtnArama.UseVisualStyleBackColor = true;
            this.BtnArama.Click += new System.EventHandler(this.BtnArama_Click);
            // 
            // TxtAra
            // 
            this.TxtAra.Location = new System.Drawing.Point(121, 81);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(417, 30);
            this.TxtAra.TabIndex = 21;
            this.TxtAra.TextChanged += new System.EventHandler(this.TxtAra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Kitap Ara:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ara2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(719, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnArama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtKitapid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbKitapTur);
            this.Controls.Add(this.TxtKitapSayfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKitapYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKitapAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("DFKaiSho-SB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKitapAd;
        private System.Windows.Forms.TextBox TxtKitapYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKitapSayfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbKitapTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtKitapid;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnArama;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

