using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDragon
{
    class Deck
    {
        public static int amountThieft = 4;
        public static int amountDragon = 24;
        public static int amountEgg = 24;
        public static int amountMother = 10;
        public static int amountFather = 10;
        public static int amountNest = 7;
        public List<Card> deck { get; set; }
        public Deck() 
        {
            List<Card> deckTemp = new List<Card> { };
            for (int i = 0; i < amountThieft; i++)
            {
                deckTemp.Add(new Thieft());
            }
            for (int i = 0; i < amountNest; i++)
            {
                deckTemp.Add(new Nest());
            }
            for (int i = 0; i < amountMother; i++)
            {
                deckTemp.Add(new Mother());
            }
            for (int i = 0; i < amountFather; i++)
            {
                deckTemp.Add(new Father());
            }
            deck = new List<Card> { };
            Random random = new Random();
            while (deckTemp.Count > 0)
	            {
                    int randomCardID = random.Next(0, deckTemp.Count);
                    deck.Add(deckTemp[randomCardID]);
                    deckTemp.RemoveAt(randomCardID);
	            }



        }
    }
}
