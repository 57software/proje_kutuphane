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
    public partial class EmanetAl : Form
    {
        public EmanetAl()
        {
            InitializeComponent();
        }

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

        // Gösterge paneline giriş
        private void btn_gostergePaneli_Click(object sender, EventArgs e)
        {
            GostergePaneli gostergePaneli = new GostergePaneli();
            gostergePaneli.Show();
            this.Close();
        }

        // Emanet Ver'e giriş
        private void btn_emanetVer_Click(object sender, EventArgs e)
        {
            EmanetVer emanetVer = new EmanetVer();
            emanetVer.Show();
            this.Close();
        }

        // Emanet Al'a giriş
        private void btn_emanetAl_Click(object sender, EventArgs e)
        {
            EmanetAl emanetAl = new EmanetAl();
            emanetAl.Show();
            this.Close();
        }

        // dataGrid'deki satıra tıklandığında verileri textBoxlara doldurur
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                txt_kitapID.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_emanetID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_teslimTarihi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txt_kutuphaneID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        Veriler veriler = new Veriler();

        // Kullanıcı adı arama
        private void btn_kullaniciAdi_ara_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kullaniciAdi_ara.Text.Trim().ToLower());
            veriler.Kullanıcı_ara(dataGridView1, kullaniciAdi);
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        // Kullanıcı adı listesi temizle
        private void btn_kullaniciAdi_yenile_Click(object sender, EventArgs e)
        {
            txt_kullaniciAdi_ara.Text = "";

            string ara_kullaniciAdi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kullaniciAdi_ara.Text.Trim().ToLower());
            veriler.Kullanıcı_ara(dataGridView1, ara_kullaniciAdi);
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        // Kitap adeti artır
        private void KitapAdetiArtir(int kitap_id, int kutuphane_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // Kitap adeti
            string query3 = "SELECT adet FROM kitaplar_kutuphane WHERE kitap_id = @kitap_id";
            MySqlCommand command3 = new MySqlCommand(query3, baglanti);
            command3.Parameters.AddWithValue("@kitap_id", kitap_id);

            int adet = Convert.ToInt32(command3.ExecuteScalar());

            int kitapSayisi = 0;
            kitapSayisi = adet + 1;

            baglanti.Close();

            veri_Tabani.KutuphanedekiKitabi_Guncelle(kitap_id, kutuphane_id, kitapSayisi);
        }

        // Emanet Al
        private void btn_emanet_al_Click(object sender, EventArgs e)
        {
            int kitap_id, emanet_id;
            string teslimTarihi, kutuphane_id;

            kitap_id = Convert.ToInt32(txt_kitapID.Text.Trim());
            emanet_id = Convert.ToInt32(txt_emanetID.Text.Trim());
            teslimTarihi = txt_teslimTarihi.Text.Trim();
            kutuphane_id = txt_kutuphaneID.Text.Trim();

            try
            {
                int kutuphane_id1 = Convert.ToInt32(kutuphane_id);

                DateTime bugun = DateTime.Today;

                string[] Tarih = teslimTarihi.Split('.');

                int teslimGun = Convert.ToInt32(Tarih[0]);
                int teslimAy = Convert.ToInt32(Tarih[1]);
                int teslimYil = Convert.ToInt32(Tarih[2]);

                DateTime kullanicininTarihi = new DateTime(teslimYil, teslimAy, teslimGun);
                TimeSpan fark = bugun - kullanicininTarihi;

                int gunFarki = fark.Days; // ücret (günlük 1 tl)

                if (gunFarki < 0)
                {
                    gunFarki = 0;
                }

                // ücreti kaydetti
                veri_Tabani.EmanetGuncelle(emanet_id, gunFarki);

                if(gunFarki > 0)
                {
                    DialogResult kontrol = MessageBox.Show("Ücret: " + gunFarki + "TL\nKullanıcı ödeme yaptı mı?", "Ödeme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (kontrol == DialogResult.Yes)
                    {
                        veri_Tabani.EmanetAl(emanet_id);

                        KitapAdetiArtir(kitap_id, kutuphane_id1);

                        MessageBox.Show("Emanet geri alındı!", "Emanet Al", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DialogResult kontrol = MessageBox.Show("Emaneti almak için emin misin?", "Emanet Al", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (kontrol == DialogResult.Yes)
                    {
                        veri_Tabani.EmanetAl(emanet_id);

                        KitapAdetiArtir(kitap_id, kutuphane_id1);

                        MessageBox.Show("Emanet geri alındı!", "Emanet Al", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
