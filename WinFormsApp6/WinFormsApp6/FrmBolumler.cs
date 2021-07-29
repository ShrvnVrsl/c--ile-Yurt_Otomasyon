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
    public partial class FrmBolumler : Form
    {
        SqlConnection baglanti = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand komut;
        public FrmBolumler()
        {
            InitializeComponent();
        }

        void BolumGetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog = YurtKayıt; Integrated Security = SSPI");
            //SqlBaglantim bgl = new SqlBaglantim();
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Bolumler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            BolumGetir();
        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {           
                string sorgu = "INSERT INTO Bolumler(BolumAd) VALUES(@p1)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                BolumGetir();
                MessageBox.Show("Bölüm Eklendi");               
            }
            catch 
            {

                MessageBox.Show("Hata Oluştu Yeniden Deneyin", "HATA");
            }
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TxtBolumid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtBolumAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", TxtBolumid.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                BolumGetir();
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            catch
            {

                MessageBox.Show("HATAA, İşlem Başarısız");
            }
        }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
               baglanti.Open();
               SqlCommand komut2 = new SqlCommand("update Bolumler Set BolumAd=@p1  where Bolumid=@p2", baglanti);
               komut2.Parameters.AddWithValue("@p2", TxtBolumid.Text);
               komut2.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
               komut2.ExecuteNonQuery();
               baglanti.Close();
               BolumGetir();
               MessageBox.Show("Düzenleme Başarılı");
            }
            catch 
            {

                MessageBox.Show("Düzenleme Başarısız", "HATA");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
