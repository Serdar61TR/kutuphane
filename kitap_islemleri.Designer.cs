namespace küytüphane_otomasyonu
{
    partial class kitap_islemleri
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
            this.Cevirmenn = new System.Windows.Forms.Label();
            this.txt_cevirmen = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.cmb_tur = new System.Windows.Forms.ComboBox();
            this.txt_raf = new System.Windows.Forms.TextBox();
            this.txt_yayınEvi = new System.Windows.Forms.TextBox();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.txt_kitap = new System.Windows.Forms.TextBox();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.Rafnoo = new System.Windows.Forms.Label();
            this.Turuu = new System.Windows.Forms.Label();
            this.YayinEvii = new System.Windows.Forms.Label();
            this.Yazarr = new System.Windows.Forms.Label();
            this.Kitap = new System.Windows.Forms.Label();
            this.İsbn = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn_nu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cevirmen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ara = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cevirmenn
            // 
            this.Cevirmenn.AutoSize = true;
            this.Cevirmenn.Location = new System.Drawing.Point(38, 309);
            this.Cevirmenn.Name = "Cevirmenn";
            this.Cevirmenn.Size = new System.Drawing.Size(64, 16);
            this.Cevirmenn.TabIndex = 31;
            this.Cevirmenn.Text = "Çevirmen";
            // 
            // txt_cevirmen
            // 
            this.txt_cevirmen.Location = new System.Drawing.Point(134, 303);
            this.txt_cevirmen.Name = "txt_cevirmen";
            this.txt_cevirmen.Size = new System.Drawing.Size(176, 22);
            this.txt_cevirmen.TabIndex = 30;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(210, 342);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 32);
            this.btn_ekle.TabIndex = 29;
            this.btn_ekle.Text = "Kitabı Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // cmb_tur
            // 
            this.cmb_tur.FormattingEnabled = true;
            this.cmb_tur.Location = new System.Drawing.Point(134, 214);
            this.cmb_tur.Name = "cmb_tur";
            this.cmb_tur.Size = new System.Drawing.Size(176, 24);
            this.cmb_tur.TabIndex = 28;
            this.cmb_tur.SelectedIndexChanged += new System.EventHandler(this.cmb_tur_SelectedIndexChanged);
            // 
            // txt_raf
            // 
            this.txt_raf.Location = new System.Drawing.Point(134, 260);
            this.txt_raf.Name = "txt_raf";
            this.txt_raf.Size = new System.Drawing.Size(176, 22);
            this.txt_raf.TabIndex = 27;
            // 
            // txt_yayınEvi
            // 
            this.txt_yayınEvi.Location = new System.Drawing.Point(134, 177);
            this.txt_yayınEvi.Name = "txt_yayınEvi";
            this.txt_yayınEvi.Size = new System.Drawing.Size(176, 22);
            this.txt_yayınEvi.TabIndex = 26;
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(134, 137);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(176, 22);
            this.txt_yazar.TabIndex = 25;
            // 
            // txt_kitap
            // 
            this.txt_kitap.Location = new System.Drawing.Point(134, 97);
            this.txt_kitap.Name = "txt_kitap";
            this.txt_kitap.Size = new System.Drawing.Size(176, 22);
            this.txt_kitap.TabIndex = 24;
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(134, 57);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(176, 22);
            this.txt_barkod.TabIndex = 23;
            // 
            // Rafnoo
            // 
            this.Rafnoo.AutoSize = true;
            this.Rafnoo.Location = new System.Drawing.Point(38, 260);
            this.Rafnoo.Name = "Rafnoo";
            this.Rafnoo.Size = new System.Drawing.Size(46, 16);
            this.Rafnoo.TabIndex = 22;
            this.Rafnoo.Text = "Raf no";
            // 
            // Turuu
            // 
            this.Turuu.AutoSize = true;
            this.Turuu.Location = new System.Drawing.Point(38, 217);
            this.Turuu.Name = "Turuu";
            this.Turuu.Size = new System.Drawing.Size(34, 16);
            this.Turuu.TabIndex = 21;
            this.Turuu.Text = "Türü";
            // 
            // YayinEvii
            // 
            this.YayinEvii.AutoSize = true;
            this.YayinEvii.Location = new System.Drawing.Point(38, 177);
            this.YayinEvii.Name = "YayinEvii";
            this.YayinEvii.Size = new System.Drawing.Size(62, 16);
            this.YayinEvii.TabIndex = 20;
            this.YayinEvii.Text = "Yayın evi";
            // 
            // Yazarr
            // 
            this.Yazarr.AutoSize = true;
            this.Yazarr.Location = new System.Drawing.Point(38, 137);
            this.Yazarr.Name = "Yazarr";
            this.Yazarr.Size = new System.Drawing.Size(42, 16);
            this.Yazarr.TabIndex = 19;
            this.Yazarr.Text = "Yazar";
            // 
            // Kitap
            // 
            this.Kitap.AutoSize = true;
            this.Kitap.Location = new System.Drawing.Point(38, 97);
            this.Kitap.Name = "Kitap";
            this.Kitap.Size = new System.Drawing.Size(60, 16);
            this.Kitap.TabIndex = 18;
            this.Kitap.Text = "Kitap Adı";
            // 
            // İsbn
            // 
            this.İsbn.AutoSize = true;
            this.İsbn.Location = new System.Drawing.Point(38, 57);
            this.İsbn.Name = "İsbn";
            this.İsbn.Size = new System.Drawing.Size(38, 16);
            this.İsbn.TabIndex = 17;
            this.İsbn.Text = "ISBN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapAdi,
            this.YayinEvi,
            this.isbn_nu,
            this.yazar,
            this.turu,
            this.rafno,
            this.cevirmen});
            this.dataGridView1.Location = new System.Drawing.Point(372, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 315);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "Kitap Adı";
            this.KitapAdi.MinimumWidth = 6;
            this.KitapAdi.Name = "KitapAdi";
            // 
            // YayinEvi
            // 
            this.YayinEvi.DataPropertyName = "YayinEvi";
            this.YayinEvi.HeaderText = "Yayın Evi";
            this.YayinEvi.MinimumWidth = 6;
            this.YayinEvi.Name = "YayinEvi";
            // 
            // isbn_nu
            // 
            this.isbn_nu.DataPropertyName = "isbn_nu";
            this.isbn_nu.HeaderText = "ISBN";
            this.isbn_nu.MinimumWidth = 6;
            this.isbn_nu.Name = "isbn_nu";
            // 
            // yazar
            // 
            this.yazar.DataPropertyName = "yazar";
            this.yazar.HeaderText = "Yazar";
            this.yazar.MinimumWidth = 6;
            this.yazar.Name = "yazar";
            // 
            // turu
            // 
            this.turu.DataPropertyName = "turu";
            this.turu.HeaderText = "Türü";
            this.turu.MinimumWidth = 6;
            this.turu.Name = "turu";
            // 
            // rafno
            // 
            this.rafno.DataPropertyName = "rafno";
            this.rafno.HeaderText = "Raf No";
            this.rafno.MinimumWidth = 6;
            this.rafno.Name = "rafno";
            // 
            // cevirmen
            // 
            this.cevirmen.DataPropertyName = "cevirmen";
            this.cevirmen.HeaderText = "Çevirmen";
            this.cevirmen.MinimumWidth = 6;
            this.cevirmen.Name = "cevirmen";
            // 
            // Ara
            // 
            this.Ara.AutoSize = true;
            this.Ara.Location = new System.Drawing.Point(793, 29);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(82, 16);
            this.Ara.TabIndex = 34;
            this.Ara.Text = "Kitap adı ara";
            this.Ara.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(881, 29);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(186, 22);
            this.txt_ara.TabIndex = 33;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(802, 417);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(125, 32);
            this.btn_guncelle.TabIndex = 35;
            this.btn_guncelle.Text = "Kitabı Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(960, 417);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(125, 32);
            this.btn_sil.TabIndex = 37;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.button1_Click);
            // 
            // kitap_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 541);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cevirmenn);
            this.Controls.Add(this.txt_cevirmen);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.cmb_tur);
            this.Controls.Add(this.txt_raf);
            this.Controls.Add(this.txt_yayınEvi);
            this.Controls.Add(this.txt_yazar);
            this.Controls.Add(this.txt_kitap);
            this.Controls.Add(this.txt_barkod);
            this.Controls.Add(this.Rafnoo);
            this.Controls.Add(this.Turuu);
            this.Controls.Add(this.YayinEvii);
            this.Controls.Add(this.Yazarr);
            this.Controls.Add(this.Kitap);
            this.Controls.Add(this.İsbn);
            this.Name = "kitap_islemleri";
            this.Text = "kitap_islemleri";
            this.Load += new System.EventHandler(this.kitap_islemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cevirmenn;
        private System.Windows.Forms.TextBox txt_cevirmen;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ComboBox cmb_tur;
        private System.Windows.Forms.TextBox txt_raf;
        private System.Windows.Forms.TextBox txt_yayınEvi;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.TextBox txt_kitap;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.Label Rafnoo;
        private System.Windows.Forms.Label Turuu;
        private System.Windows.Forms.Label YayinEvii;
        private System.Windows.Forms.Label Yazarr;
        private System.Windows.Forms.Label Kitap;
        private System.Windows.Forms.Label İsbn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Ara;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn_nu;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cevirmen;
    }
}