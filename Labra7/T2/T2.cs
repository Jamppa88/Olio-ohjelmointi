using System;
using System.Collections.Generic;
using System.Linq;


namespace JAMK_IT
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            string[] fileContent;
            if (System.IO.File.Exists(@"D:\Temp\nimet.txt"))
            {
                try
                {
                    fileContent = System.IO.File.ReadAllLines(@"D:\Temp\nimet.txt");
                    
                    Dictionary<string, int> nimet = new Dictionary<string,int>();
                    
                    foreach (string line in fileContent)
                    {
                        if (!nimet.ContainsKey(line))
                        {
                            nimet.Add(line, 1);
                        }
                        else
                        {
                            nimet[line]++;
                        }
                    }
                    Console.WriteLine("Löytyi {0} riviä, ja {1} nimeä.", fileContent.Count(), nimet.Count);
                    foreach (string line in nimet.Keys)
                    {
                        Console.WriteLine("Nimi {0} esiintyi {1} kertaa.", line, nimet[line]);
                    }

                    // Tehdään lajiteltu tulostus käyttäen list-muuttujaa apuna
                    var list = nimet.Keys.ToList();
                    list.Sort();

                    Console.WriteLine("Lajiteltuna:");
                    foreach (var key in list)
                    {
                        Console.WriteLine("Nimi {0} esiintyi {1} kertaa.", key, nimet[key]);
                    }
                    Console.ReadKey();
                    /* Toimisi myös:
                     * foreach (var line in nimet.OrderBy(i => i.key){
                     *      Console.Writeline(line);
                     * } */

                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
              
        }
    }
}
