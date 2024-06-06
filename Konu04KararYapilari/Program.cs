namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karar Yapıları!");
            Console.WriteLine("Programdaki kodların akışını belirli bir şarta göre yönlendirmemizi sağlar.");
            /*
            Console.WriteLine("Bir Sayı Giriniz:");
            var sayi = int.Parse(Console.ReadLine());

            if (sayi > 0)//eğer sayı 0 dan büyükse
            {
                // burası işletilir.
                Console.WriteLine($"sayı({sayi}) pozitif");
            }
            else if (sayi == 0)//yukardaki değilse eğer sayı 0 a eşitse
            {
                // burası işletilir
                Console.WriteLine($"sayı({sayi}) sıfırdır");
            }
            else//yukardakilerin hiçbiri değilse
            {
                //sayı 0 dan küçükse işletilir.
                Console.WriteLine($"sayı({sayi}) negatif");
            }
            
            Console.WriteLine("Kullanıcı Adınızı Giriniz:");
            string kullaniciadi = Console.ReadLine();//Console.ReadLine() metodu ekrandan girilen değeri yakalar ve kullaniciadi değişkenine atar
            Console.WriteLine("Şifrenizi Giriniz");
            string sifre = Console.ReadLine();//Console.ReadLine() metodu ekrandan girilen değeri yakalar ve sifre değişkenine atar

            string veritabanindakiKullaniciAdi = "admin";
            string veritabanindakiSifre = "123456";

            if (kullaniciadi == veritabanindakiKullaniciAdi && sifre == veritabanindakiSifre)//Eğer ekrandan girilen kullanıcı adı ve şifre veritabanımızdaki ile eşleşiyorsa
            {
                Console.WriteLine("Sisteme giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifrenizde hata var!");
            }
            
            int saat = DateTime.Now.Hour; // bulunduğumuz saat bilgisini sistemden aldık
            if (saat < 18) // eğer saat 18 den küçükse
            {
                Console.WriteLine("İyi günler. Saat : " + saat);
            }
            else Console.WriteLine("İyi Akşamlar. Saat : " + saat);

            Console.WriteLine("//Ternary operatörü");

            Console.WriteLine((saat < 18) ? "İyi günler. Saat : " + saat : "İyi Akşamlar. Saat : " + saat);
            */
            Console.WriteLine("switch case yapısı ile akış kontrolü");

            int ay = DateTime.Now.Month;//Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bulunduğumuz Ay : " + ay);
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimi");
                    Console.WriteLine();
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimi");
                    Console.WriteLine();
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimi");
                    Console.WriteLine();
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimi");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Yanlış bilgi.");
                    break;
            }

        }
    }
}
