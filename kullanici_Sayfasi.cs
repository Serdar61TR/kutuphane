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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace küytüphane_otomasyonu
{
    public partial class kullanici_Sayfasi : Form
    {
        public int secilenSatir = 0;
        denemeEntitiesConnectionDb db = new denemeEntitiesConnectionDb();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");
        SqlCommand komut;
      
        public kullanici_Sayfasi()
        {
            InitializeComponent();
        }

        private void kullanici_Sayfasi_Load(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kitaplar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            giris_sayfası giris = new giris_sayfası();
            giris.txt_Eposta.Text = label1.Text;
            long id = giris_sayfası.Tc;
            label1.Text = $@"{db.kullanicilar.FirstOrDefault(x => x.tc == giris_sayfası.Tc).ad_soyad}";
            label2.Text = $@"{db.kullanicilar.FirstOrDefault(x => x.tc == giris_sayfası.Tc).tc}";
            listeleme();
            DergiDAtagridstyle();
            Kitapdatagirdstyle();
            Rezz.Text = Localization.Rezz;
            Rez.Text = Localization.Rezz;
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into KitapRez (KitapAdi,isbn_nu,Alici,AliciTc,RezTarihi,YayinEvi,Yazar,Turu,Rafno,Cevirmen)values(@Kitap,@isbn,@Alici,@AliciTc,@RezTarihi,@YayinEvi,@Yazar,@Turu,@Rafno,@Cevirmen)", baglanti);
            komut.Parameters.AddWithValue("@Kitap", dataGridView1.Rows[secilenSatir].Cells["KitapAdi"].Value);
            komut.Parameters.AddWithValue("@isbn", dataGridView1.Rows[secilenSatir].Cells["isbn_nu"].Value);
            komut.Parameters.AddWithValue("@Cevirmen", dataGridView1.Rows[secilenSatir].Cells["Cevirmen"].Value);
            komut.Parameters.AddWithValue("@YayinEvi", dataGridView1.Rows[secilenSatir].Cells["YayinEvi"].Value);
            komut.Parameters.AddWithValue("@Yazar", dataGridView1.Rows[secilenSatir].Cells["Yazar"].Value);
            komut.Parameters.AddWithValue("@Turu", dataGridView1.Rows[secilenSatir].Cells["Turu"].Value);
            komut.Parameters.AddWithValue("@Rafno", dataGridView1.Rows[secilenSatir].Cells["Rafno"].Value);
            komut.Parameters.AddWithValue("@AliciTc", label2.Text);
            komut.Parameters.AddWithValue("@Alici", label1.Text);
            komut.Parameters.AddWithValue("@RezTarihi", DateTime.Now);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kitapdatagirdstyle();
            MessageBox.Show("Rezervasyonunuz yapılmıştır");
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into DergiRez(DergiAdi,issn,alici,RezTarihi,AliciTc,Yayin_tarihi,dili)values(@DergiAdi,@issn,@alici,@RezTarihi,@AliciTc,@Yayin_tarihi,@Dili)", baglanti);
            komut.Parameters.AddWithValue("@DergiAdi", dataGridView2.Rows[secilenSatir].Cells["dergi_adi"].Value);
            komut.Parameters.AddWithValue("@issn", dataGridView2.Rows[secilenSatir].Cells["issn"].Value);
            komut.Parameters.AddWithValue("@Yayin_tarihi", dataGridView2.Rows[secilenSatir].Cells["yayin_tarihi"].Value);
            komut.Parameters.AddWithValue("@Dili", dataGridView2.Rows[secilenSatir].Cells["dili"].Value);
            komut.Parameters.AddWithValue("@alici", label1.Text);
            komut.Parameters.AddWithValue("@RezTarihi", DateTime.Now);
            komut.Parameters.AddWithValue("@AliciTc", label2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            DergiDAtagridstyle();
            MessageBox.Show("Rezervasyonunuz yapılmıştır");
            

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenSatir = e.RowIndex;

        }
        public void listeleme()
        {

            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select*from dergiler ", baglanti);
            DataTable dt = new DataTable();
            dataGridView2.DataSource = dt;
            da.Fill(dt);

            baglanti.Close();
        }
        public void Kitapdatagirdstyle()
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
            dataGridView1.Columns["KitapAdi"].HeaderText = "Kitap Adı";
            dataGridView1.Columns["YayinEvi"].HeaderText = "Yayın Evi";
            dataGridView1.Columns["isbn_nu"].HeaderText = "ISBN";
            dataGridView1.Columns["Yazar"].HeaderText = "Yazar";
            dataGridView1.Columns["Turu"].HeaderText = "Türü";
            dataGridView1.Columns["Rafno"].HeaderText = "Rafno:";
            dataGridView1.Columns["Cevirmen"].HeaderText = "Çevirmen";
           


        }
        public void DergiDAtagridstyle()
        {
            dataGridView2.BorderStyle = BorderStyle.FixedSingle;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;

            dataGridView2.BackgroundColor = Color.DeepSkyBlue;
            dataGridView2.RowHeadersDefaultCellStyle.BackColor = Color.YellowGreen;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView2.DefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Columns["dergi_adi"].HeaderText = "Dergi Adı";
            dataGridView2.Columns["issn"].HeaderText = "ISSN";
            dataGridView2.Columns["yayin_tarihi"].HeaderText = "Yayın Tarihi";
            dataGridView2.Columns["dili"].HeaderText = "Dili";
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
