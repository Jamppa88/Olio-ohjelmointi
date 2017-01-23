using System;


namespace JAMK_IT
{
    class Program
    {
       
        static void Main(string[] args)
        {
            bool exit = false;
            string input;
            Fridge jkaappi = new Fridge();
            Food food = new Food("Banaani");
            Drink drink = new Drink("Maito");
            Console.WriteLine("Jääkaappi-simulaatio.");
            while (!exit)
            {
                Console.WriteLine("Valitse haluamasi toiminto:");
                Console.WriteLine("ota = Ota kaapista, lisaa = Lisää kaappiin, check = Tarkista sisältö, x poistu");
                Console.Write("\n >> ");
                input = Console.ReadLine();

                if (input == "ota")
                {
                    Console.Write("Kirjoita haluamasi tuote: ");
                    input = Console.ReadLine();
                    if (jkaappi.HasItem(input))
                    {
                        FoodStuff tmp = jkaappi.Copy(input);
                        jkaappi.Take(tmp);
                    }
                    else
                    {
                        Console.WriteLine("Tuotetta ei löydy.");
                    }
                }
                else if (input == "lisaa")
                {
                    Console.Write("Kirjoita haluamasi tuotteen tyyppi (drink/food): ");
                    input = Console.ReadLine();
                    if (input == "drink")
                    {
                        Console.Write("Kirjoita haluamasi tuote: ");
                        input = Console.ReadLine();
                        if (jkaappi.HasItem(input))
                        {
                            drink = (Drink)jkaappi.Copy(input);
                        }
                        else
                            drink = new Drink(input);
                        jkaappi.Add(drink);
                    }
                    else if (input == "food")
                    {
                        Console.Write("Kirjoita haluamasi tuote: ");
                        input = Console.ReadLine();
                        if (jkaappi.HasItem(input))
                        {
                            food = (Food)jkaappi.Copy(input);
                        }
                        else
                            food = new Food(input);
                        jkaappi.Add(food);
                    }
                    else
                        Console.WriteLine("Tuntematon syöte!");

                }
                else if (input == "check")
                {
                    Console.WriteLine(jkaappi.Contains());
                }
                else if (input == "x")
                    exit = true;
                else
                    Console.WriteLine("Tuntematon syöte!");
                       
            }
        }
    }
}
