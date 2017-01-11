using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Tee ohjelma, jossa kysytään käyttäjältä tämän ikä.
 * Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta,
 * tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
 */

namespace T4
{
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
