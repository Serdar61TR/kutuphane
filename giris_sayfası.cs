using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using küytüphane_otomasyonu.Models;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using System.Reflection.Emit;

namespace küytüphane_otomasyonu
{
    public partial class giris_sayfası : Form
    {
        denemeEntitiesConnectionDb db = new denemeEntitiesConnectionDb();
        public static int tc;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");
        SqlDataReader dr ;
        public giris_sayfası()
        {
            InitializeComponent();
        }

       

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            uye_kayit kayit = new uye_kayit();
            kayit.Show();
            this.Hide();
        }

        private void btn_unuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum unuttum=new SifremiUnuttum();
            unuttum.Show();
        }

        public void metinyazdir()
        {
            label1.Text = Localization.E_posta;
            label2.Text = Localization.label2;
            btn_giris.Text = Localization.btn_giris;
            btn_kaydol.Text=Localization.btn_kaydol;
            btn_unuttum.Text = Localization.btn_unuttum;
            DilSecimi.Text = Localization.DilSecimi;
            
        }
        private void giris_sayfası_Load(object sender, EventArgs e)
        {
            metinyazdir();
            
        }
        public static long Tc;
        private string sifre;
        public void degistirilen()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kullanicilar where eposta=@eposta and sifre=@sifre", baglanti);
            komut.Parameters.AddWithValue("@eposta", txt_Eposta.Text);
            komut.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            dr = komut.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (Convert.ToString(dr["rol"]) == "admin")
                    {
                        yönetici_sayfası yönetici = new yönetici_sayfası();
                        yönetici.Show();
                    }
                    else if (Convert.ToString(dr["rol"]) == "personel")
                    {
                        var durum = db.kullanicilar.FirstOrDefault(x => x.eposta == txt_Eposta.Text && x.sifre == txt_sifre.Text);
                        Tc = durum.tc;
                        personel_anasayfa personel = new personel_anasayfa();
                        personel.Show();
                    }
                    else if (Convert.ToString(dr["rol"]) == "kullanıcı")
                    {
                        
                        var durum = db.kullanicilar.FirstOrDefault(x => x.eposta == txt_Eposta.Text && x.sifre == txt_sifre.Text);
                        
                        
                            Tc = durum.tc;
                            kullanici_Sayfasi kullanici_ = new kullanici_Sayfasi();
                            kullanici_.Show();

                        
                        
                    }


                }
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre yanlış");
            }
            baglanti.Close();
            
            
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("");
            metinyazdir();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("en-US");
            metinyazdir();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = "Degistirilen";
         
                }
    }
}
