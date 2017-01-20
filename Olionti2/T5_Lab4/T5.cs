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
            Radio radio = new Radio();
            string input;
            int temp1;
            double temp2;
            bool exit = false;
            Console.WriteLine("Radio-ohjelma.");
            while (!exit)
            {
                Console.WriteLine("Ohjaa radiota käskyillä on/off, vol tai freq. Syötä x poistuaksesi.");
                Console.WriteLine("Nykyinen tila: Power = {0}, Volume = {1}, Frequency = {2}.", radio.Power, radio.Volume, radio.Frequency);
                Console.Write(" > ");
                input = Console.ReadLine();
                if (input == "x")
                    exit = true;
                else if (input == "on")
                    radio.Power = true;
                else if (input == "off")
                    radio.Power = false;
                else if (input == "vol")
                {
                    Console.WriteLine("Syötä haluamasi äänen voimakkuus (0-9)");
                    Console.Write(" > ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out temp1))
                    {
                        radio.Volume = temp1;
                    }
                    else
                        Console.WriteLine("Virheellinen syöte!");
                }
                else if (input == "freq")
                {
                    Console.WriteLine("Syötä haluamasi taajuus (2000-26000)");
                    Console.Write(" > ");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out temp2))
                    {
                        radio.Frequency = temp2;
                    }
                    else
                        Console.WriteLine("Virheellinen syöte!");
                }
                else
                    Console.WriteLine("Tuntematon syöte!");
            }
            
        }
    }
}
