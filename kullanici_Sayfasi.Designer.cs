namespace küytüphane_otomasyonu
{
    partial class kullanici_Sayfasi
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
            this.Rez = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn_nu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rafno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cevirmen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.issn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dergi_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayin_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Rez
            // 
            this.Rez.Location = new System.Drawing.Point(570, 193);
            this.Rez.Name = "Rez";
            this.Rez.Size = new System.Drawing.Size(142, 50);
            this.Rez.TabIndex = 1;
            this.Rez.Text = "Rezervasyon Yap";
            this.Rez.UseVisualStyleBackColor = true;
            this.Rez.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapAdi,
            this.YayinEvi,
            this.isbn_nu,
            this.Yazar,
            this.Turu,
            this.Rafno,
            this.Cevirmen});
            this.dataGridView1.Location = new System.Drawing.Point(27, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(685, 158);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "Kitap Adı";
            this.KitapAdi.MinimumWidth = 6;
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.ReadOnly = true;
            // 
            // YayinEvi
            // 
            this.YayinEvi.DataPropertyName = "YayinEvi";
            this.YayinEvi.HeaderText = "Yayın Evi";
            this.YayinEvi.MinimumWidth = 6;
            this.YayinEvi.Name = "YayinEvi";
            this.YayinEvi.ReadOnly = true;
            // 
            // isbn_nu
            // 
            this.isbn_nu.DataPropertyName = "isbn_nu";
            this.isbn_nu.HeaderText = "ISBN";
            this.isbn_nu.MinimumWidth = 6;
            this.isbn_nu.Name = "isbn_nu";
            this.isbn_nu.ReadOnly = true;
            // 
            // Yazar
            // 
            this.Yazar.DataPropertyName = "Yazar";
            this.Yazar.HeaderText = "Yazar";
            this.Yazar.MinimumWidth = 6;
            this.Yazar.Name = "Yazar";
            this.Yazar.ReadOnly = true;
            // 
            // Turu
            // 
            this.Turu.DataPropertyName = "Turu";
            this.Turu.HeaderText = "Türü";
            this.Turu.MinimumWidth = 6;
            this.Turu.Name = "Turu";
            this.Turu.ReadOnly = true;
            // 
            // Rafno
            // 
            this.Rafno.DataPropertyName = "Rafno";
            this.Rafno.HeaderText = "Rafno";
            this.Rafno.MinimumWidth = 6;
            this.Rafno.Name = "Rafno";
            this.Rafno.ReadOnly = true;
            // 
            // Cevirmen
            // 
            this.Cevirmen.DataPropertyName = "Cevirmen";
            this.Cevirmen.HeaderText = "Çevirmen";
            this.Cevirmen.MinimumWidth = 6;
            this.Cevirmen.Name = "Cevirmen";
            this.Cevirmen.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issn,
            this.dergi_adi,
            this.dili,
            this.yayin_tarihi});
            this.dataGridView2.Location = new System.Drawing.Point(27, 249);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(685, 163);
            this.dataGridView2.TabIndex = 34;
            // 
            // issn
            // 
            this.issn.DataPropertyName = "issn";
            this.issn.HeaderText = "ISSN No";
            this.issn.MinimumWidth = 6;
            this.issn.Name = "issn";
            // 
            // dergi_adi
            // 
            this.dergi_adi.DataPropertyName = "dergi_adi";
            this.dergi_adi.HeaderText = "Dergi Adı";
            this.dergi_adi.MinimumWidth = 6;
            this.dergi_adi.Name = "dergi_adi";
            // 
            // dili
            // 
            this.dili.DataPropertyName = "dili";
            this.dili.HeaderText = "Dil";
            this.dili.MinimumWidth = 6;
            this.dili.Name = "dili";
            // 
            // yayin_tarihi
            // 
            this.yayin_tarihi.DataPropertyName = "yayin_tarihi";
            this.yayin_tarihi.HeaderText = "Yayın Tarihi";
            this.yayin_tarihi.MinimumWidth = 6;
            this.yayin_tarihi.Name = "yayin_tarihi";
            // 
            // Rezz
            // 
            this.Rezz.Location = new System.Drawing.Point(570, 418);
            this.Rezz.Name = "Rezz";
            this.Rezz.Size = new System.Drawing.Size(142, 50);
            this.Rezz.TabIndex = 35;
            this.Rezz.Text = "Rezervasyon Yap";
            this.Rezz.UseVisualStyleBackColor = true;
            this.Rezz.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullanici_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 488);
            this.Controls.Add(this.Rezz);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Rez);
            this.Name = "kullanici_Sayfasi";
            this.Text = "kullanici_Sayfasi";
            this.Load += new System.EventHandler(this.kullanici_Sayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Rez;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn_nu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rafno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cevirmen;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn issn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dergi_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayin_tarihi;
        private System.Windows.Forms.Button Rezz;
    }
}