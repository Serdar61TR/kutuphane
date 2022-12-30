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
    public partial class EmanetiAl : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");
        SqlCommand komut;
        public EmanetiAl()
        {
            InitializeComponent();
        }

        private void EmanetiAl_Load(object sender, EventArgs e)
        {
            kitap();
            dergiler();
            Kitapdatagirdstyle();
            DergiDAtagridstyle();
        }
        int secilensatir = 0;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilensatir = e.RowIndex;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Kitap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into kitaplar(KitapAdi,YayinEvi,isbn_nu,Yazar,Turu,Rafno,Cevirmen)values(@KitapAdi,@YayinEvi,@isbn_nu,@Yazar,@Turu,@Rafno,@Cevirmen)", baglanti);
            komut.Parameters.AddWithValue("@KitapAdi", dataGridView1.Rows[secilensatir].Cells["KitapAdi"].Value);
            komut.Parameters.AddWithValue("@YayinEvi", dataGridView1.Rows[secilensatir].Cells["YayinEvi"].Value);
            komut.Parameters.AddWithValue("@isbn_nu", dataGridView1.Rows[secilensatir].Cells["isbn_nu"].Value);
            komut.Parameters.AddWithValue("@Yazar", dataGridView1.Rows[secilensatir].Cells["Yazar"].Value);
            komut.Parameters.AddWithValue("@Turu", dataGridView1.Rows[secilensatir].Cells["Turu"].Value);
            komut.Parameters.AddWithValue("@Rafno", dataGridView1.Rows[secilensatir].Cells["Rafno"].Value);
            komut.Parameters.AddWithValue("@Cevirmen", dataGridView1.Rows[secilensatir].Cells["Cevirmen"].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into OkunanKitaplar(Alici,AliciTc,KitapAdi,isbn_nu,Yazar,Rafno,Turu,YayinEvi,Cevirmen,AlimTarihi,TeslimEdecegiTarih,TeslimEdilenTarih)values(@Alici,@AliciTc,@KitapAdi,@isbn_nu,@Yazar,@Rafno,@Turu,@YayinEvi,@Cevirmen,@AlimTarihi,@TeslimEdecegiTarih,@TeslimEdilenTarih)", baglanti);
            komut2.Parameters.AddWithValue("@Alici", dataGridView1.Rows[secilensatir].Cells["alici"].Value);
            komut2.Parameters.AddWithValue("@AliciTc", dataGridView1.Rows[secilensatir].Cells["alici_tc"].Value);
            komut2.Parameters.AddWithValue("@KitapAdi", dataGridView1.Rows[secilensatir].Cells["KitapAdi"].Value);
            komut2.Parameters.AddWithValue("@isbn_nu", dataGridView1.Rows[secilensatir].Cells["isbn_nu"].Value);
            komut2.Parameters.AddWithValue("@Yazar", dataGridView1.Rows[secilensatir].Cells["Yazar"].Value);
            komut2.Parameters.AddWithValue("@Turu", dataGridView1.Rows[secilensatir].Cells["turu"].Value);
            komut2.Parameters.AddWithValue("@AlimTarihi", dataGridView1.Rows[secilensatir].Cells["alim_tarihi"].Value);
            komut2.Parameters.AddWithValue("@TeslimEdecegiTarih", dataGridView1.Rows[secilensatir].Cells["teslim_tarihi"].Value);
            komut2.Parameters.AddWithValue("@TeslimEdilenTarih", DateTime.Now);
            komut2.Parameters.AddWithValue("@Rafno", dataGridView1.Rows[secilensatir].Cells["Rafno"].Value);
            komut2.Parameters.AddWithValue("@YayinEvi", dataGridView1.Rows[secilensatir].Cells["YayinEvi"].Value);
            komut2.Parameters.AddWithValue("@Cevirmen", dataGridView1.Rows[secilensatir].Cells["Cevirmen"].Value);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from EmanetKitaplar where isbn_nu=@isbn_nu", baglanti);
            komut3.Parameters.AddWithValue("@isbn_nu", dataGridView1.Rows[secilensatir].Cells["isbn_nu"].Value);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Alındı");
            kitap();
            Kitapdatagirdstyle();


        }
        public void kitap()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from EmanetKitaplar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void dergiler()
        {
            baglanti.Open();
           SqlDataAdapter da = new SqlDataAdapter("select*from EmanetDergiler", baglanti);
           DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilensatir = e.RowIndex;
        }

        private void btn_dergi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into dergiler(issn,dergi_adi,dili,yayin_tarihi)values(@issn,@dergi_adi,@dili,@yayin_tarihi)",baglanti);
            komut.Parameters.AddWithValue("@issn", dataGridView2.Rows[secilensatir].Cells["issn"].Value);
            komut.Parameters.AddWithValue("@dergi_adi", dataGridView2.Rows[secilensatir].Cells["Dergi"].Value);
            komut.Parameters.AddWithValue("@dili", dataGridView2.Rows[secilensatir].Cells["Dili"].Value);
            komut.Parameters.AddWithValue("yayin_tarihi", dataGridView2.Rows[secilensatir].Cells["YayinTarihi"].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into OkunanDergiler(Alici,AliciTc,Dergi,issn,Dili,YayinTarihi,AlimTarihi,TeslimEdecegiTarih,TeslimEdilenTarih)values(@Alici,@AliciTc,@Dergi,@issn,@Dili,@YayinTarihi,@AlimTarihi,@TeslimEdecegiTarih,@TeslimEdilenTarih)", baglanti);
            komut2.Parameters.AddWithValue("@Alici", dataGridView2.Rows[secilensatir].Cells["alici"].Value);
            komut2.Parameters.AddWithValue("@AliciTc", dataGridView2.Rows[secilensatir].Cells["AliciTc"].Value);
            komut2.Parameters.AddWithValue("@Dergi", dataGridView2.Rows[secilensatir].Cells["Dergi"].Value);
            komut2.Parameters.AddWithValue("@issn", dataGridView2.Rows[secilensatir].Cells["issn"].Value);
            komut2.Parameters.AddWithValue("@YayinTarihi", dataGridView2.Rows[secilensatir].Cells["YayinTarihi"].Value);
            komut2.Parameters.AddWithValue("@AlimTarihi", dataGridView2.Rows[secilensatir].Cells["AlimTarihi"].Value);
            komut2.Parameters.AddWithValue("@TeslimedecegiTarih", dataGridView2.Rows[secilensatir].Cells["TeslimTarihi"].Value);
            komut2.Parameters.AddWithValue("@TeslimEdilenTarih", DateTime.Now);
            komut2.Parameters.AddWithValue("@Dili", dataGridView2.Rows[secilensatir].Cells["Dili"].Value);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from EmanetDergiler where issn=@issn",baglanti);
            komut3.Parameters.AddWithValue("@issn", dataGridView2.Rows[secilensatir].Cells["issn"].Value);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Dergi Alındı");
            dergiler();
            DergiDAtagridstyle();
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
            dataGridView1.Columns["alici"].HeaderText = "Alıcı";
            dataGridView1.Columns["alici_tc"].HeaderText = "Alıcı Tc";
            dataGridView1.Columns["TeslimEden"].HeaderText = "Teslim Eden";
            dataGridView1.Columns["alici_tel"].HeaderText = "Alıcı Telefon";
            dataGridView1.Columns["alim_tarihi"].HeaderText = "Alım Tarihi";
            dataGridView1.Columns["teslim_tarihi"].HeaderText = "Teslim Tarihi";

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
            dataGridView2.Columns["Dergi"].HeaderText = "Dergi Adı";
            dataGridView2.Columns["issn"].HeaderText = "ISSN";
            dataGridView2.Columns["YayinTarihi"].HeaderText = "Yayın Tarihi";
            dataGridView2.Columns["Dili"].HeaderText = "Dili";
            dataGridView2.Columns["Alici"].HeaderText = "Alıcı";
            dataGridView2.Columns["AliciTc"].HeaderText = "Alıcı Tc";
            dataGridView2.Columns["AliciTel"].HeaderText = "AlıcıTel";
            dataGridView2.Columns["AlimTarihi"].HeaderText = "Alım Tarihi";
            dataGridView2.Columns["TeslimTarihi"].HeaderText = "Teslim Tarihi";
            dataGridView2.Columns["TeslimEden"].HeaderText = "Teslim Eden";

        }
    }
}
