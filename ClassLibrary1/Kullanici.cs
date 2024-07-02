namespace ClassLibrary1
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string? KullaniciAdi { get; set; } // string? soru işareti bu özellik boş bırakılabilir demek
        public string Sifre { get; set; } // diğerleri boş bırakılamaz
        public string Email { get; set; }
    }
}
