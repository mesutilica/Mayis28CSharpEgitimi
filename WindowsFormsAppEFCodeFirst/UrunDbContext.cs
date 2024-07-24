using System;
using System.Collections.Generic;
using System.Data.Entity; //entity framework kütüphanesi
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppEFCodeFirst
{
    internal class UrunDbContext : DbContext //UrunDbContext bizim veritabanı yönetim contextimiz, DbContext ise entity framework ün 
    {
        public DbSet<Entities.Product> Products { get; set; }//Entity framework de Veritabanı tablolarımızı programımızla eşleştiren kısım. Products sql server veritabanındaki Products tablosuna karşılık gelir.
        /*
         * Projede Entity framework kullanmak için yapılacaklar;
         * Projeye sağ tıklayıp açılan menüden Nuget yazana tıklayıp paket yönetci ekranını açıyoruz
         * Nuget penceresinde Browse sekmesine basıp oradan Entity framework ü seçip install diyerek yüklemeyi tamamlıyoruz.
         * Projeye Entity classlarımızı(Product, Category.. vb) ekleyip içlerine propertyleri ekliyoruz
         * UrunDbContext sınıfımızı oluşturup Entity framework ün DbContext sınıfından kalıtımla bu şekilde tanımlıyoruz
         * UrunDbContext içine kaç Entity classımız varsa onları DbSet olarak yukardaki gibi tanımlıyoruz
         * ProductDal sınıfımızı oluşturuyoruz ve içinde Entity framework ile veritabanı işlemleri yapan metotlarımızı hazırlıyoruz
         * Son olarak bu metotları ilgili ekranlarda çağırarak veritabanı CRUD işlemlerini yapıyoruz.
         */
    }
}
