using System;
using System.Collections.Generic;
using System.Linq;
using System.Data; // ado.net kütüphanesi
using System.Data.SqlClient; // ado.net kütüphanesi

namespace WindowsFormsAppAdoNet
{
    internal class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(LocalDB)\MSSQLLocalDB; database=UrunYonetimiAdoNet; Integrated security=True"); // sql server veritabanına bağlantı kurmayı sağlayan nesnemiz
        private void ConnectionKontrol()//Veritabanı bağlantısının açık olup olmadığını kontrol eden metot
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            ConnectionKontrol(); // veritabanı bağlantısını aç
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    UrunAdi = reader["UrunAdi"].ToString(),
                    StokMiktari = Convert.ToInt32(reader["StokMiktari"]),
                    UrunFiyati = Convert.ToDecimal(reader["UrunFiyati"]),
                    Durum = Convert.ToBoolean(reader["Durum"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            command.Dispose();

            return products;
        }
        public DataTable GetAllDataTable()
        {
            ConnectionKontrol();//Bağlantı kontrolü yaptık
            SqlCommand komut = new SqlCommand("select * from products", _connection);//veritabanına sorgumuzu gönderdik
            SqlDataReader reader = komut.ExecuteReader();//veritabanındaki kayıtları okuduk
            DataTable dataTable = new DataTable();//Okuduğumuz kayıtları yükleyeceğimiz data tabloyu oluşturduk
            dataTable.Load(reader);//data tabloya veritabanından çektiğimiz kayıtları yükledik
            reader.Close();//veri okuyucuyu kapattık
            _connection.Close();
            komut.Dispose();
            return dataTable;//kayıtların yüklendiği data tabloyu geriye döndürdük
        }
        public DataTable GetAllDataTable(string kelime)
        {
            ConnectionKontrol();//Bağlantı kontrolü yaptık
            SqlCommand komut = new SqlCommand("select * from products where urunadi like @kelime", _connection);//veritabanına sorgumuzu gönderdik
            komut.Parameters.AddWithValue("@kelime", "%" + kelime + "%");
            SqlDataReader reader = komut.ExecuteReader();//veritabanındaki kayıtları okuduk
            DataTable dataTable = new DataTable();//Okuduğumuz kayıtları yükleyeceğimiz data tabloyu oluşturduk
            dataTable.Load(reader);//data tabloya veritabanından çektiğimiz kayıtları yükledik
            reader.Close();//veri okuyucuyu kapattık
            _connection.Close();
            komut.Dispose();
            return dataTable;//kayıtların yüklendiği data tabloyu geriye döndürdük
        }
        public void Add(Product product)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand(
                "Insert into Products values(@UrunAdi,@UrunFiyati,@StokMiktari,@Durum)", _connection);
            command.Parameters.AddWithValue("@UrunAdi", product.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", product.UrunFiyati);
            command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
            command.Parameters.AddWithValue("@Durum", product.Durum);
            command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
        }
    }
}
