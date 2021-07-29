using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class FrmYoneticiAnaForm : Form
    {
        public FrmYoneticiAnaForm()
        {
            InitializeComponent();
        }

        private void BtnGiderislemleri_Click(object sender, EventArgs e)
        {
            FrmGiderListe frm6 = new FrmGiderListe();
            frm6.ShowDialog();
        }

        private void BtnGider_Click(object sender, EventArgs e)
        {
            FrmGider frm5 = new FrmGider();
            frm5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGelirIstatistik frm7 = new FrmGelirIstatistik();
            frm7.ShowDialog();
        }

        private void BtnYoneticiIslem_Click(object sender, EventArgs e)
        {
            FrmYoneticiIslem frm8 = new FrmYoneticiIslem();
            frm8.ShowDialog();
        }

        private void BtnPersonel_Click(object sender, EventArgs e)
        {
            FrmPersonel frm9 = new FrmPersonel();
            frm9.ShowDialog();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("ÇIKIŞ yapmak istediğinize emin misiniz", "ÇIKIŞ YAPILSIN MI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnHesapMakine_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void BtnNotEkle_Click(object sender, EventArgs e)
        {
            FrmNotEkle frm10 = new FrmNotEkle();
            frm10.ShowDialog();
        }
    }
}
