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
    public partial class FrmAnaFormm : Form
    {
        

        public FrmAnaFormm()
        {
            InitializeComponent();
        }

       
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            
        }
        private void FrmAnaFormm_Load(object sender, EventArgs e)
        {
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("ÇIKIŞ yapmak istediğinize emin misiniz", "ÇIKIŞ YAPILSIN MI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (cevap==DialogResult.Yes)
            {
                Application.Exit();
            }  
        }

        private void BtnOgrListe_Click(object sender, EventArgs e)
        {
            FrmOgrListe frm3 = new FrmOgrListe();
            frm3.ShowDialog();
        }

        private void btnOgrEkle_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void BtnBolum_Click(object sender, EventArgs e)
        {
            FrmBolumler frm2 = new FrmBolumler();
            frm2.ShowDialog();
        }

        private void BtnKalanBorc_Click(object sender, EventArgs e)
        {
            OgrOdemeYap frm4 = new OgrOdemeYap();
            frm4.ShowDialog();
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MERHABALAR" + "\n" + "----- SİSTEMİMİZ HAKKINDA BİLGİ -----" + "\n" + "1)ÖĞRENCİ KAYIT İŞLEMLERİ : İLE YURDUMUZA KAYIT YAPABİLİRSİNİZ (NOT:ödeme kayıt işlemlerinden sonra yapılıcaktır)  " + "\n" +
                   "2)BÖLÜM İŞLEMLERİ İLE : YURDUMUZUN VERİTABANINDA HENÜZ BULUNMAYAN BİR BÖLÜMÜ EKLEYEREK BİZE DESTEK OLABİLİRSİNİZ" + "\n" +
                   "3)ÖĞRENCİ İŞLEMLERİ İLE : YURDUMUZDAKİ KAYITLI ÖĞRENCİ LİSTESİNİ GÖRÜNTÜLEYEBİLİR ,KAYDINIZI GÜNCELLEYEBİLİR VE AYNI ZAMANDA  KAYDINIZI SİLİP YURDUMUZDAN İLİŞKİNİZİ KESEBİLİRSİNİZ"
                   + "\n" +"4)ÖDEME İŞLEMLERİ İLE : ÖDEMELERİNİZİ YAPABİLİRSİNİZ (NOT:yurt ücretlerimiz sabittir-3000TL)"
                   + "\n" +"5)BU SİSTEMİN KURUCULARI : ŞEHRİVAN VARIŞLI , ESMA NUR MAVİ , SİMEN ARSLANDIR" , "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
