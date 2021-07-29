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
    public partial class OgrOdemeYap : Form
    {
        SqlConnection baglanti = new SqlConnection();
        SqlDataAdapter da;

        public OgrOdemeYap()
        {
            InitializeComponent();
        }

        void BorcGetirr()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog = YurtKayıt; Integrated Security = SSPI");
            //SqlBaglantim bgl = new SqlBaglantim();
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Borclar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void BttOdemeYap_Click(object sender, EventArgs e)
        {
            //Ödenen Miktarı Kalan Miktardan Eksiltme
            baglanti.Open();
            int odenen, kalan,yeniborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalanBorc.Text);
            yeniborc = kalan - odenen;
            TxtKalanBorc.Text = yeniborc.ToString();

            //Yeni Miktarı veri tabanına Kaydetme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1  where Ogrid=@p2", baglanti);
            komut.Parameters.AddWithValue("@p2", txtOgrid.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalanBorc.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("BORÇ ÖDENDİ", "BİLDİRİ");



            //İşlemlerden Sonra DataGridi Yeniledik
            BorcGetirr();


        }

        private void TxtAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select * from Borclar where OgrAd like '%" + TxtAra.Text + "%' ", baglanti);
            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void OgrOdemeYap_Load(object sender, EventArgs e)
        {
            BorcGetirr();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;

            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtOgrad.Text = ad;
            TxtOgrsoyad.Text = soyad;
            TxtKalanBorc.Text = kalan;
            txtOgrid.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtAra.Clear();
            BorcGetirr();
        }
    }
}
