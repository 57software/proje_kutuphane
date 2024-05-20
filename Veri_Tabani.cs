using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace proje_kutuphane
{
    public class Veri_Tabani
    {
        MySqlConnection baglanti;

        // Üye kayıt
        public void UyeKayit(string ad, string soyad, string kullanici, string sifre, string cinsiyet, double telefon, string eposta, string kayitTarihi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand kayit = new MySqlCommand();
            baglanti.Open();
            kayit.Connection = baglanti;

            // Son kaydolan adres_id alır
            string query = "SELECT adres_id FROM adresler ORDER BY adres_id DESC LIMIT 1";
            MySqlCommand command = new MySqlCommand(query, baglanti);
            int adres_id = Convert.ToInt32(command.ExecuteScalar());

            kayit.CommandText = "INSERT INTO tbl_uyeler VALUES(NULL,'" + adres_id + "','" + ad + "','" + soyad + "','" + kullanici + "','" + sifre + "','" + cinsiyet + "','" + telefon + "','" + eposta + "', 'Üye', '" + kayitTarihi + "', 0)";
            kayit.ExecuteNonQuery();
            baglanti.Close();
        }

        // Üye sil
        public void UyeSil(string kullaniciAdi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand sil = new MySqlCommand();
            baglanti.Open();
            sil.Connection = baglanti;
            sil.CommandText = "DELETE FROM tbl_uyeler WHERE kullaniciAdi=@kullaniciAdi";
            sil.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        // Üye güncelle
        public void UyeGuncelle(int uye_id, string ad, string soyad, string kullanici, string sifre, string cinsiyet, double telefon, string eposta, string yetki)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE tbl_uyeler SET  uyeAd='" + ad + "', uyeSoyad='" + soyad + "', kullaniciAdi='" + kullanici + "', sifre='" + sifre + "', cinsiyet='" + cinsiyet + "', telefon='" + telefon + "', eposta='" + eposta + "', yetki='" + yetki + "' WHERE uye_id=@id";
            int id = uye_id;
            guncelle.Parameters.AddWithValue("@id", id);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        // Üye yasakla
        public void UyeYasakla(string kullaniciAdi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE tbl_uyeler SET yasaklimi = 1 WHERE kullaniciAdi=@kullaniciAdi";
            guncelle.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        // Üye yasak kaldır
        public void UyeYasakKaldir(string kullaniciAdi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE tbl_uyeler SET yasaklimi = 0 WHERE kullaniciAdi=@kullaniciAdi";
            guncelle.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kullanıcı şifremi unuttum
        public void KullaniciSifremiUnuttum(string kullaniciAdi, string sifre)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE tbl_uyeler SET sifre = '"+ sifre +"' WHERE kullaniciAdi=@kullaniciAdi";
            guncelle.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        // Adres kayıt
        public void AdresKayit(string mahalle, string cadde, string sokak, double binaNo, double kapiNo, string ilce, string il)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand kayit = new MySqlCommand();
            baglanti.Open();
            kayit.Connection = baglanti;
            kayit.CommandText = "INSERT INTO adresler VALUES(NULL,'" + mahalle + "','" + cadde + "','" + sokak + "','" + binaNo + "','" + kapiNo + "','" + ilce + "','" + il + "')";
            kayit.ExecuteNonQuery();
            baglanti.Close();
        }

        // Adres sil
        public void AdresSil(int adres_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand sil = new MySqlCommand();
            baglanti.Open();
            sil.Connection = baglanti;
            sil.CommandText = "DELETE FROM adresler WHERE adres_id=@id";
            int id = adres_id;
            sil.Parameters.AddWithValue("@id", id);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        // Adres güncelle
        public void AdresGuncelle(int adres_id, string mahalle, string cadde, string sokak, double binaNo, double kapiNo, string ilce, string il)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE adresler SET mahalle='" + mahalle + "', cadde='" + cadde + "', sokak='" + sokak + "', binaNo='" + binaNo + "', kapiNo='" + kapiNo + "', ilce='" + ilce + "', il='" + il + "' WHERE adres_id=@id";
            int id = adres_id;
            guncelle.Parameters.AddWithValue("@id", id);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kitap ekle
        public void KitapEkle(int yayinEvi_id, double ISBN, string kitapAdi, string yayinTarihi, int sayfaSayisi, string kitapDili)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand kayit = new MySqlCommand();
            baglanti.Open();
            kayit.Connection = baglanti;
            kayit.CommandText = "INSERT INTO tbl_kitaplar VALUES(NULL,'" + yayinEvi_id + "','" + ISBN + "','" + kitapAdi + "','" + yayinTarihi + "','" + sayfaSayisi + "','" + kitapDili + "')";
            kayit.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kitap sil
        public void KitapSil(int kitap_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand sil = new MySqlCommand();
            baglanti.Open();
            sil.Connection = baglanti;
            sil.CommandText = "DELETE FROM tbl_kitaplar WHERE kitap_id=@id";
            int id = kitap_id;
            sil.Parameters.AddWithValue("@id", id);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kitap güncelle
        public void KitapGuncelle(int kitap_id, int yayinEvi_id, double ISBN, string kitapAdi, string yayinTarihi, int sayfaSayisi, string kitapDili)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE tbl_kitaplar SET yayinEvi_id='" + yayinEvi_id + "', ISBN='" + ISBN + "', kitapAdi='" + kitapAdi + "', yayinTarihi='" + yayinTarihi + "', sayfaSayisi='" + sayfaSayisi + "', kitapDili='" + kitapDili + "' WHERE kitap_id=@id";
            int id = kitap_id;
            guncelle.Parameters.AddWithValue("@id", id);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kategori ekle
        public void KategoriEkle(int kitap_id, string kategoriAdi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand kayit = new MySqlCommand();
            baglanti.Open();
            kayit.Connection = baglanti;
            kayit.CommandText = "INSERT INTO kategoriler VALUES(NULL,'" + kitap_id + "','" + kategoriAdi + "')";
            kayit.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kategori sil
        public void KategoriSil(int kitap_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand sil = new MySqlCommand();
            baglanti.Open();
            sil.Connection = baglanti;
            sil.CommandText = "DELETE FROM kategoriler WHERE kitap_id=@id";
            int id = kitap_id;
            sil.Parameters.AddWithValue("@id", id);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kategori güncelle
        public void KategoriGuncelle(int kategori_id, int kitap_id, string kategoriAdi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE kategoriler SET kitap_id='" + kitap_id + "', kategoriAdi='" + kategoriAdi + "' WHERE kategori_id=@id";
            int id = kategori_id;
            guncelle.Parameters.AddWithValue("@id", id);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        // Yazar ekle
        public void YazarEkle(int kitap_id, string yazarAd, string yazarSoyad)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand kayit = new MySqlCommand();
            baglanti.Open();
            kayit.Connection = baglanti;
            kayit.CommandText = "INSERT INTO yazarlar VALUES(NULL,'" + kitap_id + "','" + yazarAd + "','" + yazarSoyad + "')";
            kayit.ExecuteNonQuery();
            baglanti.Close();
        }

        // Yazar sil
        public void YazarSil(int kitap_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand sil = new MySqlCommand();
            baglanti.Open();
            sil.Connection = baglanti;
            sil.CommandText = "DELETE FROM yazarlar WHERE kitap_id=@id";
            int id = kitap_id;
            sil.Parameters.AddWithValue("@id", id);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        // Yazar güncelle
        public void YazarGuncelle(int yazar_id, int kitap_id, string yazarAd, string yazarSoyad)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE yazarlar SET kitap_id='" + kitap_id + "', yazarAd='" + yazarAd + "', yazarSoyad='" + yazarSoyad + "' WHERE yazar_id=@id";
            int id = yazar_id;
            guncelle.Parameters.AddWithValue("@id", id);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        // Yayın Evi ekle
        public void YayinEvi_Ekle(string yayinEviAdi, int adres_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand kayit = new MySqlCommand();
            baglanti.Open();
            kayit.Connection = baglanti;
            kayit.CommandText = "INSERT INTO tbl_yayin_evleri VALUES(NULL,'" + yayinEviAdi + "','" + adres_id + "')";
            kayit.ExecuteNonQuery();
            baglanti.Close();
        }

        // Yayın Evi sil
        public void YayinEvi_Sil(int yayinEvi_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand sil = new MySqlCommand();
            baglanti.Open();
            sil.Connection = baglanti;
            sil.CommandText = "DELETE FROM tbl_yayin_evleri WHERE yayinEvi_id=@id";
            int id = yayinEvi_id;
            sil.Parameters.AddWithValue("@id", id);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        // Yayın Evi güncelle
        public void YayinEvi_Guncelle(int yayinEvi_id, string yayinEviAdi, int adres_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE tbl_yayin_evleri SET yayinEviAdi='" + yayinEviAdi + "', adres_id='" + adres_id + "' WHERE yayinEvi_id=@id";
            int id = yayinEvi_id;
            guncelle.Parameters.AddWithValue("@id", id);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kütüphane ekle
        public void KutuphaneEkle(string kutuphaneAd, int adres_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand kayit = new MySqlCommand();
            baglanti.Open();
            kayit.Connection = baglanti;
            kayit.CommandText = "INSERT INTO tbl_kutuphane VALUES(NULL,'" + kutuphaneAd + "','" + adres_id + "')";
            kayit.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kütüphane sil
        public void KutuphaneSil(int kutuphane_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand sil = new MySqlCommand();
            baglanti.Open();
            sil.Connection = baglanti;
            sil.CommandText = "DELETE FROM tbl_kutuphane WHERE kutuphane_id=@id";
            int id = kutuphane_id;
            sil.Parameters.AddWithValue("@id", id);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kütüphane güncelle
        public void KutuphaneGuncelle(int kutuphane_id, string kutuphaneAd, int adres_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE tbl_kutuphane SET kutuphaneAd='" + kutuphaneAd + "', adres_id='" + adres_id + "' WHERE kutuphane_id=@id";
            int id = kutuphane_id;
            guncelle.Parameters.AddWithValue("@id", id);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kütüphaneye kitap ekle
        public void KutuphaneyeKitap_Ekle(int kitap_id, int kutuphane_id, int adet)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand kayit = new MySqlCommand();
            baglanti.Open();
            kayit.Connection = baglanti;
            kayit.CommandText = "INSERT INTO kitaplar_kutuphane VALUES('" + kitap_id + "','" + kutuphane_id + "','" + adet + "')";
            kayit.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kütüphanedeki kitabı sil
        public void KutuphanedenKitap_Sil(int kitap_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand sil = new MySqlCommand();
            baglanti.Open();
            sil.Connection = baglanti;
            sil.CommandText = "DELETE FROM kitaplar_kutuphane WHERE kitap_id=@id";
            int id = kitap_id;
            sil.Parameters.AddWithValue("@id", id);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        // Kütüphanedeki kitabı güncelle
        public void KutuphanedekiKitabi_Guncelle(int kitap_id, int kutuphane_id, int adet)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE kitaplar_kutuphane SET kitap_id='" + kitap_id + "', kutuphane_id='" + kutuphane_id + "', adet='" + adet + "' WHERE kitap_id=@id";
            int id = kitap_id;
            guncelle.Parameters.AddWithValue("@id", id);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        // Emanet ver
        public void EmanetVer(int uye_id, int kitap_id, int kutuphane_id, string emanetTarihi, string teslimTarihi, int ucret, int emanetmi)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand kayit = new MySqlCommand();
            baglanti.Open();
            kayit.Connection = baglanti;
            kayit.CommandText = "INSERT INTO tbl_emanet VALUES(NULL,'" + uye_id + "','" + kitap_id + "','" + kutuphane_id + "','" + emanetTarihi + "','" + teslimTarihi + "','" + ucret + "','" + emanetmi + "')";
            kayit.ExecuteNonQuery();
            baglanti.Close();
        }

        // Emanet al
        public void EmanetAl(int emanet_id)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand sil = new MySqlCommand();
            baglanti.Open();
            sil.Connection = baglanti;
            sil.CommandText = "UPDATE tbl_emanet SET emanetmi = 0 WHERE emanet_id =@id";
            int id = emanet_id;
            sil.Parameters.AddWithValue("@id", id);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        // Emanet güncelle (ücreti güncellemek için)
        public void EmanetGuncelle(int emanet_id, int ucret)
        {
            baglanti = new MySqlConnection(Baglan.Bag);
            MySqlCommand guncelle = new MySqlCommand();
            baglanti.Open();
            guncelle.Connection = baglanti;
            guncelle.CommandText = "UPDATE tbl_emanet SET ucret = '" + ucret + "' WHERE emanet_id=@id";
            int id = emanet_id;
            guncelle.Parameters.AddWithValue("@id", id);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
