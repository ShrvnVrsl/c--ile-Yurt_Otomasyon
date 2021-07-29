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






namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection baglanti = new SqlConnection (@"Data Source=DESKTOP-KRI9USO;Initial Catalog=YurtKayıt;Integrated Security=True");
        SqlBaglantim bgl = new SqlBaglantim();

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgilerini Kaydetme Komutları
            try
            {
               
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", MskDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", CmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", TxtOgrMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", MskVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", RchAdres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi","BAŞARILI İŞLEM");



                //Öğrenci id'yi labela çekme
                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();



                //Öğrenci Borç Alanı Oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values(@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", TxtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", TxtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
                }
               catch (Exception)
                {
                    MessageBox.Show("HATA!!!  Lütfen yeniden deneyin");
                }



            //Öğrenci Oda Kontenanı Artırma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);//se.tiğim odanın aktif öğrenci sayısını bir arttırır 
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
