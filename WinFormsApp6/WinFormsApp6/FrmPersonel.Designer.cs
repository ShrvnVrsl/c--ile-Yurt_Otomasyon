
namespace WinFormsApp6
{
    partial class FrmPersonel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnPGuncelle = new System.Windows.Forms.Button();
            this.BtnPSil = new System.Windows.Forms.Button();
            this.BtnPKaydet = new System.Windows.Forms.Button();
            this.TxtPGorev = new System.Windows.Forms.TextBox();
            this.TxtPAd = new System.Windows.Forms.TextBox();
            this.TxtPid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(2, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(469, 299);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnPGuncelle
            // 
            this.BtnPGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnPGuncelle.Location = new System.Drawing.Point(311, 170);
            this.BtnPGuncelle.Name = "BtnPGuncelle";
            this.BtnPGuncelle.Size = new System.Drawing.Size(123, 35);
            this.BtnPGuncelle.TabIndex = 18;
            this.BtnPGuncelle.Text = "Güncelle";
            this.BtnPGuncelle.UseVisualStyleBackColor = false;
            this.BtnPGuncelle.Click += new System.EventHandler(this.BtnPGuncelle_Click);
            // 
            // BtnPSil
            // 
            this.BtnPSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnPSil.Location = new System.Drawing.Point(154, 170);
            this.BtnPSil.Name = "BtnPSil";
            this.BtnPSil.Size = new System.Drawing.Size(121, 35);
            this.BtnPSil.TabIndex = 17;
            this.BtnPSil.Text = "Sil";
            this.BtnPSil.UseVisualStyleBackColor = false;
            this.BtnPSil.Click += new System.EventHandler(this.BtnPSil_Click);
            // 
            // BtnPKaydet
            // 
            this.BtnPKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnPKaydet.Location = new System.Drawing.Point(12, 170);
            this.BtnPKaydet.Name = "BtnPKaydet";
            this.BtnPKaydet.Size = new System.Drawing.Size(118, 35);
            this.BtnPKaydet.TabIndex = 16;
            this.BtnPKaydet.Text = "Kaydet";
            this.BtnPKaydet.UseVisualStyleBackColor = false;
            this.BtnPKaydet.Click += new System.EventHandler(this.BtnPKaydet_Click);
            // 
            // TxtPGorev
            // 
            this.TxtPGorev.Location = new System.Drawing.Point(176, 96);
            this.TxtPGorev.Name = "TxtPGorev";
            this.TxtPGorev.Size = new System.Drawing.Size(207, 25);
            this.TxtPGorev.TabIndex = 15;
            // 
            // TxtPAd
            // 
            this.TxtPAd.Location = new System.Drawing.Point(176, 50);
            this.TxtPAd.Name = "TxtPAd";
            this.TxtPAd.Size = new System.Drawing.Size(207, 25);
            this.TxtPAd.TabIndex = 14;
            // 
            // TxtPid
            // 
            this.TxtPid.Location = new System.Drawing.Point(176, 12);
            this.TxtPid.Name = "TxtPid";
            this.TxtPid.Size = new System.Drawing.Size(207, 25);
            this.TxtPid.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "PERSONEL GÖREV :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "PERSONEL AD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "PERSONEL İD :";
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(473, 507);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnPGuncelle);
            this.Controls.Add(this.BtnPSil);
            this.Controls.Add(this.BtnPKaydet);
            this.Controls.Add(this.TxtPGorev);
            this.Controls.Add(this.TxtPAd);
            this.Controls.Add(this.TxtPid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonel";
            this.Text = "PERSONEL İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnPGuncelle;
        private System.Windows.Forms.Button BtnPSil;
        private System.Windows.Forms.Button BtnPKaydet;
        private System.Windows.Forms.TextBox TxtPGorev;
        private System.Windows.Forms.TextBox TxtPAd;
        private System.Windows.Forms.TextBox TxtPid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}