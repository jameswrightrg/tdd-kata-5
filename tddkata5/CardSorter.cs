using System;
using System.Linq;

namespace tddkata5
{
    public class CardSorter
    {
        public static string Sort(string input)
        {
            return GetReversedString(input);
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
    }
}