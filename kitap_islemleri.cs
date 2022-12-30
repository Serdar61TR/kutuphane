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
using System.ComponentModel.Design;

namespace küytüphane_otomasyonu
{
    public partial class kitap_islemleri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        public kitap_islemleri()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            

            DialogResult a;
            a = MessageBox.Show("Kayıt Eklensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
SqlCommand komut = new SqlCommand("insert into kitaplar(KitapAdi,YayinEvi,isbn_nu,Yazar,Turu,Rafno,Cevirmen) values(@kitapadi,@yayinevi,@isbn,@yazar,@turu,@rafno,@cevirmen)");
            komut.Connection = baglanti;
            baglanti.Open();

            komut.Parameters.AddWithValue("@kitapadi", txt_kitap.Text);
            komut.Parameters.AddWithValue("@yayinevi", txt_yayınEvi.Text);
            komut.Parameters.AddWithValue("@isbn", txt_barkod.Text);
            komut.Parameters.AddWithValue("@yazar", txt_yazar.Text);
            komut.Parameters.AddWithValue("@turu", cmb_tur.Text);
            komut.Parameters.AddWithValue("@rafno", txt_raf.Text);
            komut.Parameters.AddWithValue("@cevirmen", txt_cevirmen.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox textKontrol = (TextBox)item;
                        textKontrol.Clear();
                    }
                }
            }
            listeleme();
        }

        private void kitap_islemleri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from turler", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            Kitap.Text = Localization.Kitap;
            Yazarr.Text = Localization.Yazarr;
            YayinEvii.Text = Localization.YayinEvii;
            Turuu.Text = Localization.Turuu;
            Rafnoo.Text = Localization.Rafnoo;
            Cevirmenn.Text = Localization.Cevirmenn;
            btn_ekle.Text = Localization.btn_Ekle;
            btn_guncelle.Text= Localization.btn_guncelle;
            btn_sil.Text= Localization.btn_sil;
           



            while (dr.Read())
            {
                cmb_tur.Items.Add(dr["KitapTurleri"]);

               
            }
            baglanti.Close();
            listeleme();
            datagirdstyle();
        }
        public void listeleme()
        {
            
            baglanti.Open();
            
             da = new SqlDataAdapter("select*from kitaplar",baglanti);
             dt = new DataTable();
            dataGridView1.DataSource = dt;
            da.Fill(dt);
           
            baglanti.Close();
         }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            
            SqlCommandBuilder buildir = new SqlCommandBuilder(da);
            da.Update(dt);
            listeleme();
            datagirdstyle();
           
            






        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }
        public  void datagirdstyle()
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

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("select*from kitaplar where KitapAdi like'%" + txt_ara.Text + "%'", baglanti);
            adapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into SilinenKitaplar(KitapAdi,YayinEvi,isbn_nu,Yazar,Turu,Rafno,Cevirmen)values(@KitapAdi,@YayinEvi,@isbn_nu,@Yazar,@Turu,@Rafno,@Cevirmen)", baglanti);
            komut2.Parameters.AddWithValue("@KitapAdi", dataGridView1.Rows[secilensatir].Cells["KitapAdi"].Value);
            komut2.Parameters.AddWithValue("@YayinEvi", dataGridView1.Rows[secilensatir].Cells["YayinEvi"].Value);
            komut2.Parameters.AddWithValue("@isbn_nu", dataGridView1.Rows[secilensatir].Cells["isbn_nu"].Value);
            komut2.Parameters.AddWithValue("@Yazar", dataGridView1.Rows[secilensatir].Cells["Yazar"].Value);
            komut2.Parameters.AddWithValue("@Rafno", dataGridView1.Rows[secilensatir].Cells["Rafno"].Value);
            komut2.Parameters.AddWithValue("@Cevirmen", dataGridView1.Rows[secilensatir].Cells["Cevirmen"].Value);
            komut2.Parameters.AddWithValue("@Turu", dataGridView1.Rows[secilensatir].Cells["Turu"].Value);
            komut2.ExecuteNonQuery();
            baglanti.Close();



            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kitaplar where isbn_nu=@isbn",baglanti);
            komut.Parameters.AddWithValue("@isbn", dataGridView1.CurrentRow.Cells["isbn_nu"].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listeleme();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmb_tur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int secilensatir = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilensatir = e.RowIndex;
        }
    }
}
