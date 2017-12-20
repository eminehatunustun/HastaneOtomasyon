using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHRS
{
    public partial class KullaniciSecim : Form
    {
        public KullaniciSecim()
        {
            InitializeComponent();
        }

        private void KullaniciSecim_Load(object sender, EventArgs e)
        {

        }

        private void pbUsers_Click(object sender, EventArgs e)
        {
            Form1 frmUsers = new Form1();
            this.Hide();
            frmUsers.Show();
        }

        private void pbAdmin_Click(object sender, EventArgs e)
        {
            Randevularr frmAdmin = new Randevularr();
            this.Hide();
            frmAdmin.Show();
        }
    }
}
