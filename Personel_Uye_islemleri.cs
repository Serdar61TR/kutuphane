using küytüphane_otomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace küytüphane_otomasyonu
{
    public partial class Personel_Uye_islemleri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public Personel_Uye_islemleri()
        {
            InitializeComponent();
        }

        private void Personel_Uye_islemleri_Load(object sender, EventArgs e)
        {
            kayitgetir();
            datagirdstyle();
            AdiSoyadi.Text = Localization.AdiSoyadi;
            Tcc.Text = Localization.Tc;
            Dtarih.Text = Localization.Dtarih;
            Cinsiyett.Text = Localization.Cinsiyet;
            Telefon.Text= Localization.Telefon;
            Adress.Text= Localization.Adress;
            E_posta.Text= Localization.E_posta;
            btn_guncelle.Text= Localization.btn_guncelle;
            btn_sil.Text= Localization.btn_sil;
            btn_uye_ekle.Text = Localization.btn_Ekle;
        }
        

        public void datagirdstyle()
        {
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;



            dataGridView1.BackgroundColor = Color.DeepSkyBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.YellowGreen;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Columns["tc"].HeaderText = "Tc";
            dataGridView1.Columns["ad_soyad"].HeaderText = "Ad Soyad";
            dataGridView1.Columns["cinsiyet"].HeaderText = "Cinsiyet";
            dataGridView1.Columns["tel"].HeaderText = "Telefon";
            dataGridView1.Columns["adres"].HeaderText = "Adres";
            dataGridView1.Columns["eposta"].HeaderText = "eposta";
            





        }

        public void kayitgetir()
        {
            baglanti.Open();

            da = new SqlDataAdapter("Select*from uyeler", baglanti);
            dt = new DataTable();

            dataGridView1.DataSource = dt;
            da.Fill(dt);
            baglanti.Close();
        }
        [Obsolete]
        private void btn_uye_ekle_Click(object sender, EventArgs e)
        {

            DialogResult a;
            a = MessageBox.Show("Kayıt Eklensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
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
                SqlCommand komut2 = new SqlCommand("insert into kullanicilar (rol,ad_soyad,eposta,tc,sifre)values(@rol,@adsoyad,@eposta,@tc,@sifre)", baglanti);

                komut2.Parameters.AddWithValue("@adsoyad", txt_AdSoyad.Text);
                komut2.Parameters.AddWithValue("@eposta", txt_Email.Text);
                komut2.Parameters.AddWithValue("@tc", txt_Tc.Text);
                komut2.Parameters.Add("@rol", Convert.ToString("kullanıcı"));
                Random rndm = new Random();
                int sifre2 = rndm.Next(50, 100);
                komut2.Parameters.Add("@sifre", sifre2);

                komut2.ExecuteNonQuery();
                baglanti.Close();



                MailGonder mg = new MailGonder();
                mg.kayit(txt_Email.Text);
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox textKontrol = (TextBox)item;
                        textKontrol.Clear();
                    }
                }

            }
            kayitgetir();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder buildir = new SqlCommandBuilder(da);
            da.Update(dt);
            kayitgetir();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            //{
            //    baglanti.Open();
            //    SqlCommand komut = new SqlCommand("delete from uyeler where tc='" + dataGridView1.SelectedRows[i].Cells["tc"].Value.ToString() + "'", baglanti);



            //    komut.ExecuteNonQuery();

            //    baglanti.Close();
            //    kayitgetir();
            //}
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from uyeler where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            kayitgetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("select*from uyeler where tc like'%" + txt_arama.Text + "%'", baglanti);
            adapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
        }
    }
}

