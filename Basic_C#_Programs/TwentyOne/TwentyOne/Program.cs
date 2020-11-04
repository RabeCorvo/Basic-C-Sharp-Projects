using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Dinosaur Motel and Casino";

           

            Console.WriteLine("Welcome to the {0}.  Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}.  Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\ywing\Desktop\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Don't let the door hit you on the way out ya bum.");
            Console.ReadLine();
        }
    }
}

//OVERLOADED OPERATORS FROM EARLIER IN THE COURSE
//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Sam";
//game += player;
//game -= player;

//Card card = new Card();
//card.Suit = Suit.Clubs;
//int underlyingValue = (int)Suit.Diamonds;   //Same way of converting as Convert.ToInt32(Suit.Diamonds);

//LAMDA FUNCTION EXAMPLE
//int count = deck.Cards.Count(x => x.Face == Face.Ace);            //lambda function example .Count()
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();   //lamda function example of .Where().  The .ToList() is needed to build a new list.
//foreach (Card card in newList)
//{
//    Console.WriteLine(card.Face);
//}
//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
//int sum = numberList.Where(x => x > 20).Sum();
//Console.WriteLine(sum);

//ORIGINAL DECK SHUFFLE FROM EARLIER IN THE COURSE
//Deck deck = new Deck();

//deck.Shuffle(100);

//foreach (Card card in deck.Cards)
//{
//    Console.WriteLine(card.Face + " of " + card.Suit);
//}
//Console.WriteLine(deck.Cards.Count);
//Console.ReadLine();