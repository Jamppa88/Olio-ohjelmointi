using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator hissi = new Elevator();
            bool exit = false;
            string input;
            int tmp;
            while (!exit)
            {
                Console.WriteLine("Elevator is now on floor {0}.", hissi.CurrentFloor);
                Console.Write("Give a new floor number (1-5) or x to exit > ");
                input = Console.ReadLine();
                if (int.TryParse(input, out tmp))
                {
                    hissi.CurrentFloor = tmp;
                    if (tmp < hissi.MinFloor || tmp > hissi.MaxFloor)
                        Console.WriteLine("Non-existent floor!");
                }
                
                else if (input == "x")
                    exit = true;
                else
                    Console.WriteLine("Invalid input! Type x to exit.");
            }
        }
    }

    
}
