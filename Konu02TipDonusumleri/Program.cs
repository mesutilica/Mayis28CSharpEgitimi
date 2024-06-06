namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Dönüşümleri!");
            //Implicit Casting daha küçük boyutlu bir türü daha büyük bir boyut türüne geçirirken otomatik olarak yapılır
            Console.WriteLine("Implicit Casting");
            int sayi = 1234567890;
            double kesirliSayi = sayi; //int den double a otomatik dönüşüm

            Console.WriteLine(sayi);      // Çıktı 9
            Console.WriteLine(kesirliSayi);   // Çıktı 9

            Console.WriteLine();

            //Explicit Casting türü değerin önüne parantez içine alarak manuel yapılmalıdır
            Console.WriteLine("Explicit Casting");
            double kesirliSayi2 = 1234567890;
            int tamSayi = (int)kesirliSayi2;    // Manuel dönüştürme: double dan int e

            Console.WriteLine("kesirliSayi2 : " + kesirliSayi2);   // Çıktı 9.78
            Console.WriteLine("tamSayi : " + tamSayi);      // Çıktı 9

            Console.WriteLine();
            Console.WriteLine("Diğer Tür Dönüştürme Yöntemleri");

            int tamSayi2 = 10;
            double kesirliSayi3 = 95.25;
            bool islemSonuc = true;

            Console.WriteLine("Lütfen Bir Sayı Giriniz:");
            var strparsayi = Console.ReadLine();

            Console.WriteLine("strparsayi nın veri tipi : " + strparsayi.GetType());

            var parsayi = int.Parse(strparsayi); // int.Parse metodu kendisine verilen string değerin tırnaklarını kaldırarak int tipine çevirir

            Console.WriteLine("parsayi nın veri tipi : " + parsayi.GetType());

            Console.WriteLine("int.Parse : " + (int.Parse(strparsayi) + tamSayi2));
            Console.WriteLine("double.Parse : " + (double.Parse(strparsayi) + tamSayi2));
            Console.WriteLine("decimal.Parse : " + (decimal.Parse(strparsayi) + tamSayi2));

            Console.WriteLine();

            Console.WriteLine("Convert sınıfı metotlarıyla tip dönüştürme");
            Console.WriteLine(Convert.ToString(tamSayi2).GetType()); // convert int to string
            Console.WriteLine(Convert.ToDouble(tamSayi2).GetType()); // convert int to double
            Console.WriteLine(Convert.ToInt32(kesirliSayi3).GetType()); // convert double to int
            Console.WriteLine(Convert.ToString(islemSonuc).GetType());   // convert bool to string

            Console.WriteLine();

            object nesne = "123456";// çift tırnak içine yazılan verinin tipi ne olursa olsun c# bunu string tipinde algılar!
            Console.WriteLine("nesne nin veri tipi : " + nesne.GetType());
            nesne = Convert.ToDecimal(nesne);
            Console.WriteLine("nesne nin veri tipi : " + nesne.GetType());
            Console.WriteLine("nesnenin değeri: " + nesne);
        }
    }
}
