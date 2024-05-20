using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Uyeler : Form
    {
        public Uyeler()
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

        // Üye listesi kapat
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            panelButonlar.Visible = true;

            txt_kullaniciAdi.Text = "";
            txt_Adres_id.Text = "";
        }

        // Üye listesi aç
        private void btn_uyeListe_Click(object sender, EventArgs e)
        {
            tablo.Uye_doldur(dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            panelGuncelle.Visible = false;
            panelButonlar.Visible = false;
        }

        // Kullanıcı adı arama metodu
        public void Kullanıcı_ara(DataGridView dataGridView, string kullaniciAdi)
        {
            MySqlDataAdapter data;
            DataTable tablo;

            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();
            data = new MySqlDataAdapter("SELECT tbl_uyeler.uye_id AS 'Üye ID', tbl_uyeler.adres_id AS 'Adres ID', tbl_uyeler.uyeAd AS 'Üye Adı', tbl_uyeler.uyeSoyad AS 'Üye Soyadı', tbl_uyeler.kullaniciAdi AS 'Kullanıcı Adı', tbl_uyeler.sifre AS 'Şifre', tbl_uyeler.cinsiyet AS 'Cinsiyet', tbl_uyeler.telefon AS 'Telefon', tbl_uyeler.eposta AS 'Eposta', tbl_uyeler.yetki AS 'Yetki', tbl_uyeler.kayitTarihi AS 'Kayıt Tarihi', tbl_uyeler.yasaklimi AS 'Yasaklı mı', adresler.mahalle AS 'Mahalle', adresler.cadde AS 'Cadde', adresler.sokak AS 'Sokak', adresler.binaNo AS 'Bina No', adresler.kapiNo AS 'Kapı No', adresler.ilce AS 'İlçe', adresler.il AS 'İl' FROM tbl_uyeler, adresler WHERE kullaniciAdi = '" + kullaniciAdi + "' AND tbl_uyeler.adres_id = adresler.adres_id", baglanti);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            dataGridView.DataSource = tablo; // DataGridView'e verileri bağlama

            baglanti.Close();
        }

        // Yasaklamak için kullanıcı adı ara
        private void btn_yasaklaUyeAra_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciAdi_Ara.Text.Trim();
            Kullanıcı_ara(dataGridView2, kullaniciAdi);
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            txt_kullaniciAdi_Ara.Text = "";
        }

        // Kullanıcı adı listesi temizle
        private void btn_yasaklaUyeYenile_Click(object sender, EventArgs e)
        {
            txt_kullaniciAdi_Ara.Text = "";

            string ara_kullaniciAdi = txt_kullaniciAdi_Ara.Text;
            Kullanıcı_ara(dataGridView2, ara_kullaniciAdi);
        }

        // Veritabanına özel şifreleme metodu
        private string Sifreleme(string kullanici_sifre)
        {
            string sifre, guvenlikBas, guvenlikSon, rastgeleSayi, yapilanSifre, uretilenSifre;

            rastgeleSayi = "411349"; // 6
            guvenlikBas = "Library"; // 7
            guvenlikSon = "123987";  // 6

            // Min: 7+8+6+6=27
            // Max: 7+16+6+6=35
            yapilanSifre = guvenlikBas + kullanici_sifre + rastgeleSayi + guvenlikSon; // 27 ya da 35

            uretilenSifre = "1234567890"; // 10

            sifre = yapilanSifre + uretilenSifre; // 27+10 = 37 ya da 35+10=45

            return sifre;
        }

        // Şifre çöz
        public string SifreCöz(string sifre)
        {
            string cozulenSifre = "";
            for (int i = 37; i < 46; i++)
            {
                if (sifre.Length == i)
                {
                    cozulenSifre = sifre.Substring(7, (i - 29));
                    break;
                }
            }
            return cozulenSifre;
        }

        // Datagrid'deki satıra tıkladığında veriler kutulara dolar
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null && !dataGridView2.CurrentRow.IsNewRow)
            {
                txt_kullaniciAdi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                txt_Adres_id.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

                if (panelGuncelle.Visible == true)
                {
                    txt_vtSifre.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();

                    txt_uyeID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    txt_ad.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                    txt_soyad.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                    txt_kullaniciAdi2.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    // sifre güvenlik amacıyla yazılmamıştır
                    txt_eposta.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
                    maskedTextBox1.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
                    comboBox1.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                    comboBox_Yetki.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();

                    txt_adresID.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    txt_mahalle.Text = dataGridView2.CurrentRow.Cells[12].Value.ToString();
                    txt_cadde.Text = dataGridView2.CurrentRow.Cells[13].Value.ToString();
                    txt_sokak.Text = dataGridView2.CurrentRow.Cells[14].Value.ToString();
                    txt_binaNo.Text = dataGridView2.CurrentRow.Cells[15].Value.ToString();
                    txt_kapiNo.Text = dataGridView2.CurrentRow.Cells[16].Value.ToString();
                    txt_ilce.Text = dataGridView2.CurrentRow.Cells[17].Value.ToString();
                    txt_il.Text = dataGridView2.CurrentRow.Cells[18].Value.ToString();
                }
            }
        }

        // Üye yasakla
        private void btn_kullaniciYasakla_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciAdi.Text.Trim();

            if (String.IsNullOrEmpty(txt_kullaniciAdi.Text))
            {
                MessageBox.Show("Bilgiler eksik bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kullaniciAdi == "Admin" || kullaniciAdi == "admin")
            {
                MessageBox.Show("Admin kullanıcısı yasaklanamaz!", "Üye Yasakla", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult kontrol = MessageBox.Show("Üyeyi yasaklamak istediğine emin misin?", "Üye Yasakla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (kontrol == DialogResult.Yes)
                {
                    veri_Tabani.UyeYasakla(kullaniciAdi);
                    MessageBox.Show("Kullanıcı yasaklandı!", "Üye Yasakla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Üye yasağını kaldır
        private void btn_uyeYasakKaldir_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciAdi.Text.Trim();

            if (String.IsNullOrEmpty(txt_kullaniciAdi.Text))
            {
                MessageBox.Show("Bilgiler eksik bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult kontrol = MessageBox.Show("Üyenin yasağını kaldırmak istediğine emin misin?", "Üye Yasağını Kaldır", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (kontrol == DialogResult.Yes)
                {
                    veri_Tabani.UyeYasakKaldir(kullaniciAdi);
                    MessageBox.Show("Kullanıcının yasağı kaldırıldı!", "Üye Yasağını Kaldır", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Üyelik sil
        private void btn_uyeSil_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = txt_kullaniciAdi.Text.Trim();
            string adresID = txt_Adres_id.Text.Trim();
            int adres_id;

            if (String.IsNullOrEmpty(txt_kullaniciAdi.Text))
            {
                MessageBox.Show("Bilgiler eksik bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kullaniciAdi == "Admin" || kullaniciAdi == "admin")
            {
                MessageBox.Show("Admin kullanıcısı silinemez!", "Üye Sil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult kontrol = MessageBox.Show("Üyeliği silmek istediğine emin misin?", "Üye Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (kontrol == DialogResult.Yes)
                {
                    try
                    {
                        adres_id = Convert.ToInt32(adresID);

                        veri_Tabani.AdresSil(adres_id);
                        veri_Tabani.UyeSil(kullaniciAdi);

                        MessageBox.Show("Kullanıcı silindi!", "Üye Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Güncelleme paneli açar
        private void btn_guncellePanel_Click(object sender, EventArgs e)
        {
            panelGuncelle.Visible = true;
            panel3.Visible = false;
            panel4.Visible = true;
            panelButonlar.Visible = false;
        }

        // Üye güncelle
        private void btn_uyeGuncelle_Click(object sender, EventArgs e)
        {
            // Adres bilgileri
            string adresID, mahalle, cadde, sokak, binaNo, kapiNo, ilce, il;
            double binaNo1, kapiNo1;
            int adresID1;

            adresID = txt_adresID.Text.Trim();
            mahalle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_mahalle.Text.Trim().ToLower());
            cadde = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_cadde.Text.Trim().ToLower());
            sokak = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_sokak.Text.Trim().ToLower());
            binaNo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_binaNo.Text.Trim());
            kapiNo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kapiNo.Text.Trim());
            ilce = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_ilce.Text.Trim().ToLower());
            il = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_il.Text.Trim().ToLower());

            // Kişisel bilgiler
            string uyeID, uyeAd, uyeSoyad, kullaniciAdi, sifre, cinsiyet, telefon, eposta, yetki;
            double telefon1;
            string guvenliSifre;
            int uyeID1;

            string vt_sifre = txt_vtSifre.Text.Trim();

            uyeID = txt_uyeID.Text.Trim();

            uyeAd = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_ad.Text.Trim().ToLower());
            uyeSoyad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_soyad.Text.Trim().ToLower());

            kullaniciAdi = txt_kullaniciAdi2.Text.Trim();
            sifre = txt_sifre.Text.Trim();

            cinsiyet = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(comboBox1.Text.Trim().ToLower());
            telefon = maskedTextBox1.Text.Trim();
            eposta = txt_eposta.Text.Trim();
            yetki = comboBox_Yetki.Text.Trim();

            if (String.IsNullOrEmpty(txt_ad.Text) || String.IsNullOrEmpty(txt_soyad.Text) || String.IsNullOrEmpty(txt_kullaniciAdi.Text) || String.IsNullOrEmpty(txt_eposta.Text) || String.IsNullOrEmpty(maskedTextBox1.Text) || maskedTextBox1.Text.Length < 10 || comboBox1.Text == "Cinsiyet" || comboBox_Yetki.Text == "Yetki" || String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(txt_mahalle.Text) || String.IsNullOrEmpty(txt_cadde.Text) || String.IsNullOrEmpty(txt_sokak.Text) || String.IsNullOrEmpty(txt_binaNo.Text) || String.IsNullOrEmpty(txt_kapiNo.Text) || String.IsNullOrEmpty(txt_ilce.Text) || String.IsNullOrEmpty(txt_il.Text))
            {
                MessageBox.Show("Bilgiler eksik bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kullaniciAdi == "Admin" || kullaniciAdi == "admin")
            {
                MessageBox.Show("Admin kullanıcısı güncellenemez!", "Üye Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!String.IsNullOrEmpty(txt_sifre.Text))
                {
                    if (String.IsNullOrEmpty(txt_sifre.Text))
                    {
                        MessageBox.Show("Bilgiler eksik bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (sifre.Length < 8)
                    {
                        MessageBox.Show("Şifre 8 karakterden az olamaz!", "Üye Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (sifre.Length > 16)
                    {
                        MessageBox.Show("Şifre 16 karakterden fazla olamaz!", "Üye Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else // şifre doluysa çalışır
                    {
                        try
                        {
                            // Adres güncelle
                            adresID1 = Convert.ToInt32(adresID);
                            binaNo1 = Convert.ToDouble(binaNo);
                            kapiNo1 = Convert.ToDouble(kapiNo);
                            veri_Tabani.AdresGuncelle(adresID1, mahalle, cadde, sokak, binaNo1, kapiNo1, ilce, il);

                            // Üye güncelle
                            telefon1 = Convert.ToDouble(telefon);
                            uyeID1 = Convert.ToInt32(uyeID);

                            // Şifre güvenliği için ek şifreleme
                            guvenliSifre = Sifreleme(sifre);

                            veri_Tabani.UyeGuncelle(uyeID1, uyeAd, uyeSoyad, kullaniciAdi, guvenliSifre, cinsiyet, telefon1, eposta, yetki);

                            MessageBox.Show("Bilgiler başarıyla güncellendi!", "Üye Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizle();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else // şifre boşsa çalışır
                {
                    try
                    {
                        // Adres güncelle
                        adresID1 = Convert.ToInt32(adresID);
                        binaNo1 = Convert.ToDouble(binaNo);
                        kapiNo1 = Convert.ToDouble(kapiNo);
                        veri_Tabani.AdresGuncelle(adresID1, mahalle, cadde, sokak, binaNo1, kapiNo1, ilce, il);

                        // Üye güncelle
                        telefon1 = Convert.ToDouble(telefon);
                        uyeID1 = Convert.ToInt32(uyeID);

                        veri_Tabani.UyeGuncelle(uyeID1, uyeAd, uyeSoyad, kullaniciAdi, vt_sifre, cinsiyet, telefon1, eposta, yetki);

                        MessageBox.Show("Bilgiler başarıyla güncellendi!", "Üye Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Güncelleme paneli kapat
        private void btn_guncelleKapat_Click(object sender, EventArgs e)
        {
            panelGuncelle.Visible = false;
            panelButonlar.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            txt_kullaniciAdi.Text = "";
            txt_Adres_id.Text = "";
        }

        // Temizle
        private void Temizle()
        {
            foreach (Control item in panelGuncelle.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
            maskedTextBox1.Text = "";
            comboBox1.Text = "Cinsiyet";
            comboBox_Yetki.Text = "Yetki";
        }

        private void btn_listeArama_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_arama.Text.Trim();
            Kullanıcı_ara(dataGridView1, kullaniciAdi);
            txt_arama.Text = "";
        }

        private void btn_listeYenile_Click(object sender, EventArgs e)
        {
            tablo.Uye_doldur(dataGridView1);
        }
    }
}
