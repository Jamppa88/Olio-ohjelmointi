using System;

/* Tehtävä 3, Jani Kerttula
 * 9.1.2017
 */
namespace T3
{
    class T3
    {
        static void Main(string[] args)
        {
            float[] luku = new float[3];
            float sum, ka;
            Console.Write("Anna ensimmäinen luku > ");
            luku[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku > ");
            luku[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku > ");
            luku[2] = int.Parse(Console.ReadLine());
            sum = luku[0]+ luku[1]+ luku[2];
            ka = sum / 3;
            Console.WriteLine("\nLukujen summa on {0}, ja keskiarvo {1}", sum, ka);
            
            Console.ReadLine();
        }
    }
}
