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
            CardDeck deck = new CardDeck();
            Card card = new Card();
            for (int i = 0; i < 52; i++)
            {
                card = new Card();
                if (i < 13)
                {
                    card.Maa = (MAA)0;
                    card.Nro = i+1;
                }
                else if (i < 26)
                {
                    card.Maa = (MAA)1;
                    card.Nro = i - 12;
                }
                else if (i < 39)
                {
                    card.Maa = (MAA)2;
                    card.Nro = i - 25;
                }
                else
                {
                    card.Maa = (MAA)3;
                    card.Nro = i - 38;
                }
                deck.Cards.Add(card);
            }
            Console.WriteLine("Kortit jäjestyksessä:");
            Tulosta(deck);
            Console.ReadLine();
            
            Shuffle(ref deck);
            Console.WriteLine("Kortit sekoitettuna:");
            Tulosta(deck);
            Console.ReadLine();
        }
        static void Tulosta(CardDeck deck)
        {
            int i = 1;
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine("{0}. kortti = {1} {2}", i, card.Maa, card.Nro);
                i++;
            }
        }
        static void Shuffle(ref CardDeck deck)
        {
            Random rng = new Random();
            for (int i = 0; i < deck.Cards.Count; i++)
            {
                int j = rng.Next(deck.Cards.Count);
                if (i != j)
                {
                    Card tmp = new Card();
                    tmp = deck.Cards[i];
                    deck.Cards[i] = deck.Cards[j];
                    deck.Cards[j] = tmp;
                }
            }
            

        }
        
    }
}
