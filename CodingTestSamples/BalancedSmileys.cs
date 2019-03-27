using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestSamples
{
    public class BalancedSmileys
    {
        public static bool IsBalancedRec(string input, int numOpen = 0)
        {
            if (numOpen < 0)
                return false;
            if (string.IsNullOrEmpty(input))
                return numOpen == 0;

            char c = input[0];
            string rest = input.Substring(1);

            if (c == '(')
                return IsBalancedRec(rest, numOpen + 1);
            else if (c == ')')
                return IsBalancedRec(rest, numOpen - 1);
            else
                return IsBalancedRec(rest, numOpen);
        }
    }
}
