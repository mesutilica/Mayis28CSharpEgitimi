namespace Konu15AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu15 Abstract Classes!");

            Console.WriteLine();

            Database database = new Oracle();//Database sınıfından yeni bir oracle nesnesi oluşturuyoruz
            database.Add();
            database.Delete();

            Console.WriteLine();

            Database database2 = new SqlServer();//Database sınıfından yeni bir SqlServer nesnesi oluşturuyoruz
            database2.Add();
            database2.Delete();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Add metodu çalıştı Ekleme yapıldı");
        }

        public abstract void Delete();//crud
        public abstract void Update();//crud
        public abstract void Get();//crud
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            // silme kodları
            Console.WriteLine("Kayıt SqlServer dan silindi");
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            // silme kodları
            Console.WriteLine("Kayıt Oracle dan silindi");
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
