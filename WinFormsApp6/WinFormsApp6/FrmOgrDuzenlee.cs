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
    public partial class FrmOgrDuzenlee : Form
    {
        public FrmOgrDuzenlee()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        public string id,ad,soyad, TC, telefon, dogum, bolum;

        private void BtnOgrSil_Click(object sender, EventArgs e)
        {

            //ÖĞRENCİ SİL
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where Ogrid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", TxtOgrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Borlar Tablosundan Öğrenciyi Silme
            SqlCommand komutsill = new SqlCommand("delete from Borclar where Ogrid=@ogr1", bgl.baglanti());
            komutsill.Parameters.AddWithValue("@ogr1", TxtOgrid.Text);
            komutsill.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ÖĞRENCİ KAYDI BAŞARILI BİR ŞEKİLDE SİLİNDİ","İŞLEM BAŞARILI");

            //AKTİFLİK DURUMUNU DEĞİŞTİR
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);//se.tiğim odanın aktif öğrenci sayısını bir arttırır 
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public string mail, odano, veliad, velitel, adres;     

        private void FrmOgrDuzenlee_Load(object sender, EventArgs e)
        {
            TxtOgrid.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTC.Text = TC;
            MskOgrTelefon.Text = telefon;
            MskDogum.Text = dogum;
            CmbBolum.Text = bolum;
            TxtOgrMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = veliad;
            MskVeliTel.Text = velitel;
            RchAdres.Text = adres;


            //Bölümleri Listeleme Komutları 

            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();


            //Booş Odaları Listeleme Komutları

            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void BtnGuncel_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskTC.Text);
                komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", MskDogum.Text);
                komut.Parameters.AddWithValue("@p7", CmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", TxtOgrMail.Text);
                komut.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", MskVeliTel.Text);
                komut.Parameters.AddWithValue("@p12", RchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kayıt Güncellendi", "BİLDİRİM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Güncellenenemedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
