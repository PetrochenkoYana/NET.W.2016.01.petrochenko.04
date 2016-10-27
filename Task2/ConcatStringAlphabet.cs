using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    public static class ConcatStringAlphabet
    {
        public static string Longest(string a, string b)
        {
            if (a != null && b != null)
            {
                Regex rg=new Regex("[a-z]");
                if (rg.IsMatch(a) && rg.IsMatch(b))
                {
                    string commonStr = a + b;
                    string resultStr = "";
                    char[] charCommonStr = commonStr.ToCharArray();
                    char[] arrayAlphabet = new char[26];

                    for (int i = 0; i < charCommonStr.Length; i++)
                    {
                        if (arrayAlphabet[(int) charCommonStr[i] - 97] == 0)
                            arrayAlphabet[(int) charCommonStr[i] - 97] = charCommonStr[i];
                    }
                    for (int i = 0; i < arrayAlphabet.Length; i++)
                    {
                        if (arrayAlphabet[i] != 0)
                            resultStr += Convert.ToString(arrayAlphabet[i]);

                    }
                    return resultStr;
                }
                else
                {
                    throw new Exception("Strings should consist of small english letters only");
                }
            }
            else

            {
                throw new NullReferenceException("Strings should not to be null");

            }
        }
    }
}
