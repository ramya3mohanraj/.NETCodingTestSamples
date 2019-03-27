using System;
using System.Collections.Generic;

namespace CodingTestSamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> result = KeypadNosToChars.letterCombinations("4155230");
            Console.WriteLine("Keypad Nos To Characters");
            Console.WriteLine(string.Join(',', result));

            double bodmasResult = BodmasExpression.Evaluate("2+(100/5)+10");
            Console.WriteLine("Bodmas Result:" + bodmasResult);

            bool isBalanced = BalancedSmileys.IsBalancedRec("so(m(eth)ing)");
            Console.WriteLine("isBalanced:" + isBalanced);

            Console.ReadLine();
        }

        
    }
}
