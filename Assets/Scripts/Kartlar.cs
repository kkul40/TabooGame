using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kartlar : MonoBehaviour
{
    public static List<Kart> kelimeKartları = new List<Kart>();

    public void Awake()
    {
        //Hızlı kart eklemek için alttakini kopyala yapıştır
        //kelimeKartları.Add(new Kart(0, "none", "none", "none", "none", "none", "none"));
        kelimeKartları.Add(new Kart(0, "Cihaz", "Ürün", "Makine", "Küçük", "Elektronik", "Aparat"));
        kelimeKartları.Add(new Kart(1, "İhtiyaç", "Var", "Zorunlu", "Yemek", "Su", "Yaşam"));
        kelimeKartları.Add(new Kart(2, "Antropometri", "Ölçü", "İnsan", "Uzunluk", "Boyut", "Beden"));
        kelimeKartları.Add(new Kart(3, "Reaktör", "Uranyum", "Nükleer", "Radyasyon", "Santral", "Çernobil"));
        kelimeKartları.Add(new Kart(4, "Petrol", "Benzin", "Mazot", "yakıt", "Akaryakıt", "Otomobil"));
        kelimeKartları.Add(new Kart(5, "Beton", "Çimento", "İnşaat", "Gri", "Duvar", "Yapmak"));
        kelimeKartları.Add(new Kart(6, "İletişim", "Haberleşme", "Telefon", "Mesaj", "Teknolji", "Bell"));
        kelimeKartları.Add(new Kart(7, "Tamir", "Etmek", "Onarmak", "Bozulmak", "Kırılmak", "Usta"));
        kelimeKartları.Add(new Kart(8, "Güvenlik", "Korunmak", "Tehlike", "İş", "Yasa", "Görevli"));
        kelimeKartları.Add(new Kart(9, "Sınav", "Ders", "Puan", "Okul", "Sınıf", "Girmek"));
        kelimeKartları.Add(new Kart(10, "Ritim", "Muzik", "Tempo", "Tasarım", "Konu", "Resim"));
        kelimeKartları.Add(new Kart(11, "Ses", "Tel", "Enerji", "Muzik", "Çıkmak", "Konuşmak"));
        kelimeKartları.Add(new Kart(12, "Grafik", "Görsel", "Tasarım", "Konu", "Pasta", "Çizim"));
        kelimeKartları.Add(new Kart(13, "Çevre", "Kirlilik", "Doğa", "Dünya", "Çöp", "Etraf"));
        kelimeKartları.Add(new Kart(14, "Karbon", "Atom", "Monoksit", "Zarar", "Fabrika", "Baca"));
        kelimeKartları.Add(new Kart(15, "İklim", "Doğa", "Çevre", "Mevsim", "Değişiklik", "Bölge"));
        kelimeKartları.Add(new Kart(16, "Temel", "Mimari", "İnşaat", "Ev", "Taşıyıcı", "Eleman"));
        kelimeKartları.Add(new Kart(17, "Fisyon", "Uranyum", "Atom", "Tepkime", "Radyasyon", "Parçalanma"));
        kelimeKartları.Add(new Kart(18, "Yalıtım", "Soğuk", "Sıcak", "Termos", "Duvar", "Cephe"));
        kelimeKartları.Add(new Kart(19, "Kullanışlı", "Ürün", "Pratik", "Küçük", "Tasarım", "Ev"));
        kelimeKartları.Add(new Kart(20, "Uygun", "Göre", "Tam", "Ölçü", "Uymak", "Giymek"));
        kelimeKartları.Add(new Kart(21, "Biçim", "Tasarım", "Araç", "Çizim", "Kompozisyon", "Temel"));
        kelimeKartları.Add(new Kart(22, "Gölge", "Güneş", "Işık", "Yansıma", "Karanlık", "Siyah"));
        kelimeKartları.Add(new Kart(23, "Biyokütle", "Enerji", "Geri Dönüşüm", "Yenilenebilir", "Yağ", "Sıvı"));
        kelimeKartları.Add(new Kart(24, "Yapı", "Mimari", "İnşaat", "Tasarım", "Yapmak", "Konut"));
        kelimeKartları.Add(new Kart(25, "Kompozisyon", "Yazmak", "Çizim", "Ders", "Anlatmak", "Sonuç"));
        kelimeKartları.Add(new Kart(26, "Estetik", "Güzel", "Şık", "Yaptırmak", "Özellik", "Tarz"));
        kelimeKartları.Add(new Kart(27, "Araç", "Malzeme", "Gereç", "İş", "Kullanmak", "Ders"));
        kelimeKartları.Add(new Kart(28, "İcat", "Yenilik", "Bulmak", "Olmayan", "Mucit", "Çıkarmak"));
        kelimeKartları.Add(new Kart(29, "Panel", "Konferans", "Güneş", "Enerji", "Elektrik", "Yenilenebilir"));
        kelimeKartları.Add(new Kart(30, "Sergi", "Dönem", "Okul", "Fuar", "Sunmak", "Ders"));
        kelimeKartları.Add(new Kart(31, "Üretim", "Fabrika", "El", "Makine", "Sanati", "Seri"));
        kelimeKartları.Add(new Kart(32, "Reklam", "Televizyon", "Satış", "Para", "Yapmak", "Uygulama"));
        kelimeKartları.Add(new Kart(33, "Tesla", "Elektrik", "Nikola", "Edison", "Mucit", "Patent"));
        kelimeKartları.Add(new Kart(34, "İnovasyon", "Yenilik", "Yenileşim", "Tasarım", "Ürün", "Düşünme"));
        kelimeKartları.Add(new Kart(35, "Bilim", "İnsan", "Araştırma", "Deney", "Laboratuvar", "Yeni"));
        kelimeKartları.Add(new Kart(36, "Süreç", "Zaman", "Döngü", "Saat", "Tasarım", "İlerlemek"));
        kelimeKartları.Add(new Kart(37, "Problem", "Matematik", "Sorun", "Sıkıntı", "Dert", "Çözüm"));
        kelimeKartları.Add(new Kart(38, "Malzeme", "Ham Madde", "Araç", "Gereç", "Resim", "İş"));
        kelimeKartları.Add(new Kart(39, "Taslak", "Çizim", "Hayal", "Kurgu", "Tasarım", "Geliştirmek"));
        kelimeKartları.Add(new Kart(40, "Model", "Manken", "Ürün", "Yeni", "Boyut", "Maket"));
        kelimeKartları.Add(new Kart(41, "Prototip", "Yapmak", "Tasarlamak", "Maket", "Küçük", "Ölçek"));
        kelimeKartları.Add(new Kart(42, "Geri Dönüşüm", "Kağıt", "Atık", "Yeniden", "Tekrar", "Çevre"));
        kelimeKartları.Add(new Kart(43, "Bilgisayar Destekli Tasarım", "Çizmek", "Autocad", "Tasarlamak", "El", "Fare"));
        kelimeKartları.Add(new Kart(44, "Okul", "Eğitim", "Burası", "Öğretmek", "Öğretim", "Öğrenci"));
        kelimeKartları.Add(new Kart(45, "Tavla", "Zar", "Oyun", "Yenmek", "Mars", "Kapı"));
        kelimeKartları.Add(new Kart(46, "Google", "Arama Motoru", "Bilgisayar", "İnternet", "Site", "Sayfa"));
        kelimeKartları.Add(new Kart(47, "Bill Gates", "Zengin", "Microsoft", "Para", "PC", "Windows"));
        kelimeKartları.Add(new Kart(48, "Okey", "Zar", "Istaka", "Taş", "4 Kişi", "Oyun"));
        kelimeKartları.Add(new Kart(49, "Para", "Kağıt", "Dolar", "Satın Alma", "Ülke", "Kazanmak"));
        kelimeKartları.Add(new Kart(50, "Çorap", "İnce", "Kaçmak", "Ten Rengi", "Parizyen", "Ayak"));
        kelimeKartları.Add(new Kart(51, "Kalem", "Kurşun", "Tükenmez", "Dolma", "Kağıt", "Çizgi"));
        kelimeKartları.Add(new Kart(52, "Aşk", "Kalp", "Bayan&Erkek", "Tutku", "Kırmızı", "Seks"));
        kelimeKartları.Add(new Kart(53, "Mouse", "Fare", "Bilgisayar", "Klavye", "Tuş", "Klik"));
        kelimeKartları.Add(new Kart(54, "Takvim", "Yıl", "Ay", "Hafta", "Gün", "Sayı"));
        kelimeKartları.Add(new Kart(55, "Telefon", "Alo", "Ahize", "Tuş", "Ses", "Numara"));
        kelimeKartları.Add(new Kart(56, "Müchevher", "Kadın", "Takı", "Altın", "Bilezik", "Kolye"));
        kelimeKartları.Add(new Kart(57, "Güneş", "Isı", "Işık", "Kaynak", "Enerji", "Dönmek"));
        kelimeKartları.Add(new Kart(58, "Doğal", "Enerji", "Temiz", "Çevreci", "Enerji", "Yaşam"));
        kelimeKartları.Add(new Kart(59, "Konut", "Apartman", "Yaşam", "Ev", "Mimari", "İnşaat"));
        kelimeKartları.Add(new Kart(60, "Oje", "Tırnak", "Renk", "Sürmek", "Aseton", "Manikür"));
        kelimeKartları.Add(new Kart(61, "Şimşek", "Gökyüzü", "Yağmur", "Işık", "Kalp Krizi", "Korku"));
        kelimeKartları.Add(new Kart(62, "Hastalık", "Hastane", "Hasta", "Doktor", "Hemşire", "İlaç"));
        kelimeKartları.Add(new Kart(63, "none", "none", "none", "none", "none", "none"));
        kelimeKartları.Add(new Kart(64, "none", "none", "none", "none", "none", "none"));
        kelimeKartları.Add(new Kart(65, "none", "none", "none", "none", "none", "none"));
    }
}
