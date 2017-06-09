using System;
using System.Linq;

namespace tddkata5
{
    public class CardSorter
    {
        public static string Sort(string input)
        {
            var cards = input.Select(GetCardValue);
            cards = cards.OrderBy(i => i);
            return new string(cards.Select(GetCardName).ToArray());
        }

        private static char GetCardName(int arg)
        {
            return arg == 1 ? 'A' : arg.ToString()[0];
        }

        private static int GetCardValue(char card)
        {
            var value = 0;

            if (int.TryParse(card.ToString(), out value))
            {
                return value;
            }

            if (char.ToUpperInvariant(card) == 'A')
            {
                return 1;
            }

            throw new Exception("Invalid card");
        }
    }
}