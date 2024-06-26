namespace Konu14InterfacesArayuzler
{
    interface OrnekArayuz // class yerine interface yazıyoruz
    {
        public int Id { get; set; }
    }
    interface IDemo
    {
        void Goster(); // interface de metot imzası tanımlama
    }
    interface icerebilecekleri : IDemo
    {
        public int sayi1 { get; set; }
        int sayi { get; set; }
        static int sayi2 { get; set; }
        void Topla();
        int ToplamaYap();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu14InterfacesArayuzler!");

        }
    }
    interface ISinifGereksinimleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
    }
    interface IVeritabaniIslemleri
    {
        void Add();
        void Update();
        void Delete();
        void Get();
        void GetAll();
    }
    class Urun : ISinifGereksinimleri, IVeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
        public string? Resim { get; set; }

        public void Add()
        {
            Console.WriteLine("Ürün veritabanına eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Ürün veritabanından silindi");
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("Ürün güncellendi");
        }
    }
}
