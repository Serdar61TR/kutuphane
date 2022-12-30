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
    public partial class yönetici_sayfası : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        public yönetici_sayfası()
        {
            InitializeComponent();
        }

        private void yönetici_sayfası_Load(object sender, EventArgs e)
        {
            
            listele();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Roller", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            AdSoyad.Text = Localization.Adsoyad;
            Eposta.Text = Localization.E_posta;
            Sifre.Text= Localization.Sifre;
            Tc.Text = Localization.Tc;
            Rol.Text= Localization.Rol;
            btn_guncelle.Text = Localization.btn_guncelle;
            btn_kaydet.Text = Localization.btn_uye_kayit;
            btn_sil.Text = Localization.btn_sil;

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Rol"]);


            }
            baglanti.Close();
        }
        public void listele()
        {
            baglanti.Open();
             da = new SqlDataAdapter("select*from kullanicilar", baglanti);
             dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            baglanti.Close();
            Datagridstyle();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kullanicilar(rol,ad_soyad,sifre,eposta,tc)values(@rol,@ad_soyad,@sifre,@eposta,@tc)",baglanti);
            komut.Parameters.AddWithValue("@rol", comboBox1.Text);
            komut.Parameters.AddWithValue("@ad_soyad", txt_AdSoyad.Text);
            komut.Parameters.AddWithValue("@sifre", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@eposta", txt_Eposta.Text);
            komut.Parameters.AddWithValue("@tc", txt_Tc.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı Eklendi");
            listele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder buildir = new SqlCommandBuilder(da);
            da.Update(dt);
            listele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"delete from kullanicilar where tc=@tc",baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi");
        }
        public void Datagridstyle()
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
            dataGridView1.Columns["rol"].HeaderText = "Rol";
            dataGridView1.Columns["ad_soyad"].HeaderText = "Ad Soyad";
            dataGridView1.Columns["sifre"].HeaderText = "Şifre";
            dataGridView1.Columns["eposta"].HeaderText = "Eposta";
            dataGridView1.Columns["tc"].HeaderText = "Tc";


        }
    }
}
