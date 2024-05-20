using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Windows.Forms;

namespace proje_kutuphane
{
    public class Tablo
    {
        MySqlConnection baglanti;
        MySqlDataAdapter data;
        public DataTable tablo;

        // Datagrid doldurma
        public void Doldur(string table, DataGridView dataGridView)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();
            data = new MySqlDataAdapter("SELECT * FROM " + table, baglanti);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            dataGridView.DataSource = tablo; // DataGridView'e verileri bağlama

            baglanti.Close();
        }

        // Kitaplar tablosu
        public void Kitap_doldur(DataGridView dataGridView)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();
            data = new MySqlDataAdapter("SELECT tbl_yayin_evleri.yayinEviAdi AS 'Yayınevi Adı', kategoriler.kategoriAdi AS 'Kategori Adı', kitaplar_kutuphane.kutuphane_id AS 'Kütüphane No', kitaplar_kutuphane.adet AS 'Kitap Adeti', yazarlar.yazarAd AS 'Yazar Adı', yazarlar.yazarSoyad AS 'Yazar Soyadı', tbl_kitaplar.ISBN AS 'ISBN', tbl_kitaplar.kitapAdi AS 'Kitap Adı', tbl_kitaplar.yayinTarihi AS 'Yayın Tarihi', tbl_kitaplar.sayfaSayisi AS 'Sayfa Sayısı', tbl_kitaplar.kitapDili AS 'Kitap Dili' FROM tbl_yayin_evleri, tbl_kitaplar, kitaplar_kutuphane, yazarlar, kategoriler WHERE tbl_yayin_evleri.yayinEvi_id = tbl_kitaplar.yayinEvi_id AND tbl_kitaplar.kitap_id = kitaplar_kutuphane.kitap_id AND yazarlar.kitap_id = tbl_kitaplar.kitap_id AND kategoriler.kitap_id = tbl_kitaplar.kitap_id", baglanti);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            dataGridView.DataSource = tablo; // DataGridView'e verileri bağlama

            baglanti.Close();
        }

        // Üyeler tablosu
        public void Uye_doldur(DataGridView dataGridView)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();
            data = new MySqlDataAdapter("SELECT tbl_uyeler.uye_id AS 'Üye ID', tbl_uyeler.adres_id AS 'Adres ID', tbl_uyeler.uyeAd AS 'Üye Adı', tbl_uyeler.uyeSoyad AS 'Üye Soyadı', tbl_uyeler.kullaniciAdi AS 'Kullanıcı Adı', tbl_uyeler.sifre AS 'Şifre', tbl_uyeler.cinsiyet AS 'Cinsiyet', tbl_uyeler.telefon AS 'Telefon', tbl_uyeler.eposta AS 'Eposta', tbl_uyeler.yetki AS 'Yetki', tbl_uyeler.kayitTarihi AS 'Kayıt Tarihi', tbl_uyeler.yasaklimi AS 'Yasaklı mı', adresler.mahalle AS 'Mahalle', adresler.cadde AS 'Cadde', adresler.sokak AS 'Sokak', adresler.binaNo AS 'Bina No', adresler.kapiNo AS 'Kapı No', adresler.ilce AS 'İlçe', adresler.il AS 'İl' FROM tbl_uyeler, adresler WHERE tbl_uyeler.adres_id = adresler.adres_id", baglanti);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            dataGridView.DataSource = tablo; // DataGridView'e verileri bağlama

            baglanti.Close();
        }

        // Yayınevleri tablosu
        public void Yayinevi_doldur(DataGridView dataGridView)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();
            data = new MySqlDataAdapter("SELECT tbl_yayin_evleri.yayinEvi_id AS 'Yayınevi ID', tbl_yayin_evleri.yayinEviAdi AS 'Yayınevi Adı', tbl_yayin_evleri.adres_id AS 'Adres ID', adresler.mahalle AS 'Mahalle', adresler.cadde AS 'Cadde', adresler.sokak AS 'Sokak', adresler.binaNo AS 'Bina No', adresler.kapiNo AS 'Kapı No', adresler.ilce AS 'İlçe', adresler.il AS 'İl' FROM tbl_yayin_evleri, adresler WHERE adresler.adres_id = tbl_yayin_evleri.adres_id", baglanti);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            dataGridView.DataSource = tablo; // DataGridView'e verileri bağlama

            baglanti.Close();
        }

        // Kütüphane tablosu
        public void Kutuphane_doldur(DataGridView dataGridView)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            baglanti.Open();
            data = new MySqlDataAdapter("SELECT tbl_kutuphane.kutuphane_id AS 'Kütüphane No', tbl_kutuphane.kutuphaneAd AS 'Kütüphane Adı', tbl_kutuphane.adres_id AS 'Adres No', adresler.mahalle AS 'Mahalle', adresler.cadde AS 'Cadde', adresler.sokak AS 'Sokak', adresler.binaNo AS 'Bina No', adresler.kapiNo AS 'Kapı No', adresler.ilce AS 'İlçe', adresler.il AS 'İl' FROM tbl_kutuphane, adresler WHERE adresler.adres_id = tbl_kutuphane.adres_id", baglanti);
            tablo = new DataTable("veriler");
            data.Fill(tablo);
            dataGridView.DataSource = tablo; // DataGridView'e verileri bağlama

            baglanti.Close();
        }
    }
}
