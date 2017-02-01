using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dice dice = new Dice();
                List<int> throws = new List<int>();
                int numThrows;
                string input;
                Console.Write("Anna heitettävien noppien määrä: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out numThrows))
                {
                    for (int i = 0; i < numThrows; i++)
                    {
                        throws.Add(dice.Throw());
                    }
                    int[] lkms = new int[6];
                    for (int i = 0; i < throws.Count; i++)
                    {
                        lkms[throws[i] - 1]++;
                    }
                    Console.WriteLine("Heitit noppaa {0} kertaa:", throws.Count);
                    Console.WriteLine("- keskiarvo: " + throws.Average());
                    for (int i = 0; i < lkms.Count(); i++)
                    {
                        Console.WriteLine("- {0}. esiintyi {1} kertaa", i + 1, lkms[i]);
                    }


                }
                else
                    Console.WriteLine("Et antanut lukua!");
                Console.ReadKey();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
