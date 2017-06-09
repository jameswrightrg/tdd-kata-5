using System;
using System.Collections.Generic;
using System.Linq;

namespace tddkata5
{
    public class CardSorter
    {
        private static List<char> validCards = new List<char> {'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K'}; 

        public static string Sort(string input)
        {
            var cards = input.Select(GetCardValue);
            cards = cards.OrderBy(i => i);
            return new string(cards.Select(GetCardName).ToArray());
        }

        private static char GetCardName(int arg)
        {
            return validCards[arg];
        }

        private static int GetCardValue(char card)
        {
            if (validCards.Contains(card))
            {
                return validCards.IndexOf(card);
            }

            throw new Exception("Invalid card");
        }
    }
}