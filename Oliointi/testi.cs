using System;
/* Testiohjelma
 * 9.1.2017
 */ 

// Testikommentti 11.1.2017
// Toinen muutoskommentti höh
namespace Hello
{
    class Henkilo {
        public string Nimi { get; set; }
        public int Ika { get; set; }
    }
    class testi
    {
        static void Main(string[] args)
        {
            SayHello();
            ShowNames();
            Console.ReadLine();
        }
        static void ShowNames()
        {
            //TODO
            
            string[] hlo = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna henkilön nimi > ");
                hlo[i] = Console.ReadLine();
                
            }

            Array.Sort(hlo);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(hlo[i]);
            }
            Console.WriteLine("Ohjelma suoritettu onnistuneesti");

        }
        static void SayHello()
        {
            // määritellään muuttuja
            
            // luodaan olio Henkilo-luokasta
            Henkilo hlo = new Henkilo();
            hlo.Nimi = "Pekka Pouta";
            hlo.Ika = 34;
            // konsolille
            Console.WriteLine("Terve {0},\nIkäsi on {1}", hlo.Nimi, hlo.Ika);
            
        }


    }

}
