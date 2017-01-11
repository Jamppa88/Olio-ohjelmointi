using System;
/* Tehtävä 1, Jani Kerttula
 * 9.1.2017
 */

namespace T1
{
    // Määritetään enumeraatio
    enum Luku {yksi, kaksi, kolme }
    class T1
    {
        
        static void Main(string[] args)
        {
            // Esitellään muuttujat
            int luku;
            Luku l;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());
            l = (Luku)luku-1;
            // Jos luku on enumeraation sisällä, tulostetaan se
            if (luku > 0 && luku < 4)
            {
                Console.WriteLine("Annoit luvun {0}", l);
            } else
            {
                Console.WriteLine("Joku muu luku");
            }
            Console.ReadLine();
        }
    }
}
