using System;
using System.Collections.Generic;

namespace JAMK_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kirsi = new Employee("Kirsi Kernel", "Teacher", 1200);
            Boss jussi  = new Boss("Jussi Jurkka", "Head of Institute", 9000 , "Audi", 5000);
            Tulosta(kirsi.PrintData());
            Tulosta(jussi.PrintData());
            // Vaihdetaan välissä Kirsin tietoja, ja kokeillaan toimiiko tulostus
            kirsi.Profession = "Työtön";
            kirsi.Salary = 0;
            Tulosta(kirsi.PrintData());
            Console.ReadLine();
        }

        static void Tulosta(string tuloste)
        {
            // Luodaan lista tarvittavia stringejä
            List<string> temp = new List<string>();
            // Ikuinen loop, katkaistaan koodin sisällä
            for (int i = 0; i > -1; i++) { 
                // Pätkitään syöte paloiksi, alusta alkaen.
                temp.Add(tuloste.Remove(tuloste.IndexOf(';')));
                // Katkaistaan verrattavasta stringistä talteen otettu pala pois.
                tuloste = tuloste.Substring(tuloste.IndexOf(';') + 1);
                if (tuloste.Contains(";"))
                {
                    continue;
                }
                // Tehdään kaksi eri tulostusta vastaamaan luokkien eroa
                else if (temp.Count == 5)
                {
                    temp.Add(tuloste);
                    Console.WriteLine("Name: {0}, Profession: {1}, Salary: {2}, Car: {3}, Bonus: {4}", temp[0], temp[1], temp[2], temp[3], temp[4]);
                    break;
                }
                else
                {
                    temp.Add(tuloste);
                    Console.WriteLine("Name: {0}, Profession: {1}, Salary: {2}", temp[0], temp[1], temp[2]);
                    break;
                }
            }


        }
    }
}
