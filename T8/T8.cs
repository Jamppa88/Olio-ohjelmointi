/* Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
 * 
 * Jani Kerttula K8958
 * 14.1.2017
 */

using System;

namespace T8
{
    class T8
    {
        static int[] luvut = new int[3];
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Anna ensimmäinen luku > ");
                luvut[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(luvut);
            Array.Reverse(luvut);

            Console.WriteLine("Suurin luku on " + luvut[0]);

            Console.ReadLine();
        }
        
    }
}
