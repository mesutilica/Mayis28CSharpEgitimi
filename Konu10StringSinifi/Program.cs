namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu10 String Sinifi!");
            string degisken;
            char karakter = 'F'; // char tek karakter alır
            string metinlericin = "metinler için mi kullanıyoduk?";
            Console.WriteLine(metinlericin);

            // Ornek1();
            // StringMetotlari();
            SplitMetodu();
        }
        static void Ornek1()
        {
            string birMetin = "Ankara başkenttir";
            String birsayi = "123456789";
            System.String birTarih = "02.05.2021";
            string kod = "//5456dfgd\n";//buradaki \n kodu enter görevi görür ve kendinden sonra gelecek olan metni bir alt satıra kaydırır

            string s = "Barış Manço";
            Console.WriteLine("For Döngüsü Çıktısı");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("s[" + i + "] = " + s[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Foreach Döngüsü Çıktısı");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birsayi.GetType());
            Console.WriteLine(birTarih.GetType());
            Console.WriteLine(kod);
        }
        static void StringMetotlari()
        {
            string metin = "Stringin Birçok Metodu Vardır";

            Console.WriteLine("metin in karakter sayısı(metin.Length) : " + metin.Length); // Length metin değişkeninde kaç karakter olduğunu verir.
            var klon = metin.Clone(); // Clone metodu metin değişkeninin klonlayıp klon değişkenine atar.
            Console.WriteLine("metnin klonu : " + klon);
            metin = "My Name is Ali";
            Console.WriteLine(metin + " metin.EndsWith(\"i\") metin i ile mi bitiyor : " + metin.EndsWith("i"));
            Console.WriteLine(metin + " metin.EndsWith(\"r\") metin r ile mi bitiyor : " + metin.EndsWith("r"));
            Console.WriteLine(metin + " metin.StartsWith(\"r\") metin r ile mi başlıyor : " + metin.StartsWith("r"));
            Console.WriteLine(metin + " metin.StartsWith(\"m\") metin m ile mi başlıyor : " + metin.StartsWith("m"));
            Console.WriteLine(metin + " metin.StartsWith(\"M\") metin M ile mi başlıyor : " + metin.StartsWith("M"));
            Console.WriteLine(metin + " metin.IndexOf(name) metin içindeki name in index değeri : " + metin.IndexOf("name"));
            Console.WriteLine(metin + " metin.IndexOf(Name) metin içindeki Name in index değeri : " + metin.IndexOf("Name"));
            Console.WriteLine(metin + " metin.LastIndexOf(\"i\") metin içindeki i in index değeri : " + metin.LastIndexOf("i"));
            Console.WriteLine(metin + " metin.Insert(0, \"Merhaba : \") metine Merhaba ekleme : " + metin.Insert(0, "Merhaba : ")); // metnin değeri değişmiyor sadece başına merhaba ekleniyor
            Console.WriteLine(metin);
            Console.WriteLine("metin.Substring(2) : " + metin.Substring(2));
            Console.WriteLine("metin.Substring(2, 5) : " + metin.Substring(2, 5)); // Substring metinden parça alır, kaçıncı karakterden itibaren kaç karakter alacağımızı belirtiyoruz.
            Console.WriteLine("metin.ToLower : " + metin.ToLower()); // metini küçük harfe çevirir
            Console.WriteLine("metin.ToUpper : " + metin.ToUpper()); // metini büyük harfe çevirir
            Console.WriteLine("metin.ToLower().Replace(\" \", \"-\") : " + metin.ToLower().Replace(" ", "-")); // metini küçük harfe çevir ve replace ile içindeki boşlukları - ile değiştir
            Console.WriteLine("metin.Remove(2, 5): " + metin.Remove(2, 5)); // metinde seçili alanı silmek için

            Console.WriteLine("Her Kelimenin İlk Harfini Büyük Yapma");
            Console.WriteLine();
            string ilkHarfiBuyut = "C# String Culture info ile İLK keliMeleri büyük harfli yapma";
            ilkHarfiBuyut = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ilkHarfiBuyut.ToLower());
            Console.WriteLine(ilkHarfiBuyut);
        }
        static void SplitMetodu()
        {
            string sehirler = "İstanbul,Ankara,İzmir,Bursa,Adana,Antalya";
            string[] sehirlerArray = sehirler.Split(',');
            Console.WriteLine("4. Şehir : " + sehirlerArray[3]);
            foreach (var item in sehirlerArray)
            {
                Console.WriteLine("Şehir : " + item);
            }
            Console.WriteLine();

            Console.WriteLine("tarih parçalama");

            var tarih = DateTime.Now.ToShortDateString();
            Console.WriteLine("tarih: " + tarih);
            var tarihparcalari = tarih.Split(".");
            var gun = tarihparcalari[0];
            var ay = tarihparcalari[1];
            var yil = tarihparcalari[2];

            Console.WriteLine("gun: " + gun + "\n ay: " + ay + "\n yil: " + yil);
        }
    }
}
