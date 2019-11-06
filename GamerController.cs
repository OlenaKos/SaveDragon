using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDragon//.Controller
{
    class GamerController
    {
        public List<Card> GetCardFromDeck(Gamer gamer, Deck cardDeck, int cardCount)
        {
            List<Card> cards = new List<Card> { };
            for (int i = 0; i < cardCount; i++)
            {
                cards.Add(cardDeck.deck[0]);
                cardDeck.deck.RemoveAt(0);
            }

            return cards;
        }
    }
}
