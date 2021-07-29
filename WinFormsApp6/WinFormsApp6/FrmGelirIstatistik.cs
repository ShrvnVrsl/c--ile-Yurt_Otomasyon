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
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {
            //Kasadaki Toplam Para
            SqlCommand komut = new SqlCommand("Select Sum(OdemeMiktar) from Kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblPara.Text = oku[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //Ayları Tekrarsız Getirme
            SqlCommand komut2 = new SqlCommand("Select distinct(OdemeAy) From Kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbPara.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();


        }

        private void CmbPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Select sum(OdemeMiktar) From Kasa Where OdemeAy=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbPara.Text);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAy.Text = oku3[0].ToString() + "TL";
            }
            bgl.baglanti().Close();



            //Comboboxsa göre Datagridi getirme

            if (bgl.baglanti().State == ConnectionState.Closed)  //Eğer Bağlantı Kapalıysa AÇ
                bgl.baglanti().Open();

            string sorgu = "Select OdemeAy, OdemeMiktar  from Kasa where OdemeAy='" + CmbPara.Text + " ' ";  //sorg cmlesi oluşturma
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, bgl.baglanti()); //veritabanından sorgu cümlesi çekilir
            DataSet ds = new DataSet();  //DataSet nesnesi oluşturma
            adp.Fill(ds);  //Adapterdaki bilgi DataSete aktarılır
            dataGridView1.DataSource = ds.Tables[0];  //Kullanıcı seçilen nesneleri datagridde görür.

        }
    }
}
