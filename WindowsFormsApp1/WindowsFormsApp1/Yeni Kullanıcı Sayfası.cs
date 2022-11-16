using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Yeni_Kullanıcı_Sayfası : Form
    {
        SqlConnection bağlanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=VeriTabani;Integrated Security=True");
        public Yeni_Kullanıcı_Sayfası()
        {
            InitializeComponent();
        }

        private void Yeni_Kullanıcı_Sayfası_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=Kullanici;Integrated Security=True");
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textSifre.Text==null||textAd.Text==null||textSoyad.Text==null)   
            {
                if (textSifre.Text==textSifreOnay.Text)
            {
                baglanti.Open();
                string Ad=textAd.Text, Soyad=textSoyad.Text, Kullanici_Adi=textKullaniciAdi.Text, Sifre=textSifre.Text, E_mail=textEmail.Text, Tarih=dateTimeTarih.Text;
                SqlCommand komut = new SqlCommand("select * from Kayit where Kullanici_Adi='"+Kullanici_Adi+"'",baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                SqlCommand komut1 = new SqlCommand("select * from Kayit where E_mail='" +E_mail + "'", baglanti);
                SqlDataReader oku1 = komut1.ExecuteReader();
                    if (oku.Read())
                    {
                        MessageBox.Show("bu kullanıcı adı kullanılıyor lütfen başka bir kullanıcı adı deneyiniz");
                    }
                    else if(oku1.Read())
                    {
                        MessageBox.Show("bu mail kullanılıyor lütfen başka bir kullanıcı adı deneyiniz");
                    }
                      
                    else
                    {
                        oku.Close();
                        SqlCommand ekle = new SqlCommand("insert into Kayit(Ad,Soyad,Kullanici_Adi,Sifre,E_mail,Tarih) values('"+Ad+"','"+Soyad+"','"+Kullanici_Adi+"','"+Sifre+"','"+E_mail+"','"+Tarih+"')",baglanti);
                        ekle.ExecuteNonQuery();
                        MessageBox.Show("Kayıdınız başarılı");
                    }
                    bağlanti.Close();
                
            }
            else
            {
                MessageBox.Show("Girilen şifreler birbirleri ile uyuşmuyorlar lütfen tekrar giriniz");
            }

            }
            else
            {
                MessageBox.Show("lütfen boş kısımları dolduralım");

            }
           
            
           
        }
        

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        bool tutus;
        int farex, farey;
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

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            farex = 0;
            farey = 0;
        }
    }
}

