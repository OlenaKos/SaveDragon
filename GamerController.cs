using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDragon2//.Controller
{
    class GamerController : IActions
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

        public void UseThrowCardCombination(Gamer gamer, int CardID, Deck cardDeck)
        {
            cardDeck.deck.Add(gamer.GamerCards[CardID]);
            gamer.GamerCards.RemoveAt(CardID);
            gamer.GamerCards.Add(cardDeck.deck[0]);
            cardDeck.deck.RemoveAt(0);
        }

        public void UseMamaMamaCombination(Gamer gamer, Deck cardDeck)
        {
            Mother mother = new Mother();
            int IDMother = DefineRequiredCardID(mother, gamer);
            UseThrowCardCombination(gamer, IDMother, cardDeck);
            IDMother = DefineRequiredCardID(mother, gamer);
            UseThrowCardCombination(gamer, IDMother, cardDeck);
        }

        private int DefineRequiredCardID(Card card, Gamer gamer)
        {
            int RequiredCardID = -1;
            for (int i = 0; i < gamer.GamerCards.Count; i++)
            {
                if (gamer.GamerCards[i].GetType() == typeof(Card))
                {
                    RequiredCardID = i;
                    break;
                }
            }
            return RequiredCardID;
        }

        public void UseMamaPapaNestCombination(Gamer gamer, Deck cardDeck)
        {
            Mother mother = new Mother();
            Father father = new Father();
            Nest nest = new Nest();
            int IDMother = DefineRequiredCardID(mother, gamer);
            UseThrowCardCombination(gamer, IDMother, cardDeck);
            int IDFather = DefineRequiredCardID(mother, gamer);
            UseThrowCardCombination(gamer, IDMother, cardDeck);
            int IDNest = DefineRequiredCardID(mother, gamer);
            UseThrowCardCombination(gamer, IDFather, cardDeck);
        }

       public bool UsePapaPapaCombination(Gamer gamer)
        {
         
            Father father = new Father();
            Nest nest = new Nest();
            int IDMother = DefineRequiredCardID(mother, gamer);
            UseThrowCardCombination(gamer, IDMother, cardDeck);
            int IDFather = DefineRequiredCardID(mother, gamer);
            UseThrowCardCombination(gamer, IDMother, cardDeck);
            int IDNest = DefineRequiredCardID(mother, gamer);
            UseThrowCardCombination(gamer, IDFather, cardDeck);
        }

        public bool UseThieftCombination(Gamer gamer)
        {
            throw new NotImplementedException();
        }

    }
}
