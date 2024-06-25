namespace Konu12KalitimInheritance
{
    public class OrtakOzellikler : OrnekMetotlar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime EklenmeTarihi { get; set; }
    }
}
