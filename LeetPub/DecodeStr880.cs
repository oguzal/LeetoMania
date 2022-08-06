using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class DecodeStr880
    {
        public string DecodeAtIndex(string s, int k)
        {
            String strCopy = "";
            var str = new StringBuilder();
            for (int x = 0; x < s.Length; x++)
            {
                var letter = s[x];
                if (str.Length >= k)
                    return str[k - 1].ToString();

            
                if (!Char.IsNumber(letter)) {
                    str.Append(letter);
                 
                }         
                else
                {
                    strCopy = str.ToString();
                    for (int y = 0; y < Convert.ToInt32(letter.ToString())-1; y++)
                    {
                        str.Append(strCopy);
                        if (str.Length >= k)
                            return str[k - 1].ToString();
                    }
                }
            }
            return str[k - 1].ToString();
        }
    }
}
