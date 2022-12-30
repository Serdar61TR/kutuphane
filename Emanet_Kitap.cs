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

namespace küytüphane_otomasyonu
{
    public partial class Emanet_Kitap : Form

    {
        denemeEntitiesConnectionDb db = new denemeEntitiesConnectionDb();
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");
        SqlCommand komut;
        public Emanet_Kitap()
        {
            InitializeComponent();
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
            dataGridView1.Columns["KitapAdi"].HeaderText = "Kitap Adı";
            dataGridView1.Columns["YayinEvi"].HeaderText = "Yayın Evi";
            dataGridView1.Columns["isbn_nu"].HeaderText = "ISBN";
            dataGridView1.Columns["yazar"].HeaderText = "Yazar";
            dataGridView1.Columns["turu"].HeaderText = "Türü";
            dataGridView1.Columns["rafno"].HeaderText = "Rafno:";
            dataGridView1.Columns["cevirmen"].HeaderText = "Çevirmen";

        }

        public void listeleme()
        {

            baglanti.Open();

            da = new SqlDataAdapter("select*from kitaplar", baglanti);
            dt = new DataTable();
            dataGridView1.DataSource = dt;
            da.Fill(dt);

            baglanti.Close();





        }
        

        private void Emanet_Kitap_Load(object sender, EventArgs e)
        {
            listeleme();
            long id = giris_sayfası.Tc;
            txt_personel.Text = $@"{db.kullanicilar.FirstOrDefault(x => x.tc == giris_sayfası.Tc).ad_soyad}";

            datagirdstyle();
            Alici.Text = Localization.Alici;
            AliciTc.Text = Localization.AliciTc;
            AliciTel.Text = Localization.AliciTel;
            button1.Text= Localization.btn_TeslimEt;

        }

        public int secilensatir = 0;
        

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Dergi teslim edilisin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                baglanti.Open();
                komut = new SqlCommand("insert into EmanetKitaplar(alici,alici_tc,alici_tel,KitapAdi,isbn_nu,Yazar,Rafno,Turu,alim_tarihi,YayinEvi,teslim_tarihi,TeslimEden,Cevirmen)values(@alici,@alici_tc,@alici_tel,@kitap,@isbn_no,@yazari,@rafno,@kategori,@alim_tarihi,@yayin_evi,@teslim_tarihi,@TeslimEden,@Cevirmen)", baglanti);
                komut.Parameters.AddWithValue("@alici", txt_AdSoyad.Text);

                komut.Parameters.AddWithValue("@alici_tc", txt_tc.Text);
                komut.Parameters.AddWithValue("@alici_tel", txt_tel.Text);
                komut.Parameters.AddWithValue("@kitap", dataGridView1.Rows[secilensatir].Cells["KitapAdi"].Value);
                komut.Parameters.AddWithValue("@isbn_no", dataGridView1.Rows[secilensatir].Cells["isbn_nu"].Value);
                komut.Parameters.AddWithValue("@yazari", dataGridView1.Rows[secilensatir].Cells["Yazar"].Value);
                komut.Parameters.AddWithValue("@rafno", dataGridView1.Rows[secilensatir].Cells["Rafno"].Value);
                komut.Parameters.AddWithValue("@kategori", dataGridView1.Rows[secilensatir].Cells["Turu"].Value);
                komut.Parameters.AddWithValue("@yayin_evi", dataGridView1.Rows[secilensatir].Cells["YayinEvi"].Value);
                komut.Parameters.AddWithValue("@Cevirmen", dataGridView1.Rows[secilensatir].Cells["Cevirmen"].Value);
                komut.Parameters.AddWithValue("@alim_tarihi", DateTime.Now);
                komut.Parameters.AddWithValue("@teslim_tarihi", DateTime.Now.AddDays(+15));
                komut.Parameters.AddWithValue("@TeslimEden", txt_personel.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete from kitaplar where isbn_nu=@isbn", baglanti);
                komut2.Parameters.AddWithValue("@isbn", dataGridView1.CurrentRow.Cells["isbn_nu"].Value);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Kitap teslim edildi");
                baglanti.Close();
                listeleme();
            }
                
            datagirdstyle();


        }
        
private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilensatir = e.RowIndex;
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("select*from kitaplar where KitapADi like'%" + txt_ara.Text + "%'", baglanti);
            adapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
        }
    }

}
