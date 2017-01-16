/* Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
 *
 * Jani Kerttula K8958
 * 11.1.2017
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class T5
    {
        // Annetaan yhteinen muuttuja metodeille
        static int t;
        static void Main(string[] args)
        {
            Console.Write("Anna sekunttimäärä > ");
            t = int.Parse(Console.ReadLine());
            CalcTime();
            Console.ReadLine();
        }
        // Aliohjelma, joka laskee ajan haluttuun muotoon
        static void CalcTime()
        {
            int h, m, s;
            // Integerejä jaettaessa laskutoimitus jättää desimaalit pois, = profit!
            h = t / 3600;
            m = (t - h * 3600) / 60;
            s = t - h * 3600 - m * 60;

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: {0} tuntia {1} minuuttia {2} sekunttia", h, m, s);

        }
    }
}
