/* Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. 
 * Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
 * 
 * Jani Kerttula, K8958
 * 14.1.2017
 */

using System;


namespace T10
{
    class T10
    {
        static void Main(string[] args)
        {
            // Tehdään valmiiksi alustettu jono
            int[] arr = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.WriteLine("Hep!");
            }
            Console.ReadLine();
        }
    }
}
