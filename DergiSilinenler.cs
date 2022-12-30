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
    public partial class DergiSilinenler : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True"); 
        SqlDataAdapter da;
        DataTable dt;

        public DergiSilinenler()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DergiSilinenler_Load(object sender, EventArgs e)
        {
            listeleme();
           
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
            listeleme2();
            Kitapdatagirdstyle();

            
        }
        public void listeleme()
        {

            baglanti.Open();

            da = new SqlDataAdapter("select*from SilinenDergiler", baglanti);
            dt = new DataTable();
            dataGridView1.DataSource = dt;
            da.Fill(dt);

            baglanti.Close();
        }
        public void listeleme2()
        {

            baglanti.Open();

            da = new SqlDataAdapter("select*from SilinenKitaplar", baglanti);
            dt = new DataTable();
            dataGridView2.DataSource = dt;
            da.Fill(dt);

            baglanti.Close();
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
           


        }
    }
}
