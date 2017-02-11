using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Face.ToString());

            //Clubs = 1,    // ♣ u2663
            //Diamonds = 2, // ♦ u2666
            //Hearts = 3,   // ♥ u2665
            //Spades = 4    // ♠ u2660
            char suitCh = '\u0000';
            if (Suit == CardSuit.Clubs)
            {
                suitCh = '\u2663';
            }
            else if (Suit == CardSuit.Diamonds)
            {
                suitCh = '\u2666';
            }
            else if (Suit == CardSuit.Hearts)
            {
                suitCh = '\u2665';
            }
            else if (Suit == CardSuit.Spades)
            {
                suitCh = '\u2660';
            }
            
            sb.Append(suitCh.ToString());

            return sb.ToString();
        }
    }
}
