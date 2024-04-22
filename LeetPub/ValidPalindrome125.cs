using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class ValidPalindrome125
    {
        public bool IsPalindrome(string s)
        {

            var l = 0;
            var r = s.Length - 1;
            while (l < r)
            {
                while (r > l && l < s.Length && !isAlphaNum(s[l]))
                    l++;
                while (r > l && r >= 0 && !isAlphaNum(s[r]))
                    r--;
                if (l == r || l == s.Length) return true;

                if (char.ToUpper(s[l]) != char.ToUpper(s[r]))
                    return false;
                l++;
                r--;
            }


            return true;
        }

        public bool isAlphaNum(char c)
        {
            return char.IsLetter(c) || char.IsDigit(c);
        }
    }
}
