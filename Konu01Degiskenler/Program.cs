namespace Konu01Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Değişkenler!");

            Console.WriteLine(); // cw yaz tab a bas. Bu şekilde içini boş bırakırsak ekranda boş satır oluşturur
            /*
                çoklu 
                yorum
                satırı
             */
            Console.WriteLine("Tam Sayı Veri Tipleri ");

            byte plaka_kodu;//0 - 255 tamsayı
            plaka_kodu = 255; // değişkene değer atama

            Console.WriteLine("plaka_kodu: " + plaka_kodu);

            sbyte sbyteTuru = 127;// +127 ile -128 arası değer alabilir

            short kisa = 32767; //-32768 ile +32767 arası değer alabilir
            ushort birazuzun = 65535; //0 - 65535
            int tamsayi = -2147483648;//32bit 4byte +2147483647 -2147483648
            uint uzuntamsayi = 4567892;// 0 - 4294967295
            long dahauzuntamsayi = 9223372036854775807;
            ulong enuzuntamsayi = 18446744073709551615;

            int tamsayi2 = 5718; // değişken belirleme kuralı : int değişkenin veri tipi, tamsayi2: değişkenin adı, = 5718 değişkenin değeri, ; kodun bittiğini gösterir.

            //Kesirli Sayı Değişken Tipleri
            float kesirliSayi = 4.5f; //4byte yer kaplar 6-7 basamak
            double kesirliSayi2 = 4.5; //8byte yer kaplar 15 - 16 basamak

            //Decimal Veri Tipi
            decimal UrunFiyati = 5500; //12byte, duyarlı basamak 28 - 29

            //Char Veri Tipi
            char karakter = 'ç';//char sadece 1 tane değer alır ve tek tırnak içine yazılır

            //String Veri Tipi
            string degisken;
            string degisken1, degisken2;
            string metin = "string veri tipinde \n \t tüm karakterleri kullanabiliriz"; // \n metinde kendinden sonraki alanın bir alt satırdan devam etmesini, \t ise klavyeden tab tuşuna basmış gibi metni ileri iter

            Console.WriteLine("metin içeriği: " + metin);

            //Boolean Veri Tipi
            //Geriye true veya false dönen veri tipidir, 1byte lık yer kaplar
            bool islemSonuc = true;
            bool durum = false;

            //var ile değişken oluşturma

            var birdegisken = 18; //var ile oluşturulan değişkenlerde değişkenin veri tipi c# tarafından değişkene atanan değere göre otomatik algılanır
            var strmetin = "string metin";
            // strmetin = true; // strmetin değişkeninin tipi var tarafından string olarak belirlendikten sonra bool gibi farklı bir tipte veri atanamaz artık bu değişkene.

            var sonuc = false;
            sonuc = true;
            // sonuc = 18; // var ile tanımlanan nesneye farklı tipte veri atanamaz!

            Console.WriteLine("object veri tipi:");
            object nesne = "bu bir nesnedir"; // Bu değişken türüne her türden veri atanabilir.
            Console.WriteLine(nesne + "-Tipi: " + nesne.GetType());
            nesne = 18; // object ile tanımlanan nesne değiştirilebilir
            Console.WriteLine(nesne + "-Tipi: " + nesne.GetType()); // GetType metodu bir nesnenin veri tipini bize getirir.

            //C# ta sabit tanımlama
            const int kdvOrani = 18;//sabitleri const olarak tanımlayıp program içerisinde kullanabiliriz, sabitlerin değeri tanımlandığı yerde verilir sonradan değişmez
            const int iskonto = 25;
            //kdvOrani = 25; // sabitlerin değeri bu şekilde sonradan değiştirilemez!

            Console.WriteLine("Uygulanan Iskonto Oranı: " + iskonto);
            Console.WriteLine("Ekrana Bir Şey Yazıp Enter a Basınız:");
            var deger = Console.ReadLine();//bu komut ekrandan girilen 1 satırlık veriyi yakalamamızı sağlar
            Console.WriteLine("Girdiğiniz Değer : " + deger);
        }
    }
}
