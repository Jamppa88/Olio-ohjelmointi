/* Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
 * 
 * Jani Kerttula, K8958
 * 14.1.2017
 */

using System;
using System.Collections.Generic;


namespace T9
{
    class T9
    {
        static void Main(string[] args)
        {
            // Käytetään geneeristä List-metodia tehdäksemme määrittämättömän kokoisen listan.
            List<int> luvut = new List<int>();
            bool exit = false;
            int sum = 0;
            Console.WriteLine("Syötä lukuja, lopeta syöttö antamalla luku 0.");
            while (exit != true)
            {
                Console.Write("Anna luku > ");
                // Lisätään listaan luku
                luvut.Add(int.Parse(Console.ReadLine()));
                // Jos listaan tulee luku 0
                if (luvut.Contains(0))
                    exit = true;
            }
            foreach (int a in luvut)
            {
                sum += a;
            }
            Console.WriteLine("Syötettyjen lukujen summa on {0}.", sum);
            Console.ReadLine();
        }
    }
}
