namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 07 Donguler!");

            Console.WriteLine("1-For Döngüsü");
            for (int i = 0; i < 5; i++)//i değişkeni oluştur ve 0 değerini ata; i 10 dan küçük olduğu sürece dön; her dönüşte i yi 1 artır i++ ile
            {
                Console.WriteLine("i değişkeninin değeri {0}", i);
            } // for döngüsünü çoğunlukla veritabanından bir veri listesi çekip ekrana yazdırma gibi işlemlerde kullanırız

            Console.WriteLine();

            Console.WriteLine("2-While Döngüsü");
            int j = 0;
            while (j < 5) //While döngüsünün şartı bu şekilde, anlamı toplam küçükse 5 den sürekli dön
            {// while döngüsünü çoğunlukla veritabanından veri okurken falan kullanırız.
                Console.WriteLine("While Sayı {0}", j);//toplamın değerini ekrana yazdırıyoruz
                j++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
            }/**/

            Console.WriteLine();
            Console.WriteLine("3-Do While Döngüsü");
            int toplam = 7;
            do
            {
                Console.WriteLine("toplamın değeri : " + toplam);
                toplam++;
            } while (toplam < 5); //Do While döngüsünün şartı bu şekilde, anlamı toplam küçükse 10 dan sürekli dön
            /**/

            Console.WriteLine();

            string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep Telefonu" };

            Console.WriteLine("Foreach Döngüsü");
            Console.WriteLine("Kategoriler");
            foreach (var kategori in kategoriler) // kategori(dizi öğesi) kategoriler dizisindeki her bir elemana karşılık geliyor
            {
                Console.WriteLine(kategori);
            }
            Console.WriteLine();

            //İç içe döngü kullanımı

            string[] urunler = { "Ürün 1", "Ürün 2", "Ürün3" };

            foreach (var kategori in kategoriler) // diziler için en kullanışlı döngü
            {
                Console.WriteLine("Kategori Adı : " + kategori);
                foreach (var urun in urunler)
                {
                    Console.WriteLine("\tÜrün Adı : " + urun);
                }
            }

        }
    }
}
