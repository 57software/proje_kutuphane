using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace proje_kutuphane
{
    public class Veriler
    {
        MySqlConnection baglanti;

        Veri_Tabani veri_Tabani = new Veri_Tabani();

        // Yasaklı mı? kontrolü
        public int Yasaklimi(string kullaniciAdi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // yasaklimi
            string query1 = "SELECT yasaklimi FROM tbl_uyeler WHERE kullaniciAdi = '" + kullaniciAdi + "'";
            MySqlCommand command1 = new MySqlCommand(query1, baglanti);
            object yasaklimiObj = Convert.ToInt32(command1.ExecuteScalar());
            int yasaklimi = yasaklimiObj != DBNull.Value ? Convert.ToInt32(yasaklimiObj) : 2; // null değer dönerse 2 return eder yani kullanıcı yok demek

            baglanti.Close();

            return yasaklimi;
        }

        // Hesap kontrolü
        public int HesapKontrol(string kullaniciAdi, string vt_sifre)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // hesap kontrol
            string query = "SELECT COUNT(uye_id) FROM tbl_uyeler WHERE kullaniciAdi = '" + kullaniciAdi + "' AND sifre = '" + vt_sifre + "'";
            MySqlCommand command = new MySqlCommand(query, baglanti);
            int hesap = Convert.ToInt32(command.ExecuteScalar()); // 1 olmalı

            baglanti.Close();

            return hesap;
        }

        public string YetkiKontrol(string kullaniciAdi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // yetki
            string query2 = "SELECT yetki FROM tbl_uyeler WHERE kullaniciAdi = '" + kullaniciAdi + "'";
            MySqlCommand command2 = new MySqlCommand(query2, baglanti);
            string yetki = command2.ExecuteScalar().ToString();

            baglanti.Close();

            return yetki;
        }

        public int KitapSayisi()
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // Kitap sayısı
            string query = "SELECT SUM(adet) FROM kitaplar_kutuphane WHERE adet > 0";
            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            object kitapSayisiObj = cmd.ExecuteScalar();
            int kitapSayisi = kitapSayisiObj != DBNull.Value ? Convert.ToInt32(kitapSayisiObj) : 0;

            baglanti.Close();

            return kitapSayisi;
        }

        public int EmanetVerilenler()
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // Emanet verilenler
            string query2 = "SELECT COUNT(emanet_id) FROM tbl_emanet WHERE emanetmi = 1";
            MySqlCommand cmd2 = new MySqlCommand(query2, baglanti);
            object emanetVerilenlerObj = cmd2.ExecuteScalar();
            int emanetVerilenler = emanetVerilenlerObj != DBNull.Value ? Convert.ToInt32(emanetVerilenlerObj) : 0;

            baglanti.Close();

            return emanetVerilenler;
        }

        public int EmanetAlinanlar()
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // Emanet alınanlar 
            string query1 = "SELECT COUNT(uye_id) FROM tbl_emanet WHERE emanetmi = 0";
            MySqlCommand cmd1 = new MySqlCommand(query1, baglanti);
            object emanetAlinanlarObj = cmd1.ExecuteScalar();
            int emanetAlinanlar = emanetAlinanlarObj != DBNull.Value ? Convert.ToInt32(emanetAlinanlarObj) : 0;

            baglanti.Close();

            return emanetAlinanlar;
        }

        public int UyeSayisi()
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // Üye sayısı
            string query3 = "SELECT COUNT(uye_id) FROM tbl_uyeler";
            MySqlCommand cmd3 = new MySqlCommand(query3, baglanti);
            object uyeSayisiObj = cmd3.ExecuteScalar();
            int uyeSayisi = uyeSayisiObj != DBNull.Value ? Convert.ToInt32(uyeSayisiObj) : 0;

            baglanti.Close();

            return uyeSayisi;
        }

        // Kullanıcı adı arama metodu
        public void Kullanıcı_ara(DataGridView dataGridView, string kullaniciAdi)
        {
            MySqlDataAdapter data;
            DataTable tablo;

            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();
            data = new MySqlDataAdapter("SELECT tbl_uyeler.kullaniciAdi AS 'Kullanıcı Adı', tbl_emanet.emanet_id AS 'Emanet ID', tbl_emanet.uye_id AS 'Üye ID', tbl_emanet.kitap_id AS 'Kitap ID', tbl_kitaplar.kitapAdi AS 'Kitap Adı', tbl_emanet.kutuphane_id AS 'Kütüphane ID', tbl_emanet.emanetTarihi AS 'Emanet Tarihi', tbl_emanet.teslimTarihi AS 'Teslim Tarihi', tbl_emanet.ucret AS 'Ücret', tbl_emanet.emanetmi AS 'Emanet mi' FROM tbl_uyeler, tbl_emanet, tbl_kitaplar WHERE tbl_uyeler.uye_id = tbl_emanet.uye_id AND tbl_kitaplar.kitap_id = tbl_emanet.kitap_id AND tbl_uyeler.kullaniciAdi = '" + kullaniciAdi + "' AND tbl_emanet.emanetmi = 1", baglanti);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            dataGridView.DataSource = tablo; // DataGridView'e verileri bağlama

            baglanti.Close();
        }

        // Kitap adı ara
        public void Kitap_ara(DataGridView dataGridView, string kitapAdi)
        {
            MySqlDataAdapter data;
            DataTable tablo;

            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();
            data = new MySqlDataAdapter("SELECT tbl_yayin_evleri.yayinEviAdi AS 'Yayınevi Adı', kategoriler.kategoriAdi AS 'Kategori Adı', kitaplar_kutuphane.kutuphane_id AS 'Kütüphane No', kitaplar_kutuphane.adet AS 'Kitap Adeti', yazarlar.yazarAd AS 'Yazar Adı', yazarlar.yazarSoyad AS 'Yazar Soyadı', tbl_kitaplar.ISBN AS 'ISBN', tbl_kitaplar.kitapAdi AS 'Kitap Adı', tbl_kitaplar.yayinTarihi AS 'Yayın Tarihi', tbl_kitaplar.sayfaSayisi AS 'Sayfa Sayısı', tbl_kitaplar.kitapDili AS 'Kitap Dili' FROM tbl_yayin_evleri, tbl_kitaplar, kitaplar_kutuphane, yazarlar, kategoriler WHERE tbl_yayin_evleri.yayinEvi_id = tbl_kitaplar.yayinEvi_id AND tbl_kitaplar.kitap_id = kitaplar_kutuphane.kitap_id AND yazarlar.kitap_id = tbl_kitaplar.kitap_id AND kategoriler.kitap_id = tbl_kitaplar.kitap_id AND kitapAdi LIKE '%" + kitapAdi + "%'", baglanti);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            dataGridView.DataSource = tablo; // DataGridView'e verileri bağlama

            baglanti.Close();
        }

        public int Uye_id(string kullaniciAdi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // uye id
            string query = "SELECT uye_id FROM tbl_uyeler WHERE kullaniciAdi = '" + kullaniciAdi + "'";
            MySqlCommand command = new MySqlCommand(query, baglanti);
            int uye_id = Convert.ToInt32(command.ExecuteScalar());

            baglanti.Close();

            return uye_id;
        }

        public int Emanet_sayisi(int uye_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // emanet sayısı
            string query1 = "SELECT COUNT(uye_id) FROM tbl_emanet WHERE uye_id = '" + uye_id + "' AND emanetmi = 1";
            MySqlCommand command1 = new MySqlCommand(query1, baglanti);
            int emanet_sayisi = Convert.ToInt32(command1.ExecuteScalar());

            baglanti.Close();

            return emanet_sayisi;
        }

        public int SifremiUnuttum(string kullaniciAdi, string eposta)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            string query1 = "SELECT COUNT(uye_id) FROM tbl_uyeler WHERE kullaniciAdi = '" + kullaniciAdi + "' AND eposta = '" + eposta + "'";
            MySqlCommand command1 = new MySqlCommand(query1, baglanti);
            int hesap = Convert.ToInt32(command1.ExecuteScalar()); // 1 hesap var - 0 hesap yok

            baglanti.Close();

            return hesap;
        }

        // Hesap kontrolü
        public int KitapEmanetKullanici(string kullaniciAdi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // hesap kontrol
            string query = "SELECT COUNT(uye_id) FROM tbl_uyeler WHERE kullaniciAdi = '" + kullaniciAdi + "'";
            MySqlCommand command = new MySqlCommand(query, baglanti);
            int hesap = Convert.ToInt32(command.ExecuteScalar()); // 1 olmalı

            baglanti.Close();

            return hesap;
        }

        // Kitap adeti
        public int KitapAdet(string ISBN1)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            double ISBN = Convert.ToDouble(ISBN1);

            // Kitap id
            string query2 = "SELECT kitap_id FROM tbl_kitaplar WHERE ISBN = @isbn";
            MySqlCommand command2 = new MySqlCommand(query2, baglanti);
            command2.Parameters.AddWithValue("@isbn", ISBN);
            int kitap_id = Convert.ToInt32(command2.ExecuteScalar());

            string query3 = "SELECT adet FROM kitaplar_kutuphane WHERE kitap_id = @kitap_id";
            MySqlCommand command3 = new MySqlCommand(query3, baglanti);
            command3.Parameters.AddWithValue("@kitap_id", kitap_id);
            int adet = Convert.ToInt32(command3.ExecuteScalar());

            baglanti.Close();

            return adet;
        }

        public int YayineviID(string yayineviAdi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            string query = "SELECT yayinEvi_id FROM tbl_yayin_evleri WHERE yayinEviAdi = '" + yayineviAdi + "' ";
            MySqlCommand command = new MySqlCommand(query, baglanti);
            int yayinEvi_id = Convert.ToInt32(command.ExecuteScalar()); // yayinevi ID

            baglanti.Close();

            return yayinEvi_id;
        }

        public int EnSonKayitKitapID()
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // en son kaydedilen kitap_id
            string query2 = "SELECT kitap_id FROM tbl_kitaplar ORDER BY kitap_id DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query2, baglanti);
            int enSonki_kitapID = Convert.ToInt32(cmd.ExecuteScalar());

            baglanti.Close();

            return enSonki_kitapID;
        }

        public int KitapID(double ISBN)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // Kitap ID
            string query = "SELECT kitap_id FROM tbl_kitaplar WHERE ISBN = '" + ISBN + "'";
            MySqlCommand command = new MySqlCommand(query, baglanti);
            int kitap_id = Convert.ToInt32(command.ExecuteScalar());

            baglanti.Close();

            return kitap_id;
        }

        public int YazarID(int kitap_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // yazar id
            string query3 = "SELECT yazar_id FROM yazarlar WHERE kitap_id = '" + kitap_id + "'";
            MySqlCommand command3 = new MySqlCommand(query3, baglanti);
            int yazarID = Convert.ToInt32(command3.ExecuteScalar());

            baglanti.Close();

            return yazarID;
        }

        public int KategoriID(int kitap_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();

            // kategori id
            string query4 = "SELECT kategori_id FROM kategoriler WHERE kitap_id = '" + kitap_id + "'";
            MySqlCommand command4 = new MySqlCommand(query4, baglanti);
            int kategori_id = Convert.ToInt32(command4.ExecuteScalar());

            baglanti.Close();

            return kategori_id;
        }

        public void Kutuphane_ara(DataGridView dataGridView, string kutuphaneAdi)
        {
            MySqlDataAdapter data;
            DataTable tablo;

            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();
            data = new MySqlDataAdapter("SELECT tbl_kutuphane.kutuphane_id AS 'Kütüphane No', tbl_kutuphane.kutuphaneAd AS 'Kütüphane Adı', tbl_kutuphane.adres_id AS 'Adres ID', adresler.mahalle AS 'Mahalle', adresler.cadde AS 'Cadde', adresler.sokak AS 'Sokak', adresler.binaNo AS 'Bina No', adresler.kapiNo AS 'Kapı No', adresler.ilce AS 'İlçe', adresler.il AS 'İl' FROM tbl_kutuphane, adresler WHERE adresler.adres_id = tbl_kutuphane.adres_id AND tbl_kutuphane.kutuphaneAd LIKE '%" + kutuphaneAdi + "%'", baglanti);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            dataGridView.DataSource = tablo; // DataGridView'e verileri bağlama

            baglanti.Close();
        }

        public void Yayinevi_ara(DataGridView dataGridView, string yayineviAdi)
        {
            MySqlDataAdapter data;
            DataTable tablo;

            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();
            data = new MySqlDataAdapter("SELECT tbl_yayin_evleri.yayinEvi_id AS 'Yayınevi ID', tbl_yayin_evleri.yayinEviAdi AS 'Yayınevi Adı', tbl_yayin_evleri.adres_id AS 'Adres ID', adresler.mahalle AS 'Mahalle', adresler.cadde AS 'Cadde', adresler.sokak AS 'Sokak', adresler.binaNo AS 'Bina No', adresler.kapiNo AS 'Kapı No', adresler.ilce AS 'İlçe', adresler.il AS 'İl' FROM tbl_yayin_evleri, adresler WHERE tbl_yayin_evleri.yayinEviAdi LIKE '%" + yayineviAdi + "%' AND adresler.adres_id = tbl_yayin_evleri.adres_id", baglanti);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            dataGridView.DataSource = tablo; // DataGridView'e verileri bağlama

            baglanti.Close();
        }
    }
}
