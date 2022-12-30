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

namespace küytüphane_otomasyonu
{
    public partial class uye_kayit : Form
    {
        SqlConnection baglanti= new SqlConnection(@"Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");

        public uye_kayit()
        {
            InitializeComponent();
        }
       
        [Obsolete]
        private void btn_uye_kayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into uyeler(tc,ad_soyad,d_tarihi,cinsiyet,tel,adres,eposta) values(@tc,@adsoyad,@dtarih,@cinsiyet,@tel,@adres,@e_posta)");
            komut.Connection = baglanti;
            baglanti.Open();
            komut.Parameters.AddWithValue("@tc", txt_Tc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txt_AdSoyad.Text);
            komut.Parameters.AddWithValue("@dtarih", Convert.ToDateTime(txt_tarih.Text));
            komut.Parameters.AddWithValue("@cinsiyet", cmb_Cinsiyet.Text);
            komut.Parameters.AddWithValue("@tel", txt_Tel.Text);
            komut.Parameters.AddWithValue("@adres", txt_Adres.Text);
            komut.Parameters.AddWithValue("@e_posta", txt_Email.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into kullanicilar (rol,ad_soyad,sifre,eposta,tc)values(@rol,@adsoyad,@sifre,@eposta,@tc)", baglanti);
            
            komut2.Parameters.AddWithValue("@adsoyad", txt_AdSoyad.Text);
            komut2.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            komut2.Parameters.AddWithValue("@eposta", txt_Email.Text);
            komut2.Parameters.AddWithValue("@tc", txt_Tc.Text);
            komut2.Parameters.Add("@rol", Convert.ToString("kullanıcı"));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız başarıyla oluşturumuştur");
            giris_sayfası giris = new giris_sayfası();
            giris.Show();
            this.Hide();
            baglanti.Close();
          
            
           
        }

        private void uye_kayit_Load(object sender, EventArgs e)
        {
            Tcc.Text = Localization.Tc;
            Adsoyad.Text = Localization.Adsoyad;
            Adres.Text= Localization.Adres;
            Sifre.Text= Localization.Sifre;
            Dtarih.Text= Localization.Dtarih;
            Cinsiyet.Text= Localization.Cinsiyet;
            Telefon.Text= Localization.Telefon;
            E_posta.Text= Localization.E_posta;
            btn_uye_kayit.Text = Localization.btn_uye_kayit;

        }

        private void txt_Tc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
            
    }
}
