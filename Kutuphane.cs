using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_kutuphane
{
    public partial class Kutuphane : Form
    {
        public Kutuphane()
        {
            InitializeComponent();
        }

        Tablo tablo = new Tablo();
        Veri_Tabani veri_Tabani = new Veri_Tabani();
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

        // Kitaplar'a giriş
        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show();
            this.Close();
        }

        // Yayınevleri'ne giriş
        private void btn_yayinEvleri_Click(object sender, EventArgs e)
        {
            Yayinevleri yayinevleri = new Yayinevleri();
            yayinevleri.Show();
            this.Close();
        }

        // Kütüphane'ye giriş
        private void btn_kutuphane_Click(object sender, EventArgs e)
        {
            Kutuphane kutuphane = new Kutuphane();
            kutuphane.Show();
            this.Close();
        }

        // Veritabanında kütüphane kontrolü
        static bool KutuphaneAdiKontrol(MySqlConnection connection, string kutuphaneAd)
        {
            string query = "SELECT COUNT(*) FROM tbl_kutuphane WHERE kutuphaneAd = @kutuphaneAd";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@kutuphaneAd", kutuphaneAd);

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count == 0; // Kütüphane adı yok demek
        }

        // Kütüphane ekle
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string kutuphaneAdi, mahalle, cadde, sokak, binaNo, kapiNo, ilce, il;
            double binaNo1, kapiNo1;

            kutuphaneAdi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kutuphaneAd.Text.Trim().ToLower());
            mahalle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_mahalle.Text.Trim().ToLower());
            cadde = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_cadde.Text.Trim().ToLower());
            sokak = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_sokak.Text.Trim().ToLower());
            binaNo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_binaNo.Text.Trim());
            kapiNo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kapiNo.Text.Trim());
            ilce = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_ilce.Text.Trim().ToLower());
            il = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_il.Text.Trim().ToLower());

            MySqlConnection baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            bool kutuphaneKontrol = KutuphaneAdiKontrol(baglanti, kutuphaneAdi);

            if (String.IsNullOrEmpty(txt_kutuphaneAd.Text) || String.IsNullOrEmpty(txt_mahalle.Text) || String.IsNullOrEmpty(txt_cadde.Text) || String.IsNullOrEmpty(txt_sokak.Text) || String.IsNullOrEmpty(txt_binaNo.Text) || String.IsNullOrEmpty(txt_kapiNo.Text) || String.IsNullOrEmpty(txt_ilce.Text) || String.IsNullOrEmpty(txt_il.Text))
            {
                MessageBox.Show("Bilgiler eksik bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!kutuphaneKontrol)
            {
                try
                {
                    if (!KutuphaneAdiKontrol(baglanti, kutuphaneAdi))
                    {
                        MessageBox.Show("Bu kütüphane daha önce kaydedilmiş!", "Kütüphane Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                try
                {
                    // Adres kayıt
                    binaNo1 = Convert.ToDouble(binaNo);
                    kapiNo1 = Convert.ToDouble(kapiNo);
                    veri_Tabani.AdresKayit(mahalle, cadde, sokak, binaNo1, kapiNo1, ilce, il);

                    string query = "SELECT adres_id FROM adresler ORDER BY adres_id DESC LIMIT 1";
                    MySqlCommand command = new MySqlCommand(query, baglanti);
                    int adres_id = Convert.ToInt32(command.ExecuteScalar());

                    // Kütüphane kayıt
                    veri_Tabani.KutuphaneEkle(kutuphaneAdi, adres_id);

                    MessageBox.Show("Kütüphane başarıyla kaydedildi!", "Kütüphane Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglanti.Close();
                }
            }
            baglanti.Close();
        }

        // Temizle
        private void Temizle()
        {
            foreach (Control item in panel_islemler.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
        }

        // Kütüphane sil
        private void btn_sil_Click(object sender, EventArgs e)
        {
            string adresID = txt_adresID.Text;
            string kutuphaneID = txt_kutuphaneID.Text;
            int kutuphaneID1, adresID1;

            DialogResult kontrol = MessageBox.Show("Kütüphaneyi silmek istediğine emin misin?", "Kütüphane Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (String.IsNullOrEmpty(txt_kutuphaneAd.Text) || String.IsNullOrEmpty(txt_mahalle.Text) || String.IsNullOrEmpty(txt_cadde.Text) || String.IsNullOrEmpty(txt_sokak.Text) || String.IsNullOrEmpty(txt_binaNo.Text) || String.IsNullOrEmpty(txt_kapiNo.Text) || String.IsNullOrEmpty(txt_ilce.Text) || String.IsNullOrEmpty(txt_il.Text))
            {
                MessageBox.Show("Bilgiler eksik bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    adresID1 = Convert.ToInt32(adresID);
                    kutuphaneID1 = Convert.ToInt32(kutuphaneID);
                    if (kontrol == DialogResult.Yes)
                    {
                        veri_Tabani.AdresSil(adresID1);
                        veri_Tabani.KutuphaneSil(kutuphaneID1);

                        MessageBox.Show("Kütüphane silindi!", "Kütüphane Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Kütüphane güncelle
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string kutuphaneAdi, mahalle, cadde, sokak, binaNo, kapiNo, ilce, il;
            double binaNo1, kapiNo1;

            string kutuphaneID, adresID;
            int kutuphaneID1, adresID1;

            kutuphaneID = txt_kutuphaneID.Text;
            adresID = txt_adresID.Text;

            kutuphaneAdi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kutuphaneAd.Text.Trim().ToLower());
            mahalle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_mahalle.Text.Trim().ToLower());
            cadde = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_cadde.Text.Trim().ToLower());
            sokak = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_sokak.Text.Trim().ToLower());
            binaNo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_binaNo.Text.Trim());
            kapiNo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kapiNo.Text.Trim());
            ilce = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_ilce.Text.Trim().ToLower());
            il = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_il.Text.Trim().ToLower());

            DialogResult kontrol = MessageBox.Show("Kütüphaneyi güncellemek istediğine emin misin?", "Kütüphane Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (String.IsNullOrEmpty(txt_kutuphaneAd.Text) || String.IsNullOrEmpty(txt_mahalle.Text) || String.IsNullOrEmpty(txt_cadde.Text) || String.IsNullOrEmpty(txt_sokak.Text) || String.IsNullOrEmpty(txt_binaNo.Text) || String.IsNullOrEmpty(txt_kapiNo.Text) || String.IsNullOrEmpty(txt_ilce.Text) || String.IsNullOrEmpty(txt_il.Text))
            {
                MessageBox.Show("Bilgiler eksik bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (kontrol == DialogResult.Yes)
                {
                    try
                    {
                        kutuphaneID1 = Convert.ToInt32(kutuphaneID);
                        adresID1 = Convert.ToInt32(adresID);

                        binaNo1 = Convert.ToDouble(binaNo);
                        kapiNo1 = Convert.ToDouble(kapiNo);

                        veri_Tabani.AdresGuncelle(adresID1, mahalle, cadde, sokak, binaNo1, kapiNo1, ilce, il);
                        veri_Tabani.KutuphaneGuncelle(kutuphaneID1,kutuphaneAdi, adresID1);

                        MessageBox.Show("Kütüphane güncellendi!", "Kütüphane Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Datagrid'deki satıra tıkladığında veriler kutulara dolar
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                txt_kutuphaneID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_kutuphaneAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_adresID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_mahalle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_cadde.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_sokak.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_binaNo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_kapiNo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txt_ilce.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txt_il.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
        }

        Veriler veriler = new Veriler();

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string kutuphaneAdi = txt_kutuphaneAd_ara.Text;

            veriler.Kutuphane_ara(dataGridView1, kutuphaneAdi);
            dataGridView1.Columns[2].Visible = false;

            txt_kutuphaneAd_ara.Text = "";
        }

        // Liste açar
        private void btn_liste_Click(object sender, EventArgs e)
        {
            panel_liste.Visible = true;
            tablo.Kutuphane_doldur(dataGridView2);
            dataGridView2.Columns[2].Visible = false;
        }

        // Liste kapat
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            panel_liste.Visible = false;
        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            string kutuphaneAdi = txt_arama.Text;

            veriler.Kutuphane_ara(dataGridView2, kutuphaneAdi);

            txt_kutuphaneAd_ara.Text = "";
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_listeYenile_Click(object sender, EventArgs e)
        {
            tablo.Kutuphane_doldur(dataGridView2);
        }
    }
}
