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
    public partial class Dergi_İslemleri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable dt;
        
        public Dergi_İslemleri()
        {
            InitializeComponent();
        }

        private void Dergi_İslemleri_Load(object sender, EventArgs e)
        {
            listeleme();
            DergiDAtagridstyle();
            dergi.Text = Localization.dergi;
            YayinTarihi.Text = Localization.YayinTarihi;
            Dil.Text = Localization.Dil;
            btn_Ekle.Text= Localization.btn_Ekle;
            btn_guncelle.Text= Localization.btn_guncelle;
            btn_sil.Text= Localization.btn_sil;
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

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut =new SqlCommand("insert into dergiler(issn,dergi_adi,dili,yayin_tarihi)values(@issn,@dergi_adi,@dili,@yayin_tarihi)",baglanti);
            komut.Parameters.AddWithValue("@issn", txt_issn.Text);
            komut.Parameters.AddWithValue("@dergi_adi", txt_DergiAdi.Text);
            komut.Parameters.AddWithValue("@dili", txt_Dili.Text);
            komut.Parameters.AddWithValue("@yayin_tarihi", txt_YayinTarihi.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Dergi eklendi");
            baglanti.Close();
            DergiDAtagridstyle();
            listeleme();

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder buildir = new SqlCommandBuilder(da);
            da.Update(dt);
            listeleme();
        }
        public int secilensatir = 0;
        private void btn_sil_Click(object sender, EventArgs e)
        {
            
            DialogResult a;
            a = MessageBox.Show("Kayıt silinsinmi", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (a == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("insert into SilinenDergiler(issn,dergi_adi,dili,yayin_tarihi)values(@issn,@dergi_adi,@dili,@yayin_tarihi)", baglanti);
                komut2.Parameters.AddWithValue("@issn", dataGridView1.Rows[secilensatir].Cells["issn"].Value);
                komut2.Parameters.AddWithValue("@dergi_adi", dataGridView1.Rows[secilensatir].Cells["dergi_adi"].Value);
                komut2.Parameters.AddWithValue("@dili", dataGridView1.Rows[secilensatir].Cells["dili"].Value);
                komut2.Parameters.AddWithValue("@yayin_tarihi", dataGridView1.Rows[secilensatir].Cells["yayin_tarihi"].Value);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("delete from dergiler where issn=@issn",baglanti);
                komut.Parameters.AddWithValue("@issn", dataGridView1.Rows[secilensatir].Cells["issn"].Value);
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
            listeleme();
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
            dataGridView1.Columns["dergi_Adi"].HeaderText = "Dergi Adı";
            dataGridView1.Columns["issn"].HeaderText = "ISSN";
            dataGridView1.Columns["yayin_tarihi"].HeaderText = "Yayın Tarihi";
            dataGridView1.Columns["dili"].HeaderText = "Dili";
            

        }
    }
}
