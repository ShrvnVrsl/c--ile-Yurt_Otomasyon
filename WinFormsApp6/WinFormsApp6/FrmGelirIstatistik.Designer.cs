
namespace WinFormsApp6
{
    partial class FrmGelirIstatistik
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
            this.LblPara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbPara = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblAy = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPara
            // 
            this.LblPara.AutoSize = true;
            this.LblPara.Location = new System.Drawing.Point(481, 18);
            this.LblPara.Name = "LblPara";
            this.LblPara.Size = new System.Drawing.Size(17, 18);
            this.LblPara.TabIndex = 0;
            this.LblPara.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "KASADAKİ PARA :";
            // 
            // CmbPara
            // 
            this.CmbPara.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbPara.FormattingEnabled = true;
            this.CmbPara.Location = new System.Drawing.Point(122, 15);
            this.CmbPara.Name = "CmbPara";
            this.CmbPara.Size = new System.Drawing.Size(186, 26);
            this.CmbPara.TabIndex = 2;
            this.CmbPara.SelectedIndexChanged += new System.EventHandler(this.CmbPara_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "AY SEÇİN :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "SEÇİLEN AY :";
            // 
            // LblAy
            // 
            this.LblAy.AutoSize = true;
            this.LblAy.Location = new System.Drawing.Point(481, 56);
            this.LblAy.Name = "LblAy";
            this.LblAy.Size = new System.Drawing.Size(17, 18);
            this.LblAy.TabIndex = 5;
            this.LblAy.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(534, 178);
            this.dataGridView1.TabIndex = 6;
            // 
            // FrmGelirIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(558, 309);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblAy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbPara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPara);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelirIstatistik";
            this.Text = "GELİR İSTATİSİTKLERİ";
            this.Load += new System.EventHandler(this.FrmGelirIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblAy;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}