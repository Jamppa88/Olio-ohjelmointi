using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static List<Kalastaja> fishers = new List<Kalastaja>();
        static void Main(string[] args)
        {
            CreateFisher("Pekka Pouta", "0401234567");
            Kalapaikka doomLake = new Kalapaikka("Doom Lake", "Jyväskylä");
            Kala trout = new Kala("Trout", 150, 2.3, doomLake);
            Kalapaikka rova = new Kalapaikka("Rovajärvi", "Rovaniemi");
            Kala salmon = new Kala("Salmon", 160, 10.3, rova);
            fishers[0].Kalat.Add(trout);
            Console.WriteLine("{0} caught a new fish!", fishers[0].Name);
            Console.WriteLine("- {0}, {1} cm, {2} kg, {3}.", fishers[0].Kalat.Last().Name, fishers[0].Kalat.Last().Length, fishers[0].Kalat.Last().Weight, fishers[0].Kalat.Last().FoundAt.Name);
            Console.WriteLine();
            fishers[0].Kalat.Add(salmon);
            Console.WriteLine("{0} caught a new fish!", fishers[0].Name);
            Console.WriteLine("- {0}, {1} cm, {2} kg, {3}.", fishers[0].Kalat.Last().Name, fishers[0].Kalat.Last().Length, fishers[0].Kalat.Last().Weight, fishers[0].Kalat.Last().FoundAt.Name);
            Console.WriteLine();
            PrintFish(0);
        }
        static void CreateFisher(string name, string phone)
        {
            fishers.Add(new Kalastaja(name, phone));
            Console.WriteLine("New fisherman created:");
            Console.WriteLine("- Name: {0}, Phone: {1}", fishers.Last().Name, fishers.Last().PuhNum);
            Console.WriteLine(); 
        }
        static void PrintFish(int index)
        {
            Console.WriteLine("Registry of caught fish for: " + fishers[index].Name);
            foreach (var item in fishers[index].Kalat)
            {
                Console.WriteLine("- specie: " + item.Name);
                Console.WriteLine("- length: " + item.Length);
                Console.WriteLine("- weight: " + item.Weight);
                Console.WriteLine("- found at: {0}, {1}", item.FoundAt.Name, item.FoundAt.Place);
                Console.WriteLine();
            }
            foreach(var item in fishers[index].Kalat.OrderByDescending(item => item.Weight))
            {
                Console.WriteLine("- specie: " + item.Name);
                Console.WriteLine("- length: " + item.Length);
                Console.WriteLine("- weight: " + item.Weight);
                Console.WriteLine("- found at: {0}, {1}", item.FoundAt.Name, item.FoundAt.Place);
                Console.WriteLine();
            }
        }
    }

}
