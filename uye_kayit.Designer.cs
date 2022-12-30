namespace küytüphane_otomasyonu
{
    partial class uye_kayit
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
            this.txt_tarih = new System.Windows.Forms.DateTimePicker();
            this.btn_uye_kayit = new System.Windows.Forms.Button();
            this.cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.E_posta = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.Cinsiyet = new System.Windows.Forms.Label();
            this.Dtarih = new System.Windows.Forms.Label();
            this.Adsoyad = new System.Windows.Forms.Label();
            this.Tcc = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_tarih
            // 
            this.txt_tarih.Location = new System.Drawing.Point(159, 175);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(200, 22);
            this.txt_tarih.TabIndex = 32;
            // 
            // btn_uye_kayit
            // 
            this.btn_uye_kayit.Location = new System.Drawing.Point(534, 175);
            this.btn_uye_kayit.Name = "btn_uye_kayit";
            this.btn_uye_kayit.Size = new System.Drawing.Size(150, 43);
            this.btn_uye_kayit.TabIndex = 31;
            this.btn_uye_kayit.Text = "Kaydol";
            this.btn_uye_kayit.UseVisualStyleBackColor = true;
            this.btn_uye_kayit.Click += new System.EventHandler(this.btn_uye_kayit_Click);
            // 
            // cmb_Cinsiyet
            // 
            this.cmb_Cinsiyet.FormattingEnabled = true;
            this.cmb_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_Cinsiyet.Location = new System.Drawing.Point(159, 222);
            this.cmb_Cinsiyet.Name = "cmb_Cinsiyet";
            this.cmb_Cinsiyet.Size = new System.Drawing.Size(150, 24);
            this.cmb_Cinsiyet.TabIndex = 30;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(534, 120);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(150, 22);
            this.txt_Email.TabIndex = 29;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(534, 71);
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(150, 22);
            this.txt_Adres.TabIndex = 28;
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(534, 22);
            this.txt_Tel.MaxLength = 10;
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(150, 22);
            this.txt_Tel.TabIndex = 27;
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(159, 74);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(150, 22);
            this.txt_AdSoyad.TabIndex = 26;
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(159, 25);
            this.txt_Tc.MaxLength = 11;
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(150, 22);
            this.txt_Tc.TabIndex = 25;
            this.txt_Tc.TextChanged += new System.EventHandler(this.txt_Tc_TextChanged);
            this.txt_Tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tc_KeyPress);
            // 
            // E_posta
            // 
            this.E_posta.AutoSize = true;
            this.E_posta.Location = new System.Drawing.Point(411, 125);
            this.E_posta.Name = "E_posta";
            this.E_posta.Size = new System.Drawing.Size(54, 16);
            this.E_posta.TabIndex = 24;
            this.E_posta.Text = "E-posta";
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(411, 75);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(43, 16);
            this.Adres.TabIndex = 23;
            this.Adres.Text = "Adres";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(411, 25);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(53, 16);
            this.Telefon.TabIndex = 22;
            this.Telefon.Text = "Telefon";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.AutoSize = true;
            this.Cinsiyet.Location = new System.Drawing.Point(25, 225);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(54, 16);
            this.Cinsiyet.TabIndex = 21;
            this.Cinsiyet.Text = "Cinsiyet";
            // 
            // Dtarih
            // 
            this.Dtarih.AutoSize = true;
            this.Dtarih.Location = new System.Drawing.Point(25, 175);
            this.Dtarih.Name = "Dtarih";
            this.Dtarih.Size = new System.Drawing.Size(88, 16);
            this.Dtarih.TabIndex = 20;
            this.Dtarih.Text = "Doğum Tarihi";
            // 
            // Adsoyad
            // 
            this.Adsoyad.AutoSize = true;
            this.Adsoyad.Location = new System.Drawing.Point(25, 75);
            this.Adsoyad.Name = "Adsoyad";
            this.Adsoyad.Size = new System.Drawing.Size(67, 16);
            this.Adsoyad.TabIndex = 19;
            this.Adsoyad.Text = "Ad Soyad";
            // 
            // Tcc
            // 
            this.Tcc.AutoSize = true;
            this.Tcc.Location = new System.Drawing.Point(25, 25);
            this.Tcc.Name = "Tcc";
            this.Tcc.Size = new System.Drawing.Size(25, 16);
            this.Tcc.TabIndex = 18;
            this.Tcc.Text = "TC";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(159, 122);
            this.txt_sifre.MaxLength = 11;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(150, 22);
            this.txt_sifre.TabIndex = 33;
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.Location = new System.Drawing.Point(25, 126);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(37, 16);
            this.Sifre.TabIndex = 34;
            this.Sifre.Text = "Şifre:";
            // 
            // uye_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_tarih);
            this.Controls.Add(this.btn_uye_kayit);
            this.Controls.Add(this.cmb_Cinsiyet);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.txt_Tc);
            this.Controls.Add(this.E_posta);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Cinsiyet);
            this.Controls.Add(this.Dtarih);
            this.Controls.Add(this.Adsoyad);
            this.Controls.Add(this.Tcc);
            this.Name = "uye_kayit";
            this.Text = "uye_kayit";
            this.Load += new System.EventHandler(this.uye_kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txt_tarih;
        private System.Windows.Forms.Button btn_uye_kayit;
        private System.Windows.Forms.ComboBox cmb_Cinsiyet;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.TextBox txt_Tc;
        private System.Windows.Forms.Label E_posta;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label Cinsiyet;
        private System.Windows.Forms.Label Dtarih;
        private System.Windows.Forms.Label Adsoyad;
        private System.Windows.Forms.Label Tcc;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label Sifre;
    }
}