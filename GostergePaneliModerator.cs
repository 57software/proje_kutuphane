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
    public partial class GostergePaneliModerator : Form
    {
        public GostergePaneliModerator()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection(Baglan.Bag);

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
            Moderator moderator = new Moderator();
            moderator.Show();
            this.Close();
        }

        // Gösterge paneline giriş
        private void btn_gostergePaneli_Click(object sender, EventArgs e)
        {
            GostergePaneliModerator moderator = new GostergePaneliModerator();
            moderator.Show();
            this.Close();
        }

        // Emanet ver'e giriş
        private void btn_emanetVer_Click(object sender, EventArgs e)
        {
            EmanetVerModerator moderator = new EmanetVerModerator();
            moderator.Show();
            this.Close();
        }

        // Emanet al'a giriş
        private void btn_emanetAl_Click(object sender, EventArgs e)
        {
            EmanetAlModerator moderator = new EmanetAlModerator();
            moderator.Show();
            this.Close();
        }

        // Kitap listesi
        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            ModeratorKitapListe moderatorKitapListe = new ModeratorKitapListe();
            moderatorKitapListe.Show();
            this.Close();
        }

        Veriler veriler = new Veriler();

        private void GostergePaneliModerator_Load(object sender, EventArgs e)
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
