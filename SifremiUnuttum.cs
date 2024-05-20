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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje_kutuphane
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        // Çıkış
        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Login sayfasına giriş
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
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
        }

        Veri_Tabani veriTabani = new Veri_Tabani();
        Veriler veriler = new Veriler();

        // Şifre değiştir
        private void btn_sifreDegistir_Click(object sender, EventArgs e)
        {
            string eposta, kullaniciAdi, sifre, vt_sifre;
            eposta = txt_eposta.Text.Trim();
            kullaniciAdi = txt_kullaniciAdi.Text.Trim();
            sifre = txt_sifre.Text.Trim();

            if (String.IsNullOrEmpty(txt_kullaniciAdi.Text) || String.IsNullOrEmpty(txt_sifre.Text))
            {
                MessageBox.Show("Bilgiler eksik bırakılamaz!", "Şifremi Unuttum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kullaniciAdi == "Admin" || kullaniciAdi == "admin")
            {
                MessageBox.Show("Admin kullanıcısının şifresi değiştirilemez!", "Şifremi Unuttum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();
            }
            else if (sifre.Length < 8)
            {
                MessageBox.Show("Şifre 8 karakterden az olamaz!", "Şifremi Unuttum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sifre.Length > 16)
            {
                MessageBox.Show("Şifre 16 karakterden fazla olamaz!", "Şifremi Unuttum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int hesap = veriler.SifremiUnuttum(kullaniciAdi, eposta); // 1 hesap var - 0 hesap yok

                    if (hesap == 1)
                    {
                        try
                        {
                            vt_sifre = Sifreleme(sifre);
                            veriTabani.KullaniciSifremiUnuttum(kullaniciAdi, vt_sifre);
                            MessageBox.Show("Şifre değiştirildi!", "Şifremi Unuttum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizle();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya eposta yanlış!", "Şifremi Unuttum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
