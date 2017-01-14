/* Mäkihypyssä käytetään viittä arvostelutuomaria. 
 * Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, 
 * että summasta on vähennetty pois pienin ja suurin tyylipiste.
 * 
 * Jani Kerttula, K8958
 * 14.1.2017
 */

using System;
using System.Linq;


namespace T13
{
    class T13
    {
        static void Main(string[] args)
        {
            int[] pisteet = new int[5];
            int sum = 0;
            for (int i = 0; i < pisteet.Length; i++)
            {
                Console.Write("Anna pisteet > ");
                pisteet[i] = int.Parse(Console.ReadLine());
            }
            
            
            foreach (int i in pisteet)
            {
                sum += i;
            }
            // Vähennetään lasketusta kokonaissummasta suurin ja pienin luku
            sum -= pisteet.Max() + pisteet.Min();

            Console.WriteLine("Kokonaispisteet ovat {0}.", sum);
            Console.ReadLine();
        }
    }
}
