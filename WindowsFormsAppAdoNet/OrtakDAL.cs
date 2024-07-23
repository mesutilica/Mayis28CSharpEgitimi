using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppAdoNet
{
    public class OrtakDAL
    {
        internal SqlConnection _connection = new SqlConnection(@"server=(LocalDB)\MSSQLLocalDB; database=UrunYonetimiAdoNet; Integrated security=True"); // sql server veritabanına bağlantı kurmayı sağlayan nesnemiz
        internal void ConnectionKontrol()//Veritabanı bağlantısının açık olup olmadığını kontrol eden metot
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public DataTable GetAllDataTable(string sqlSorgu)
        {
            ConnectionKontrol();//Bağlantı kontrolü yaptık
            SqlCommand komut = new SqlCommand(sqlSorgu, _connection);//veritabanına sorgumuzu gönderdik
            SqlDataReader reader = komut.ExecuteReader();//veritabanındaki kayıtları okuduk
            DataTable dataTable = new DataTable();//Okuduğumuz kayıtları yükleyeceğimiz data tabloyu oluşturduk
            dataTable.Load(reader);//data tabloya veritabanından çektiğimiz kayıtları yükledik
            reader.Close();//veri okuyucuyu kapattık
            _connection.Close();
            komut.Dispose();
            return dataTable;//kayıtların yüklendiği data tabloyu geriye döndürdük
        }
    }
}
