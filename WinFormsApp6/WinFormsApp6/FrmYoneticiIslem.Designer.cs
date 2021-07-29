
namespace WinFormsApp6
{
    partial class FrmYoneticiIslem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtYid = new System.Windows.Forms.TextBox();
            this.TxtYAd = new System.Windows.Forms.TextBox();
            this.TxtYSifre = new System.Windows.Forms.TextBox();
            this.BtnYKaydet = new System.Windows.Forms.Button();
            this.BtnYSil = new System.Windows.Forms.Button();
            this.BtnYGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "YÖNETİCİ İD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "YÖNETİCİ AD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ŞİFRE :";
            // 
            // TxtYid
            // 
            this.TxtYid.Location = new System.Drawing.Point(191, 33);
            this.TxtYid.Name = "TxtYid";
            this.TxtYid.Size = new System.Drawing.Size(207, 25);
            this.TxtYid.TabIndex = 3;
            // 
            // TxtYAd
            // 
            this.TxtYAd.Location = new System.Drawing.Point(191, 71);
            this.TxtYAd.Name = "TxtYAd";
            this.TxtYAd.Size = new System.Drawing.Size(207, 25);
            this.TxtYAd.TabIndex = 4;
            // 
            // TxtYSifre
            // 
            this.TxtYSifre.Location = new System.Drawing.Point(191, 117);
            this.TxtYSifre.Name = "TxtYSifre";
            this.TxtYSifre.Size = new System.Drawing.Size(207, 25);
            this.TxtYSifre.TabIndex = 5;
            // 
            // BtnYKaydet
            // 
            this.BtnYKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnYKaydet.Location = new System.Drawing.Point(12, 191);
            this.BtnYKaydet.Name = "BtnYKaydet";
            this.BtnYKaydet.Size = new System.Drawing.Size(118, 35);
            this.BtnYKaydet.TabIndex = 6;
            this.BtnYKaydet.Text = "Kaydet";
            this.BtnYKaydet.UseVisualStyleBackColor = false;
            this.BtnYKaydet.Click += new System.EventHandler(this.BtnYKaydet_Click);
            // 
            // BtnYSil
            // 
            this.BtnYSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnYSil.Location = new System.Drawing.Point(169, 191);
            this.BtnYSil.Name = "BtnYSil";
            this.BtnYSil.Size = new System.Drawing.Size(121, 35);
            this.BtnYSil.TabIndex = 7;
            this.BtnYSil.Text = "Sil";
            this.BtnYSil.UseVisualStyleBackColor = false;
            this.BtnYSil.Click += new System.EventHandler(this.BtnYSil_Click);
            // 
            // BtnYGuncelle
            // 
            this.BtnYGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnYGuncelle.Location = new System.Drawing.Point(326, 191);
            this.BtnYGuncelle.Name = "BtnYGuncelle";
            this.BtnYGuncelle.Size = new System.Drawing.Size(123, 35);
            this.BtnYGuncelle.TabIndex = 8;
            this.BtnYGuncelle.Text = "Güncelle";
            this.BtnYGuncelle.UseVisualStyleBackColor = false;
            this.BtnYGuncelle.Click += new System.EventHandler(this.BtnYGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(498, 288);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmYoneticiIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(501, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnYGuncelle);
            this.Controls.Add(this.BtnYSil);
            this.Controls.Add(this.BtnYKaydet);
            this.Controls.Add(this.TxtYSifre);
            this.Controls.Add(this.TxtYAd);
            this.Controls.Add(this.TxtYid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYoneticiIslem";
            this.Text = "YÖNETİCİ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmYoneticiIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtYid;
        private System.Windows.Forms.TextBox TxtYAd;
        private System.Windows.Forms.TextBox TxtYSifre;
        private System.Windows.Forms.Button BtnYKaydet;
        private System.Windows.Forms.Button BtnYSil;
        private System.Windows.Forms.Button BtnYGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}