namespace küytüphane_otomasyonu
{
    partial class Dergi_İslemleri
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
            this.issn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dergi_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayin_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_issn = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_DergiAdi = new System.Windows.Forms.TextBox();
            this.txt_YayinTarihi = new System.Windows.Forms.TextBox();
            this.txt_Dili = new System.Windows.Forms.TextBox();
            this.İssn = new System.Windows.Forms.Label();
            this.dergi = new System.Windows.Forms.Label();
            this.Dil = new System.Windows.Forms.Label();
            this.YayinTarihi = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issn,
            this.dergi_adi,
            this.dili,
            this.yayin_tarihi});
            this.dataGridView1.Location = new System.Drawing.Point(293, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(841, 237);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // txt_issn
            // 
            this.txt_issn.Location = new System.Drawing.Point(151, 47);
            this.txt_issn.Name = "txt_issn";
            this.txt_issn.Size = new System.Drawing.Size(100, 22);
            this.txt_issn.TabIndex = 34;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(151, 242);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(100, 32);
            this.btn_Ekle.TabIndex = 35;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_DergiAdi
            // 
            this.txt_DergiAdi.Location = new System.Drawing.Point(151, 96);
            this.txt_DergiAdi.Name = "txt_DergiAdi";
            this.txt_DergiAdi.Size = new System.Drawing.Size(100, 22);
            this.txt_DergiAdi.TabIndex = 36;
            // 
            // txt_YayinTarihi
            // 
            this.txt_YayinTarihi.Location = new System.Drawing.Point(151, 147);
            this.txt_YayinTarihi.Name = "txt_YayinTarihi";
            this.txt_YayinTarihi.Size = new System.Drawing.Size(100, 22);
            this.txt_YayinTarihi.TabIndex = 37;
            // 
            // txt_Dili
            // 
            this.txt_Dili.Location = new System.Drawing.Point(151, 187);
            this.txt_Dili.Name = "txt_Dili";
            this.txt_Dili.Size = new System.Drawing.Size(100, 22);
            this.txt_Dili.TabIndex = 38;
            // 
            // İssn
            // 
            this.İssn.AutoSize = true;
            this.İssn.Location = new System.Drawing.Point(49, 52);
            this.İssn.Name = "İssn";
            this.İssn.Size = new System.Drawing.Size(62, 16);
            this.İssn.TabIndex = 39;
            this.İssn.Text = "ISSN No:";
            // 
            // dergi
            // 
            this.dergi.AutoSize = true;
            this.dergi.Location = new System.Drawing.Point(49, 96);
            this.dergi.Name = "dergi";
            this.dergi.Size = new System.Drawing.Size(66, 16);
            this.dergi.TabIndex = 40;
            this.dergi.Text = "Dergi Adı:";
            // 
            // Dil
            // 
            this.Dil.AutoSize = true;
            this.Dil.Location = new System.Drawing.Point(49, 187);
            this.Dil.Name = "Dil";
            this.Dil.Size = new System.Drawing.Size(29, 16);
            this.Dil.TabIndex = 41;
            this.Dil.Text = "Dili:";
            // 
            // YayinTarihi
            // 
            this.YayinTarihi.AutoSize = true;
            this.YayinTarihi.Location = new System.Drawing.Point(49, 147);
            this.YayinTarihi.Name = "YayinTarihi";
            this.YayinTarihi.Size = new System.Drawing.Size(75, 16);
            this.YayinTarihi.TabIndex = 42;
            this.YayinTarihi.Text = "Yayın tarihi:";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(928, 291);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(100, 32);
            this.btn_guncelle.TabIndex = 43;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(1034, 291);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 32);
            this.btn_sil.TabIndex = 44;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // Dergi_İslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 362);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.YayinTarihi);
            this.Controls.Add(this.Dil);
            this.Controls.Add(this.dergi);
            this.Controls.Add(this.İssn);
            this.Controls.Add(this.txt_Dili);
            this.Controls.Add(this.txt_YayinTarihi);
            this.Controls.Add(this.txt_DergiAdi);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_issn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dergi_İslemleri";
            this.Text = "Dergi_İslemleri";
            this.Load += new System.EventHandler(this.Dergi_İslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_issn;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_DergiAdi;
        private System.Windows.Forms.TextBox txt_YayinTarihi;
        private System.Windows.Forms.TextBox txt_Dili;
        private System.Windows.Forms.Label İssn;
        private System.Windows.Forms.Label dergi;
        private System.Windows.Forms.Label Dil;
        private System.Windows.Forms.Label YayinTarihi;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridViewTextBoxColumn issn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dergi_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayin_tarihi;
    }
}