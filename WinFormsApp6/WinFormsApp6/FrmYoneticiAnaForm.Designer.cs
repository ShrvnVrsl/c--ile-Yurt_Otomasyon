
namespace WinFormsApp6
{
    partial class FrmYoneticiAnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiAnaForm));
            this.BtnGiderislemleri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnGider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnYoneticiIslem = new System.Windows.Forms.Button();
            this.BtnPersonel = new System.Windows.Forms.Button();
            this.BtnNotEkle = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnHesapMakine = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnGiderislemleri
            // 
            this.BtnGiderislemleri.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnGiderislemleri.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGiderislemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGiderislemleri.ImageIndex = 1;
            this.BtnGiderislemleri.ImageList = this.ımageList1;
            this.BtnGiderislemleri.Location = new System.Drawing.Point(357, 67);
            this.BtnGiderislemleri.Name = "BtnGiderislemleri";
            this.BtnGiderislemleri.Size = new System.Drawing.Size(323, 72);
            this.BtnGiderislemleri.TabIndex = 10;
            this.BtnGiderislemleri.Text = "YURT GİDERLERİ LİSTELEME-GÜNCELLEME\r\n\r\n";
            this.BtnGiderislemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGiderislemleri.UseVisualStyleBackColor = false;
            this.BtnGiderislemleri.Click += new System.EventHandler(this.BtnGiderislemleri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir (4).png");
            this.ımageList1.Images.SetKeyName(1, "gider.png");
            this.ımageList1.Images.SetKeyName(2, "Gelirİstatistik.jpg");
            this.ımageList1.Images.SetKeyName(3, "YÖNETİCİİ.jpg");
            this.ımageList1.Images.SetKeyName(4, "kapat.jpg");
            this.ımageList1.Images.SetKeyName(5, "Personel.jpg");
            this.ımageList1.Images.SetKeyName(6, "Hesap makinesi.png");
            this.ımageList1.Images.SetKeyName(7, "Ogr.png");
            this.ımageList1.Images.SetKeyName(8, "not.png");
            // 
            // BtnGider
            // 
            this.BtnGider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGider.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGider.ImageIndex = 0;
            this.BtnGider.ImageList = this.ımageList1;
            this.BtnGider.Location = new System.Drawing.Point(3, 67);
            this.BtnGider.Name = "BtnGider";
            this.BtnGider.Size = new System.Drawing.Size(312, 72);
            this.BtnGider.TabIndex = 9;
            this.BtnGider.Text = "YURT GİDERLERİ";
            this.BtnGider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGider.UseVisualStyleBackColor = false;
            this.BtnGider.Click += new System.EventHandler(this.BtnGider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "YURT OTOMASYONU YÖNTİCİ ANA SAYFASINA HOŞGELDİNİZ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(3, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 75);
            this.button1.TabIndex = 12;
            this.button1.Text = "GELİR İSTATİSTİKLERİ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnYoneticiIslem
            // 
            this.BtnYoneticiIslem.BackColor = System.Drawing.Color.Plum;
            this.BtnYoneticiIslem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnYoneticiIslem.ImageIndex = 3;
            this.BtnYoneticiIslem.ImageList = this.ımageList1;
            this.BtnYoneticiIslem.Location = new System.Drawing.Point(357, 169);
            this.BtnYoneticiIslem.Name = "BtnYoneticiIslem";
            this.BtnYoneticiIslem.Size = new System.Drawing.Size(323, 75);
            this.BtnYoneticiIslem.TabIndex = 13;
            this.BtnYoneticiIslem.Text = "YÖNETİCİ İŞLEMLERİ";
            this.BtnYoneticiIslem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnYoneticiIslem.UseVisualStyleBackColor = false;
            this.BtnYoneticiIslem.Click += new System.EventHandler(this.BtnYoneticiIslem_Click);
            // 
            // BtnPersonel
            // 
            this.BtnPersonel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnPersonel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonel.ImageIndex = 5;
            this.BtnPersonel.ImageList = this.ımageList1;
            this.BtnPersonel.Location = new System.Drawing.Point(357, 264);
            this.BtnPersonel.Name = "BtnPersonel";
            this.BtnPersonel.Size = new System.Drawing.Size(323, 68);
            this.BtnPersonel.TabIndex = 14;
            this.BtnPersonel.Text = "PERSONEL İŞLEMLERİ";
            this.BtnPersonel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPersonel.UseVisualStyleBackColor = false;
            this.BtnPersonel.Click += new System.EventHandler(this.BtnPersonel_Click);
            // 
            // BtnNotEkle
            // 
            this.BtnNotEkle.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BtnNotEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNotEkle.ImageIndex = 8;
            this.BtnNotEkle.ImageList = this.ımageList1;
            this.BtnNotEkle.Location = new System.Drawing.Point(3, 264);
            this.BtnNotEkle.Name = "BtnNotEkle";
            this.BtnNotEkle.Size = new System.Drawing.Size(312, 68);
            this.BtnNotEkle.TabIndex = 15;
            this.BtnNotEkle.Text = "NOT BIRAK           ";
            this.BtnNotEkle.UseVisualStyleBackColor = false;
            this.BtnNotEkle.Click += new System.EventHandler(this.BtnNotEkle_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackColor = System.Drawing.Color.Brown;
            this.BtnKapat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKapat.ImageIndex = 4;
            this.BtnKapat.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(196, 338);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(254, 60);
            this.BtnKapat.TabIndex = 16;
            this.BtnKapat.Text = "GÜVENLİ ÇIKIŞ";
            this.BtnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnHesapMakine
            // 
            this.BtnHesapMakine.ImageIndex = 6;
            this.BtnHesapMakine.ImageList = this.ımageList1;
            this.BtnHesapMakine.Location = new System.Drawing.Point(596, 2);
            this.BtnHesapMakine.Name = "BtnHesapMakine";
            this.BtnHesapMakine.Size = new System.Drawing.Size(72, 59);
            this.BtnHesapMakine.TabIndex = 17;
            this.toolTip1.SetToolTip(this.BtnHesapMakine, "Hesap Makinesi");
            this.BtnHesapMakine.UseVisualStyleBackColor = true;
            this.BtnHesapMakine.Click += new System.EventHandler(this.BtnHesapMakine_Click);
            // 
            // FrmYoneticiAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(692, 401);
            this.Controls.Add(this.BtnHesapMakine);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnNotEkle);
            this.Controls.Add(this.BtnPersonel);
            this.Controls.Add(this.BtnYoneticiIslem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGiderislemleri);
            this.Controls.Add(this.BtnGider);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYoneticiAnaForm";
            this.Text = "YÖENTİCİ ANA SAYFA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGiderislemleri;
        private System.Windows.Forms.Button BtnGider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnYoneticiIslem;
        private System.Windows.Forms.Button BtnPersonel;
        private System.Windows.Forms.Button BtnNotEkle;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Button BtnHesapMakine;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}