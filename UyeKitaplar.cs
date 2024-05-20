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
    public partial class UyeKitaplar : Form
    {
        public UyeKitaplar()
        {
            InitializeComponent();
        }

        Tablo tablo = new Tablo();
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
            Uye uye = new Uye();
            uye.Show();
            this.Close();
        }

        // Kitaplar'a giriş
        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            UyeKitaplar uye = new UyeKitaplar();
            uye.Show();
            this.Close();
        }

        Veriler veriler = new Veriler();

        private void UyeKitaplar_Load(object sender, EventArgs e)
        {
            tablo.Kitap_doldur(dataGridView1);
        }

        // Genel Liste'de Ara
        private void btn_listeArama_Click(object sender, EventArgs e)
        {
            string ara_kitapAdi = txt_arama.Text;
            veriler.Kitap_ara(dataGridView1, ara_kitapAdi);
            txt_arama.Text = "";
        }

        // Genel Liste Yenile
        private void btn_listeYenile_Click(object sender, EventArgs e)
        {
            tablo.Kitap_doldur(dataGridView1);
        }
    }
}
