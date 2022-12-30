using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using küytüphane_otomasyonu.Models;

namespace küytüphane_otomasyonu.Models
{
    internal class MailGonder
    {
        denemeEntitiesConnectionDb db=new denemeEntitiesConnectionDb();
        public void Microsoft(/*string GondericiMail, string GondericiSifre,*/ string AliciMail)
        {
            string GondericiMail = "asdserdar147serdar@hotmail.com";
            string GondericiSifre = "36463661Ts";
            kullanicilar p = db.kullanicilar.FirstOrDefault(x => x.eposta == AliciMail);
            Random rnd = new Random();
            p.sifre = rnd.Next(1000, 10000).ToString();
            db.SaveChanges();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(GondericiMail, GondericiSifre);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail, "KİTABHANE ŞİFRE YENİLEME");
            mail.To.Add(AliciMail);
            mail.Subject = "Şifre Sıfırlama Talebinde Bulundunuz";
            mail.IsBodyHtml = true;
            mail.Body = $@"Şifre sıfırlama talebinde bulundunuz. Yeni Şifreniz{p.sifre}";
            sc.Send(mail);


        }
        public void kayit(/*string GondericiMail, string GondericiSifre,*/ string AliciMail)
        {
            string GondericiMail = "asdserdar147serdar@hotmail.com";
            string GondericiSifre = "36463661Ts";
            kullanicilar p = db.kullanicilar.FirstOrDefault(x => x.eposta == AliciMail);
            Random rnd = new Random();
            p.sifre = rnd.Next(1000, 10000).ToString();
            db.SaveChanges();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(GondericiMail, GondericiSifre);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail, "KİTABHANE HOŞGELDİNİZ");
            mail.To.Add(AliciMail);
            mail.Subject = "Aramıza Hoşgeldiniz";
            mail.IsBodyHtml = true;
            mail.Body = $@" Şifreniz{p.sifre}";
            sc.Send(mail);


        }
    }
}
