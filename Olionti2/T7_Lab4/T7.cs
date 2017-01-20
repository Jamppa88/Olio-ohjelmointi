using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää perintää.
 *
 * Jani Kerttula, K8958
 * 20.1.2017
 */

namespace JAMK_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Child lapsi = new Child("Nunnu", 15, (Sex)1);
            Adult aikune = new Adult("Pete", 38, 0);

            Console.WriteLine("Ihmismoduuli.");
            while (true)
            {
                Console.WriteLine("Sinulla on kaksi tyyppiä, joita ohjata.");
                Console.WriteLine("Ensimmäisenä on lapsi {0}, joka sanoo: {1}", lapsi.Name, lapsi.SayHi());
                Console.WriteLine("Toisena sinulla on aikuinen {0}, joka sanoo: {1}", aikune.Name, aikune.SayHi());
                Console.WriteLine();
                Console.WriteLine("Oho, lapsi näyttää yrittävän syövän räkää, annatko? y/n");
                Console.Write(">> ");
                string input = Console.ReadLine();
                if (input == "n")
                {
                    Console.WriteLine("Et antanut syödä, nyt lapsi sanoo: {0}", lapsi.NoEatBooger());
                }
                else
                    Console.WriteLine("Nyt lapsi syö räkää, kuuluu vain: {0}", lapsi.EatBooger());
                Console.WriteLine("Petellä olisi töitä tehtävänä, tekeekö hän? y/n");
                Console.Write(">> ");
                input = Console.ReadLine();
                if (input == "n")
                {
                    Console.WriteLine("{1} pitää vapaata, puskan takaa kuuluu: {0}", aikune.DontWork(), aikune.Name);
                }
                else
                    Console.WriteLine("{1} paiskii ahkerasti töitä => {0}", aikune.DoWork(), aikune.Name);
                Console.WriteLine("\nTähän päättyy demo, haluatko kokeilla uudestaan? y/n");
                Console.Write(">> ");
                input = Console.ReadLine();
                if (input == "n")
                {
                    Console.WriteLine("Kiitoksia kokeilusta!");
                    break;
                }
                else
                {
                    Console.WriteLine("Otetaan uudestaan! Paina Enter jatkaaksesi...");
                    Console.ReadLine();
                    Console.Clear();
                }
                   
            }
        }
    }
}
