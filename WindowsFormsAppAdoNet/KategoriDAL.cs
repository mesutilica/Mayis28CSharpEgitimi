using System.Data.SqlClient; // ado.net kütüphanesi

namespace WindowsFormsAppAdoNet
{
    public class KategoriDAL : OrtakDAL
    {
        public int Add(Kategori kategori)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("insert into Categories values(@KategoriAdi, @Durum)", _connection);
            command.Parameters.AddWithValue("@KategoriAdi", kategori.KategoriAdi);
            command.Parameters.AddWithValue("@Durum", kategori.Durum);
            var sonuc = command.ExecuteNonQuery();//Bu satır insert komutunun çalıştırılarak verilerin veritabanına işlenmesini sağlar
            command.Dispose();
            _connection.Close();
            return sonuc;
        }
        public int Update(Kategori kategori)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("update Categories set KategoriAdi=@KategoriAdi, Durum=@Durum where Id=@Id", _connection);
            command.Parameters.AddWithValue("@KategoriAdi", kategori.KategoriAdi);
            command.Parameters.AddWithValue("@Durum", kategori.Durum);
            command.Parameters.AddWithValue("@Id", kategori.Id);
            var sonuc = command.ExecuteNonQuery();//Bu satır insert komutunun çalıştırılarak verilerin veritabanına işlenmesini sağlar
            command.Dispose();
            _connection.Close();
            return sonuc;
        }
        public int Delete(int Id)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("delete from Categories where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", Id);
            var sonuc = command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
            return sonuc;
        }
    }
}
