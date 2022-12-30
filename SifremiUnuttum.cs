using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using küytüphane_otomasyonu.Models;

namespace küytüphane_otomasyonu
{
    public partial class SifremiUnuttum : Form
    {
        MailGonder mg=new MailGonder();
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mg.Microsoft(txt_eposta.Text);
            MessageBox.Show("Girilen Bilgiler eşleşir ise şifreniz yenilenecek.", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            SifreAl.Text = Localization.SifreAl;
        }
    }
}
