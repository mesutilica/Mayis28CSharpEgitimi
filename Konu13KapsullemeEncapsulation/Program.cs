namespace Konu13KapsullemeEncapsulation
{
    public class Bolum
    {
        private string BolumAdi;//dışarıdan erişime kapalı değişkenimiz. 
        //Accessor (Getter)
        public string GetBolumAdi() { return BolumAdi; }//Geriye private BolumAdi değişkenini döndüren metot
        //Mutator (Setter)
        //public void SetBolumAdi(string a) { BolumAdi = a; }//Dışarıdan aldığı a parametresini BolumAdi değişkenine atayan metot
        public void SetBolumAdi(string istenenEgitimi)
        {
            if (istenenEgitimi == "Yazılım Mühendisliği")
            {
                Console.WriteLine("Üniversitemizde {0} bölümü bulunmamaktadır!", istenenEgitimi);
            }
            else BolumAdi = istenenEgitimi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13KapsullemeEncapsulation!");
        }
    }
}
