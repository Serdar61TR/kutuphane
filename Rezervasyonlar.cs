using küytüphane_otomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace küytüphane_otomasyonu
{
    public partial class Rezervasyonlar : Form
    {SqlConnection baglanti =new SqlConnection(@"Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand komut;
        denemeEntitiesConnectionDb db = new denemeEntitiesConnectionDb();
        public Rezervasyonlar()
        {
            InitializeComponent();
        }

        private void Rezervasyonlar_Load(object sender, EventArgs e)
        {
            dergiler();
            long id = giris_sayfası.Tc;
            label1.Text = $@"{db.kullanicilar.FirstOrDefault(x => x.tc == giris_sayfası.Tc).ad_soyad}";
            kitaplar();
            Kitapdatagirdstyle();
            DergiDAtagridstyle();
            TeslimEt.Text = Localization.btn_TeslimEt;
            TeslimEtt.Text = Localization.btn_TeslimEt;
        }
        public void dergiler()
        {
            baglanti.Open();
            da = new SqlDataAdapter("select*from DergiRez",baglanti);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            baglanti.Close();

        }
        public void kitaplar()
        {
            baglanti.Open();
            da = new SqlDataAdapter("select*from KitapRez", baglanti);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource=dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            DialogResult a;
            a = MessageBox.Show("Dergi teslim edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a==DialogResult.Yes)
                {
                    baglanti.Open();
                    komut = new SqlCommand("insert into EmanetDergiler(alici,aliciTc,AliciTel,Dergi,issn,AlimTarihi,TeslimTarihi,Dili,YayinTarihi,TeslimEden)values(@alici,@AliciTc,@AliciTel,@Dergi,@issn,@AlimTarihi,@TeslimTarihi,@Dili,@YayinTarihi,@TeslimEden)",baglanti);
                    komut.Parameters.AddWithValue("@alici", dataGridView1.Rows[secilensatir].Cells["alici"].Value);
                    komut.Parameters.AddWithValue("@aliciTc", dataGridView1.Rows[secilensatir].Cells["AliciTc"].Value);
                    komut.Parameters.AddWithValue("@AliciTel", textBox1.Text);
                    komut.Parameters.AddWithValue("@Dergi", dataGridView1.Rows[secilensatir].Cells["DergiAdi"].Value);
                    komut.Parameters.AddWithValue("@issn", dataGridView1.Rows[secilensatir].Cells["issn"].Value);
                    komut.Parameters.AddWithValue("@AlimTarihi", DateTime.Now);
                    komut.Parameters.AddWithValue("@TeslimTarihi", DateTime.Now.AddDays(+15));
                    komut.Parameters.AddWithValue("@Dili", dataGridView1.Rows[secilensatir].Cells["Dili"].Value);
                    komut.Parameters.AddWithValue("@YayinTarihi", dataGridView1.Rows[secilensatir].Cells["Yayin_tarihi"].Value);
                    komut.Parameters.AddWithValue("@TeslimEden", label1.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete from dergiler where issn=@issn",baglanti);
                komut2.Parameters.AddWithValue("@issn", dataGridView1.Rows[secilensatir].Cells["issn"].Value);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("delete from DergiRez where issn=@issn",baglanti);
                komut3.Parameters.AddWithValue("@issn", dataGridView1.Rows[secilensatir].Cells["issn"].Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                DergiDAtagridstyle();
                dergiler();


            }
            
           


        }
        public int secilensatir = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilensatir = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            DialogResult a;
            a=MessageBox.Show("Kitap teslim edilsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (a==DialogResult.Yes)
            {
                
                komut = new SqlCommand("insert into EmanetKitaplar(alici,alici_tc,alici_tel,KitapAdi,isbn_nu,Yazar,Rafno,Turu,alim_tarihi,YayinEvi,teslim_tarihi,TeslimEden,Cevirmen)values(@alici,@alici_tc,@alici_tel,@kitap,@isbn_no,@yazari,@rafno,@kategori,@alim_tarihi,@yayin_evi,@teslim_tarihi,@TeslimEden,@Cevirmen)", baglanti);
                komut.Parameters.AddWithValue("@alici", dataGridView2.Rows[secilensatir].Cells["Alici"].Value);

                komut.Parameters.AddWithValue("@alici_tc", dataGridView2.Rows[secilensatir].Cells["AliciTc"].Value);
                komut.Parameters.AddWithValue("@alici_tel", textBox1.Text);
                komut.Parameters.AddWithValue("@kitap", dataGridView2.Rows[secilensatir].Cells["KitapAdi"].Value);
                komut.Parameters.AddWithValue("@isbn_no", dataGridView2.Rows[secilensatir].Cells["isbn_nu"].Value);
                komut.Parameters.AddWithValue("@yazari", dataGridView2.Rows[secilensatir].Cells["Yazar"].Value);
                komut.Parameters.AddWithValue("@rafno", dataGridView2.Rows[secilensatir].Cells["Rafno"].Value);
                komut.Parameters.AddWithValue("@kategori", dataGridView2.Rows[secilensatir].Cells["Turu"].Value);
                komut.Parameters.AddWithValue("@yayin_evi", dataGridView2.Rows[secilensatir].Cells["YayinEvi"].Value);
                komut.Parameters.AddWithValue("@Cevirmen", dataGridView2.Rows[secilensatir].Cells["Cevirmen"].Value);
                komut.Parameters.AddWithValue("@alim_tarihi", DateTime.Now);
                komut.Parameters.AddWithValue("@teslim_tarihi", DateTime.Now.AddDays(+15));
                komut.Parameters.AddWithValue("@TeslimEden", label1.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete from kitaplar where isbn_nu=@isbn", baglanti);
                komut2.Parameters.AddWithValue("@isbn", dataGridView2.Rows[secilensatir].Cells["isbn_nu"].Value);
                komut2.ExecuteNonQuery();
                
                baglanti.Close();
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("delete from KitapRez where isbn_nu=@isbn_nu", baglanti);
                komut3.Parameters.AddWithValue("@isbn_nu", dataGridView2.Rows[secilensatir].Cells["isbn_nu"].Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kitap teslim edildi");
                kitaplar();
                Kitapdatagirdstyle();
            }
           

        }
        public void Kitapdatagirdstyle()
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
            dataGridView2.Columns["KitapAdi"].HeaderText = "Kitap Adı";
            dataGridView2.Columns["YayinEvi"].HeaderText = "Yayın Evi";
            dataGridView2.Columns["isbn_nu"].HeaderText = "ISBN";
            dataGridView2.Columns["Yazar"].HeaderText = "Yazar";
            dataGridView2.Columns["Turu"].HeaderText = "Türü";
            dataGridView2.Columns["Rafno"].HeaderText = "Rafno:";
            dataGridView2.Columns["Cevirmen"].HeaderText = "Çevirmen";
            dataGridView2.Columns["Alici"].HeaderText = "Alıcı";
            dataGridView2.Columns["AliciTc"].HeaderText = "Alıcı Tc";
            dataGridView2.Columns["RezTarihi"].HeaderText = "Rezervasyon Tarihi";
            

        }
        public void DergiDAtagridstyle()
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
            dataGridView1.Columns["DergiAdi"].HeaderText = "Dergi Adı";
            dataGridView1.Columns["issn"].HeaderText = "ISSN";
            dataGridView1.Columns["Yayin_tarihi"].HeaderText = "Yayın Tarihi";
            dataGridView1.Columns["Dili"].HeaderText = "Dili";
            dataGridView1.Columns["alici"].HeaderText = "Alıcı";
            dataGridView1.Columns["AliciTc"].HeaderText = "Alıcı Tc";
            dataGridView1.Columns["RezTarihi"].HeaderText = "Rezervasyon Tarihi";

        }
    }
}
