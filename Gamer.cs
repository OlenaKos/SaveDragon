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
        public List<Card> GamerCards { set; get; }
        public List<Card> GamerEggs { get; set; }
        public List<Card> GamerDragons { get; set; }
        public Gamer()
        {
            Name = Names[namesCounter];
            namesCounter++;
            GamerEggs = new List<Card> { };
            GamerDragons = new List<Card> { };
            GamerCards = new List<Card> { };
        }


    }
}
