using MySql.Data.MySqlClient;
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
    public partial class GostergePaneli : Form
    {
        public GostergePaneli()
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

        // Gösterge paneline giriş
        private void btn_gostergePaneli_Click(object sender, EventArgs e)
        {
            GostergePaneli gostergePaneli = new GostergePaneli();
            gostergePaneli.Show();
            this.Close();
        }

        // Emanet ver'e giriş
        private void btn_emanetVer_Click(object sender, EventArgs e)
        {
            EmanetVer emanetVer = new EmanetVer();
            emanetVer.Show();
            this.Close();
        }

        // Emanet al'a giriş
        private void btn_emanetAl_Click(object sender, EventArgs e)
        {
            EmanetAl emanetAl = new EmanetAl();
            emanetAl.Show();
            this.Close();
        }

        Veriler veriler = new Veriler();

        private void GostergePaneli_Load(object sender, EventArgs e)
        {
            // Kitap sayısı
            lbl_mevcutKitaplar.Text = veriler.KitapSayisi().ToString();

            // Emanet verilenler
            lbl_emanetVerilenler.Text = veriler.EmanetVerilenler().ToString();

            // Emanet alınanlar
            lbl_emanetAlinanlar.Text = veriler.EmanetAlinanlar().ToString();

            // Üye sayısı
            lbl_uyeSayisi.Text = veriler.UyeSayisi().ToString();
        }
    }
}
