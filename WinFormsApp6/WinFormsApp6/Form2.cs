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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void BtnGuncel_Click(object sender, EventArgs e)
        {
            if (TxtYYAd.Text == "" || TxtYYSifre.Text == "")
            {
                MessageBox.Show("Alanlar Boş Geçilemez..");
            }
            else
            {
                string user;
                string password;
                user = TxtYYAd.Text;
                password = TxtYYSifre.Text;

                SqlCommand sorgu = new SqlCommand("select * from Admin where YoneticiAd='" + user + "'", bgl.baglanti());
                SqlDataReader oku = sorgu.ExecuteReader();
                if (oku.Read())
                {
                    oku.Close();
                    SqlCommand guncelle = new SqlCommand("update Admin set YoneticiSifre='" + password + "' where YoneticiAd='" + user + "'", bgl.baglanti());
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            TxtYYAd.Text = TxtYAd.Text;
        }

        private void BtnYGiris_Click(object sender, EventArgs e)
        {
            if (TxtYAd.Text == "" || TxtYSifre.Text == "")
            {
                MessageBox.Show("YÖNETİCİ ADI VE ŞİFRE BOŞ BIRAKILAMAZ LÜTFEN ALANLARIN DOLU OLDUĞUNDAN EMİN OLUN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                SqlCommand komutt = new SqlCommand("select * from Admin where YoneticiAd=@p1 and YoneticiSifre=@p2", bgl.baglanti());
                komutt.Parameters.AddWithValue("@p1", TxtYAd.Text);
                komutt.Parameters.AddWithValue("@p2", TxtYSifre.Text);
                SqlDataReader oku = komutt.ExecuteReader();

                if (oku.Read())
                {
                    FrmYoneticiAnaForm frm2 = new FrmYoneticiAnaForm();
                    frm2.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRE GİRDİNİZ", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtYAd.Clear();
                    TxtYSifre.Clear();
                    TxtYAd.Focus(); //imleci odaklar
                }
                bgl.baglanti().Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TxtYSifre.PasswordChar = '\0';  //karakteri göster
            }
            else
            {
                TxtYSifre.PasswordChar = '*';
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
