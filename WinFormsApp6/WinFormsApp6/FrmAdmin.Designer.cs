
namespace WinFormsApp6
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnBilgiAl = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnYoneticiGiris = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAdminKayit = new System.Windows.Forms.Button();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtAdminAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtYKAd = new System.Windows.Forms.TextBox();
            this.BtnGuncel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 418);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.BtnBilgiAl);
            this.tabPage1.Controls.Add(this.BtnYoneticiGiris);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.BtnAdminKayit);
            this.tabPage1.Controls.Add(this.BtnGirisYap);
            this.tabPage1.Controls.Add(this.TxtSifre);
            this.tabPage1.Controls.Add(this.TxtAdminAd);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kulanıcı Girişi";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(283, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 22);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BtnBilgiAl
            // 
            this.BtnBilgiAl.ImageIndex = 0;
            this.BtnBilgiAl.ImageList = this.ımageList1;
            this.BtnBilgiAl.Location = new System.Drawing.Point(432, 19);
            this.BtnBilgiAl.Name = "BtnBilgiAl";
            this.BtnBilgiAl.Size = new System.Drawing.Size(48, 37);
            this.BtnBilgiAl.TabIndex = 18;
            this.BtnBilgiAl.Tag = "";
            this.toolTip1.SetToolTip(this.BtnBilgiAl, "Bilgi Al");
            this.BtnBilgiAl.UseVisualStyleBackColor = true;
            this.BtnBilgiAl.Click += new System.EventHandler(this.BtnBilgiAl_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "bilgi.jpg");
            // 
            // BtnYoneticiGiris
            // 
            this.BtnYoneticiGiris.BackColor = System.Drawing.Color.Maroon;
            this.BtnYoneticiGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnYoneticiGiris.ForeColor = System.Drawing.Color.White;
            this.BtnYoneticiGiris.Location = new System.Drawing.Point(158, 323);
            this.BtnYoneticiGiris.Name = "BtnYoneticiGiris";
            this.BtnYoneticiGiris.Size = new System.Drawing.Size(167, 45);
            this.BtnYoneticiGiris.TabIndex = 17;
            this.BtnYoneticiGiris.Text = "YÖNETİCİ GİRİŞİ";
            this.BtnYoneticiGiris.UseVisualStyleBackColor = false;
            this.BtnYoneticiGiris.Click += new System.EventHandler(this.BtnYoneticiGiris_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(211, 213);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(139, 18);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAdminKayit
            // 
            this.BtnAdminKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAdminKayit.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnAdminKayit.ForeColor = System.Drawing.Color.Red;
            this.BtnAdminKayit.Location = new System.Drawing.Point(296, 255);
            this.BtnAdminKayit.Name = "BtnAdminKayit";
            this.BtnAdminKayit.Size = new System.Drawing.Size(114, 40);
            this.BtnAdminKayit.TabIndex = 14;
            this.BtnAdminKayit.Text = "KAYDOL";
            this.BtnAdminKayit.UseVisualStyleBackColor = false;
            this.BtnAdminKayit.Click += new System.EventHandler(this.BtnAdminKayit_Click_1);
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnGirisYap.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnGirisYap.ForeColor = System.Drawing.Color.Red;
            this.BtnGirisYap.Location = new System.Drawing.Point(71, 254);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(119, 41);
            this.BtnGirisYap.TabIndex = 13;
            this.BtnGirisYap.Text = "GİRİŞ";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click_1);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(283, 155);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(195, 25);
            this.TxtSifre.TabIndex = 12;
            // 
            // TxtAdminAd
            // 
            this.TxtAdminAd.Location = new System.Drawing.Point(283, 96);
            this.TxtAdminAd.Name = "TxtAdminAd";
            this.TxtAdminAd.Size = new System.Drawing.Size(195, 25);
            this.TxtAdminAd.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kullanıcı Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Georgia", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(58, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "YURT OTOMASYONU GİRİŞ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.TxtYKAd);
            this.tabPage2.Controls.Add(this.BtnGuncel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Şifremi Unuttum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(240, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(38, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 25);
            this.textBox2.TabIndex = 5;
            // 
            // TxtYKAd
            // 
            this.TxtYKAd.Location = new System.Drawing.Point(211, 100);
            this.TxtYKAd.Name = "TxtYKAd";
            this.TxtYKAd.Size = new System.Drawing.Size(159, 25);
            this.TxtYKAd.TabIndex = 4;
            // 
            // BtnGuncel
            // 
            this.BtnGuncel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGuncel.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtnGuncel.Location = new System.Drawing.Point(184, 230);
            this.BtnGuncel.Name = "BtnGuncel";
            this.BtnGuncel.Size = new System.Drawing.Size(115, 38);
            this.BtnGuncel.TabIndex = 3;
            this.BtnGuncel.Text = "GÜNCELLE";
            this.BtnGuncel.UseVisualStyleBackColor = false;
            this.BtnGuncel.Click += new System.EventHandler(this.BtnGuncel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = " Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kullanıcı Ad :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(493, 407);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAdminKayit;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtAdminAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TxtYKAd;
        private System.Windows.Forms.Button BtnGuncel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBilgiAl;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnYoneticiGiris;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
    }
}