using System;
using System.CodeDom;
using System.Linq;

namespace tddkata5
{
    public class CardSorter
    {
        public static string Sort(string input)
        {
            if (input.Length == 2)
            {
                return GetCardValue(input[1]) < GetCardValue(input[0]) ? GetReversedString(input) : input;
            }
            return input;
        }

        private static string GetReversedString(string input)
        {
            var result = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }

            return result;
        }

        private static int GetCardValue(char card)
        {
            int value = 0;

            if (char.IsDigit(card))
            {
                return card;
            }

            if (char.ToUpperInvariant(card) == 'A')
            {
                return 1;
            }

            throw new Exception("Invalid card");
        }
    }
}