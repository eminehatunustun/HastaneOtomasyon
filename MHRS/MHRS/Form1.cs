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
using System.Reflection;

namespace MHRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(Properties.Settings.Default.cnn);
        List<Kullanicilar> ListKullanicilarim = new List<Kullanicilar>();
        bool giris = false;
        public static int KullaniciID;
        //   Guid g = new Guid();
        private void Form1_Load(object sender, EventArgs e)
        {
            //var Guid = new System.Guid();
            pbSifreGorunur.Tag = "A";
            lblGUID.Text = Guid.NewGuid().ToString().Substring(0, 5);
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == null && txtTC.Text == null)
            {
                MessageBox.Show("Lütfen TC Kimlik ve Şifre Alanlarını Doldorunuz.");
            }
            else
            {
                if (txtGUID.Text == lblGUID.Text)
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
                        foreach (Kullanicilar kullanici in ListKullanicilarim)
                        {
                            if (txtTC.Text != kullanici.KullaniciTC.ToString() || txtSifre.Text != kullanici.sifre)
                            {
                                giris = false;

                            }
                            else
                            {
                                giris = true;
                                KullaniciID = kullanici.KullaniciID;
                                break;
                            }
                        }
                        if (giris == true)
                        {
                            AnaSayfaRandevu frmrandevu = new AnaSayfaRandevu();
                            this.Hide();
                            frmrandevu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı Giriş");
                            lblGUID.Text = Guid.NewGuid().ToString().Substring(0, 5);
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
                else
                {
                    MessageBox.Show("Lütfen Resimde Gördüğünüzü Yazınız. ");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblGUID.Text = Guid.NewGuid().ToString().Substring(0, 5);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTC_Click(object sender, EventArgs e)
        {
            txtTC.Clear();
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.Clear();
        }

        private void txtGUID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGUID_Click(object sender, EventArgs e)
        {
            txtGUID.Clear();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayitOl kayit = new KayitOl();
            this.Hide();
            kayit.Show();
        }

        private void pbSifreGorunur_MouseHover(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false;
            pbSifreGorunur.Image = Properties.Resources.close;
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum frmSifre = new SifremiUnuttum();
            this.Hide();
            frmSifre.Show();
        }

        private void pbSifreGorunur_MouseLeave(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            pbSifreGorunur.Image = Properties.Resources.open;
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
