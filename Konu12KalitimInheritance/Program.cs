namespace Konu12KalitimInheritance
{
    class Arac
    {
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Kornaya Basıldı!");
        }
    }
    class Otombil : Arac //  : Arac ile arac sınıfından içindekileri miras alırız
    { // artık otomobil sınıfında arac sınıfındaki içeriklere sahibiz
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu12KalitimInheritance!");
            Arac arac = new();
            arac.AracTuru = "Araba";
            Console.WriteLine("arac.AracTuru : " + arac.AracTuru);
            Otombil otombil = new();
            otombil.AracTuru = "Otomobil"; // Normalde Otomobil classında AracTuru yok
            Console.WriteLine("otombil.AracTuru : " + otombil.AracTuru);
            otombil.KornaCal(); // KornaCal metodu bir üst sınıf olan Arac sınıfından geliyor

            Console.WriteLine();

            Kategori kategori = new()
            {
                Name = "Elektronik",
                UstMenudeGoster = true,
                EklenmeTarihi = DateTime.Now
            };

            if (kategori.UstMenudeGoster == true)
            {
                Console.WriteLine($"kategori bilgileri :\n Adı : {kategori.Name} - Eklenme Tarihi : {kategori.EklenmeTarihi}");
            }

            Console.WriteLine();

            Urun urun = new()
            {
                Name = "Klavye",
                Fiyat = 299,
                Kdv = 18,
                EklenmeTarihi = DateTime.Now
            };

            Console.WriteLine($"ürün Bilgileri");
            Console.WriteLine($"Adı : {urun.Name}");
            Console.WriteLine($"Fiyatı : {urun.Fiyat}");
            Console.WriteLine($"Kdv : {urun.Kdv}");
            Console.WriteLine($"Eklenme Tarihi : {urun.EklenmeTarihi}");
        }
    }
}
