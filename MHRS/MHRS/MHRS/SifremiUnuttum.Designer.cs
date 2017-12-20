namespace MHRS
{
    partial class SifremiUnuttum
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
            this.lblSifre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.lblSifre2 = new System.Windows.Forms.Label();
            this.btnKullaniciAra = new System.Windows.Forms.Button();
            this.btnYeniSifre = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.Crimson;
            this.lblSifre.Location = new System.Drawing.Point(143, 64);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre:";
            this.lblSifre.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik Numarası:";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(207, 61);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(167, 30);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.Visible = false;
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(207, 14);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(167, 30);
            this.txtTC.TabIndex = 3;
            // 
            // txtSifre2
            // 
            this.txtSifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre2.Location = new System.Drawing.Point(207, 113);
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.Size = new System.Drawing.Size(167, 30);
            this.txtSifre2.TabIndex = 2;
            this.txtSifre2.UseSystemPasswordChar = true;
            this.txtSifre2.Visible = false;
            // 
            // lblSifre2
            // 
            this.lblSifre2.AutoSize = true;
            this.lblSifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre2.ForeColor = System.Drawing.Color.Crimson;
            this.lblSifre2.Location = new System.Drawing.Point(76, 118);
            this.lblSifre2.Name = "lblSifre2";
            this.lblSifre2.Size = new System.Drawing.Size(125, 25);
            this.lblSifre2.TabIndex = 4;
            this.lblSifre2.Text = "Şifre  Tekrar:";
            this.lblSifre2.Visible = false;
            // 
            // btnKullaniciAra
            // 
            this.btnKullaniciAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciAra.Location = new System.Drawing.Point(390, 12);
            this.btnKullaniciAra.Name = "btnKullaniciAra";
            this.btnKullaniciAra.Size = new System.Drawing.Size(87, 32);
            this.btnKullaniciAra.TabIndex = 6;
            this.btnKullaniciAra.Text = "Ara";
            this.btnKullaniciAra.UseVisualStyleBackColor = true;
            this.btnKullaniciAra.Click += new System.EventHandler(this.btnKullaniciAra_Click);
            // 
            // btnYeniSifre
            // 
            this.btnYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniSifre.Location = new System.Drawing.Point(81, 161);
            this.btnYeniSifre.Name = "btnYeniSifre";
            this.btnYeniSifre.Size = new System.Drawing.Size(293, 32);
            this.btnYeniSifre.TabIndex = 6;
            this.btnYeniSifre.Text = "Yeni Şifre Oluştur";
            this.btnYeniSifre.UseVisualStyleBackColor = true;
            this.btnYeniSifre.Visible = false;
            this.btnYeniSifre.Click += new System.EventHandler(this.btnYeniSifre_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Image = global::MHRS.Properties.Resources.back2;
            this.btnAnaSayfa.Location = new System.Drawing.Point(390, 104);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(177, 75);
            this.btnAnaSayfa.TabIndex = 6;
            this.btnAnaSayfa.Text = "Ana Sayfaya Dön";
            this.btnAnaSayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnaSayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 207);
            this.Controls.Add(this.btnYeniSifre);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnKullaniciAra);
            this.Controls.Add(this.lblSifre2);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtTC);
            this.Name = "SifremiUnuttum";
            this.Text = "SifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtSifre2;
        private System.Windows.Forms.Label lblSifre2;
        private System.Windows.Forms.Button btnKullaniciAra;
        private System.Windows.Forms.Button btnYeniSifre;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}