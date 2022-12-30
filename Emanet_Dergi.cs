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
    public partial class Emanet_Dergi : Form
    {
        denemeEntitiesConnectionDb db = new denemeEntitiesConnectionDb();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable dt;
        public Emanet_Dergi()
        {
            InitializeComponent();
        }
        public int secilensatir = 0;
        private void Emanet_Dergi_Load(object sender, EventArgs e)
        {
            listeleme();
            long id = giris_sayfası.Tc;
            label4.Text = $@"{db.kullanicilar.FirstOrDefault(x => x.tc == giris_sayfası.Tc).ad_soyad}";
            DergiDAtagridstyle();
            Alici.Text = Localization.Alici;
            AliciTc.Text = Localization.AliciTc;
            AliciTel.Text= Localization.AliciTel;
           btn_ver.Text= Localization.btn_TeslimEt;
        }
        public void listeleme()
        {

            baglanti.Open();

            da = new SqlDataAdapter("select*from dergiler", baglanti);
            dt = new DataTable();
            dataGridView1.DataSource = dt;
            da.Fill(dt);

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Dergi teslim edilisin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a==DialogResult.Yes)
            {
                baglanti.Open();
                komut = new SqlCommand("insert into EmanetDergiler(alici,AliciTc,AliciTel,Dergi,issn,AlimTarihi,TeslimTarihi,Dili,YayinTarihi,TeslimEden)values(@alici,@AliciTc,@AliciTel,@Dergi,@issn,@AlimTarihi,@TeslimTarihi,@Dili,@YayinTarihi,@TeslimEden)", baglanti);
                komut.Parameters.AddWithValue("@alici", txt_AdSoyad.Text);
                komut.Parameters.AddWithValue("@issn", dataGridView1.Rows[secilensatir].Cells["issn"].Value);
                komut.Parameters.AddWithValue("@AliciTc", txt_tc.Text);
                komut.Parameters.AddWithValue("@AliciTel", txt_tel.Text);
                komut.Parameters.AddWithValue("@Dergi", dataGridView1.Rows[secilensatir].Cells["dergi_adi"].Value);
                komut.Parameters.AddWithValue("@Dili", dataGridView1.Rows[secilensatir].Cells["dili"].Value);
                komut.Parameters.AddWithValue("@YayinTarihi", dataGridView1.Rows[secilensatir].Cells["yayin_tarihi"].Value);
                komut.Parameters.AddWithValue("@AlimTarihi", DateTime.Now);
                komut.Parameters.AddWithValue("@TeslimTarihi", DateTime.Now.AddDays(+15));
                komut.Parameters.AddWithValue("@TeslimEden", label4.Text);
               
                komut.ExecuteNonQuery();
                MessageBox.Show("Teslim edildi");
                baglanti.Close();
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete from dergiler where issn=@issn",baglanti);
                komut2.Parameters.AddWithValue("@issn", dataGridView1.Rows[secilensatir].Cells["issn"].Value);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                listeleme();
            }
           
            DergiDAtagridstyle();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilensatir = e.RowIndex;
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
            dataGridView1.Columns["dergi_adi"].HeaderText = "Dergi Adı";
            dataGridView1.Columns["issn"].HeaderText = "ISSN";
            dataGridView1.Columns["yayin_tarihi"].HeaderText = "Yayın Tarihi";
            dataGridView1.Columns["dili"].HeaderText = "Dili";
          

        }
    }
}
