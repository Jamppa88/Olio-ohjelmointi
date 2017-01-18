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
            Amplifier vahvistin = new Amplifier();
            bool exit = false;
            string input;
            int tmp;
            while (!exit)
            {
                Console.Write("Give a new volume value (0-100) or x to exit > ");
                input = Console.ReadLine();
                if (int.TryParse(input, out tmp)) {
                    vahvistin.CurrentAmp = tmp;
                    if (tmp > vahvistin.MaxAmp)
                        Console.WriteLine("-> Too high volume - Amplifier volume is set to maximum : {0}", vahvistin.MaxAmp);
                    else if (tmp < vahvistin.MinAmp)
                        Console.WriteLine("-> Too low volume - Amplifier volume is set to minimum : {0}", vahvistin.MinAmp);
                    else
                        Console.WriteLine("-> Amplifier volume is set to: {0}", tmp);
                }
                else if (input == "x")
                    exit = true;
                else
                    Console.WriteLine("Invalid input!");
            }
        }
    }
    
}
