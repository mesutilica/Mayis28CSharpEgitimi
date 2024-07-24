using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppEFCodeFirst.Entities; // Product sınıfını burada kullanabilmek için gerekli using

namespace WindowsFormsAppEFCodeFirst
{
    internal class ProductDal
    {
        public List<Product> GetAll()
        {
            using (UrunDbContext context = new UrunDbContext())//entity framework üzerinden db işlemlerini yapabilmek için
            {
                return context.Products.ToList();//GetAll metodunun çağrıldığı yere ürün listesini döndür
            }
        }
    }
}
