using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);     //randomly chooses a number between two set values (value1, value2)
                TempList.Add(deck.Cards[randomIndex]);                  //adds card at randomIndex number to TempList
                deck.Cards.RemoveAt(randomIndex);                       //removes card at randomIndex from original list deck.Cards until no cards are left
            }
            deck.Cards = TempList;                                      //deck.Cards is empty and so the TempList is assigned to it in whatever order it was randomly generated in
            return deck;

        }
    }
}
