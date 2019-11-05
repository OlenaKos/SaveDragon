using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDragon
{
    class Gamer
    {
        public static string[] Names = new string [] {"James Bond", "Harry Potter", "Sara O'Connor", "Chuck Norris"};
        public static int namesCounter = 0;
        public string Name { get; set; }
        public List<Card> gamerCards { set; get; }
        public List<Card> gamerEggs { get; set; }
        public List<Card> gamerDragons { get; set; }
        public Gamer()
        {
            Name = Names[namesCounter];
            namesCounter++;
            gamerEggs = new List<Card> { };
            gamerDragons = new List<Card> { };
            gamerCards = new List<Card> { };
        }

        public List<Card> GetCardFromDeck(Deck cardDeck, int cardCount)
        {
            List<Card> cards = new List<Card> { };
            for (int i = 0; i < cardCount; i++)
            {
                cards.Add(deck.deck[0]);
                deck.deck.RemoveAt(0);
            }

            return cards;
        }
    }
}
