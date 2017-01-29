
using System.Collections.Generic;


namespace JAMK_IT
{
    public enum MAA {Hertta, Pata, Ruutu, Risti };
    class CardDeck
    {
        public List<Card> Cards = new List<Card>();
    }
    class Card
    {
        public MAA Maa { get; set; }
        public int Nro { get; set; }
    }
}
