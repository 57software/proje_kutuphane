using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Reflection.Emit;

namespace proje_kutuphane
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Çıkış
        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Veritabanında kullanıcı adı kontrolü
        static bool KullaniciAdiKontrol(MySqlConnection connection, string kullaniciAdi)
        {
            string query = "SELECT COUNT(*) FROM tbl_uyeler WHERE kullaniciAdi = @kullaniciAdi";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count == 0; // Kullanıcı adı yok demek
        }

        // Veritabanında ePosta kontrolü
        static bool EpostaKontrol(MySqlConnection connection, string ePosta)
        {
            string query = "SELECT COUNT(*) FROM tbl_uyeler WHERE eposta = @ePosta";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@ePosta", ePosta);

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count == 0; // Eposta yok demek
        }

        // Veritabanında telefon numarası kontrolü
        static bool telefonKontrol(MySqlConnection connection, string telefon)
        {
            string query = "SELECT COUNT(*) FROM tbl_uyeler WHERE telefon = @Telefon";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Telefon", telefon);

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count == 0; // Telefon yok demek
        }

        // Kayıt butonu
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            Veri_Tabani islem = new Veri_Tabani();

            // Adres bilgileri
            string mahalle, cadde, sokak, binaNo, kapiNo, ilce, il;
            double binaNo1, kapiNo1;

            mahalle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_mahalle.Text.Trim().ToLower());
            cadde = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_cadde.Text.Trim().ToLower());
            sokak = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_sokak.Text.Trim().ToLower());
            binaNo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_binaNo.Text.Trim().ToLower());
            kapiNo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kapiNo.Text.Trim().ToLower());
            ilce = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_ilce.Text.Trim().ToLower());
            il = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_il.Text.Trim().ToLower());

            // Kişisel bilgiler
            string uyeAd, uyeSoyad, kullaniciAdi, sifre, cinsiyet, telefon, eposta, kayitTarihi;
            double telefon1;
            string guvenliSifre;

            uyeAd = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_ad.Text.Trim().ToLower());
            uyeSoyad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_soyad.Text.Trim().ToLower());

            kullaniciAdi = txt_kullaniciAdi.Text.Trim();
            sifre = txt_sifre.Text.Trim();

            cinsiyet = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(comboBox1.Text.Trim().ToLower());
            telefon = maskedTextBox1.Text.Trim();
            eposta = txt_eposta.Text.Trim();

            kayitTarihi = DateTime.Now.ToShortDateString();

            MySqlConnection baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();
            bool kullaniciKontrol = KullaniciAdiKontrol(baglanti, kullaniciAdi);
            bool epostaKontrol = EpostaKontrol(baglanti, eposta);
            bool TelefonKontrol = telefonKontrol(baglanti, telefon);

            if (String.IsNullOrEmpty(txt_ad.Text) || String.IsNullOrEmpty(txt_soyad.Text) || String.IsNullOrEmpty(txt_kullaniciAdi.Text) || String.IsNullOrEmpty(txt_sifre.Text) || String.IsNullOrEmpty(txt_eposta.Text) || String.IsNullOrEmpty(maskedTextBox1.Text) || maskedTextBox1.Text.Length < 10 || comboBox1.Text == "Cinsiyet" || String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(txt_mahalle.Text) || String.IsNullOrEmpty(txt_cadde.Text) || String.IsNullOrEmpty(txt_sokak.Text) || String.IsNullOrEmpty(txt_binaNo.Text) || String.IsNullOrEmpty(txt_kapiNo.Text) || String.IsNullOrEmpty(txt_ilce.Text) || String.IsNullOrEmpty(txt_il.Text))
            {
                MessageBox.Show("Bilgiler eksik bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!kullaniciKontrol)
            {
                try
                {
                    if (!KullaniciAdiKontrol(baglanti, kullaniciAdi))
                    {
                        MessageBox.Show("Bu kullanıcı adı başkası tarafından kullanılmakta!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else if (sifre.Length < 8)
            {
                MessageBox.Show("Şifre 8 karakterden az olamaz!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sifre.Length > 16)
            {
                MessageBox.Show("Şifre 16 karakterden fazla olamaz!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!epostaKontrol)
            {
                try
                {
                    if (!EpostaKontrol(baglanti, eposta))
                    {
                        MessageBox.Show("Bu E-Posta başkası tarafından kullanılmakta!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else if (!TelefonKontrol)
            {
                try
                {
                    if (!telefonKontrol(baglanti, telefon))
                    {
                        MessageBox.Show("Bu telefon başkası tarafından kullanılmakta!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    islem.AdresKayit(mahalle, cadde, sokak, binaNo1, kapiNo1, ilce, il);

                    // Şifre güvenliği için ek şifreleme
                    guvenliSifre = Sifreleme(sifre);

                    // Üye kayıt
                    telefon1 = Convert.ToDouble(telefon);
                    islem.UyeKayit(uyeAd, uyeSoyad, kullaniciAdi, guvenliSifre, cinsiyet, telefon1, eposta, kayitTarihi);

                    MessageBox.Show("Kayıt başarıyla tamamlandı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            baglanti.Close();
        }

        // Şifre göster
        private void sifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = sifreGoster.Checked ? '\0' : '*';
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

        // Temizle
        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
            maskedTextBox1.Text = "";
            comboBox1.Text = "Cinsiyet";
        }

        // Temizle butonu
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        // Giriş sayfasına gitme butonu
        private void btn_giris_Click(object sender, EventArgs e)
        {
            LoginForm lForm = new LoginForm();
            lForm.Show();
            this.Close();
        }
    }
}