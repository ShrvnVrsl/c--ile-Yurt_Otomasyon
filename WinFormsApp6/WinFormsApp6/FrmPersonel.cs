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
    public partial class FrmPersonel : Form
    {
        SqlConnection baglanti = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand komutt;
        public FrmPersonel()
        {
            InitializeComponent();
        }

        void PersonelGetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog = YurtKayıt; Integrated Security = SSPI");
            //SqlBaglantim bgl = new SqlBaglantim();
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Personel", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            PersonelGetir();
        }

        private void BtnPKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("insert into Personel(PersonelAdSoyad,PersonelDepartman) values(@p1,@p2)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtPAd.Text);
                komut2.Parameters.AddWithValue("@p2", TxtPGorev.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Başarılı Bir Şekilde Eklendi","İŞLEM BAŞARILI");
                PersonelGetir();
            }
            catch
            {

                MessageBox.Show("Hata Oluştu Yeniden Deneyin", "HATA");
            }
        }

        private void BtnPSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Personel WHERE Personelid=@p1";
            komutt = new SqlCommand(sorgu, baglanti);
            komutt.Parameters.AddWithValue("@p1", TxtPid.Text);
            baglanti.Open();
            komutt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT SİLİNDİ", "İŞLEM BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            PersonelGetir();
        }

        private void BtnPGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgun = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where Personelid=@p3", bgl.baglanti());
            komutgun.Parameters.AddWithValue("@p1", TxtPAd.Text);
            komutgun.Parameters.AddWithValue("@p2", TxtPGorev.Text);
            komutgun.Parameters.AddWithValue("@p3", TxtPid.Text);
            komutgun.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("GÜNCELLEME BAŞARILI", "İŞLEM BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            PersonelGetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();


            TxtPAd.Text = ad;
            TxtPGorev.Text = gorev;
            TxtPid.Text = id;

            PersonelGetir();
        }
    }
}
