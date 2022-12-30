namespace küytüphane_otomasyonu
{
    partial class personel_anasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel_anasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Kitap_islemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.Uye_islemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.Dergi_islemeri = new System.Windows.Forms.ToolStripMenuItem();
            this.EmanetVerme = new System.Windows.Forms.ToolStripMenuItem();
            this.Kitap = new System.Windows.Forms.ToolStripMenuItem();
            this.Dergi = new System.Windows.Forms.ToolStripMenuItem();
            this.EmanetAlma = new System.Windows.Forms.ToolStripMenuItem();
            this.Silinenler = new System.Windows.Forms.ToolStripMenuItem();
            this.Rezervasyonlar = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.okunanlar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Kitap_islemleri,
            this.Uye_islemleri,
            this.Dergi_islemeri,
            this.EmanetVerme,
            this.EmanetAlma,
            this.Silinenler,
            this.Rezervasyonlar,
            this.okunanlar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1316, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Kitap_islemleri
            // 
            this.Kitap_islemleri.Image = ((System.Drawing.Image)(resources.GetObject("Kitap_islemleri.Image")));
            this.Kitap_islemleri.Name = "Kitap_islemleri";
            this.Kitap_islemleri.Size = new System.Drawing.Size(158, 44);
            this.Kitap_islemleri.Text = "Kitap İşlemleri";
            this.Kitap_islemleri.Click += new System.EventHandler(this.kitapİşlemleriToolStripMenuItem_Click);
            // 
            // Uye_islemleri
            // 
            this.Uye_islemleri.Image = ((System.Drawing.Image)(resources.GetObject("Uye_islemleri.Image")));
            this.Uye_islemleri.Name = "Uye_islemleri";
            this.Uye_islemleri.Size = new System.Drawing.Size(148, 44);
            this.Uye_islemleri.Text = "Üye İşlemleri";
            this.Uye_islemleri.Click += new System.EventHandler(this.üyeİşlemleriToolStripMenuItem_Click);
            // 
            // Dergi_islemeri
            // 
            this.Dergi_islemeri.Image = ((System.Drawing.Image)(resources.GetObject("Dergi_islemeri.Image")));
            this.Dergi_islemeri.Name = "Dergi_islemeri";
            this.Dergi_islemeri.Size = new System.Drawing.Size(160, 44);
            this.Dergi_islemeri.Text = "Dergi İşlemleri";
            this.Dergi_islemeri.Click += new System.EventHandler(this.dergiİşlemleriToolStripMenuItem_Click);
            // 
            // EmanetVerme
            // 
            this.EmanetVerme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Kitap,
            this.Dergi});
            this.EmanetVerme.Image = ((System.Drawing.Image)(resources.GetObject("EmanetVerme.Image")));
            this.EmanetVerme.Name = "EmanetVerme";
            this.EmanetVerme.Size = new System.Drawing.Size(159, 44);
            this.EmanetVerme.Text = "Emanet Verme";
            this.EmanetVerme.Click += new System.EventHandler(this.emanetVermeToolStripMenuItem_Click);
            // 
            // Kitap
            // 
            this.Kitap.Image = ((System.Drawing.Image)(resources.GetObject("Kitap.Image")));
            this.Kitap.Name = "Kitap";
            this.Kitap.Size = new System.Drawing.Size(129, 26);
            this.Kitap.Text = "Kitap";
            this.Kitap.Click += new System.EventHandler(this.kitapToolStripMenuItem_Click);
            // 
            // Dergi
            // 
            this.Dergi.Image = ((System.Drawing.Image)(resources.GetObject("Dergi.Image")));
            this.Dergi.Name = "Dergi";
            this.Dergi.Size = new System.Drawing.Size(129, 26);
            this.Dergi.Text = "Dergi";
            this.Dergi.Click += new System.EventHandler(this.dergiToolStripMenuItem_Click);
            // 
            // EmanetAlma
            // 
            this.EmanetAlma.BackColor = System.Drawing.SystemColors.Window;
            this.EmanetAlma.Image = ((System.Drawing.Image)(resources.GetObject("EmanetAlma.Image")));
            this.EmanetAlma.Name = "EmanetAlma";
            this.EmanetAlma.Size = new System.Drawing.Size(152, 44);
            this.EmanetAlma.Text = "Emanet Alma";
            this.EmanetAlma.Click += new System.EventHandler(this.emanetAlmaToolStripMenuItem_Click);
            // 
            // Silinenler
            // 
            this.Silinenler.Image = ((System.Drawing.Image)(resources.GetObject("Silinenler.Image")));
            this.Silinenler.Name = "Silinenler";
            this.Silinenler.Size = new System.Drawing.Size(122, 44);
            this.Silinenler.Text = "silinenler";
            this.Silinenler.Click += new System.EventHandler(this.silinenlerToolStripMenuItem_Click);
            // 
            // Rezervasyonlar
            // 
            this.Rezervasyonlar.Image = ((System.Drawing.Image)(resources.GetObject("Rezervasyonlar.Image")));
            this.Rezervasyonlar.Name = "Rezervasyonlar";
            this.Rezervasyonlar.Size = new System.Drawing.Size(158, 44);
            this.Rezervasyonlar.Text = "rezervasyonlar";
            this.Rezervasyonlar.Click += new System.EventHandler(this.rezervasyonlarToolStripMenuItem_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir.png");
            this.ımageList1.Images.SetKeyName(1, "IEp4jdho_400x400.jpg");
            this.ımageList1.Images.SetKeyName(2, "png-transparent-computer-icons-reading-book-book-angle-text-hand.png");
            // 
            // okunanlar
            // 
            this.okunanlar.Image = ((System.Drawing.Image)(resources.GetObject("okunanlar.Image")));
            this.okunanlar.Name = "okunanlar";
            this.okunanlar.Size = new System.Drawing.Size(130, 44);
            this.okunanlar.Text = "Okunanlar";
            this.okunanlar.Click += new System.EventHandler(this.okunanlarToolStripMenuItem_Click);
            // 
            // personel_anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 562);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "personel_anasayfa";
            this.Text = "personel_anasayfa";
            this.Load += new System.EventHandler(this.personel_anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Kitap_islemleri;
        private System.Windows.Forms.ToolStripMenuItem Uye_islemleri;
        private System.Windows.Forms.ToolStripMenuItem Dergi_islemeri;
        private System.Windows.Forms.ToolStripMenuItem EmanetVerme;
        private System.Windows.Forms.ToolStripMenuItem EmanetAlma;
        private System.Windows.Forms.ToolStripMenuItem Kitap;
        private System.Windows.Forms.ToolStripMenuItem Dergi;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolStripMenuItem Silinenler;
        private System.Windows.Forms.ToolStripMenuItem Rezervasyonlar;
        private System.Windows.Forms.ToolStripMenuItem okunanlar;
    }
}