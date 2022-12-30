namespace küytüphane_otomasyonu
{
    partial class Personel_Uye_islemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tarih = new System.Windows.Forms.DateTimePicker();
            this.btn_uye_ekle = new System.Windows.Forms.Button();
            this.cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.E_posta = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.Cinsiyett = new System.Windows.Forms.Label();
            this.Dtarih = new System.Windows.Forms.Label();
            this.AdiSoyadi = new System.Windows.Forms.Label();
            this.Tcc = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.Ara = new System.Windows.Forms.Label();
            this.txt_arama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tc,
            this.ad_soyad,
            this.d_tarihi,
            this.cinsiyet,
            this.tel,
            this.adres,
            this.eposta});
            this.dataGridView1.Location = new System.Drawing.Point(387, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(831, 358);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tc
            // 
            this.tc.DataPropertyName = "tc";
            this.tc.HeaderText = "TC";
            this.tc.MinimumWidth = 6;
            this.tc.Name = "tc";
            // 
            // ad_soyad
            // 
            this.ad_soyad.DataPropertyName = "ad_soyad";
            this.ad_soyad.HeaderText = "Ad Soyad";
            this.ad_soyad.MinimumWidth = 6;
            this.ad_soyad.Name = "ad_soyad";
            // 
            // d_tarihi
            // 
            this.d_tarihi.DataPropertyName = "d_tarihi";
            this.d_tarihi.HeaderText = "Doğum Tarihi";
            this.d_tarihi.MinimumWidth = 6;
            this.d_tarihi.Name = "d_tarihi";
            // 
            // cinsiyet
            // 
            this.cinsiyet.DataPropertyName = "cinsiyet";
            this.cinsiyet.HeaderText = "Cinsiyet";
            this.cinsiyet.MinimumWidth = 6;
            this.cinsiyet.Name = "cinsiyet";
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "Telefon";
            this.tel.MinimumWidth = 6;
            this.tel.Name = "tel";
            // 
            // adres
            // 
            this.adres.DataPropertyName = "adres";
            this.adres.HeaderText = "Adres";
            this.adres.MinimumWidth = 6;
            this.adres.Name = "adres";
            // 
            // eposta
            // 
            this.eposta.DataPropertyName = "eposta";
            this.eposta.HeaderText = "Eposta";
            this.eposta.MinimumWidth = 6;
            this.eposta.Name = "eposta";
            // 
            // txt_tarih
            // 
            this.txt_tarih.Location = new System.Drawing.Point(163, 156);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(200, 22);
            this.txt_tarih.TabIndex = 32;
            // 
            // btn_uye_ekle
            // 
            this.btn_uye_ekle.Location = new System.Drawing.Point(58, 422);
            this.btn_uye_ekle.Name = "btn_uye_ekle";
            this.btn_uye_ekle.Size = new System.Drawing.Size(150, 43);
            this.btn_uye_ekle.TabIndex = 31;
            this.btn_uye_ekle.Text = "Ekle";
            this.btn_uye_ekle.UseVisualStyleBackColor = true;
            this.btn_uye_ekle.Click += new System.EventHandler(this.btn_uye_ekle_Click);
            // 
            // cmb_Cinsiyet
            // 
            this.cmb_Cinsiyet.FormattingEnabled = true;
            this.cmb_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_Cinsiyet.Location = new System.Drawing.Point(163, 211);
            this.cmb_Cinsiyet.Name = "cmb_Cinsiyet";
            this.cmb_Cinsiyet.Size = new System.Drawing.Size(150, 24);
            this.cmb_Cinsiyet.TabIndex = 30;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(163, 372);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(150, 22);
            this.txt_Email.TabIndex = 29;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(163, 323);
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(150, 22);
            this.txt_Adres.TabIndex = 28;
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(163, 268);
            this.txt_Tel.MaxLength = 10;
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(150, 22);
            this.txt_Tel.TabIndex = 27;
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(163, 107);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(150, 22);
            this.txt_AdSoyad.TabIndex = 26;
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(163, 60);
            this.txt_Tc.MaxLength = 11;
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(150, 22);
            this.txt_Tc.TabIndex = 25;
            // 
            // E_posta
            // 
            this.E_posta.AutoSize = true;
            this.E_posta.Location = new System.Drawing.Point(55, 378);
            this.E_posta.Name = "E_posta";
            this.E_posta.Size = new System.Drawing.Size(54, 16);
            this.E_posta.TabIndex = 24;
            this.E_posta.Text = "E-posta";
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(56, 323);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(43, 16);
            this.Adress.TabIndex = 23;
            this.Adress.Text = "Adres";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(56, 268);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(53, 16);
            this.Telefon.TabIndex = 22;
            this.Telefon.Text = "Telefon";
            // 
            // Cinsiyett
            // 
            this.Cinsiyett.AutoSize = true;
            this.Cinsiyett.Location = new System.Drawing.Point(55, 211);
            this.Cinsiyett.Name = "Cinsiyett";
            this.Cinsiyett.Size = new System.Drawing.Size(54, 16);
            this.Cinsiyett.TabIndex = 21;
            this.Cinsiyett.Text = "Cinsiyet";
            // 
            // Dtarih
            // 
            this.Dtarih.AutoSize = true;
            this.Dtarih.Location = new System.Drawing.Point(55, 156);
            this.Dtarih.Name = "Dtarih";
            this.Dtarih.Size = new System.Drawing.Size(88, 16);
            this.Dtarih.TabIndex = 20;
            this.Dtarih.Text = "Doğum Tarihi";
            // 
            // AdiSoyadi
            // 
            this.AdiSoyadi.AutoSize = true;
            this.AdiSoyadi.Location = new System.Drawing.Point(55, 107);
            this.AdiSoyadi.Name = "AdiSoyadi";
            this.AdiSoyadi.Size = new System.Drawing.Size(67, 16);
            this.AdiSoyadi.TabIndex = 19;
            this.AdiSoyadi.Text = "Ad Soyad";
            // 
            // Tcc
            // 
            this.Tcc.AutoSize = true;
            this.Tcc.Location = new System.Drawing.Point(55, 60);
            this.Tcc.Name = "Tcc";
            this.Tcc.Size = new System.Drawing.Size(25, 16);
            this.Tcc.TabIndex = 18;
            this.Tcc.Text = "TC";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(1111, 437);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(107, 52);
            this.btn_sil.TabIndex = 38;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(930, 437);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(128, 52);
            this.btn_guncelle.TabIndex = 37;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // Ara
            // 
            this.Ara.AutoSize = true;
            this.Ara.Location = new System.Drawing.Point(909, 12);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(68, 16);
            this.Ara.TabIndex = 40;
            this.Ara.Text = "TC Arama";
            // 
            // txt_arama
            // 
            this.txt_arama.Location = new System.Drawing.Point(1006, 12);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(212, 22);
            this.txt_arama.TabIndex = 39;
            this.txt_arama.TextChanged += new System.EventHandler(this.txt_arama_TextChanged);
            // 
            // Personel_Uye_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 543);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.txt_arama);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.txt_tarih);
            this.Controls.Add(this.btn_uye_ekle);
            this.Controls.Add(this.cmb_Cinsiyet);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.txt_Tc);
            this.Controls.Add(this.E_posta);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Cinsiyett);
            this.Controls.Add(this.Dtarih);
            this.Controls.Add(this.AdiSoyadi);
            this.Controls.Add(this.Tcc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personel_Uye_islemleri";
            this.Text = "Uye_islemleri";
            this.Load += new System.EventHandler(this.Personel_Uye_islemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposta;
        private System.Windows.Forms.DateTimePicker txt_tarih;
        private System.Windows.Forms.Button btn_uye_ekle;
        private System.Windows.Forms.ComboBox cmb_Cinsiyet;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.TextBox txt_Tc;
        private System.Windows.Forms.Label E_posta;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label Cinsiyett;
        private System.Windows.Forms.Label Dtarih;
        private System.Windows.Forms.Label AdiSoyadi;
        private System.Windows.Forms.Label Tcc;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label Ara;
        private System.Windows.Forms.TextBox txt_arama;
    }
}