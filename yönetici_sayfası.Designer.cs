namespace küytüphane_otomasyonu
{
    partial class yönetici_sayfası
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
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.AdSoyad = new System.Windows.Forms.Label();
            this.Eposta = new System.Windows.Forms.Label();
            this.Sifre = new System.Windows.Forms.Label();
            this.Tc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.Rol = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(164, 42);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(153, 22);
            this.txt_AdSoyad.TabIndex = 3;
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(164, 91);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(153, 22);
            this.txt_Eposta.TabIndex = 4;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(164, 142);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(153, 22);
            this.txt_Sifre.TabIndex = 5;
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(164, 194);
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(153, 22);
            this.txt_Tc.TabIndex = 6;
            // 
            // AdSoyad
            // 
            this.AdSoyad.AutoSize = true;
            this.AdSoyad.Location = new System.Drawing.Point(65, 39);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(67, 16);
            this.AdSoyad.TabIndex = 7;
            this.AdSoyad.Text = "Ad Soyad";
            // 
            // Eposta
            // 
            this.Eposta.AutoSize = true;
            this.Eposta.Location = new System.Drawing.Point(65, 97);
            this.Eposta.Name = "Eposta";
            this.Eposta.Size = new System.Drawing.Size(50, 16);
            this.Eposta.TabIndex = 8;
            this.Eposta.Text = "Eposta";
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.Location = new System.Drawing.Point(65, 142);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(34, 16);
            this.Sifre.TabIndex = 9;
            this.Sifre.Text = "Şifre";
            // 
            // Tc
            // 
            this.Tc.AutoSize = true;
            this.Tc.Location = new System.Drawing.Point(65, 194);
            this.Tc.Name = "Tc";
            this.Tc.Size = new System.Drawing.Size(23, 16);
            this.Tc.TabIndex = 10;
            this.Tc.Text = "Tc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(708, 283);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(164, 304);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 13;
            this.btn_kaydet.Text = "Ekle";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(849, 286);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 14;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Location = new System.Drawing.Point(65, 244);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(28, 16);
            this.Rol.TabIndex = 16;
            this.Rol.Text = "Rol";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 244);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // yönetici_sayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 503);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Tc);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.Eposta);
            this.Controls.Add(this.AdSoyad);
            this.Controls.Add(this.txt_Tc);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Eposta);
            this.Controls.Add(this.txt_AdSoyad);
            this.Name = "yönetici_sayfası";
            this.Text = "yönetici_sayfası";
            this.Load += new System.EventHandler(this.yönetici_sayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_Tc;
        private System.Windows.Forms.Label AdSoyad;
        private System.Windows.Forms.Label Eposta;
        private System.Windows.Forms.Label Sifre;
        private System.Windows.Forms.Label Tc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}