using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDragon2//.Controller
{
    class GameController
    {

        public void StartGame()
        {
            Game game = new Game(2);
        }

        public void GiveCardsToGamers(List<Gamer> gamers, Deck deck)
        {
            foreach (var gamer in gamers)
            {
                for (int i = 0; i < 4; i++)
                {
                    gamer.GamerCards.Add(deck.deck[0]);
                    deck.deck.RemoveAt(0);
                }
            }
        }

    }
}
