
namespace WinFormsApp6
{
    partial class OgrOdemeYap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrid = new System.Windows.Forms.TextBox();
            this.TxtOdenen = new System.Windows.Forms.TextBox();
            this.TxtKalanBorc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BttOdemeYap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtOgrad = new System.Windows.Forms.TextBox();
            this.TxtOgrsoyad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ödenen Miktar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalan Borç :";
            // 
            // txtOgrid
            // 
            this.txtOgrid.Location = new System.Drawing.Point(137, 40);
            this.txtOgrid.Name = "txtOgrid";
            this.txtOgrid.Size = new System.Drawing.Size(164, 25);
            this.txtOgrid.TabIndex = 3;
            // 
            // TxtOdenen
            // 
            this.TxtOdenen.Location = new System.Drawing.Point(137, 180);
            this.TxtOdenen.Name = "TxtOdenen";
            this.TxtOdenen.Size = new System.Drawing.Size(164, 25);
            this.TxtOdenen.TabIndex = 4;
            // 
            // TxtKalanBorc
            // 
            this.TxtKalanBorc.Location = new System.Drawing.Point(137, 230);
            this.TxtKalanBorc.Name = "TxtKalanBorc";
            this.TxtKalanBorc.Size = new System.Drawing.Size(164, 25);
            this.TxtKalanBorc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Öğrenci Ara --->";
            // 
            // TxtAra
            // 
            this.TxtAra.Location = new System.Drawing.Point(549, 24);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(186, 25);
            this.TxtAra.TabIndex = 7;
            this.TxtAra.TextChanged += new System.EventHandler(this.TxtAra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(454, 346);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BttOdemeYap
            // 
            this.BttOdemeYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BttOdemeYap.Location = new System.Drawing.Point(59, 307);
            this.BttOdemeYap.Name = "BttOdemeYap";
            this.BttOdemeYap.Size = new System.Drawing.Size(174, 47);
            this.BttOdemeYap.TabIndex = 9;
            this.BttOdemeYap.Text = "ÖDEME AL";
            this.BttOdemeYap.UseVisualStyleBackColor = false;
            this.BttOdemeYap.Click += new System.EventHandler(this.BttOdemeYap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Öğrenci Ad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Öğrenci Soyad:";
            // 
            // TxtOgrad
            // 
            this.TxtOgrad.Location = new System.Drawing.Point(137, 81);
            this.TxtOgrad.Name = "TxtOgrad";
            this.TxtOgrad.Size = new System.Drawing.Size(164, 25);
            this.TxtOgrad.TabIndex = 12;
            // 
            // TxtOgrsoyad
            // 
            this.TxtOgrsoyad.Location = new System.Drawing.Point(137, 132);
            this.TxtOgrsoyad.Name = "TxtOgrsoyad";
            this.TxtOgrsoyad.Size = new System.Drawing.Size(164, 25);
            this.TxtOgrsoyad.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(695, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.toolTip1.SetToolTip(this.button1, "Sil");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OgrOdemeYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(774, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtOgrsoyad);
            this.Controls.Add(this.TxtOgrad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BttOdemeYap);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtKalanBorc);
            this.Controls.Add(this.TxtOdenen);
            this.Controls.Add(this.txtOgrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgrOdemeYap";
            this.Text = "ÖDEME İŞLEMLERİ";
            this.Load += new System.EventHandler(this.OgrOdemeYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrid;
        private System.Windows.Forms.TextBox TxtOdenen;
        private System.Windows.Forms.TextBox TxtKalanBorc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BttOdemeYap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtOgrad;
        private System.Windows.Forms.TextBox TxtOgrsoyad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}