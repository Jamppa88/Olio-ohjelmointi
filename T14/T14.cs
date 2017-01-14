/* Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). 
 * Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:

Arvosanajakauma: 
0:
1:****
2:**
3:******
4:*****
5:**

 * Jani Kerttula, K8958
 * 14.1.2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14
{
    class T14
    {
        static void Main(string[] args)
        {
            // Luodaan aluksi määrittämättömän kokoinen lista
            List<int> arvosanat = new List<int>();
            bool exit = false;
            // Luodaan erikseen inputille stringi ja integer syötteen analysointiin
            string input;
            int i;
            Console.WriteLine("Syötä ohjelmaan opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta.\nLopeta syöttämällä x.");
            while (exit == false)
            {
                Console.Write("Anna arvosana > ");
                input = Console.ReadLine();
                // Testataan onko syöte integer
                if (int.TryParse(input, out i) == true)
                {
                    // Ja onko se välillä 0-5
                    if (i < 6 && i >= 0)
                        arvosanat.Add(i);
                    else
                        Console.WriteLine("Arvo ei ole mahdollinen!");
                }
                // Poistumisehto    
                else if (input == "x")
                    exit = true;
                // Väärän syötteen hallinta
                else
                    Console.WriteLine("Tuntematon syöte, syötä arvosana 0-5 väliltä, tai x lopettaaksesi.");
            }
            Console.WriteLine("\nArvosanajakauma:");

            // Toteutetaan tähtimäärät arvosanoille kahdella loopilla, jossa tarkastetaan listasta sopivat numerot
            for (int luku = 0; luku <= 5; luku++)
            {
                Console.Write("{0}: ", luku);
                int b = luku;
                
                for (int a = 0; a < arvosanat.Count(); a++) // HUOM! List-muotoisen taulukon "pituus" saadaan .Count metodilla
                {
                    if (arvosanat[a] == b)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
