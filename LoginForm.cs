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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje_kutuphane
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Çıkış
        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Kayıt sayfasına gider
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            RegisterForm rForm = new RegisterForm();
            rForm.Show();
            this.Close();
        }

        // Şifre göster
        private void sifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = sifreGoster.Checked ? '\0' : '*';
        }

        Veriler veriler = new Veriler();

        // Giriş butonu
        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre, vt_sifre;
            int yasaklimi, hesap;

            kullaniciAdi = txt_kullaniciAdi.Text.Trim();
            sifre = txt_sifre.Text.Trim();

            vt_sifre = Sifreleme(sifre);

            try
            {
                yasaklimi = veriler.Yasaklimi(kullaniciAdi);

                if (txt_kullaniciAdi.Text == "" || txt_sifre.Text == "")
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (yasaklimi == 1)
                {
                    MessageBox.Show("Bu kullanıcı yasaklandı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (yasaklimi == 2)
                {
                    MessageBox.Show("Bu kullanıcı kayıtlı değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        hesap = veriler.HesapKontrol(kullaniciAdi, vt_sifre);

                        if (hesap == 1)
                        {
                            string yetki = veriler.YetkiKontrol(kullaniciAdi);

                            MessageBox.Show("Giriş başarılı!", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizle();
                            if (yetki == "Admin")
                            {
                                Admin admin = new Admin();
                                admin.Show();
                                this.Close();
                            }
                            else if (yetki == "Moderator")
                            {
                                Moderator moderator = new Moderator();
                                moderator.Show();
                                this.Close();
                            }
                            else
                            {
                                Uye uye = new Uye();
                                uye.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        // Şifre değiştirme sayfasına giriş
        private void btn_sifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            sifremiUnuttum.Show();
            this.Close();
        }
    }
}
