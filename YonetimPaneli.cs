using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_kutuphane
{
    public partial class YonetimPaneli : Form
    {
        public YonetimPaneli()
        {
            InitializeComponent();
        }

        // Direkt çıkış
        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Emin misin sorusu soran çıkış
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            DialogResult kontrol = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kontrol == DialogResult.Yes)
            {
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Close();
            }
        }

        // Anasayfaya giriş
        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        // Yönetim paneline giriş
        private void btn_yonetimPaneli_Click(object sender, EventArgs e)
        {
            YonetimPaneli yonetimPaneli = new YonetimPaneli();
            yonetimPaneli.Show();
            this.Close();
        }

        // Üyeler'e giriş
        private void btn_uyeler_Click(object sender, EventArgs e)
        {
            Uyeler uyeler = new Uyeler();
            uyeler.Show();
            this.Close();
        }

        // Yayınevleri'ne giriş
        private void btn_yayinEvleri_Click(object sender, EventArgs e)
        {
            Yayinevleri yayinevleri = new Yayinevleri();
            yayinevleri.Show();
            this.Close();
        }

        // Kütüphaneye giriş
        private void btn_emanetAl_Click(object sender, EventArgs e)
        {
            Kutuphane kutuphane = new Kutuphane();
            kutuphane.Show();
            this.Close();
        }
        
        // Kitaplar'a giriş
        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show();
            this.Close();
        }
    }
}
