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
    public partial class EmanetVerModerator : Form
    {
        public EmanetVerModerator()
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

        // Emanet alınacak kitap adı ara
        private void btn_emanetAra_Click(object sender, EventArgs e)
        {
            string ara_kitapAdi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kitapAdiARA.Text.Trim().ToLower());
            veriler.Kitap_ara(dataGridView2, ara_kitapAdi);
            dataGridView2.Columns[2].Visible = false;
        }

        // Emanet alınacak kitap arama listesini temizle
        private void btn_emanetYenile_Click(object sender, EventArgs e)
        {
            txt_kitapAdiARA.Text = "";
            string ara_kitapAdi = txt_kitapAdiARA.Text;

            veriler.Kitap_ara(dataGridView2, ara_kitapAdi);
            dataGridView2.Columns[2].Visible = false;
        }

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

        // Datagrid'deki satıra tıkladığında veriler kutulara dolar
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null && !dataGridView2.CurrentRow.IsNewRow)
            {
                txt_ISBN.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                txt_kutuphaneID.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            }
        }

        // Emanet kontrol
        static bool emanetKontrol(MySqlConnection connection, string kullaniciAdi, string ISBN)
        {
            // Üye id
            string query = "SELECT uye_id FROM tbl_uyeler WHERE kullaniciAdi = @kullaniciAdi";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

            int uye_id = Convert.ToInt32(command.ExecuteScalar());

            // Kitap id
            string query2 = "SELECT kitap_id FROM tbl_kitaplar WHERE ISBN = @isbn";
            MySqlCommand command2 = new MySqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@isbn", ISBN);

            int kitap_id = Convert.ToInt32(command2.ExecuteScalar());

            // Emanet kontrol
            string query3 = "SELECT COUNT(kitap_id) FROM tbl_emanet WHERE uye_id = @uye_id AND kitap_id = @kitap_id AND emanetmi = 1";
            MySqlCommand command3 = new MySqlCommand(query3, connection);
            command3.Parameters.AddWithValue("@uye_id", uye_id);
            command3.Parameters.AddWithValue("@kitap_id", kitap_id);

            int count = Convert.ToInt32(command3.ExecuteScalar());

            return count == 0; // Kitap yok demek
        }

        // Emanet ver
        private void btn_emanet_ver_Click(object sender, EventArgs e)
        {
            MySqlCommand bilgi = new MySqlCommand();
            baglanti.Open();
            bilgi.Connection = baglanti;

            string kullaniciAdi, ISBN, kutuphane_id, emanetTarihi, teslimTarihi;

            kullaniciAdi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_kullaniciAdi.Text.Trim().ToLower());
            ISBN = txt_ISBN.Text.Trim();
            kutuphane_id = txt_kutuphaneID.Text.Trim();

            emanetTarihi = DateTime.Now.ToShortDateString();

            teslimTarihi = DateTime.Now.AddDays(10).ToShortDateString();

            bool emanet_Kontrol = emanetKontrol(baglanti, kullaniciAdi, ISBN);

            int hesap = veriler.KitapEmanetKullanici(kullaniciAdi); // 1 ise hesap var, 0 ise hesap yok

            int KitapVarmi = veriler.KitapAdet(ISBN);

            DialogResult kontrol = MessageBox.Show("Kitabı emanet vermek için emin misin?", "Kitap Emanet Ver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (String.IsNullOrEmpty(txt_kullaniciAdi.Text) || String.IsNullOrEmpty(txt_ISBN.Text) || String.IsNullOrEmpty(txt_kutuphaneID.Text))
            {
                MessageBox.Show("Bilgiler boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (hesap == 0)
                {
                    MessageBox.Show("Kullanıcı kayıtlı değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (KitapVarmi == 0)
                    {
                        MessageBox.Show("Kitap stokta yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (emanet_Kontrol) // Kitap emanet alınmamışsa çalışacak
                        {
                            try
                            {
                                int kutuphane_id1 = Convert.ToInt32(kutuphane_id);

                                int uye_id = veriler.Uye_id(kullaniciAdi);

                                int emanet_sayisi = veriler.Emanet_sayisi(uye_id);

                                if (emanetKontrol(baglanti, kullaniciAdi, ISBN))
                                {
                                    if (emanet_sayisi == 3)
                                    {
                                        MessageBox.Show("Kullanıcı emanet alma sınırına ulaştı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else if (kontrol == DialogResult.Yes)
                                    {
                                        try
                                        {
                                            // Kitap id
                                            string query2 = "SELECT kitap_id FROM tbl_kitaplar WHERE ISBN = @isbn";
                                            MySqlCommand command2 = new MySqlCommand(query2, baglanti);
                                            command2.Parameters.AddWithValue("@isbn", ISBN);
                                            int kitap_id = Convert.ToInt32(command2.ExecuteScalar());

                                            veri_Tabani.EmanetVer(uye_id, kitap_id, kutuphane_id1, emanetTarihi, teslimTarihi, 0, 1);

                                            // Kitap adeti
                                            string query3 = "SELECT adet FROM kitaplar_kutuphane WHERE kitap_id = @kitap_id";
                                            MySqlCommand command3 = new MySqlCommand(query3, baglanti);
                                            command3.Parameters.AddWithValue("@kitap_id", kitap_id);
                                            int adet = Convert.ToInt32(command3.ExecuteScalar());

                                            if (adet < 0)
                                            {
                                                MessageBox.Show("Kitap stokta yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                            else
                                            {
                                                int kitapSayisi = 0;
                                                kitapSayisi = adet - 1;

                                                veri_Tabani.KutuphanedekiKitabi_Guncelle(kitap_id, kutuphane_id1, kitapSayisi);

                                                MessageBox.Show("Kitap emanet verildi!", "Emanet Ver", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Kullanıcı daha önce bu kitabı emanet aldı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            baglanti.Close();
        }
    }
}
