using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDragon2
{
    interface IActions
    {
        void UseThrowCardCombination(Gamer gamer, int CardID, Deck cardDeck);
        void UseMamaMamaCombination(Gamer gamer, Deck cardDeck);
        bool UseMamaPapaNestCombination(Gamer gamer);
        bool UsePapaPapaCombination(Gamer gamer);
        bool UseThieftCombination(Gamer gamer);
    }
}
