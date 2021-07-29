
namespace WinFormsApp6
{
    partial class FrmAnaFormm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaFormm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOgrEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnOgrListe = new System.Windows.Forms.Button();
            this.BtnBolum = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnKalanBorc = new System.Windows.Forms.Button();
            this.BtnHakkımızda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(70, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "YURT OTOMASYON SİSTEMİNE HOŞGELDİNİZ";
            // 
            // btnOgrEkle
            // 
            this.btnOgrEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOgrEkle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOgrEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOgrEkle.ImageIndex = 3;
            this.btnOgrEkle.ImageList = this.ımageList1;
            this.btnOgrEkle.Location = new System.Drawing.Point(35, 83);
            this.btnOgrEkle.Name = "btnOgrEkle";
            this.btnOgrEkle.Size = new System.Drawing.Size(263, 66);
            this.btnOgrEkle.TabIndex = 1;
            this.btnOgrEkle.Text = "ÖĞRENCİ KAYIT İŞLEMLERİ";
            this.btnOgrEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOgrEkle.UseVisualStyleBackColor = false;
            this.btnOgrEkle.Click += new System.EventHandler(this.btnOgrEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "liste.png");
            this.ımageList1.Images.SetKeyName(1, "bolum.jpg");
            this.ımageList1.Images.SetKeyName(2, "kapat.jpg");
            this.ımageList1.Images.SetKeyName(3, "Kayıt.png");
            this.ımageList1.Images.SetKeyName(4, "indir.png");
            this.ımageList1.Images.SetKeyName(5, "indir (4).png");
            this.ımageList1.Images.SetKeyName(6, "gider.png");
            this.ımageList1.Images.SetKeyName(7, "hakkımızda.jpg");
            // 
            // BtnOgrListe
            // 
            this.BtnOgrListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnOgrListe.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnOgrListe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOgrListe.ImageIndex = 0;
            this.BtnOgrListe.ImageList = this.ımageList1;
            this.BtnOgrListe.Location = new System.Drawing.Point(35, 188);
            this.BtnOgrListe.Name = "BtnOgrListe";
            this.BtnOgrListe.Size = new System.Drawing.Size(263, 67);
            this.BtnOgrListe.TabIndex = 2;
            this.BtnOgrListe.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.BtnOgrListe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOgrListe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnOgrListe.UseVisualStyleBackColor = false;
            this.BtnOgrListe.Click += new System.EventHandler(this.BtnOgrListe_Click);
            // 
            // BtnBolum
            // 
            this.BtnBolum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBolum.ImageIndex = 1;
            this.BtnBolum.ImageList = this.ımageList1;
            this.BtnBolum.Location = new System.Drawing.Point(349, 83);
            this.BtnBolum.Name = "BtnBolum";
            this.BtnBolum.Size = new System.Drawing.Size(269, 66);
            this.BtnBolum.TabIndex = 3;
            this.BtnBolum.Text = "BÖLÜM  İŞLEMLERİ";
            this.BtnBolum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBolum.UseVisualStyleBackColor = false;
            this.BtnBolum.Click += new System.EventHandler(this.BtnBolum_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackColor = System.Drawing.Color.Red;
            this.BtnKapat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnKapat.ForeColor = System.Drawing.Color.Black;
            this.BtnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKapat.ImageIndex = 2;
            this.BtnKapat.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(349, 295);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(269, 66);
            this.BtnKapat.TabIndex = 5;
            this.BtnKapat.Text = "GÜVENLİ ÇIKIŞ";
            this.BtnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnKalanBorc
            // 
            this.BtnKalanBorc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnKalanBorc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnKalanBorc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKalanBorc.ImageIndex = 4;
            this.BtnKalanBorc.ImageList = this.ımageList1;
            this.BtnKalanBorc.Location = new System.Drawing.Point(349, 188);
            this.BtnKalanBorc.Name = "BtnKalanBorc";
            this.BtnKalanBorc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnKalanBorc.Size = new System.Drawing.Size(269, 67);
            this.BtnKalanBorc.TabIndex = 6;
            this.BtnKalanBorc.Text = "ÖDEME  İŞLEMLERİ";
            this.BtnKalanBorc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKalanBorc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKalanBorc.UseVisualStyleBackColor = false;
            this.BtnKalanBorc.Click += new System.EventHandler(this.BtnKalanBorc_Click);
            // 
            // BtnHakkımızda
            // 
            this.BtnHakkımızda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnHakkımızda.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHakkımızda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHakkımızda.ImageIndex = 7;
            this.BtnHakkımızda.ImageList = this.ımageList1;
            this.BtnHakkımızda.Location = new System.Drawing.Point(35, 295);
            this.BtnHakkımızda.Name = "BtnHakkımızda";
            this.BtnHakkımızda.Size = new System.Drawing.Size(269, 66);
            this.BtnHakkımızda.TabIndex = 7;
            this.BtnHakkımızda.Text = "      HAKKIMIZDA";
            this.BtnHakkımızda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHakkımızda.UseVisualStyleBackColor = false;
            this.BtnHakkımızda.Click += new System.EventHandler(this.BtnHakkımızda_Click);
            // 
            // FrmAnaFormm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(630, 373);
            this.Controls.Add(this.BtnHakkımızda);
            this.Controls.Add(this.BtnKalanBorc);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnBolum);
            this.Controls.Add(this.BtnOgrListe);
            this.Controls.Add(this.btnOgrEkle);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaFormm";
            this.Text = "KULLANICI ANA MENÜ\r\n\r\n";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrEkle;
        private System.Windows.Forms.Button BtnOgrListe;
        private System.Windows.Forms.Button BtnBolum;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnKalanBorc;
        private System.Windows.Forms.Button BtnHakkımızda;
    }
}