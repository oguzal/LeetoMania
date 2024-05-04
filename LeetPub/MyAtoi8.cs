using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetPub
{
    public  class MyAtoi8
    {
        public int myAtoi(string s)
        {
            s = s.Trim();

            // Handle empty string, "+" or "-" only cases
            if (string.IsNullOrEmpty(s) || s == "+" || s == "-")
            {
                return 0;
            }

            bool isNegative = s[0] == '-';
            bool isPositive = s[0] == '+';

            int startIndex = isNegative || isPositive ? 1 : 0;
            StringBuilder numberBuilder = new StringBuilder();

            for (int i = startIndex; i < s.Length; i++)
            {
                char ch = s[i];
                if (char.IsDigit(ch))
                {
                    numberBuilder.Append(ch);
                }
                else
                {
                    if (numberBuilder.Length == 0)
                    {
                        return 0;
                    }
                    break;
                }
            }

            string numberString = numberBuilder.ToString();

            try
            {
                int result = int.Parse(numberString);
                return isNegative ? -result : result;
            }
            catch (FormatException)
            {
                return isNegative ? int.MinValue : int.MaxValue;
            }
        }

    }
}
