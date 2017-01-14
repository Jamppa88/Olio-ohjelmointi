/* Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.
 *  Anna Luku > 7 [Enter]    
        *
       ***
      *****
     *******
    *********
        *
        *
 *
 * Jani Kerttula, K8958
 * 14.1.2017
 */

using System;


namespace T15
{
    class T15
    {
        static void Main(string[] args)
        {
            int puu;
            Console.Write("Anna luku > ");
            puu = int.Parse(Console.ReadLine());
            DrawTree(puu);
            Console.ReadLine();
        }

        static void DrawTree(int a)
        {
            int layer = 1;
            int b = a - 3;
            while (b >= 0)
            {
                for (int i = 0; i < b; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < layer; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                layer += 2;
                b--;
            }
            b = a - 3;
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < b; x++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            
        }
    }
}
