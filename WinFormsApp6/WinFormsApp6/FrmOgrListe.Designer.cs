
namespace WinFormsApp6
{
    partial class FrmOgrListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrListe));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOgrAra = new System.Windows.Forms.TextBox();
            this.DgvOgrListe = new System.Windows.Forms.DataGridView();
            this.BtnGeriDön = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnOgrEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOgrListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ara :";
            // 
            // TxtOgrAra
            // 
            this.TxtOgrAra.Location = new System.Drawing.Point(118, 20);
            this.TxtOgrAra.Name = "TxtOgrAra";
            this.TxtOgrAra.Size = new System.Drawing.Size(273, 25);
            this.TxtOgrAra.TabIndex = 2;
            this.TxtOgrAra.TextChanged += new System.EventHandler(this.TxtOgrAra_TextChanged);
            // 
            // DgvOgrListe
            // 
            this.DgvOgrListe.AllowUserToAddRows = false;
            this.DgvOgrListe.AllowUserToDeleteRows = false;
            this.DgvOgrListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DgvOgrListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOgrListe.Location = new System.Drawing.Point(-5, 74);
            this.DgvOgrListe.Name = "DgvOgrListe";
            this.DgvOgrListe.ReadOnly = true;
            this.DgvOgrListe.RowTemplate.Height = 25;
            this.DgvOgrListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOgrListe.Size = new System.Drawing.Size(744, 312);
            this.DgvOgrListe.TabIndex = 4;
            this.DgvOgrListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOgrListe_CellClick);
            this.DgvOgrListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOgrListe_CellContentClick);
            // 
            // BtnGeriDön
            // 
            this.BtnGeriDön.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGeriDön.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGeriDön.ImageIndex = 0;
            this.BtnGeriDön.ImageList = this.ımageList1;
            this.BtnGeriDön.Location = new System.Drawing.Point(682, 10);
            this.BtnGeriDön.Name = "BtnGeriDön";
            this.BtnGeriDön.Size = new System.Drawing.Size(47, 32);
            this.BtnGeriDön.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BtnGeriDön, "Önceki Sayfaya Dön");
            this.BtnGeriDön.UseVisualStyleBackColor = false;
            this.BtnGeriDön.Click += new System.EventHandler(this.BtnGeriDön_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir.jpg");
            // 
            // BtnOgrEkle
            // 
            this.BtnOgrEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnOgrEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOgrEkle.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnOgrEkle.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnOgrEkle.Location = new System.Drawing.Point(470, 12);
            this.BtnOgrEkle.Name = "BtnOgrEkle";
            this.BtnOgrEkle.Size = new System.Drawing.Size(139, 43);
            this.BtnOgrEkle.TabIndex = 6;
            this.BtnOgrEkle.Text = "Öğrenci Ekle";
            this.BtnOgrEkle.UseVisualStyleBackColor = false;
            this.BtnOgrEkle.Click += new System.EventHandler(this.BtnOgrEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.White;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSil.Location = new System.Drawing.Point(362, 21);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(29, 23);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "X";
            this.toolTip1.SetToolTip(this.BtnSil, "Sil");
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // FrmOgrListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(741, 385);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnOgrEkle);
            this.Controls.Add(this.BtnGeriDön);
            this.Controls.Add(this.DgvOgrListe);
            this.Controls.Add(this.TxtOgrAra);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrListe";
            this.Text = "ÖĞRENCİ LİSTESİ";
            this.Load += new System.EventHandler(this.FrmOgrListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOgrListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOgrAra;
        private System.Windows.Forms.DataGridView DgvOgrListe;
        private System.Windows.Forms.Button BtnGeriDön;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnOgrEkle;
        private System.Windows.Forms.Button BtnSil;
    }
}