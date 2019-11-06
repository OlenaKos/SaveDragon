using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDragon
{
    class Game
    {
        public static int MoveCounter = 0;
        public static bool isGameRunning = true; 
        public List<Gamer> Players { get; set; }
        public Deck MainDeck { set; get; }

    }
}
