/* Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
 *
 **
 ***
 ****
 *****

 Käyttäjä antaa syötteenä tähtirivien lukumäärän. Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.

 * Jani Kerttula, K8958
 * 14.1.2017
 * 
 */

using System;


namespace T11
{
    class T11
    {
        static void Main(string[] args)
        {
            int rivit;
            Console.Write("Anna rivien määrä > ");
            rivit = int.Parse(Console.ReadLine());

            for (int a= 0; a < rivit; a++)
            {
                for (int b= 0; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
