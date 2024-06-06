namespace Konu05Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metotlar!");
            /*
            ToplamaYap();
            ToplamaYap(18, 18);

            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı daha giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            ToplamaYap(sayi1, sayi2);
            
            KdvHesapla();
            */
            Console.WriteLine("Üretilen Sms Şifresi: " + SmsSifreUret());
            Console.WriteLine();
            Console.WriteLine("3 sayının toplamı: " + ToplamaYap(18, 50, 50));
        }
        static void ToplamaYap() // bu metot geriye değer döndürmeyen metottur (void)
        {
            Console.WriteLine(10 + 8);
        }
        static void ToplamaYap(int sayi1, int sayi2)
        {
            Console.WriteLine("Toplam: " + (sayi1 + sayi2));
        }
        static int ToplamaYap(int sayi1, int sayi2, int sayi3)
        {
            //Geriye değer döndüren metotlarda metot isminin önüne metodun geriye döndüreceği veri türü yazılır
            //metodun aldığı parametre ile geri dönüş veri türü aynı olmak zorunda DEĞİLDİR!
            //Yani bir metot parametre olarak int alırken geriye string, bool vb veri türü döndürebilir!
            return sayi1 + sayi2 + sayi3;
        }
        static int SmsSifreUret() // bu metot geriye değer döndüren metottur (int)
        {
            var sms = new Random();
            int geriDonecekDeger = sms.Next(0, 9999);
            return geriDonecekDeger;
        }
        static void KdvHesapla()
        {
            double fiyat, kdv, toplam; // değişken tanımlarken aynı tipler için bu şekilde araya , koyarak birden fazla değişken tanımlayabiliriz.
            Console.WriteLine("Ürün fiyatını giriniz:");
            fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kdv miktarını giriniz:");
            var kdvMiktari = Convert.ToDouble(Console.ReadLine());
            kdv = fiyat * kdvMiktari / 100;
            toplam = fiyat + kdv;
            Console.WriteLine("Ürün kdv tutarı: " + kdv + " TL");
            Console.WriteLine("Kdv dahil fiyatı : " + toplam + " TL");
        }

    }
}
