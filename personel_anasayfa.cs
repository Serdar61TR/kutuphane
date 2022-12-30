using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace küytüphane_otomasyonu
{
    public partial class personel_anasayfa : Form
    {
        public personel_anasayfa()
        {
            InitializeComponent();
                this.IsMdiContainer=true;
        }

        

        private void personel_anasayfa_Load(object sender, EventArgs e)
        {
            Kitap_islemleri.Text = Localization.Kitap_islemleri;
            Uye_islemleri.Text=Localization.Uye_islemleri;
            Dergi_islemeri.Text = Localization.Dergi_islemeri;
            EmanetVerme.Text = Localization.EmanetVerme;
            Kitap.Text = Localization.Kitap;
            Dergi.Text = Localization.Dergi2;
            EmanetAlma.Text= Localization.EmanetAlma;
            Silinenler.Text= Localization.Silinenler;
            Rezervasyonlar.Text= Localization.Rezervasyonlar;
            okunanlar.Text= Localization.okunanlar;
        }

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitap_islemleri Kitapİslemleri=new kitap_islemleri();
            Kitapİslemleri.MdiParent= this;
            Kitapİslemleri.Show();
           

        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_Uye_islemleri Uyeİslemleri = new Personel_Uye_islemleri();
            Uyeİslemleri.MdiParent= this;
            Uyeİslemleri.Show();
        }

        private void dergiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dergi_İslemleri dergi = new Dergi_İslemleri();
            dergi.MdiParent= this;
            dergi.Show();
        }

        private void emanetVermeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kitapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emanet_Kitap EmanetKitap=new Emanet_Kitap();
            EmanetKitap.MdiParent= this;
            EmanetKitap.Show();
        }

        private void dergiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emanet_Dergi EmanetDergi=new Emanet_Dergi(); 
            EmanetDergi.MdiParent= this;
            EmanetDergi.Show();
        }

        private void emanetAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetiAl EmanetiAl=new EmanetiAl();
            EmanetiAl.MdiParent= this;
            EmanetiAl.Show();
        }

        private void silinenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DergiSilinenler silinenler = new DergiSilinenler();
            silinenler.MdiParent= this;
            silinenler.Show();
        }

        private void rezervasyonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervasyonlar rez = new Rezervasyonlar();
            rez.MdiParent= this;
            rez.Show();
        }

        private void okunanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okunanlar oku = new okunanlar();
            oku.MdiParent= this;
            oku.Show();
        }
    }
}
