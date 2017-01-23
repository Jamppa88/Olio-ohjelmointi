using System;


namespace JAMK_IT
{
    abstract class Nisakas
    {
        public int Ika { get; set; }
        abstract public void Liiku();
    }
    class Ihminen: Nisakas
    {
        public int Paino { get; set; }
        public int Pituus { get; set; }
        public string Nimi { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Liikun...");
        }
        public void Kasva()
        {
            Ika++;
        }
    }
    class Vauva: Ihminen
    {
        public string Vaippa { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Konttaan...");
        }
    }
    class Aikuinen: Ihminen
    {
        public string Auto { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Kävelen...");
        }
    }
}
