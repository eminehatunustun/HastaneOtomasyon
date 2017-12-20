using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MHRS
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(Properties.Settings.Default.cnn);
        List<Kullanicilar> ListKullanicilarim = new List<Kullanicilar>();
        bool KullaniciVarmi = false;
        int ID;
        private void btnKullaniciAra_Click(object sender, EventArgs e)
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Kullanicilar", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //Kullanicilar kullanicim = new Kullanicilar();
                while (reader.Read())
                {
                    Kullanicilar kullanici = new Kullanicilar();
                    kullanici.KullaniciID = int.Parse(reader["KullaniciID"].ToString());
                    kullanici.KullaniciTC = (reader["KullaniciTC"].ToString());
                    kullanici.sifre = reader["Sifre"].ToString();
                    ListKullanicilarim.Add(kullanici);
                }
                reader.Close();
                cmd.Dispose();
                foreach (Kullanicilar kullanici in ListKullanicilarim)
                {
                    if (txtTC.Text==kullanici.KullaniciTC)
                    {
                        KullaniciVarmi = true;
                        ID = kullanici.KullaniciID;
                        break;

                    }
                    else
                    {
                        KullaniciVarmi = false;
                    }
                }
                if (KullaniciVarmi == true)
                {
                    txtSifre2.Visible = true;
                    txtSifre.Visible = true;
                    btnYeniSifre.Visible = true;
                    lblSifre.Visible = true;
                    lblSifre2.Visible = true;
                    
                   
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş");
                   // lblGUID.Text = Guid.NewGuid().ToString().Substring(0, 5);
                }
                //PropertyInfo[] kullanicim = typeof(Kullanicilar).GetProperties();
                //foreach (PropertyInfo property in kullanicim)
                //{
                //    //var value = property.GetValue(kullanicim);
                //}
            }
            cnn.Close();
            cmd.Dispose();
        }

        private void btnYeniSifre_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text=="" ||txtSifre2.Text=="")
            {
                MessageBox.Show("Lütfen yeni şifre belirleyin.");
            }
            else
            {
                if (txtSifre.Text!=txtSifre2.Text)
                {
                    MessageBox.Show("Şifreler aynı olmalı.");
                }
                else
                {
                    if (cnn.State == ConnectionState.Closed)
                        cnn.Open();
                    SqlCommand cmd = new SqlCommand("update Kullanicilar set Sifre=@Sifre where KullaniciID=@KullaniciID", cnn);
                    /// cmd.Parameters.AddWithValue = ("@Sifre",a);
                    cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                    cmd.Parameters.AddWithValue("@KullaniciID",ID);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    cmd.Dispose();
                    MessageBox.Show("Şifreniz başarıyla değiştirilmiştir.");
                }
            }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 frmGiris = new Form1();
            this.Close();
            frmGiris.Show();
        }
    }
}
