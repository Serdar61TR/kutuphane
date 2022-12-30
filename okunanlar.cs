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
    public partial class okunanlar : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D66A5JR;Initial Catalog=deneme;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        public okunanlar()
        {
            InitializeComponent();
        }

        private void okunanlar_Load(object sender, EventArgs e)
        {
            dergi();
            kitap();
            Kitapdatagirdstyle();
            DergiDAtagridstyle();
        }
        public void kitap()
        {

            baglanti.Open();

            da = new SqlDataAdapter("select*from OkunanKitaplar", baglanti);
            dt = new DataTable();
            dataGridView1.DataSource = dt;
            da.Fill(dt);

            baglanti.Close();
        }
        public void dergi()
        {

            baglanti.Open();

            da = new SqlDataAdapter("select*from OkunanDergiler", baglanti);
            dt = new DataTable();
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
        }
    }
   
    }
