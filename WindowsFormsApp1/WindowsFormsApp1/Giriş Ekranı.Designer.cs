using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textEmail = new System.Windows.Forms.TextBox();
            this.giriş = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabelSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.checkBeniHatırla = new System.Windows.Forms.CheckBox();
            this.linkLabelKayıt = new System.Windows.Forms.LinkLabel();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.panelArkaPlan = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelArkaPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(78)))), ((int)(((byte)(135)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEmail.Location = new System.Drawing.Point(104, 137);
            this.textEmail.MaxLength = 50;
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEmail.Size = new System.Drawing.Size(216, 29);
            this.textEmail.TabIndex = 0;
            this.textEmail.Text = " E-mail";
            this.textEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textEmail.Enter += new System.EventHandler(this.textKullaniciAdi_Enter);
            this.textEmail.Leave += new System.EventHandler(this.textKullaniciAdi_Leave);
            // 
            // giriş
            // 
            this.giriş.BackColor = System.Drawing.Color.SteelBlue;
            this.giriş.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giriş.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.giriş.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.giriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.giriş.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.giriş.Location = new System.Drawing.Point(104, 344);
            this.giriş.Name = "giriş";
            this.giriş.Size = new System.Drawing.Size(216, 35);
            this.giriş.TabIndex = 3;
            this.giriş.Text = "Giriş";
            this.giriş.UseVisualStyleBackColor = false;
            this.giriş.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(288, 195);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(25, 27);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabelSifremiUnuttum
            // 
            this.linkLabelSifremiUnuttum.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabelSifremiUnuttum.AutoSize = true;
            this.linkLabelSifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelSifremiUnuttum.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabelSifremiUnuttum.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelSifremiUnuttum.LinkColor = System.Drawing.SystemColors.ScrollBar;
            this.linkLabelSifremiUnuttum.Location = new System.Drawing.Point(239, 242);
            this.linkLabelSifremiUnuttum.Name = "linkLabelSifremiUnuttum";
            this.linkLabelSifremiUnuttum.Size = new System.Drawing.Size(81, 13);
            this.linkLabelSifremiUnuttum.TabIndex = 7;
            this.linkLabelSifremiUnuttum.TabStop = true;
            this.linkLabelSifremiUnuttum.Text = "Şifremi Unuttum";
            this.linkLabelSifremiUnuttum.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabelSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link1_LinkClicked);
            // 
            // checkBeniHatırla
            // 
            this.checkBeniHatırla.AutoSize = true;
            this.checkBeniHatırla.BackColor = System.Drawing.Color.Transparent;
            this.checkBeniHatırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.checkBeniHatırla.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.checkBeniHatırla.Location = new System.Drawing.Point(104, 238);
            this.checkBeniHatırla.Name = "checkBeniHatırla";
            this.checkBeniHatırla.Size = new System.Drawing.Size(79, 17);
            this.checkBeniHatırla.TabIndex = 9;
            this.checkBeniHatırla.Text = "Beni Hatırla";
            this.checkBeniHatırla.UseVisualStyleBackColor = false;
            this.checkBeniHatırla.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // linkLabelKayıt
            // 
            this.linkLabelKayıt.ActiveLinkColor = System.Drawing.Color.MediumAquamarine;
            this.linkLabelKayıt.AutoSize = true;
            this.linkLabelKayıt.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.linkLabelKayıt.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelKayıt.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabelKayıt.Location = new System.Drawing.Point(263, 393);
            this.linkLabelKayıt.Name = "linkLabelKayıt";
            this.linkLabelKayıt.Size = new System.Drawing.Size(57, 17);
            this.linkLabelKayıt.TabIndex = 10;
            this.linkLabelKayıt.TabStop = true;
            this.linkLabelKayıt.Text = "Kayıt Ol";
            this.linkLabelKayıt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textSifre
            // 
            this.textSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(78)))), ((int)(((byte)(132)))));
            this.textSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSifre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textSifre.Location = new System.Drawing.Point(104, 197);
            this.textSifre.MaxLength = 50;
            this.textSifre.Multiline = true;
            this.textSifre.Name = "textSifre";
            this.textSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textSifre.Size = new System.Drawing.Size(216, 27);
            this.textSifre.TabIndex = 2;
            this.textSifre.Text = " Sifre";
            this.textSifre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textSifre.Enter += new System.EventHandler(this.textSifre_Enter);
            this.textSifre.Leave += new System.EventHandler(this.textSifre_Leave);
            // 
            // panelArkaPlan
            // 
            this.panelArkaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArkaPlan.AutoScroll = true;
            this.panelArkaPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(78)))), ((int)(((byte)(132)))));
            this.panelArkaPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelArkaPlan.Controls.Add(this.panel2);
            this.panelArkaPlan.Controls.Add(this.panel1);
            this.panelArkaPlan.Controls.Add(this.label2);
            this.panelArkaPlan.Controls.Add(this.linkLabelKayıt);
            this.panelArkaPlan.Controls.Add(this.checkBox1);
            this.panelArkaPlan.Controls.Add(this.giriş);
            this.panelArkaPlan.Controls.Add(this.textSifre);
            this.panelArkaPlan.Controls.Add(this.textEmail);
            this.panelArkaPlan.Controls.Add(this.label5);
            this.panelArkaPlan.Controls.Add(this.label3);
            this.panelArkaPlan.Controls.Add(this.label1);
            this.panelArkaPlan.Controls.Add(this.linkLabelSifremiUnuttum);
            this.panelArkaPlan.Controls.Add(this.checkBeniHatırla);
            this.panelArkaPlan.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelArkaPlan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelArkaPlan.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelArkaPlan.Location = new System.Drawing.Point(0, 0);
            this.panelArkaPlan.Name = "panelArkaPlan";
            this.panelArkaPlan.Size = new System.Drawing.Size(434, 509);
            this.panelArkaPlan.TabIndex = 16;
            this.panelArkaPlan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelArkaPlan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panelArkaPlan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panelArkaPlan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(57, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 29);
            this.panel2.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(57, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 29);
            this.panel1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(110, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "kayıtlı değil misin ?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(91, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 73);
            this.label5.TabIndex = 26;
            this.label5.Text = "______";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(122, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = "Giriş Ekranı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(91, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 73);
            this.label1.TabIndex = 27;
            this.label1.Text = "______";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(78)))), ((int)(((byte)(132)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(298, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 26);
            this.button3.TabIndex = 18;
            this.button3.Text = "━";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(78)))), ((int)(((byte)(132)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(343, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "□";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(78)))), ((int)(((byte)(132)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(388, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 26);
            this.button2.TabIndex = 20;
            this.button2.Text = "╳";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panelArkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelArkaPlan.ResumeLayout(false);
            this.panelArkaPlan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button giriş;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabelSifremiUnuttum;
        private System.Windows.Forms.CheckBox checkBeniHatırla;
        private System.Windows.Forms.LinkLabel linkLabelKayıt;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.Panel panelArkaPlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

