using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data.Sql;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection scn;
        SqlDataReader sdr;
        SqlCommand scm;
        public object CheckStake { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string E_mail = textEmail.Text;
            string Sifre = textSifre.Text;
            scn = new SqlConnection("Data Source=MONSTER;Initial Catalog=Kullanici;Integrated Security=True");
            scm = new SqlCommand();
            scn.Open();
            scm.Connection = scn;
            scm.CommandText = "Select * from Kayit where E_mail='" + textEmail.Text + "'and Sifre='" + textSifre.Text + "'";
            sdr = scm.ExecuteReader();
            if (sdr.Read())
            {
                MessageBox.Show("Girilen Bilgiler Doğru");
                otomasyon_ekranı frm = new otomasyon_ekranı();
                frm.ShowDialog();
            }
            else
            { 
                MessageBox.Show("Hatalı Şifre Veya Kullaıcı Adı !!!");
            }
            scn.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
               
                //checkBox işaretli ise
                if (checkBox1.Checked && textSifre.Text!=" Sifre" )
                {
                    textSifre.PasswordChar = '✱';
                }
                //değilse karakterlerin yerine * koy.
                else
                {
                    //karakteri göster.
                    textSifre.PasswordChar = '\0';
                }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiunuttum frm = new sifremiunuttum();
            frm.ShowDialog();
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Yeni_Kullanıcı_Sayfası frm = new Yeni_Kullanıcı_Sayfası();
            frm.ShowDialog();
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        bool tutus;
        int farex, farey;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus==true)
            {
                this.Left = Cursor.Position.X - farex;
                this.Top = Cursor.Position.Y - farey;
            }
        }
        
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            farex = 0;
            farey = 0;
        }
        bool ekran=true;
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (ekran)
            {
                WindowState = FormWindowState.Maximized;
                ekran = false;
            }else
            {
                WindowState = FormWindowState.Normal;
                ekran = true;
            }
            
        }

        private void textKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text==" E-mail")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.White;
            }
        }

        private void textKullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = " E-mail";
                textEmail.ForeColor = Color.Silver;
            }
        }

        private void textSifre_Enter(object sender, EventArgs e)
        {
            if (textSifre.Text == " Sifre")
            {
                textSifre.Text = "";
                textSifre.ForeColor = Color.White;
            }
        }

        private void textSifre_Leave(object sender, EventArgs e)
        {
            if (textSifre.Text == "")
            {
                textSifre.Text = " Sifre";
                textSifre.ForeColor = Color.Silver;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            farex = Cursor.Position.X - this.Left;
            farey = Cursor.Position.Y - this.Top;

        }
    }
}
