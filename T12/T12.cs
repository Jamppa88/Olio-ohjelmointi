/* Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. 
 * Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
 * 
 * Jani Kerttula, K8958
 * 14.1.2017
 */

using System;


namespace T12
{
    class T12
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna luku > ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Käytetään valmista metodia kääntämään taulukko
            Array.Reverse(arr);

            Console.Write("Luvut ovat ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[arr.Length -1])
                    Console.Write("{0}", arr[i]);
                else
                    Console.Write("{0}, ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
