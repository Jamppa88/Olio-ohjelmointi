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
            Fridge jkaappi = new Fridge("Bosch", "T-1000", 1992, "white", true);
            string input;
            int temp;
            bool exit = false;
            Console.WriteLine("Jääkaappi-demo.");
            while (!exit)
            {
                Console.WriteLine("Ohjaa jääkaappia käskyillä on/off, fridge tai freezer. Voit myös syöttää data saadaksesi kaapin tiedot. Syötä x poistuaksesi.\n");
                Console.WriteLine("Nykyinen tila: Power = {0}, Jääkaapin lämpötila = {1} C, {2}.", jkaappi.Power, jkaappi.FridgeTemp, (jkaappi.HasFreezer)?"Pakastimen lämpötila = " + jkaappi.FreezeTemp + " C":"Ei pakastinta");
                Console.Write("\n > ");
                input = Console.ReadLine();
                if (input == "x")
                    exit = true;
                else if (input == "on")
                    jkaappi.Power = true;
                else if (input == "off")
                    jkaappi.Power = false;
                else if (input == "fridge")
                {
                    Console.WriteLine("Syötä haluamasi lämpötila.");
                    Console.Write(" > ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out temp))
                    {
                        jkaappi.FridgeTemp = temp;
                    }
                    else
                        Console.WriteLine("Virheellinen syöte!");
                }
                else if (input == "freezer")
                {
                    Console.WriteLine("Syötä haluamasi lämpötila.");
                    Console.Write(" > ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out temp))
                    {
                        jkaappi.FreezeTemp = temp;
                    }
                    else
                        Console.WriteLine("Virheellinen syöte!");
                }
                else if (input == "data")
                    Console.WriteLine("Data Sheet: " + jkaappi.DataSheet());
                else if (input == "data2")
                    Temp();
                else if (input == "change")
                {
                    if (jkaappi.Manufacturer == "Bosch")
                        jkaappi = new Fridge("Helkama", "Super", 2006, "black", false);
                    else
                        jkaappi = new Fridge("Bosch", "T-1000", 1992, "white", true);
                }

                else
                    Console.WriteLine("Tuntematon syöte!");
            }
          
        }

        static void Temp()
        {
            Oven uuni = new Oven("Harvia", "Inferno", 2017, "black", 0);
            Console.WriteLine(uuni.DataSheet());
        }
    }
}
