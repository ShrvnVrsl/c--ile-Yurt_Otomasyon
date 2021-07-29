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
    public partial class FrmYoneticiIslem : Form
    {
        SqlConnection baglanti = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand komutt;
        public FrmYoneticiIslem()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        void AdminGetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog = YurtKayıt; Integrated Security = SSPI");
            //SqlBaglantim bgl = new SqlBaglantim();
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Admin", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        

        private void BtnYSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("YÖNETİCİYİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ!!!", "SİLİNSİN Mİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
            {
                string sorgu = "DELETE FROM Admin WHERE Yoneticiid=@p1";
                komutt = new SqlCommand(sorgu, baglanti);
                komutt.Parameters.AddWithValue("@p1", TxtYid.Text);
                baglanti.Open();
                komutt.ExecuteNonQuery();
                baglanti.Close();
                AdminGetir();
            }
            else
            {
                MessageBox.Show("YÖNETİCİ SİLİNMEDİ", "YÖNETİCİ İŞLEMLERİ");
            }

        }

        private void BtnYGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Admin set YoneticiAd=@p1,YoneticiSifre=@p2  where Yoneticiid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtYAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYSifre.Text);
            komut.Parameters.AddWithValue("@p3", TxtYid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("GÜNCELLEME BAŞARILI", "İŞLEM BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            AdminGetir();
        }

        private void BtnYKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand( "insert into Admin(YoneticiAd,YoneticiSifre) values(@p1,@p2)",bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtYAd.Text);
                komut2.Parameters.AddWithValue("@p2", TxtYSifre.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();               
                MessageBox.Show("Yönetici Başarılı Bir Şekilde Eklendi");
                AdminGetir();
            }
            catch
            {

                MessageBox.Show("Hata Oluştu Yeniden Deneyin", "HATA");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre,id;
            id= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre= dataGridView1.Rows[secilen].Cells[2].Value.ToString();


            TxtYAd.Text = ad;
            TxtYSifre.Text = sifre;
            TxtYid.Text = id;

            AdminGetir();
        }

        private void FrmYoneticiIslem_Load(object sender, EventArgs e)
        {
            AdminGetir();
        }
    }
}
