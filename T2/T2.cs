using System;
/* Tehtävä 2, Jani Kerttula
 * 9.1.2017
 */

namespace T2
{
    class T2
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Anna pistemäärä > ");
            luku = int.Parse(Console.ReadLine());
            if (luku >= 0 && luku <= 11) { 
                Console.WriteLine("Koulunumero on " + luku/2);
                // integerin jako floorautuu aina!
            }else if (luku == 12) // ainut erikoisuus
            {
                Console.WriteLine("Koulunumero on 5");
            }
            else
            {
                Console.WriteLine("Pistemäärä ei ole mahdollinen!");
            }
            Console.ReadLine();
        }
    }
}
