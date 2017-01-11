using System;


/* Tee ohjelma, jossa kysytään käyttäjältä tämän ikä.
 * Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta,
 * tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
 * 
 * Jani Kerttula K8958
 * 11.1.2017
 */

namespace T4
{
    // Huvin vuoksi erillenen class iälle
    class Henkilo
    {
        public int IKA { get; set; }
    }
    class T4
    {
        static void Main(string[] args)
        {
            Henkilo henk = new Henkilo();
            Console.Write("Anna ikäsi > ");
            henk.IKA = int.Parse(Console.ReadLine());
            // yksinkertainen vertailu iästä
            if (henk.IKA < 18)
            {
                Console.WriteLine("Olet alaikäinen!");
            }
            else if (henk.IKA < 65 && henk.IKA >= 18)
            {
                Console.WriteLine("Olet aikuinen!");
            }
            else
            {
                Console.WriteLine("Olet seniori!");
            }
            Console.ReadLine();
        }
    }
}
