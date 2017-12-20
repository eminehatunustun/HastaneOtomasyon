namespace MHRS
{
    partial class Randevularr
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRandevuAra = new System.Windows.Forms.Button();
            this.cbKlinik = new System.Windows.Forms.ComboBox();
            this.cbHastane = new System.Windows.Forms.ComboBox();
            this.cbIlce = new System.Windows.Forms.ComboBox();
            this.cbIl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(331, 17);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(562, 215);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hasta TC Kimlik No";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hasta Ad Soyad";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Randevu Tarihi";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Randevu Bölümü";
            this.columnHeader4.Width = 100;
            // 
            // btnRandevuAra
            // 
            this.btnRandevuAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAra.Location = new System.Drawing.Point(11, 189);
            this.btnRandevuAra.Name = "btnRandevuAra";
            this.btnRandevuAra.Size = new System.Drawing.Size(290, 43);
            this.btnRandevuAra.TabIndex = 8;
            this.btnRandevuAra.Text = "Randevu Ara";
            this.btnRandevuAra.UseVisualStyleBackColor = true;
            this.btnRandevuAra.Click += new System.EventHandler(this.btnRandevuAra_Click);
            // 
            // cbKlinik
            // 
            this.cbKlinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKlinik.FormattingEnabled = true;
            this.cbKlinik.Location = new System.Drawing.Point(11, 141);
            this.cbKlinik.Name = "cbKlinik";
            this.cbKlinik.Size = new System.Drawing.Size(290, 33);
            this.cbKlinik.TabIndex = 4;
            this.cbKlinik.Text = "-Klinik Seçiniz-";
            // 
            // cbHastane
            // 
            this.cbHastane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbHastane.FormattingEnabled = true;
            this.cbHastane.Location = new System.Drawing.Point(11, 99);
            this.cbHastane.Name = "cbHastane";
            this.cbHastane.Size = new System.Drawing.Size(290, 33);
            this.cbHastane.TabIndex = 5;
            this.cbHastane.Text = "-Hastane Seçiniz-";
            // 
            // cbIlce
            // 
            this.cbIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIlce.FormattingEnabled = true;
            this.cbIlce.Location = new System.Drawing.Point(11, 56);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Size = new System.Drawing.Size(290, 33);
            this.cbIlce.TabIndex = 6;
            this.cbIlce.Text = "-İlçe Seçiniz-";
            // 
            // cbIl
            // 
            this.cbIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIl.FormattingEnabled = true;
            this.cbIl.Location = new System.Drawing.Point(12, 17);
            this.cbIl.Name = "cbIl";
            this.cbIl.Size = new System.Drawing.Size(290, 33);
            this.cbIl.TabIndex = 7;
            this.cbIl.Text = "-İl Seçiniz-";
            // 
            // Randevularr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 307);
            this.Controls.Add(this.btnRandevuAra);
            this.Controls.Add(this.cbKlinik);
            this.Controls.Add(this.cbHastane);
            this.Controls.Add(this.cbIlce);
            this.Controls.Add(this.cbIl);
            this.Controls.Add(this.listView1);
            this.Name = "Randevularr";
            this.Text = "Randevularr";
            this.Load += new System.EventHandler(this.Randevularr_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnRandevuAra;
        private System.Windows.Forms.ComboBox cbKlinik;
        private System.Windows.Forms.ComboBox cbHastane;
        private System.Windows.Forms.ComboBox cbIlce;
        private System.Windows.Forms.ComboBox cbIl;
    }
}