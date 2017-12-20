namespace MHRS
{
    partial class AnaSayfaRandevu
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
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbIl = new System.Windows.Forms.ComboBox();
            this.cbIlce = new System.Windows.Forms.ComboBox();
            this.cbHastane = new System.Windows.Forms.ComboBox();
            this.cbKlinik = new System.Windows.Forms.ComboBox();
            this.flpSaatler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRandevuAra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRandevuyuKaydet = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(35, 25);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(290, 30);
            this.dtpRandevuTarihi.TabIndex = 0;
            this.dtpRandevuTarihi.ValueChanged += new System.EventHandler(this.dtpRandevuTarihi_ValueChanged);
            // 
            // cbIl
            // 
            this.cbIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIl.FormattingEnabled = true;
            this.cbIl.Location = new System.Drawing.Point(35, 67);
            this.cbIl.Name = "cbIl";
            this.cbIl.Size = new System.Drawing.Size(290, 33);
            this.cbIl.TabIndex = 1;
            this.cbIl.Text = "-İl Seçiniz-";
            this.cbIl.SelectedIndexChanged += new System.EventHandler(this.cbIl_SelectedIndexChanged);
            // 
            // cbIlce
            // 
            this.cbIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIlce.FormattingEnabled = true;
            this.cbIlce.Location = new System.Drawing.Point(35, 109);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Size = new System.Drawing.Size(290, 33);
            this.cbIlce.TabIndex = 1;
            this.cbIlce.Text = "-İlçe Seçiniz-";
            this.cbIlce.SelectedIndexChanged += new System.EventHandler(this.cbIlce_SelectedIndexChanged);
            // 
            // cbHastane
            // 
            this.cbHastane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbHastane.FormattingEnabled = true;
            this.cbHastane.Location = new System.Drawing.Point(35, 152);
            this.cbHastane.Name = "cbHastane";
            this.cbHastane.Size = new System.Drawing.Size(290, 33);
            this.cbHastane.TabIndex = 1;
            this.cbHastane.Text = "-Hastane Seçiniz-";
            this.cbHastane.SelectedIndexChanged += new System.EventHandler(this.cbHastane_SelectedIndexChanged);
            // 
            // cbKlinik
            // 
            this.cbKlinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKlinik.FormattingEnabled = true;
            this.cbKlinik.Location = new System.Drawing.Point(35, 194);
            this.cbKlinik.Name = "cbKlinik";
            this.cbKlinik.Size = new System.Drawing.Size(290, 33);
            this.cbKlinik.TabIndex = 1;
            this.cbKlinik.Text = "-Klinik Seçiniz-";
            this.cbKlinik.SelectedIndexChanged += new System.EventHandler(this.cbKlinik_SelectedIndexChanged);
            // 
            // flpSaatler
            // 
            this.flpSaatler.Location = new System.Drawing.Point(5, 29);
            this.flpSaatler.Name = "flpSaatler";
            this.flpSaatler.Size = new System.Drawing.Size(190, 180);
            this.flpSaatler.TabIndex = 2;
            // 
            // btnRandevuAra
            // 
            this.btnRandevuAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAra.Location = new System.Drawing.Point(35, 242);
            this.btnRandevuAra.Name = "btnRandevuAra";
            this.btnRandevuAra.Size = new System.Drawing.Size(290, 43);
            this.btnRandevuAra.TabIndex = 3;
            this.btnRandevuAra.Text = "Randevu Ara";
            this.btnRandevuAra.UseVisualStyleBackColor = true;
            this.btnRandevuAra.Click += new System.EventHandler(this.btnRandevuAra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpSaatler);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(331, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 213);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saatler";
            // 
            // btnRandevuyuKaydet
            // 
            this.btnRandevuyuKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuyuKaydet.Location = new System.Drawing.Point(336, 244);
            this.btnRandevuyuKaydet.Name = "btnRandevuyuKaydet";
            this.btnRandevuyuKaydet.Size = new System.Drawing.Size(201, 43);
            this.btnRandevuyuKaydet.TabIndex = 3;
            this.btnRandevuyuKaydet.Text = "Randevuyu Kaydet";
            this.btnRandevuyuKaydet.UseVisualStyleBackColor = true;
            this.btnRandevuyuKaydet.Click += new System.EventHandler(this.btnRandevuyuKaydet_Click);
            // 
            // AnaSayfaRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(651, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRandevuyuKaydet);
            this.Controls.Add(this.btnRandevuAra);
            this.Controls.Add(this.cbKlinik);
            this.Controls.Add(this.cbHastane);
            this.Controls.Add(this.cbIlce);
            this.Controls.Add(this.cbIl);
            this.Controls.Add(this.dtpRandevuTarihi);
            this.Name = "AnaSayfaRandevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfaRandevu";
            this.Load += new System.EventHandler(this.AnaSayfaRandevu_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private System.Windows.Forms.ComboBox cbIl;
        private System.Windows.Forms.ComboBox cbIlce;
        private System.Windows.Forms.ComboBox cbHastane;
        private System.Windows.Forms.ComboBox cbKlinik;
        private System.Windows.Forms.FlowLayoutPanel flpSaatler;
        private System.Windows.Forms.Button btnRandevuAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRandevuyuKaydet;
    }
}