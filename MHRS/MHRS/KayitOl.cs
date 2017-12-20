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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(Properties.Settings.Default.cnn);
        SqlCommand cmd = new SqlCommand();
        bool cinsiyet;
        bool kullaniciMevcutmu = false;
       List<Kullanicilar> kullanici = new List<Kullanicilar>();
        private void KayitOl_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtTC.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || txtSifre.Text == "" || txtSifreTekrar.Text == "")
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurunuz.");
            }
            else
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler aynı değil.");
                }
                else
                {
                    if (txtTC.Text.Length < 11)
                    {
                        MessageBox.Show("TC Kimlik numarası 11 haneli olmalıdır.");
                    }
                    else
                    {
                       if( txtSifre.Text.Length<8)
                        {
                            MessageBox.Show("Şifre en az 8 haneli olmalıdır.");
                        }
                        else
                        {
                            if (rbErkek.Checked||rbKadin.Checked)
                            {
                                if (dtpDogumTarihi.Value.ToShortDateString()==DateTime.Now.ToShortDateString())
                                {
                                    MessageBox.Show("Lütfen Doğum Tarihi Alanını Boş geçmeyin");
                                }
                                else
                                {
                                    if (rbKadin.Checked)
                                    {
                                        cinsiyet = true;
                                    }
                                    else
                                    {
                                        cinsiyet = false;
                                    }
                                    dtpDogumTarihi.Format = DateTimePickerFormat.Custom;
                                        dtpDogumTarihi.CustomFormat = "dd-MM-yyyy";
                                    if (cnn.State == ConnectionState.Closed)
                                        cnn.Open();
                                    SqlCommand getir = new SqlCommand("select * from Kullanicilar", cnn);
                                    SqlDataReader reader = getir.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        Kullanicilar kullanicim = new Kullanicilar();
                                        // kullanicim.KullaniciTC=int.Parse(reader["KullaniciTC"].ToString());
                                        kullanicim.KullaniciTC = (reader["KullaniciTC"].ToString());
                                        kullanici.Add(kullanicim);
                                    }
                                    reader.Close();
                                    cmd.Dispose();
                                    foreach (Kullanicilar item in kullanici)
                                    {
                                        if (item.KullaniciTC ==(txtTC.Text))
                                        {
                                            MessageBox.Show("Bu kullanıcı Sistemimizde mevcuttur.");
                                            kullaniciMevcutmu = true;
                                            break;
                                        }

                                    }
                                    if (kullaniciMevcutmu==false)
                                    {
                                        SqlCommand cmd = new SqlCommand("Insert Into Kullanicilar (KullaniciTC , Sifre , Ad , Soyad , DogumTarihi , Cinsiyet ) Values (@KullaniciTC , @KullaniciSifre , @Ad , @Soyad , @DogumTarihi , @Cinsiyet)", cnn);
                                        cmd.Parameters.AddWithValue("@KullaniciTC", txtTC.Text);
                                        cmd.Parameters.AddWithValue("@KullaniciSifre", txtSifre.Text);
                                        cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                                        cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                                        cmd.Parameters.AddWithValue("@DogumTarihi", dtpDogumTarihi.Value.ToShortDateString());
                                        cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                                        cmd.ExecuteNonQuery();
                                        cnn.Close();
                                        cmd.Dispose();
                                        MessageBox.Show("Sistemimize kaydınız alınmıştır.");
                                    }
                                   
                                }
                               

                            }
                            else
                            {
                                MessageBox.Show("Lütfen Cinsiyet Seçiniz.");
                            }
                           
                        }
                    }
                }
            }
        }

        private void btnGorunurYap_Click(object sender, EventArgs e)
        {
            if (btnGorunurYap.Text=="Görünür Yap")
            {
                txtSifre.UseSystemPasswordChar = false;
                txtSifreTekrar.UseSystemPasswordChar = false;
                btnGorunurYap.Text = "Gizle";
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                txtSifreTekrar.UseSystemPasswordChar = true;
                btnGorunurYap.Text = "Görünür Yap";
            }
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Form1 frmGiris = new Form1();
            this.Close();
            frmGiris.Show();
        }
    }
}
