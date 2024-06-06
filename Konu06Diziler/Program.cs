namespace Konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diziler!");
            //Dizi oluşturma
            int[] sayi;//veri tipini belirttikten sonra köşeli parantez koyup dizi ismini vererek dizimizi oluşturmuş oluyoruz
            int[] ogrenciler = new int[6];//ogrenciler isminde int veri tipi taşıyan ve 7 elemandan oluşan bir dizi oluşturduk. Dizi boyutu artmaz, azalmaz.
            //Dizilerde indis denilen yapı vardır ve içine eklenecek elemanlar 0 dan başlar
            ogrenciler[0] = 100; // yazılımda sayma işlemleri 0 dan başlar. 0. eleman
            ogrenciler[1] = 200;
            ogrenciler[2] = 200;
            ogrenciler[3] = 300;
            ogrenciler[4] = 400;
            ogrenciler[5] = 500;
            Console.WriteLine("Seçilen öğrenci no : " + ogrenciler[5]);//ogrenciler isimli dizinin 5. elemanı
            ogrenciler[5] = 550;
            Console.WriteLine("Seçilen öğrenci no : " + ogrenciler[5]);
            // ogrenciler[6] = 700;//Dizilere başlangıçta kaç elemandan oluşacağı tanımlanmışsa o sayının dışına çıktığımızda hata alırız

            string[] isimler = new string[5];

            isimler[0] = "Melih";
            isimler[1] = "Ali";
            isimler[2] = "Sena";
            isimler[3] = "Musa";
            isimler[4] = "Nisa";

            Console.WriteLine(isimler[1]);

            int[] ogrenciler2 = { 100, 200, 300, 400, 500 };//Bir diğer dizi oluşturma yöntemi, bu yöntemde diziye kaç elemandan oluşacağı bilgisi verilmez ve değerler diziye eklenri. Bu durumda dizi kaç elemandan oluştuğunu içine eklenen elemanları sayarak kendisi bilir.
            Console.WriteLine(ogrenciler2[0]);
            ogrenciler2[0] = 118;
            Console.WriteLine(ogrenciler2[0]);

            string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep Telefonu", "Beyaz Eşya", "Kitap" };//Diziye eklenecek kayıt sayısı belirsizse bu şekilde de dizi tanımlaması yapabiliriz
            Console.WriteLine(kategoriler[1]);
            kategoriler[1] = "Aksesuar";
            Console.WriteLine(kategoriler[1]);

            string[] urunler = { "Ürün 1", "Ürün 2", "Ürün3" };
            Console.WriteLine(urunler[1]);
        }
    }
}
