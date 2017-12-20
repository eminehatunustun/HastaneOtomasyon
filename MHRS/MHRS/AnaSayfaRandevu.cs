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
using System.Collections;

namespace MHRS
{
    public partial class AnaSayfaRandevu : Form
    {
        public AnaSayfaRandevu()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(Properties.Settings.Default.cnn);
        Button tiklananButon;
        DateTime saat = new DateTime();
        List<Iller> ListIl = new List<Iller>();
        List<Ilceler> ListIlce = new List<Ilceler>();
        List<Hastaneler> ListHastane = new List<Hastaneler>();
        List<Klinikler> ListKlinik = new List<Klinikler>();
        List<Randevular> ListRandevu = new List<Randevular>();
        string saatimiz = "";
        string tarihimiz;
        bool dtpChanged = false;
        ArrayList taglar = new ArrayList();
        private void AnaSayfaRandevu_Load(object sender, EventArgs e)
        {
            IlleriGetir();
            tarihimiz = dtpRandevuTarihi.Value.ToShortDateString(); // 
        }

        private void IlleriGetir()
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();


            SqlCommand cmd = new SqlCommand("Select * From Iller ", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Iller il = new Iller();
                    il.IlID = int.Parse(reader["IlID"].ToString());
                    il.ilAdi = reader["IlAdi"].ToString();
                    ListIl.Add(il);
                    cbIl.Items.Add(il);
                    //cbIl.DataSource = il;
                    //cbIl.DisplayMember = "IlAdi";
                    //cbIl.ValueMember = "IlID";               
                }
            }
            reader.Close();
            cmd.Dispose();
            cnn.Close();
        }
        private void btnRandevuAra_Click(object sender, EventArgs e)
        {
            if (cbIl.SelectedItem==null ||cbIlce.SelectedItem==null||cbHastane.SelectedItem==null||cbKlinik.SelectedItem==null)
            {
                MessageBox.Show("Lütfen zorunlu alanları boş geçmeyiniz.");
            }
            else
            {
                butonOlustur();
                taglar = new ArrayList();
                Iller secilIl = cbIl.SelectedItem as Iller;
                Ilceler secilIlce = cbIlce.SelectedItem as Ilceler;
                Hastaneler secilHastane = cbHastane.SelectedItem as Hastaneler;
                Klinikler seciliKlinik = cbKlinik.SelectedItem as Klinikler;
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlCommand cmd = new SqlCommand("select * from randevular r where r.IlID=@IlID and r.IlceID=@IlceID and r.HastaneID=@HastaneID and r.KlinikID=@KlinikID and r.RandevuTarihi=@RandevuTarihi ", cnn);
                cmd.Parameters.AddWithValue("@IlID", secilIl.IlID);
                cmd.Parameters.AddWithValue("@IlceID", secilIlce.IlceID);
                cmd.Parameters.AddWithValue("@HastaneID", secilHastane.HastaneID);
                cmd.Parameters.AddWithValue("@KlinikID", seciliKlinik.KlinikID);
                cmd.Parameters.AddWithValue("@KullaniciID", Form1.KullaniciID);
             //   cmd.Parameters.AddWithValue("@RandevuSaati", saatimiz);
                
                cmd.Parameters.AddWithValue("@RandevuTarihi", dtpRandevuTarihi.Value.Date);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Randevular randevu = new Randevular();
                        randevu.RandevuID = int.Parse(reader["RandevuID"].ToString());
                        randevu.IlID = int.Parse(reader["IlID"].ToString());
                        randevu.IlceID = int.Parse(reader["IlceID"].ToString());
                        randevu.HastaneID = int.Parse(reader["HastaneID"].ToString());
                        randevu.KlinikID = int.Parse(reader["IlID"].ToString());
                        randevu.KullaniciID = int.Parse(reader["KullaniciID"].ToString());
                        randevu.RandevuTarihi = (reader["RandevuTarihi"].ToString());
                        randevu.RandevuSaati = (reader["RandevuSaati"].ToString());
                        ListRandevu.Add(randevu);
                    }

                }
                reader.Close();
                cmd.Dispose();
                cnn.Close();
                foreach (Randevular randevu in ListRandevu)
                {
                    switch (randevu.RandevuSaati.Substring(0, 5))
                    {
                        case "08:00": taglar.Add(0); break;
                        case "09:00": taglar.Add(1); break;
                        case "10:00": taglar.Add(2); break;
                        case "11:00": taglar.Add(3); break;
                        case "12:00": taglar.Add(4); break;
                        case "13:00": taglar.Add(5); break;
                        case "14:00": taglar.Add(6); break;
                        case "15:00": taglar.Add(7); break;
                        case "16:00": taglar.Add(8); break;
                        case "17:00": taglar.Add(9); break;
                    }

                }
                foreach (Button item in flpSaatler.Controls)
                {
                    if (taglar.IndexOf(item.Tag) >= 0)
                    {
                        item.Enabled = false;
                        item.BackColor = Color.Red;
                        item.ForeColor = Color.Gray;
                    }
                }
            }


        }

        private void butonOlustur()
        {
            for (int i = 0; i < 10; i++)
            {
                taglar = new ArrayList();
                Button btn = new Button();
                btn.BackColor = Color.White;
                btn.Tag = i;
                btn.Width = 80;
                btn.Height = 30;
                btn.Text = (i + 8).ToString() + ":00";
                flpSaatler.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            tiklananButon = sender as Button;
            saat = Convert.ToDateTime(tiklananButon.Tag + ":00");

            foreach (Button item in flpSaatler.Controls)
            {
                if (item.Enabled!=false)
                {
                    item.BackColor = Color.White;
                }
                
            }
            tiklananButon.BackColor = Color.Red;
            saatimiz = tiklananButon.Text;
        }

        private void flpSaatler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ilceler secilenIlce = cbIlce.SelectedItem as Ilceler;
            cbHastane.Items.Clear();
            cbKlinik.Items.Clear();
            cbHastane.Text = "-Hastane Seçiniz-";
            cbKlinik.Text = "-Klinik Seçiniz-";
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Hastane where IlceID=@IlceID ", cnn);
            cmd.Parameters.AddWithValue("@IlceID", secilenIlce.IlceID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Hastaneler hastane = new Hastaneler();
                    hastane.HastaneID = int.Parse(reader["HastaneID"].ToString());
                   hastane.HastaneAdi = reader["HastaneAdi"].ToString();
                    hastane.IlceID = int.Parse(reader["IlceID"].ToString());
                    ListHastane.Add(hastane);
                    cbHastane.Items.Add(hastane);
                }
                reader.Close();
                cmd.Dispose();
                cnn.Close();
            }
        }

        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {

            Iller secilenIl = cbIl.SelectedItem as Iller;
            cbIlce.Items.Clear();
            cbHastane.Items.Clear();
            cbKlinik.Items.Clear();
            cbIlce.Text = "-İlçe Seçiniz-";
            cbHastane.Text = "-Hastane Seçiniz-";
            cbKlinik.Text= "-Klinik Seçiniz-";
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Ilceler where IlID=@IlID ", cnn);
            cmd.Parameters.AddWithValue("@IlID",secilenIl.IlID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Ilceler ilce = new Ilceler();
                    ilce.IlceID=int.Parse(reader["IlceID"].ToString());
                    ilce.ilceAdi = reader["IlceAdi"].ToString();
                    ilce.IlID = int.Parse(reader["IlID"].ToString());
                    ListIlce.Add(ilce);
                    cbIlce.Items.Add(ilce);
                }
                reader.Close();
                cmd.Dispose();
                cnn.Close();
            }
        }

        private void cbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {

            Hastaneler secilenHastane = cbHastane.SelectedItem as Hastaneler;
            cbKlinik.Items.Clear();
            cbKlinik.Text = "-Klinik Seçiniz-";
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Klinik where HastaneID=@HastaneID ", cnn);
            cmd.Parameters.AddWithValue("@HastaneID", secilenHastane.HastaneID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Klinikler klinik = new Klinikler();
                    klinik.KlinikID = int.Parse(reader["KlinikID"].ToString());
                    klinik.KlinikAdi= reader["KlinikAdi"].ToString();
                    klinik.HastaneID = int.Parse(reader["HastaneID"].ToString());
                    ListKlinik.Add(klinik);
                    cbKlinik.Items.Add(klinik);
                }
                reader.Close();
                cmd.Dispose();
                cnn.Close();
            }
        }

        private void cbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRandevuyuKaydet_Click(object sender, EventArgs e)
        {
            if (cbIl.Text=="-İl Seçiniz-" || cbIlce.Text == "-İlçe Seçiniz-" || cbHastane.Text == "-Hastane Seçiniz-"||cbKlinik.Text == "-Klinik Seçiniz-" ||dtpChanged==false)
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Boş Geçmeyin");
                if (dtpChanged==false)
                {
                    MessageBox.Show("Lütfen tarih seçin.");
                }
            }
            else
            {
                Iller secilIl = cbIl.SelectedItem as Iller;
                Ilceler secilIlce = cbIlce.SelectedItem as Ilceler;
                Hastaneler secilHastane = cbHastane.SelectedItem as Hastaneler;
                Klinikler seciliKlinik = cbKlinik.SelectedItem as Klinikler;
                if (cnn.State==ConnectionState.Closed)
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into randevular (IlID, IlceID, HastaneID, KlinikID, KullaniciID, RandevuSaati,RandevuTarihi) values (@IlID, @IlceID, @HastaneID, @KlinikID, @KullaniciID, @RandevuSaati, @RandevuTarihi)", cnn);
                    cmd.Parameters.AddWithValue("@IlID",secilIl.IlID);
                    cmd.Parameters.AddWithValue("@IlceID",secilIlce.IlceID);
                    cmd.Parameters.AddWithValue("@HastaneID",secilHastane.HastaneID);
                    cmd.Parameters.AddWithValue("@KlinikID",seciliKlinik.KlinikID);
                    cmd.Parameters.AddWithValue("@KullaniciID",Form1.KullaniciID);
                    cmd.Parameters.AddWithValue("@RandevuSaati",saatimiz);
                    cmd.Parameters.AddWithValue("@RandevuTarihi",dtpRandevuTarihi.Value.Date );
                    //dtpRandevuTarihi.Format = DateTimePickerFormat.Custom;
                    //dtpRandevuTarihi.CustomFormat = "dd-MM-yyyy";

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cnn.Close();
                    MessageBox.Show("Randevunuz Başarıyla Kaydoldu.");
                }
            }
        }

        private void dtpRandevuTarihi_ValueChanged(object sender, EventArgs e)
        {
            tarihimiz = dtpRandevuTarihi.Value.ToShortDateString();
            dtpChanged = true;
           
        }
    }
}
