namespace Konu08SiniflarClasses
{
    /*C# nesne yönelimli bir programlama dili olduğu için her şey sınıflar içinde tanımlanır.
     sınıflara ve sınıf öğelerine erişim kısıtlanabilir veya belirli düzeylerde erişime izin verilebilir.
     Öğelere erişimi kısıtlayan ya da yetki veren anahtar sözcüklere "Erişim Belirteçleri" (acces modifiers) denir.
     *Erişim belirteçleri 4 ana sınıfa ayrılır
     * public    : Erişim kısıtı yoktur, her yerden erişilebilir
     * protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
     * internal  : Etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez
     * private   : Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez
     * Bir öğe yalnızca 1 erişim belirteci alabilir
     * namespace erişim belirteci almaz çünkü o daima public tir
     * Sınıflar public yada internal nitelemesi alabilirler ama protected yada private nitelemesi alamazlar
     * enum erişim belirteci almaz çünkü daima public tir
     */
    class Ev // sınıf tanımlama
    {
        internal string sokakAdi;
        internal int kapiNo;
    }
    public class deneme
    {
        public string UrunAdi = "public öğeye herkes erişebilir";
        protected class test //Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
        {
            string UrunAdi;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar, Classes!");
            
            Ev ilkEv = new Ev(); // soyut bir yapı olan ev sınıfından, somut bir nesne olan ilkev i oluşturduk
            ilkEv.sokakAdi = "Okul sk";
            ilkEv.kapiNo = 10;
            Console.WriteLine("İlk ev sokak adı : " + ilkEv.sokakAdi);
            Console.WriteLine("İlk ev kapı numarası : " + ilkEv.kapiNo);

            Console.WriteLine();

            Ev yazlikEv = new();
            yazlikEv.sokakAdi = "Deniz Sk.";
            yazlikEv.kapiNo = 18;
            Console.WriteLine("yazlikEv sokak adı : " + yazlikEv.sokakAdi);
            Console.WriteLine("yazlikEv kapı numarası : " + yazlikEv.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new()
            {
                sokakAdi = "Kavak sk", // bu kullanımda ; yerine öğeler arasına , koymamız gerekli
                kapiNo = 34
            };
            Console.WriteLine("koyEvi sokak adı : " + koyEvi.sokakAdi);
            Console.WriteLine("koyEvi kapı numarası : " + koyEvi.kapiNo);

            Console.WriteLine();

            Kullanici kullanici = new() // Burada Kullanici sınıf, kullanici ise nesnedir.
            {
                Adi = "Deniz",
                Soyadi = "Çoban",
                Email = "deniz@coban.com",
                Id = 1,
                KullaniciAdi = "deniz",
                Sifre = "1234"
            };

            Kullanici mesut = new()
            {
                Id = 18,
                Adi = "Mesut",
                Soyadi = "Ilıca",
                Email = "mesutilica@gmail.com",
                KullaniciAdi = "mesut",
                Sifre = "123"
            };

            Console.WriteLine("kullanici Bilgileri :\n Adı : {0} Soyadı : {1}", kullanici.Adi, kullanici.Soyadi);
            Console.WriteLine();
            Console.WriteLine("Kendi Kullanıcımız :\n Adı : {0} Soyadı : {1}", mesut.Adi, mesut.Soyadi);

            Console.WriteLine();
            /*
            Console.WriteLine("Kullanıcı Adınız :");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz :");
            var sifre = Console.ReadLine();

            if (kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.Sifre)
            {
                Console.WriteLine("Hoşgeldin : " + kullanici.Adi + " " + kullanici.Soyadi);
            }
            else Console.WriteLine("Giriş Başarısız!");

            Console.WriteLine();
            */
            Araba araba = new()
            {
                Id = 1,
                Marka = "Dacia",
                Model = "Logan",
                KasaTipi = "Sedan",
                VitesTipi = "Manuel",
                YakitTipi = "Dizel",
                Renk = "Bordo"
            };
            Console.WriteLine("Araç Bilgisi:");
            Console.WriteLine($"Marka : {araba.Marka} \n Model : {araba.Model} \n Renk : {araba.Renk}");

            Console.WriteLine();

            Araba araba2 = new()
            {
                Id = 2,
                Marka = "Audi",
                Model = "A8 Long",
                Renk = "Siyah"
            };
            Console.WriteLine("2. Araç Bilgisi:");
            Console.WriteLine($"Marka : {araba2.Marka} \n Model : {araba2.Model} \n Renk : {araba2.Renk}");

            Console.WriteLine();


            Kategori kategori = new()
            {
                Id = 1,
                KategoriAdi = "Elektronik"
            };
            Kategori kategori2 = new()
            {
                Id = 2,
                KategoriAdi = "Bilgisayar"
            };
            Kategori kategori3 = new()
            {
                Id = 3,
                KategoriAdi = "Telefon"
            };

            Console.WriteLine("Kategori : " + kategori.KategoriAdi);
            Console.WriteLine("Kategori 2 : " + kategori2.KategoriAdi);
            Console.WriteLine("Kategori 3 : " + kategori3.KategoriAdi);

            Console.WriteLine();

            SiniftaMetotKullanimi metotKullanimi = new();
            var sonuc = metotKullanimi.LoginKontrol("admin", "1234");
            if (sonuc == true)
            {
                Console.WriteLine("Giriş Başarılı!");
            }
            else Console.WriteLine("Giriş Başarısız!");

            Console.WriteLine();

            Console.WriteLine("Statik Degisken: " + SiniftaMetotKullanimi.SinifDegiskeni); // burada static olan değişkene direk sınıfadı.değişken adı şeklinde erişebiliyoruz

            Console.WriteLine("Dinamik Degisken: " + metotKullanimi.DinamikDegisken);

            Console.WriteLine();

            Urun urun = new()
            {
                Adi = "Klavye",
                Fiyati = 249,
                UrunAciklamasi = "RGB Işıklı",
                Id = 1,
                Markasi = "Logitech"
            };
            Urun mouse = new()
            {
                Adi = "Mouse",
                Fiyati = 199,
                UrunAciklamasi = "Kablolu",
                Markasi = "A4 Tech"
            };
            Console.WriteLine("Ürün Bilgileri:");
            Console.WriteLine($"Ürün Adı : {urun.Adi}");
            Console.WriteLine($"Ürün Fiyatı : {urun.Fiyati}");
            Console.WriteLine($"Ürün Ürün Açıklaması : {urun.UrunAciklamasi}");
            Console.WriteLine();
            Console.WriteLine("Ürün Bilgileri:");
            Console.WriteLine($"Ürün Adı : {mouse.Adi}");
            Console.WriteLine($"Ürün Fiyatı : {mouse.Fiyati}");
            Console.WriteLine($"Ürün Ürün Açıklaması : {mouse.UrunAciklamasi}");
            Console.WriteLine();

        }
    }
    class Kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string Soyadi;
    }
    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
    }
}
