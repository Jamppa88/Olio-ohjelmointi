/* Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
 * Algoritmi
 * 4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat
 * Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
 * 
 * Jani Kerttula K8958
 * 11.1.2017
 */

using System;

namespace T7
{
    class T7
    {
        static int luku;
        static void Main(string[] args)
        {
            Console.Write("Anna vuosiluku > ");
            luku = int.Parse(Console.ReadLine());

            Vertaus();
            Console.ReadLine();
        }
        static void Vertaus()
        {
            // Katsotaan onko luku jaollinen neljällä muttei sadalla
            if (luku % 4 == 0 && luku % 100 != 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            // Sisällytetään vuosisadat jotka ovat 400 jaollisia
            else if (luku % 400 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            // Muuten ei
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
        }
    }
}
