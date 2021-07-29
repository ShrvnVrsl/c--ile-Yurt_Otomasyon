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
    public partial class FrmOgrListe : Form
    {
        SqlConnection baglanti = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand komut;

        public FrmOgrListe()
        {
            InitializeComponent();
        }
        void OgrenciGetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog = YurtKayıt; Integrated Security = SSPI");
            //SqlBaglantim bgl = new SqlBaglantim();
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Ogrenci", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            DgvOgrListe.DataSource = tablo;
            baglanti.Close();
        }

        private void FrmOgrListe_Load(object sender, EventArgs e)
        {
            OgrenciGetir();
        }

        private void DgvOgrListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGeriDön_Click(object sender, EventArgs e)
        {
            FrmAnaFormm frm4 = new FrmAnaFormm();
            frm4.ShowDialog();
        }

        private void TxtOgrAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select * from Ogrenci where OgrAd like '%" + TxtOgrAra.Text + "%' ", baglanti);
            ara.Fill(tbl);
            baglanti.Close();
            DgvOgrListe.DataSource = tbl;
        }

        private void BtnOgrEkle_Click(object sender, EventArgs e)
        {
            Form1 frm5 = new Form1();
            frm5.ShowDialog();


            OgrenciGetir();
        }

        int secilen;
        private void DgvOgrListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridde seçilen Bilgileri Diğer Forrma Gönderir
            secilen = DgvOgrListe.SelectedCells[0].RowIndex;
            FrmOgrDuzenlee fr = new FrmOgrDuzenlee();
            fr.id = DgvOgrListe.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = DgvOgrListe.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = DgvOgrListe.Rows[secilen].Cells[2].Value.ToString();
            fr.TC = DgvOgrListe.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = DgvOgrListe.Rows[secilen].Cells[4].Value.ToString();
            fr.dogum = DgvOgrListe.Rows[secilen].Cells[5].Value.ToString();
            fr.bolum = DgvOgrListe.Rows[secilen].Cells[6].Value.ToString();
            fr.mail = DgvOgrListe.Rows[secilen].Cells[7].Value.ToString();
            fr.odano = DgvOgrListe.Rows[secilen].Cells[8].Value.ToString();
            fr.veliad = DgvOgrListe.Rows[secilen].Cells[9].Value.ToString();
            fr.velitel = DgvOgrListe.Rows[secilen].Cells[10].Value.ToString();
            fr.adres = DgvOgrListe.Rows[secilen].Cells[11].Value.ToString();
            fr.Show();
            OgrenciGetir();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            TxtOgrAra.Clear();
            OgrenciGetir();
        }
    }
}
