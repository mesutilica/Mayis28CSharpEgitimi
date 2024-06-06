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
        }
    }
}
