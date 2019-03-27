using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestSamples
{
    public class KeypadNosToChars
    {
        public static List<string> letterCombinations(string digits)
        {
            List<string> res = new List<string>();
            List<string> preres = new List<string>();
            res.Add("");

            for (int i = 0; i < digits.Length; i++)
            {
                String letters = map[digits[i]];
                if (letters.Length == 0)
                    continue;
                foreach (string str in res)
                {
                    for (int j = 0; j < letters.Length; j++)
                    {
                        preres.Add(str + letters[j]);
                    }
                }
                res = preres;
                preres = new List<string>();
            }
            return res;
        }

        static Dictionary<char, string> map = new Dictionary<char, string>()
        {
            {'1', "1" },
            {'2',"abc"},
            {'3',"def"},
            {'4',"ghi"},
            {'5',"jkl"},
            {'6',"mno"},
            {'7',"pqrs"},
            {'8',"tuv"},
            {'9',"wxyz"},
            {'0', "0"}
        };
    }
}
