using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDragon2
{
    class Game
    {
        public static int MoveCounter = 0;
        public static bool isGameRunning = true; 
        public List<Gamer> Gamers { get; set; }
        public Deck MainDeck { set; get; }

        public Game(int GamersCount)
        {
            MainDeck = new Deck();
            Gamers = new List<Gamer> { };
            Gamers.Add(new RealGamer());
            for (int i = 1; i < GamersCount; i++)
            {
                Gamers.Add(new Bot());
            }

            GameController gameController = new GameController() { };
            gameController.GiveCardsToGamers(Gamers, MainDeck);
        }

    }
}
