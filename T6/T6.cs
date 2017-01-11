/* Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
 * Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
 * Anna matka > 250 [Enter]
 * Bensaa kuluu 17,55 litraa, kustannus 27,99 euroa
 * 
 * Jani Kerttula K8958
 * 11.1.2017
 */

using System;


namespace T6
{
    class T6
    {
        static decimal matka;
        static void Main(string[] args)
        {
            Console.Write("Anna matka > ");
            matka = decimal.Parse(Console.ReadLine());

            Laskenta();
            Console.ReadLine();
        }
        // Aliohjelma laskentaan
        static void Laskenta()
        {
            decimal kulutus = 0.0702m;
            decimal hinta = 1.595m;
            decimal litra, kustannus;

            litra = (kulutus * matka);
            kustannus = (kulutus * matka * hinta);

            Console.WriteLine("Bensaa kuluu {0:F2} litraa, kustannus {1:F2} euroa", litra, kustannus); // {0:F2} muuntaa luvun kahden desimaalin tarkkuuteen
        }
    }
}
