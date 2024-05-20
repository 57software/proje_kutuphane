using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje_kutuphane
{
    public partial class Kitaplar : Form
    {
        public Kitaplar()
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

        // Uyeler'e giriş
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

        // Ekleme sayfası butonu
        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;

            panel3.Visible = true;

            panel5.Visible = true;
        }

        // Liste butonu
        private void btn_kitapListe_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            tablo.Kitap_doldur(dataGridView1);

            panel3.Visible = false;

            panel5.Visible = false;
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            panel3.Visible = true;

            YayinEvi_Yukle();
            Kategori_Yukle();
        }

        // Yayinevlerini comboBox'a yükler
        private void YayinEvi_Yukle()
        {
            MySqlConnection baglanti = new MySqlConnection(Baglan.Bag);

            try
            {
                baglanti.Open();
                string query = "SELECT yayinEviAdi FROM tbl_yayin_evleri";
                MySqlCommand cmd = new MySqlCommand(query, baglanti);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    yayinEvi.Items.Add(dr["yayinEviAdi"].ToString());
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        // Kategorileri comboBox'a yükler
        private void Kategori_Yukle()
        {
            MySqlConnection baglanti = new MySqlConnection(Baglan.Bag);

            try
            {
                baglanti.Open();
                string query = "SELECT DISTINCT kategoriAdi FROM kategoriler";
                MySqlCommand cmd = new MySqlCommand(query, baglanti);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    kategori.Items.Add(dr["kategoriAdi"].ToString());
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        // ISBN kontrol
        static bool isbnKontrol(MySqlConnection connection, string ISBN)
        {
            string query = "SELECT COUNT(ISBN) FROM tbl_kitaplar WHERE ISBN = @isbn";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@isbn", ISBN);

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count == 0; // ISBN yok demek
        }

        Veriler veriler = new Veriler();

        // Kitap ekle
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string kategori_degisken, yazarAd, yazarSoyad, kitapAdi, kitapDili;

            string sayfaSayisi, kutuphaneID, kitapAdet; // int
            int sayfaSayisi1, kutuphaneID1, kitapAdet1;

            string ISBN; // double
            double ISBN1;

            string yayinTarihi;

            kategori_degisken = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kategori.Text.Trim().ToLower());
            kutuphaneID = txt_kutuphaneID.Text.Trim();
            kitapAdet = txt_kitapAdet.Text.Trim();
            yazarAd = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_yazarAd.Text.Trim().ToLower());
            yazarSoyad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_yazarSoyad.Text.Trim().ToLower());
            ISBN = txt_ISBN.Text.Trim();
            kitapAdi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kitapAdi.Text.Trim().ToLower());
            yayinTarihi = dateTimePicker1.Value.ToShortDateString();
            sayfaSayisi = txt_sayfaSayisi.Text.Trim();
            kitapDili = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kitapDili.Text.Trim().ToLower());

            baglanti.Open();

            try
            {
                int yayinEvi_id = veriler.YayineviID(yayinEvi.Text);

                bool isbn_Kontrol = isbnKontrol(baglanti, ISBN);

                if (String.IsNullOrEmpty(yayinEvi.Text) || String.IsNullOrEmpty(kategori.Text) || String.IsNullOrEmpty(txt_kutuphaneID.Text) || String.IsNullOrEmpty(txt_kitapAdet.Text) || String.IsNullOrEmpty(txt_yazarAd.Text) || String.IsNullOrEmpty(txt_yazarSoyad.Text) || String.IsNullOrEmpty(txt_ISBN.Text) || String.IsNullOrEmpty(txt_kitapAdi.Text) || dateTimePicker1.Value.ToShortDateString() == "" || String.IsNullOrEmpty(txt_sayfaSayisi.Text) || String.IsNullOrEmpty(txt_kitapDili.Text))
                {
                    MessageBox.Show("Bilgiler boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!isbn_Kontrol)
                {
                    try
                    {
                        if (!isbnKontrol(baglanti, ISBN))
                        {
                            MessageBox.Show("Bu kitap kayıtlı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        ISBN1 = Convert.ToDouble(ISBN);
                        sayfaSayisi1 = Convert.ToInt32(sayfaSayisi);
                        kutuphaneID1 = Convert.ToInt32(kutuphaneID);
                        kitapAdet1 = Convert.ToInt32(kitapAdet);

                        veri_Tabani.KitapEkle(yayinEvi_id, ISBN1, kitapAdi, yayinTarihi, sayfaSayisi1, kitapDili);

                        int enSonki_kitapID = veriler.EnSonKayitKitapID();

                        veri_Tabani.YazarEkle(enSonki_kitapID, yazarAd, yazarSoyad);
                        veri_Tabani.KategoriEkle(enSonki_kitapID, kategori_degisken);
                        veri_Tabani.KutuphaneyeKitap_Ekle(enSonki_kitapID, kutuphaneID1, kitapAdet1);

                        MessageBox.Show("Kitap başarıyla eklendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Temizle
        private void Temizle()
        {
            dateTimePicker1.Value = DateTime.Now;

            foreach (Control item in panel5.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
            yayinEvi.Text = "";
            kategori.Text = "";
        }

        // Kitap sil
        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult kontrol = MessageBox.Show("Kitabı kütüphaneden silmek istediğine emin misin?", "Kitap Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (String.IsNullOrEmpty(yayinEvi.Text) || String.IsNullOrEmpty(kategori.Text) || String.IsNullOrEmpty(txt_kutuphaneID.Text) || String.IsNullOrEmpty(txt_kitapAdet.Text) || String.IsNullOrEmpty(txt_yazarAd.Text) || String.IsNullOrEmpty(txt_yazarSoyad.Text) || String.IsNullOrEmpty(txt_ISBN.Text) || String.IsNullOrEmpty(txt_kitapAdi.Text) || dateTimePicker1.Value.ToShortDateString() == "" || String.IsNullOrEmpty(txt_sayfaSayisi.Text) || String.IsNullOrEmpty(txt_kitapDili.Text))
            {
                MessageBox.Show("Bilgiler boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (kontrol == DialogResult.Yes)
                    {
                        double ISBN = Convert.ToDouble(txt_ISBN.Text);

                        int kitap_id = veriler.KitapID(ISBN);

                        veri_Tabani.KitapSil(kitap_id);
                        veri_Tabani.YazarSil(kitap_id);
                        veri_Tabani.KutuphanedenKitap_Sil(kitap_id);
                        veri_Tabani.KategoriSil(kitap_id);

                        MessageBox.Show("Kitap silindi!", "Kitap Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Kitap güncelle
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string yayin_Evi, Kategori, kutuphane_id, kitapAdet, yazarAd, yazarSoyad, ISBN, kitapAdi, yayinTarihi, sayfaSayisi, kitapDili;

            yayin_Evi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(yayinEvi.Text.Trim().ToLower());
            Kategori = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kategori.Text.Trim().ToLower());
            kutuphane_id = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kutuphaneID.Text.Trim().ToLower());
            kitapAdet = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kitapAdet.Text.Trim().ToLower());
            yazarAd = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_yazarAd.Text.Trim().ToLower());
            yazarSoyad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_yazarSoyad.Text.Trim().ToLower());
            ISBN = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_ISBN.Text.Trim().ToLower());
            kitapAdi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kitapAdi.Text.Trim().ToLower());
            yayinTarihi = dateTimePicker1.Value.ToShortDateString();
            sayfaSayisi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_sayfaSayisi.Text.Trim().ToLower());
            kitapDili = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kitapDili.Text.Trim().ToLower());

            DialogResult kontrol = MessageBox.Show("Kitabı güncellemek istediğine emin misin?", "Kitap Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (String.IsNullOrEmpty(yayinEvi.Text) || String.IsNullOrEmpty(kategori.Text) || String.IsNullOrEmpty(txt_kutuphaneID.Text) || String.IsNullOrEmpty(txt_kitapAdet.Text) || String.IsNullOrEmpty(txt_yazarAd.Text) || String.IsNullOrEmpty(txt_yazarSoyad.Text) || String.IsNullOrEmpty(txt_ISBN.Text) || String.IsNullOrEmpty(txt_kitapAdi.Text) || dateTimePicker1.Value.ToShortDateString() == "" || String.IsNullOrEmpty(txt_sayfaSayisi.Text) || String.IsNullOrEmpty(txt_kitapDili.Text))
            {
                MessageBox.Show("Bilgiler boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (kontrol == DialogResult.Yes)
                {
                    try
                    {
                        // dönüşümler
                        double ISBN1 = Convert.ToDouble(ISBN);
                        int sayfaSayisi1 = Convert.ToInt32(sayfaSayisi);
                        int kutuphaneID1 = Convert.ToInt32(kutuphane_id);
                        int kitapAdet1 = Convert.ToInt32(kitapAdet);

                        // kitap id
                        int kitap_id = veriler.KitapID(ISBN1);

                        // yayinevi id
                        int yayinEvi_id = veriler.YayineviID(yayin_Evi);

                        // yazar id
                        int yazarID = veriler.YazarID(kitap_id);

                        // kategori id
                        int kategori_id = veriler.KategoriID(kitap_id);

                        veri_Tabani.KitapGuncelle(kitap_id, yayinEvi_id, ISBN1, kitapAdi, yayinTarihi, sayfaSayisi1, kitapDili);
                        veri_Tabani.YazarGuncelle(yazarID, kitap_id, yazarAd, yazarSoyad);
                        veri_Tabani.KutuphanedekiKitabi_Guncelle(kitap_id, kutuphaneID1, kitapAdet1);
                        veri_Tabani.KategoriGuncelle(kategori_id, kitap_id, Kategori);

                        MessageBox.Show("Kitap güncellendi", "Kitap Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Ekleme - Silme - Düzenleme için arama
        private void btn_ekleAra_Click(object sender, EventArgs e)
        {
            string ara_kitapAdi = txt_ekleAra.Text;

            veriler.Kitap_ara(dataGridView2, ara_kitapAdi);

            txt_ekleAra.Text = "";
        }

        // Ekleme - Silme - Düzenleme için yenileme
        private void btn_ekleYenile_Click(object sender, EventArgs e)
        {
            txt_ekleAra.Text = "";
            string ara_kitapAdi = txt_ekleAra.Text;

            veriler.Kitap_ara(dataGridView2, ara_kitapAdi);
            Temizle();
        }

        // Datagrid'deki satıra tıkladığında veriler kutulara dolar
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null && !dataGridView2.CurrentRow.IsNewRow)
            {
                yayinEvi.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                kategori.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txt_kutuphaneID.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txt_kitapAdet.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                txt_yazarAd.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                txt_yazarSoyad.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                txt_ISBN.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                txt_kitapAdi.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();

                dateTimePicker1.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[8].Value);

                txt_sayfaSayisi.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
                txt_kitapDili.Text = dataGridView2.CurrentRow.Cells[10].Value.ToString();
            }
        }

        // Genel Liste'de Ara
        private void btn_listeArama_Click(object sender, EventArgs e)
        {
            string ara_kitapAdi = txt_arama.Text;
            veriler.Kitap_ara(dataGridView1, ara_kitapAdi);
        }

        // Genel Liste Yenile
        private void btn_listeYenile_Click(object sender, EventArgs e)
        {
            tablo.Kitap_doldur(dataGridView1);
        }
    }
}
