namespace ClassLibrary1
{
    public class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Fiyati { get; set; }
        public int StokMiktari { get; set; }
        public int KategoriId { get; set; }
    }
}
