using ClassLibrary1;

namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu17 Hata Yonetimi!");
            Console.WriteLine();
            Console.WriteLine("Kdv Hesaplamak İçin Fiyat Giriniz :");
            var sayi = Console.ReadLine(); // 100 ve karakter girerek deneyelim
            // KdvHesapla(double.Parse(sayi));
            try
            {
                KdvHesapla(double.Parse(sayi));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Hata Oluştu! Lütfen sadece sayısal bir değer girin!");
                //throw; bu kod hata fırlatır
                // hatayı veritabanına kaydederek loglayabiliriz.
                Console.WriteLine("Hata: " + hata.Message);
            }
            Kategori kategori = new Kategori();
            kategori.Name = "Elektronik";

            Urun urun = new Urun()
            {
                Name = "Klavye",
            };

            Kullanici kullanici = new Kullanici()
            {
                KullaniciAdi = "Admin",
                Sifre = "Ad123"
            };
        }
        static void KdvHesapla(double fiyat)
        {
            Console.WriteLine("Fiyat : " + fiyat);
            Console.WriteLine("Kdv : " + (fiyat * 0.20));
            Console.WriteLine("Kdv Dahil Toplam Tutar :" + (fiyat + (fiyat * 0.20)));
        }
    }
}
