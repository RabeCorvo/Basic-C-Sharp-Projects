using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);     //randomly chooses a number between two set values (value1, value2)
                    TempList.Add(Cards[randomIndex]);                  //adds card at randomIndex number to TempList
                    Cards.RemoveAt(randomIndex);                       //removes card at randomIndex from original list deck.Cards until no cards are left
                }
                Cards = TempList;                                      //deck.Cards is empty and so the TempList is assigned to it in whatever order it was randomly generated in
            }
        }
    }
}
