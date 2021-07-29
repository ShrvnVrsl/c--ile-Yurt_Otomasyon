using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp6
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            TxtYKAd.Text = TxtAdminAd.Text;
        }

        private void BtnGuncel_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || TxtYKAd.Text == "")
            {
                MessageBox.Show("Alanlar Boş Geçilemez..");
            }
            else
            { 
                string user;
                string password;
                user = TxtYKAd.Text;
                password = textBox2.Text;

                SqlCommand sorgu = new SqlCommand("select * from Kullanicilar where KullaniciAd='" + user + "'", bgl.baglanti());
                SqlDataReader oku = sorgu.ExecuteReader();
                if (oku.Read())
                {
                    oku.Close();
                    SqlCommand guncelle = new SqlCommand("update Kullanicilar set KullaniciSifre='" + password + "' where KullaniciAd='" + user + "'", bgl.baglanti());
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("ŞİFRE BAŞARIYLA GÜNCELLENDİ");
                }
                else
                    {
                    MessageBox.Show("Kullanıcı Adınız Hatalı Lütfen Başka Bir Kullanıcı Adı Deneyin..");
                     }
                bgl.baglanti().Close();
            }
        }

        private void BtnGirisYap_Click_1(object sender, EventArgs e)
        {
            if (TxtAdminAd.Text == "" || TxtSifre.Text == "")
            {
                MessageBox.Show("KULLANICI ADI VE ŞİFRE BOŞ BIRAKILAMAZ", "BİLGİLENDİRME");
            }
            else
            {
                string user;
                string password;
                user = TxtAdminAd.Text;
                password = TxtSifre.Text;

                SqlCommand komutt = new SqlCommand("select * from Kullanicilar where KullaniciAd='" + user + "' and KullaniciSifre='" + password + "'", bgl.baglanti());
                SqlDataReader oku = komutt.ExecuteReader();

                if (oku.Read())
                {
                    FrmAnaFormm frm1 = new FrmAnaFormm();
                    frm1.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRE GİRDİNİZ", "HATA!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                bgl.baglanti().Close();
            }
        }

        private void BtnAdminKayit_Click_1(object sender, EventArgs e)
        {

            if (TxtAdminAd.Text == "" || TxtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz");
            }
            else
            {
                string user;
                string password;
                user = TxtAdminAd.Text;
                password = TxtSifre.Text;

                SqlCommand komutt = new SqlCommand("select * from Kullanicilar where KullaniciAd='" + user + "' and KullaniciSifre='" + password + "'", bgl.baglanti());
                SqlDataReader oku = komutt.ExecuteReader();

                if (oku.Read())
                {
                    MessageBox.Show("Bu Kullanıcı Adı Zaten Kullanılıyor Lütfen Başka Bir Kullanıcı Adı Seçin...");
                }
                else
                {
                    oku.Close();
                    SqlCommand ekle = new SqlCommand("insert into Kullanicilar(KullaniciAd,KullaniciSifre)values('" + user + "','" + password + "')", bgl.baglanti());
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı ,Sisteme Yönlendiriliyorsunuz...");
                    FrmAnaFormm frm1 = new FrmAnaFormm();
                    frm1.ShowDialog();
                   
                }
                bgl.baglanti().Close();
            }
        }

        private void BtnYoneticiGiris_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void BtnBilgiAl_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("1)Kulllanıcı iseniz ve sistemde kaydınız zaten varsa bilgilerinizi girdikten sonra GİRİŞ yapabilirsiniz.  " + "\n" + 
                "2)Kulllanıcı iseniz ve sistemde kaydınız yoksa bilgilerinizi girdikten sonra KAYIT yapabilirsiniz" + "\n" +
                "3)Yönetici iseniz lütfen YÖNETİCİ GİRİŞİ yapınız ","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TxtSifre.PasswordChar = '\0';  //karakteri göster
            }
            else
            {
                TxtSifre.PasswordChar = '*';
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
