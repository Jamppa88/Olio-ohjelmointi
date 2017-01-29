using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Toteuta ohjelma, jolla voidaan lisätä, poistaa ja listata SM-Liiga-joukkueen JYP pelaajia. 
 * Luo Pelaaja-luokka jolla on ominaisuudet Etunimi, Sukunimi, Ikä ja Numero. Löydät täältä JYP pelaajat kaudella 2016-17. 
 * Luo myös Joukkue-luokka. Luokalla on ominnaisuudet Nimi, Kotikaupunki ja Pelaajat. Ominaisuus Pelaajat on siis lista Pelaaja-olioita. 
 * Tee Joukkue-luokalle sisäinen metodi HaePelaajat(string joukkue), jota konstruktori kutsuu. 
 * HaePelaajat metodi luo Pelaajat-listaan oikeat pelaajat.
 * Bonustehtävä: missä ja miten pitäisi pelaajatietoja silloin tallessa kun ohjelma ei ole käynnissä? 
 * Listaa erilaiset vaihtoehdot. Toteuta niistä tekstitiedosto-pohjainen ratkaisu.

 */

namespace JAMK_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string input;
            Joukkue jyp = new Joukkue("JYP", "Jyväskylä");
            Console.WriteLine("JYP-simulaattori.");
            while (!exit)
            {
                Console.WriteLine("Voit lisätä, poistaa ja listata pelaajia (lisaa/poista/listaa).");
                Console.WriteLine("Voit poistua kirjoittamalla exit.");
                Console.Write("\n >> ");
                input = Console.ReadLine();
                Console.Clear();
                if (input == "exit")
                    exit = true;
                else if (input == "listaa")
                {
                    Tulosta(jyp);
                }
                else if (input == "lisaa")
                {
                    LisaaPelaaja(ref jyp);
                }
                else if (input == "poista")
                {
                    PoistaPelaaja(ref jyp);
                }
                else
                    Console.WriteLine("Tuntematon syöte!");

                Console.WriteLine("Paina Enter jatkaaksesi...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void Tulosta(Joukkue jouk)
        {
            foreach (Pelaaja pel in jouk.Pelaajat)
            {
                Console.WriteLine("{0}: {1},{2}, {3}v",pel.Numero,pel.Sukunimi,pel.Etunimi,pel.Ika);
            }
        }
        static void LisaaPelaaja(ref Joukkue jouk)
        {
            string input;
            int nro;
            Pelaaja tmp = new Pelaaja();
            Console.Write("Anna etunimi: ");
            tmp.Etunimi = Console.ReadLine();
            Console.Write("Anna sukunimi: ");
            tmp.Sukunimi = Console.ReadLine();
            while (true)
            {
                Console.Write("Anna ikä: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out nro))
                {
                    tmp.Ika = nro;
                    break;
                }
                else
                    Console.WriteLine("Virheellinen syöte! Yritä uudestaan.");
            }
            while (true)
            {
                Console.Write("Anna pelaajanumero: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out nro))
                {
                    tmp.Numero = nro;
                    break;
                }
                else
                    Console.WriteLine("Virheellinen syöte! Yritä uudestaan.");
            }
            jouk.Pelaajat.Add(tmp);

        }
        static void PoistaPelaaja(ref Joukkue jouk)
        {
            string input;
            int nro;
            
            while (true)
            {
                Console.Write("Anna poistettavan pelaajan pelaajanumero, tai x keskeyttääksesi: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out nro))
                {
                    for (int i = 0; i < jouk.Pelaajat.Count; i++)
                    {
                        if (jouk.Pelaajat[i].Numero == nro)
                        {
                            jouk.Pelaajat.RemoveAt(i);
                            Console.WriteLine("Pelaaja poistettu onnistuneesti!");
                            return;
                        }

                    }
                    Console.WriteLine("Kyseisellä numerolla ei löytynyt pelaajaa.");

                }
                else if (input == "x")
                    break;
                else
                    Console.WriteLine("Virheellinen syöte! Yritä uudestaan.");
            }
        }
    }
}
