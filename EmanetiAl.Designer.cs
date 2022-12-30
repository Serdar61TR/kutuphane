namespace küytüphane_otomasyonu
{
    partial class EmanetiAl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeslimEden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alici_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alici_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn_nu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rafno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cevirmen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alim_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslim_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_Kitap = new System.Windows.Forms.Button();
            this.btn_dergi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeslimEden,
            this.alici,
            this.alici_tc,
            this.alici_tel,
            this.KitapAdi,
            this.isbn_nu,
            this.yazar,
            this.Rafno,
            this.Turu,
            this.YayinEvi,
            this.Cevirmen,
            this.alim_tarihi,
            this.teslim_tarihi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TeslimEden
            // 
            this.TeslimEden.DataPropertyName = "TeslimEden";
            this.TeslimEden.HeaderText = "Teslim Eden";
            this.TeslimEden.MinimumWidth = 6;
            this.TeslimEden.Name = "TeslimEden";
            this.TeslimEden.ReadOnly = true;
            // 
            // alici
            // 
            this.alici.DataPropertyName = "alici";
            this.alici.HeaderText = "Alan kişi";
            this.alici.MinimumWidth = 6;
            this.alici.Name = "alici";
            this.alici.ReadOnly = true;
            // 
            // alici_tc
            // 
            this.alici_tc.DataPropertyName = "alici_tc";
            this.alici_tc.HeaderText = "tc";
            this.alici_tc.MinimumWidth = 6;
            this.alici_tc.Name = "alici_tc";
            this.alici_tc.ReadOnly = true;
            // 
            // alici_tel
            // 
            this.alici_tel.DataPropertyName = "alici_tel";
            this.alici_tel.HeaderText = "Telefon";
            this.alici_tel.MinimumWidth = 6;
            this.alici_tel.Name = "alici_tel";
            this.alici_tel.ReadOnly = true;
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "Kitap Adı";
            this.KitapAdi.MinimumWidth = 6;
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.ReadOnly = true;
            // 
            // isbn_nu
            // 
            this.isbn_nu.DataPropertyName = "isbn_nu";
            this.isbn_nu.HeaderText = "isbn_nu";
            this.isbn_nu.MinimumWidth = 6;
            this.isbn_nu.Name = "isbn_nu";
            this.isbn_nu.ReadOnly = true;
            // 
            // yazar
            // 
            this.yazar.DataPropertyName = "yazar";
            this.yazar.HeaderText = "Yazar";
            this.yazar.MinimumWidth = 6;
            this.yazar.Name = "yazar";
            this.yazar.ReadOnly = true;
            // 
            // Rafno
            // 
            this.Rafno.DataPropertyName = "Rafno";
            this.Rafno.HeaderText = "Rafno";
            this.Rafno.MinimumWidth = 6;
            this.Rafno.Name = "Rafno";
            this.Rafno.ReadOnly = true;
            // 
            // Turu
            // 
            this.Turu.DataPropertyName = "Turu";
            this.Turu.HeaderText = "Kategori";
            this.Turu.MinimumWidth = 6;
            this.Turu.Name = "Turu";
            this.Turu.ReadOnly = true;
            // 
            // YayinEvi
            // 
            this.YayinEvi.DataPropertyName = "YayinEvi";
            this.YayinEvi.HeaderText = "Yayın Evi";
            this.YayinEvi.MinimumWidth = 6;
            this.YayinEvi.Name = "YayinEvi";
            this.YayinEvi.ReadOnly = true;
            // 
            // Cevirmen
            // 
            this.Cevirmen.DataPropertyName = "Cevirmen";
            this.Cevirmen.HeaderText = "Çevirmen";
            this.Cevirmen.MinimumWidth = 6;
            this.Cevirmen.Name = "Cevirmen";
            this.Cevirmen.ReadOnly = true;
            // 
            // alim_tarihi
            // 
            this.alim_tarihi.DataPropertyName = "alim_tarihi";
            this.alim_tarihi.HeaderText = "Alım Tarihi";
            this.alim_tarihi.MinimumWidth = 6;
            this.alim_tarihi.Name = "alim_tarihi";
            this.alim_tarihi.ReadOnly = true;
            // 
            // teslim_tarihi
            // 
            this.teslim_tarihi.DataPropertyName = "teslim_tarihi";
            this.teslim_tarihi.HeaderText = "Teslim Tarihi";
            this.teslim_tarihi.MinimumWidth = 6;
            this.teslim_tarihi.Name = "teslim_tarihi";
            this.teslim_tarihi.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 209);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1160, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btn_Kitap
            // 
            this.btn_Kitap.Location = new System.Drawing.Point(1015, 168);
            this.btn_Kitap.Name = "btn_Kitap";
            this.btn_Kitap.Size = new System.Drawing.Size(145, 35);
            this.btn_Kitap.TabIndex = 2;
            this.btn_Kitap.Text = "Kitabı geri al";
            this.btn_Kitap.UseVisualStyleBackColor = true;
            this.btn_Kitap.Click += new System.EventHandler(this.btn_Kitap_Click);
            // 
            // btn_dergi
            // 
            this.btn_dergi.Location = new System.Drawing.Point(1015, 374);
            this.btn_dergi.Name = "btn_dergi";
            this.btn_dergi.Size = new System.Drawing.Size(145, 33);
            this.btn_dergi.TabIndex = 3;
            this.btn_dergi.Text = "Dergiyi geri al";
            this.btn_dergi.UseVisualStyleBackColor = true;
            this.btn_dergi.Click += new System.EventHandler(this.btn_dergi_Click);
            // 
            // EmanetiAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 419);
            this.Controls.Add(this.btn_dergi);
            this.Controls.Add(this.btn_Kitap);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetiAl";
            this.Text = "EmanetiAl";
            this.Load += new System.EventHandler(this.EmanetiAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_Kitap;
        private System.Windows.Forms.Button btn_dergi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeslimEden;
        private System.Windows.Forms.DataGridViewTextBoxColumn alici;
        private System.Windows.Forms.DataGridViewTextBoxColumn alici_tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn alici_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn_nu;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rafno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn YayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cevirmen;
        private System.Windows.Forms.DataGridViewTextBoxColumn alim_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslim_tarihi;
    }
}