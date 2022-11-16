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
using System.Data.Sql;
using System.Net;
using System.Net.Mail;


namespace WindowsFormsApp1
{
    public partial class sifremiunuttum : Form
    {
        SqlConnection bağlantı = new SqlConnection("Data Source=MONSTER;Initial Catalog=Kullanici;Integrated Security=True");
        public sifremiunuttum()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("guvenlikkodugonderici@gmail.com", "2001fb601907i");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            MailMessage ePosta = new MailMessage();


            SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=VeriTabani;Integrated Security=True");
            baglanti.Open();
            string query = $"select Şifre from Tablo where Email='{textmail.Text}'";
            SqlCommand komut = new SqlCommand(query, baglanti);
            SqlDataReader reader;
            reader=komut.ExecuteReader();
            while (reader.Read())
            {
                ePosta.Body = $"Şifre : {reader[0].ToString()}";

            }




            ePosta.To.Add($"{textmail.Text}");
            ePosta.Subject = "Konu";

            ePosta.From = new MailAddress("3muharremcandan@gmail.com");

            // smtp.SendAsync(ePosta, (object)ePosta);
            smtp.Send(ePosta);

          




        }
        int sayac = 120;
        private void timer1_Tick(object sender, EventArgs e)
        {
                
                if (sayac == 0)
                {
                    timer1.Stop();
                    sayac = 120;
                    giriş.Hide();
                }
                label2.Text = sayac.ToString();
                sayac--;
           

        }
        
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sifremiunuttum_Load(object sender, EventArgs e)
        {

        }
       
        
        private void giriş_Click(object sender, EventArgs e)
        {
            
            if (textkod2.Text=="kod")
            {
                MessageBox.Show("Güvenlik Kodu Doğru","Başarılı");
                this.Close();
                otomasyon_ekranı oto = new otomasyon_ekranı();
                oto.Show();
            }
            else
            {
                MessageBox.Show("Onay Kodunuz yanlış","Hata");
                
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("12345");
            timer1.Start();
            giriş.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        bool tutus;
        int farex, farey;
        private void panelArkaPlan_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panelArkaPlan_MouseDown(object sender, MouseEventArgs e)
        {
           

        }

        private void textKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textKullaniciAdi_Enter(object sender, EventArgs e)
        {
          
        }

        private void textKullaniciAdi_Leave(object sender, EventArgs e)
        {
            
        }

        private void textSifre_Enter(object sender, EventArgs e)
        {
           
        }

        private void textSifre_Leave(object sender, EventArgs e)
        {
            
        }

        private void textSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == sayı.ToString())
            {
                MessageBox.Show("giriş başarılı");
                this.Close();
                otomasyon_ekranı oto = new otomasyon_ekranı();
                oto.ShowDialog();
            }
            else
            {
                MessageBox.Show("hatalı kod girdiniz");
            }
        }
        Random rdm = new Random();
        int sayı;
        private void button6_Click(object sender, EventArgs e)
        {
             sqlbağlantısı bağla = new sqlbağlantısı();
             SqlCommand komut = new SqlCommand("Select * from Kayit where E_mail='" + textBox1.Text.ToString() + "'", bağla.bağlantı());
             SqlDataReader oku = komut.ExecuteReader();

             sayı = rdm.Next(100000, 1000000);
             while (oku.Read())
             {
                 try
                 {
                     if (bağla.bağlantı().State == ConnectionState.Closed)
                     {
                         bağla.bağlantı().Open();
                     }
                     string say = Convert.ToString(sayı);
                     SmtpClient smtpserver = new SmtpClient();
                     MailMessage mail = new MailMessage();
                     String tarih = DateTime.Now.ToLongDateString();
                     String mailadresi = ("kodgonderici@outlook.com");
                     String sifre = ("2001fb601907i");
                     String smtpsrvr = "smtp.live.com";
                     String kime = ("kodgonderici@outlook.com");
                     String konu = ("yeni şifre");
                     String yaz = ("sayın ismail öztürk\n" + tarih + " Tarihinde şifrenizi unuttuğunuz için tek kullanımlık kodunuz" + "\n" + say + "\nkodunuzu gerekli alana giriniz ");
                     smtpserver.Credentials = new NetworkCredential(mailadresi, sifre);
                     smtpserver.Port = 25;
                     smtpserver.Host = smtpsrvr;
                     smtpserver.EnableSsl = false;
                     smtpserver.UseDefaultCredentials = false;
                     mail.From = new MailAddress(mailadresi);
                     mail.To.Add(kime);
                     mail.Subject = konu;
                     mail.Body = yaz;
                     DialogResult bilgi = new DialogResult();
                     bilgi = MessageBox.Show("tek kullanımlık kodunuz mail adresinize gönderilmiştir " + yaz);
                     smtpserver.Send(mail);
                     bağla.bağlantı().Close();
                     break;

                 }
                 catch (Exception Hata)
                 {
                     MessageBox.Show("mail gönderilemedi", Hata.Message);
                     break;
                  }}



       
        }
 System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            farex = 0;
            farey = 0;

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            farex = Cursor.Position.X - this.Left;
            farey = Cursor.Position.Y - this.Top;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - farex;
                this.Top = Cursor.Position.Y - farey;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void sifremiunuttum_Load_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
           

        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == " Kod")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textKod.Text = " Kod";
                textKod.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == " E-mail")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textEmail.Text = " E-mail";
                textEmail.ForeColor = Color.Silver;
            }
        }

        private void panelArkaPlan_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
